Public Class frmScrape
    Private Async Sub frmScrape_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        XylosTabControl1.SelectedTab = XylosTabControl1.TabPages(1)

        txtX.Text = My.Settings.scrapex.ToString
        txtY.Text = My.Settings.scrapey.ToString

        txtToken.Text = My.Settings.token.ToString
    End Sub

    Private Sub frmScrape_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.F5 Then
            txtX.Text = Cursor.Position.X
            txtY.Text = Cursor.Position.Y

            My.Settings.scrapex = Cursor.Position.X
            My.Settings.scrapey = Cursor.Position.Y
            My.Settings.Save()
        End If
    End Sub

    Private Async Sub XylosButton1_ClickAsync(sender As Object, e As EventArgs) Handles XylosButton1.Click
        My.Settings.token = txtToken.Text
        My.Settings.Save()
        Await MainAsync()
    End Sub

    Private Sub XylosButton2_Click(sender As Object, e As EventArgs) Handles XylosButton2.Click
        Process.Start("https://discordapp.com/developers/applications")
    End Sub
End Class