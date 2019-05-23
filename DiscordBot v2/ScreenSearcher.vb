Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Module ScreenSearcher
    <Extension()>
    Public Function Contains(src As Bitmap, ByRef bmp As Bitmap) As Point
        '
        '-- Some logic pre-checks
        '
        If src Is Nothing OrElse bmp Is Nothing Then Return Nothing

        If src.Width = bmp.Width AndAlso src.Height = bmp.Height Then
            If src.GetPixel(0, 0) = bmp.GetPixel(0, 0) Then
                Return New Point(0, 0)
            Else
                Return Nothing
            End If

        ElseIf src.Width < bmp.Width OrElse src.Height < bmp.Height Then
            Return Nothing

        End If
        '
        '-- Prepare optimizations
        '
        Dim sr As New Rectangle(0, 0, src.Width, src.Height)
        Dim br As New Rectangle(0, 0, bmp.Width, bmp.Height)

        Dim srcLock As BitmapData = src.LockBits(sr, Imaging.ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb)
        Dim bmpLock As BitmapData = bmp.LockBits(br, Imaging.ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb)

        Dim sStride As Integer = srcLock.Stride
        Dim bStride As Integer = bmpLock.Stride

        Dim srcSz As Integer = sStride * src.Height
        Dim bmpSz As Integer = bStride * bmp.Height

        Dim srcBuff(srcSz) As Byte
        Dim bmpBuff(bmpSz) As Byte

        Marshal.Copy(srcLock.Scan0, srcBuff, 0, srcSz)
        Marshal.Copy(bmpLock.Scan0, bmpBuff, 0, bmpSz)

        ' we don't need to lock the image anymore as we have a local copy
        bmp.UnlockBits(bmpLock)
        src.UnlockBits(srcLock)

        Dim x, y, x2, y2, sx, sy, bx, by, sw, sh, bw, bh As Integer
        Dim r, g, b As Byte

        Dim p As Point = Nothing

        bw = bmp.Width
        bh = bmp.Height

        sw = src.Width - bw      ' limit scan to only what we need. the extra corner
        sh = src.Height - bh     ' point we need is taken care of in the loop itself.

        bx = 0 : by = 0
        '
        '-- Scan source for bitmap
        '
        For y = 0 To sh
            sy = y * sStride
            For x = 0 To sw

                sx = sy + x * 3
                '
                '-- Find start point/pixel
                '
                r = srcBuff(sx + 2)
                g = srcBuff(sx + 1)
                b = srcBuff(sx)

                If r = bmpBuff(2) AndAlso g = bmpBuff(1) AndAlso b = bmpBuff(0) Then
                    p = New Point(x, y)
                    '
                    '-- We have a pixel match, check the region
                    '
                    For y2 = 0 To bh - 1
                        by = y2 * bStride
                        For x2 = 0 To bw - 1
                            bx = by + x2 * 3

                            sy = (y + y2) * sStride
                            sx = sy + (x + x2) * 3

                            r = srcBuff(sx + 2)
                            g = srcBuff(sx + 1)
                            b = srcBuff(sx)

                            If Not (r = bmpBuff(bx + 2) AndAlso
                                    g = bmpBuff(bx + 1) AndAlso
                                    b = bmpBuff(bx)) Then
                                '
                                '-- Not matching, continue checking
                                '
                                p = Nothing
                                sy = y * sStride
                                Exit For
                            End If

                        Next
                        If p = Nothing Then Exit For
                    Next
                End If 'end of region check

                If p <> Nothing Then Exit For
            Next
            If p <> Nothing Then Exit For
        Next

        bmpBuff = Nothing
        srcBuff = Nothing

        Return p

    End Function
End Module
