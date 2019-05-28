Imports System.Text

Public Class frmTester
    Dim path As String = Application.StartupPath & "\img\"

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        checkImg(cbPkmn.SelectedItem.ToString)
    End Sub

    Public Sub checkImg(ByVal poke As String)
        txtOutput.Clear()
        txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[INFO] Begin image check..." & Environment.NewLine)

        Dim pokeTemp As String = poke
        Dim typenull As String = poke

        If pokeTemp = "Nidoran" Then
            pokeTemp = "Nidoran♀"
        ElseIf pokeTemp = "Nidoran_m" Then
            pokeTemp = "Nidoran♂"
        End If
        If typenull = "Type: Null" Then
            poke = "TypeNull"
        End If
        If My.Computer.FileSystem.FileExists(path & poke & ".png") = True Then
            'FindDiscord()
            pbImg.BackgroundImage = Image.FromFile(path & poke & ".png")
            txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[INFO] Image loaded, starting scan..." & Environment.NewLine)

            FindPkmn(poke)
        Else
            txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[ERROR] Cannot find " & path & poke & ".png" & Environment.NewLine)
        End If
    End Sub

    ' Set focus window
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As IntPtr

    Private Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As IntPtr) As Long

    ' Find discord
    Public Sub FindDiscord()
        Dim nWnd As IntPtr
        Dim ceroIntPtr As New IntPtr(0)
        Dim Wnd_name As String

        Wnd_name = "#store - Discord"
        nWnd = FindWindow(Nothing, Wnd_name)

        SetForegroundWindow(nWnd)
    End Sub

    Private Sub frmTester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnTest, TextBox1.Text)

        cbPkmn.SelectedIndex = 0

        If My.Computer.FileSystem.FileExists(path & cbPkmn.SelectedItem.ToString & ".png") = True Then
            pbImg.BackgroundImage = Image.FromFile(path & cbPkmn.SelectedItem.ToString & ".png")
        Else
            txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[ERROR] Cannot find " & path & cbPkmn.SelectedItem.ToString & ".png" & Environment.NewLine)
        End If
    End Sub

    'Capture screen
    Public Function CaptureScreen() As Bitmap
        Try
            Dim screenSize = SystemInformation.PrimaryMonitorSize
            Dim screenGrab = New Bitmap(screenSize.Width, screenSize.Height)
            Dim graphic = Graphics.FromImage(screenGrab)
            graphic.CopyFromScreen(New Point(0, 0), New Point(0, 0), screenSize)

            ' Return image
            Return screenGrab

            ' Flush image
            graphic.Flush()
        Catch ex As Exception
            txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[ERROR] Cannot screenshot desktop..." & Environment.NewLine)
        End Try
    End Function

    ' Find pkmn
    Public Sub FindPkmn(pkmnName As String)
        Try
            Dim img1 As Bitmap
            Dim img2 As Bitmap
            Dim scImage As Image = CaptureScreen()
            Dim chkImage As Image = Image.FromFile(path & pkmnName & ".png")
            img1 = New Bitmap(scImage)
            img2 = New Bitmap(chkImage)

            Dim p As Point = img1.Contains(img2)

            If p <> Nothing Then
                pbImg.Image = My.Resources.iconfinder_Crown_728988
                txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[INFO] Image scan successfull..." & Environment.NewLine)
            Else
                pbImg.Image = My.Resources.iconfinder_Cancel_728918
                txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[INFO] Image scan failed..." & Environment.NewLine)
            End If
        Catch ex As Exception
            pbImg.Image = My.Resources.iconfinder_Cancel_728918
            txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[ERROR] Cannot compare images..." & Environment.NewLine)
        End Try

    End Sub

    Private Sub cbPkmn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPkmn.SelectedIndexChanged
        If My.Computer.FileSystem.FileExists(path & cbPkmn.SelectedItem.ToString & ".png") = True Then
            pbImg.Image = My.Resources.iconfinder_Invisible_728947
            pbImg.BackgroundImage = Image.FromFile(path & cbPkmn.SelectedItem.ToString & ".png")
        Else
            pbImg.Image = My.Resources.iconfinder_Cancel_728918
            txtOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") & "[ERROR] Cannot find " & path & cbPkmn.SelectedItem.ToString & ".png" & Environment.NewLine)
        End If
    End Sub

    Private Sub btnTest_MouseHover(sender As Object, e As EventArgs) Handles btnTest.MouseHover
        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine("Select the pokemon image you would like to")
        sb.AppendLine("scan for on your primary monitor.")
        sb.AppendLine("")
        sb.AppendLine("In a discord server with pokecord running ")
        sb.AppendLine("and the channel named #store type the commands:")
        sb.AppendLine("p!market search -- <pokemon name>")
        sb.AppendLine("")
        sb.AppendLine("Then take an ID from the result list and use the command:")
        sb.AppendLine("p!market view <id>")
        sb.AppendLine("")
        sb.AppendLine("Now that the pokemon is displayed, click the test button.")
        ToolTip1.Show(sb.ToString, btnTest)

    End Sub
End Class