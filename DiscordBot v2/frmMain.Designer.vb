<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.statsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fldDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.botTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pkmnIdentifier = New System.ComponentModel.BackgroundWorker()
        Me.imgCatches = New System.Windows.Forms.ImageList(Me.components)
        Me.chatSpammer = New System.ComponentModel.BackgroundWorker()
        Me.mainTab = New Gotcha.XylosTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pkmnPreview = New System.Windows.Forms.PictureBox()
        Me.lstOutput = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnStopBot = New Gotcha.XylosButton()
        Me.btnStartBot = New Gotcha.XylosButton()
        Me.noticeHome = New Gotcha.XylosNotice()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lblUBRate = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblMythicRate = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblUBCaught = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblMythicCaught = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.XylosSeparator14 = New Gotcha.XylosSeparator()
        Me.XylosSeparator10 = New Gotcha.XylosSeparator()
        Me.XylosSeparator9 = New Gotcha.XylosSeparator()
        Me.XylosSeparator8 = New Gotcha.XylosSeparator()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblSpawnRate = New System.Windows.Forms.Label()
        Me.lblMostCaught = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pbRecent = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstRecentCatch = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCatchPerMin = New System.Windows.Forms.Label()
        Me.lblLegendRate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblLegendCaught = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblAvgTime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblElapsed = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSentMsg = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.XylosSeparator7 = New Gotcha.XylosSeparator()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEvo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLevels = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XylosSeparator6 = New Gotcha.XylosSeparator()
        Me.lblCaught = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSeen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnClaimRewards = New Gotcha.XylosButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.XylosSeparator12 = New Gotcha.XylosSeparator()
        Me.btnBallance = New Gotcha.XylosButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnFavorite = New Gotcha.XylosButton()
        Me.cbPokemon = New Gotcha.XylosCombobox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNickname = New Gotcha.XylosTextBox()
        Me.btnNickname = New Gotcha.XylosButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbPokedex = New Gotcha.XylosCombobox()
        Me.btnPokedex = New Gotcha.XylosButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbInfo = New Gotcha.XylosCombobox()
        Me.btnPokemon = New Gotcha.XylosButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnInfo = New Gotcha.XylosButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnSelectLatest = New Gotcha.XylosButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbOrderBy = New Gotcha.XylosCombobox()
        Me.btnOrderBy = New Gotcha.XylosButton()
        Me.XylosSeparator11 = New Gotcha.XylosSeparator()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnDetailed = New Gotcha.XylosButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cbSelect = New Gotcha.XylosCombobox()
        Me.btnSelect = New Gotcha.XylosButton()
        Me.txtSearch = New Gotcha.XylosTextBox()
        Me.btnDeselect = New Gotcha.XylosButton()
        Me.lstPkmn = New System.Windows.Forms.CheckedListBox()
        Me.XylosSeparator5 = New Gotcha.XylosSeparator()
        Me.btnClear = New Gotcha.XylosButton()
        Me.btnSave = New Gotcha.XylosButton()
        Me.chkbRandom = New Gotcha.XylosCheckBox()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.cbInterval = New Gotcha.XylosCombobox()
        Me.XylosSeparator1 = New Gotcha.XylosSeparator()
        Me.noticeBasic = New Gotcha.XylosNotice()
        Me.btnRemoveString = New Gotcha.XylosButton()
        Me.btnAddString = New Gotcha.XylosButton()
        Me.txtAddString = New Gotcha.XylosTextBox()
        Me.lstChatSpam = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.chkAlolan = New Gotcha.XylosCheckBox()
        Me.chkUltraBeast = New Gotcha.XylosCheckBox()
        Me.chkMythic = New Gotcha.XylosCheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.chkLegendary = New Gotcha.XylosCheckBox()
        Me.XylosSeparator13 = New Gotcha.XylosSeparator()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtChannelName2 = New Gotcha.XylosTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtChannelName = New Gotcha.XylosTextBox()
        Me.btnTestEmail = New Gotcha.XylosButton()
        Me.noticeAdvanced = New Gotcha.XylosNotice()
        Me.btnSaveAdvanced = New Gotcha.XylosButton()
        Me.txtSubject = New Gotcha.XylosTextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblAltEmail = New System.Windows.Forms.Label()
        Me.XylosSeparator4 = New Gotcha.XylosSeparator()
        Me.txtAltEmail = New Gotcha.XylosTextBox()
        Me.chkAltEmail = New Gotcha.XylosCheckBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.txtHost = New Gotcha.XylosTextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtPort = New Gotcha.XylosTextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New Gotcha.XylosTextBox()
        Me.txtEmail = New Gotcha.XylosTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cbEmail = New Gotcha.XylosCombobox()
        Me.XylosSeparator3 = New Gotcha.XylosSeparator()
        Me.lblImgDir = New System.Windows.Forms.Label()
        Me.btnChange = New Gotcha.XylosButton()
        Me.txtImgDirectory = New Gotcha.XylosTextBox()
        Me.XylosSeparator2 = New Gotcha.XylosSeparator()
        Me.lblCatchDelay = New System.Windows.Forms.Label()
        Me.txtCatchDelay = New Gotcha.XylosTextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.lstLogs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.XylosSeparator15 = New Gotcha.XylosSeparator()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.LinkLabel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.mainTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.pkmnPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.pbRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statsTimer
        '
        Me.statsTimer.Interval = 500
        '
        'botTimer
        '
        '
        'pkmnIdentifier
        '
        Me.pkmnIdentifier.WorkerReportsProgress = True
        Me.pkmnIdentifier.WorkerSupportsCancellation = True
        '
        'imgCatches
        '
        Me.imgCatches.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgCatches.ImageSize = New System.Drawing.Size(40, 30)
        Me.imgCatches.TransparentColor = System.Drawing.Color.Transparent
        '
        'chatSpammer
        '
        Me.chatSpammer.WorkerReportsProgress = True
        Me.chatSpammer.WorkerSupportsCancellation = True
        '
        'mainTab
        '
        Me.mainTab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.mainTab.Controls.Add(Me.TabPage1)
        Me.mainTab.Controls.Add(Me.TabPage2)
        Me.mainTab.Controls.Add(Me.TabPage6)
        Me.mainTab.Controls.Add(Me.TabPage9)
        Me.mainTab.Controls.Add(Me.TabPage3)
        Me.mainTab.Controls.Add(Me.TabPage4)
        Me.mainTab.Controls.Add(Me.TabPage5)
        Me.mainTab.Controls.Add(Me.TabPage7)
        Me.mainTab.Controls.Add(Me.TabPage8)
        Me.mainTab.Controls.Add(Me.TabPage10)
        Me.mainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTab.FirstHeaderBorder = False
        Me.mainTab.ItemSize = New System.Drawing.Size(40, 180)
        Me.mainTab.Location = New System.Drawing.Point(0, 0)
        Me.mainTab.Multiline = True
        Me.mainTab.Name = "mainTab"
        Me.mainTab.SelectedIndex = 0
        Me.mainTab.Size = New System.Drawing.Size(787, 430)
        Me.mainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.LinkLabel3)
        Me.TabPage1.Controls.Add(Me.Label43)
        Me.TabPage1.Controls.Add(Me.Label42)
        Me.TabPage1.Controls.Add(Me.LinkLabel2)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Controls.Add(Me.Label40)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(599, 422)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "dashboard"
        Me.TabPage1.Text = "Dashboard"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(298, 291)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(43, 15)
        Me.LinkLabel3.TabIndex = 8
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Github"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(3, 126)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(596, 180)
        Me.Label43.TabIndex = 7
        Me.Label43.Text = resources.GetString("Label43.Text")
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(3, 111)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(70, 15)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "Description:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(316, 60)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(70, 15)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Github.com"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(258, 60)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(52, 15)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Website:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(258, 45)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(81, 15)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "Version 1.0.0.9"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(254, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(323, 37)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "Gotcha! A Pokecord Bot"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(112, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(136, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(6, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.pkmnPreview)
        Me.TabPage2.Controls.Add(Me.lstOutput)
        Me.TabPage2.Controls.Add(Me.btnStopBot)
        Me.TabPage2.Controls.Add(Me.btnStartBot)
        Me.TabPage2.Controls.Add(Me.noticeHome)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(599, 422)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Home"
        '
        'pkmnPreview
        '
        Me.pkmnPreview.BackgroundImage = Global.Gotcha.My.Resources.Resources.Spr_3r_000
        Me.pkmnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pkmnPreview.Location = New System.Drawing.Point(553, 64)
        Me.pkmnPreview.Name = "pkmnPreview"
        Me.pkmnPreview.Size = New System.Drawing.Size(40, 30)
        Me.pkmnPreview.TabIndex = 8
        Me.pkmnPreview.TabStop = False
        '
        'lstOutput
        '
        Me.lstOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lstOutput.Location = New System.Drawing.Point(8, 100)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(583, 314)
        Me.lstOutput.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lstOutput.TabIndex = 7
        Me.lstOutput.UseCompatibleStateImageBehavior = False
        Me.lstOutput.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Msg"
        Me.ColumnHeader4.Width = 600
        '
        'btnStopBot
        '
        Me.btnStopBot.EnabledCalc = True
        Me.btnStopBot.Location = New System.Drawing.Point(8, 35)
        Me.btnStopBot.Name = "btnStopBot"
        Me.btnStopBot.Size = New System.Drawing.Size(585, 23)
        Me.btnStopBot.TabIndex = 6
        Me.btnStopBot.Text = "Stop"
        '
        'btnStartBot
        '
        Me.btnStartBot.EnabledCalc = True
        Me.btnStartBot.Location = New System.Drawing.Point(8, 6)
        Me.btnStartBot.Name = "btnStartBot"
        Me.btnStartBot.Size = New System.Drawing.Size(585, 23)
        Me.btnStartBot.TabIndex = 3
        Me.btnStartBot.Text = "Start"
        '
        'noticeHome
        '
        Me.noticeHome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.noticeHome.Cursor = System.Windows.Forms.Cursors.Default
        Me.noticeHome.Enabled = False
        Me.noticeHome.Location = New System.Drawing.Point(8, 64)
        Me.noticeHome.Multiline = True
        Me.noticeHome.Name = "noticeHome"
        Me.noticeHome.ReadOnly = True
        Me.noticeHome.Size = New System.Drawing.Size(539, 30)
        Me.noticeHome.TabIndex = 2
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.lblUBRate)
        Me.TabPage6.Controls.Add(Me.Label33)
        Me.TabPage6.Controls.Add(Me.lblMythicRate)
        Me.TabPage6.Controls.Add(Me.Label32)
        Me.TabPage6.Controls.Add(Me.lblUBCaught)
        Me.TabPage6.Controls.Add(Me.Label31)
        Me.TabPage6.Controls.Add(Me.lblMythicCaught)
        Me.TabPage6.Controls.Add(Me.Label30)
        Me.TabPage6.Controls.Add(Me.XylosSeparator14)
        Me.TabPage6.Controls.Add(Me.XylosSeparator10)
        Me.TabPage6.Controls.Add(Me.XylosSeparator9)
        Me.TabPage6.Controls.Add(Me.XylosSeparator8)
        Me.TabPage6.Controls.Add(Me.Label16)
        Me.TabPage6.Controls.Add(Me.lblSpawnRate)
        Me.TabPage6.Controls.Add(Me.lblMostCaught)
        Me.TabPage6.Controls.Add(Me.Label15)
        Me.TabPage6.Controls.Add(Me.Label14)
        Me.TabPage6.Controls.Add(Me.pbRecent)
        Me.TabPage6.Controls.Add(Me.Label12)
        Me.TabPage6.Controls.Add(Me.lstRecentCatch)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Controls.Add(Me.lblCatchPerMin)
        Me.TabPage6.Controls.Add(Me.lblLegendRate)
        Me.TabPage6.Controls.Add(Me.Label11)
        Me.TabPage6.Controls.Add(Me.lblLegendCaught)
        Me.TabPage6.Controls.Add(Me.Label13)
        Me.TabPage6.Controls.Add(Me.lblAvgTime)
        Me.TabPage6.Controls.Add(Me.Label10)
        Me.TabPage6.Controls.Add(Me.lblElapsed)
        Me.TabPage6.Controls.Add(Me.Label9)
        Me.TabPage6.Controls.Add(Me.lblSentMsg)
        Me.TabPage6.Controls.Add(Me.Label8)
        Me.TabPage6.Controls.Add(Me.lblTime)
        Me.TabPage6.Controls.Add(Me.Label3)
        Me.TabPage6.Controls.Add(Me.XylosSeparator7)
        Me.TabPage6.Controls.Add(Me.lblRate)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.lblEvo)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Controls.Add(Me.lblLevels)
        Me.TabPage6.Controls.Add(Me.Label4)
        Me.TabPage6.Controls.Add(Me.XylosSeparator6)
        Me.TabPage6.Controls.Add(Me.lblCaught)
        Me.TabPage6.Controls.Add(Me.Label2)
        Me.TabPage6.Controls.Add(Me.lblSeen)
        Me.TabPage6.Controls.Add(Me.Label1)
        Me.TabPage6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(184, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(599, 422)
        Me.TabPage6.TabIndex = 8
        Me.TabPage6.Text = "Stats"
        '
        'lblUBRate
        '
        Me.lblUBRate.AutoSize = True
        Me.lblUBRate.Location = New System.Drawing.Point(176, 141)
        Me.lblUBRate.Name = "lblUBRate"
        Me.lblUBRate.Size = New System.Drawing.Size(23, 15)
        Me.lblUBRate.TabIndex = 52
        Me.lblUBRate.Text = "0%"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(3, 141)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(92, 15)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "Ultra Beast Rate:"
        '
        'lblMythicRate
        '
        Me.lblMythicRate.AutoSize = True
        Me.lblMythicRate.Location = New System.Drawing.Point(176, 111)
        Me.lblMythicRate.Name = "lblMythicRate"
        Me.lblMythicRate.Size = New System.Drawing.Size(23, 15)
        Me.lblMythicRate.TabIndex = 50
        Me.lblMythicRate.Text = "0%"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 111)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(73, 15)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "Mythic Rate:"
        '
        'lblUBCaught
        '
        Me.lblUBCaught.AutoSize = True
        Me.lblUBCaught.Location = New System.Drawing.Point(176, 73)
        Me.lblUBCaught.Name = "lblUBCaught"
        Me.lblUBCaught.Size = New System.Drawing.Size(13, 15)
        Me.lblUBCaught.TabIndex = 48
        Me.lblUBCaught.Text = "0"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 73)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(116, 15)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Ultra Beasts Caught: "
        '
        'lblMythicCaught
        '
        Me.lblMythicCaught.AutoSize = True
        Me.lblMythicCaught.Location = New System.Drawing.Point(176, 43)
        Me.lblMythicCaught.Name = "lblMythicCaught"
        Me.lblMythicCaught.Size = New System.Drawing.Size(13, 15)
        Me.lblMythicCaught.TabIndex = 46
        Me.lblMythicCaught.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(3, 43)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 15)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "Mythic Caught: "
        '
        'XylosSeparator14
        '
        Me.XylosSeparator14.Location = New System.Drawing.Point(6, 38)
        Me.XylosSeparator14.Name = "XylosSeparator14"
        Me.XylosSeparator14.Size = New System.Drawing.Size(585, 2)
        Me.XylosSeparator14.TabIndex = 44
        Me.XylosSeparator14.Text = "XylosSeparator14"
        '
        'XylosSeparator10
        '
        Me.XylosSeparator10.Location = New System.Drawing.Point(5, 388)
        Me.XylosSeparator10.Name = "XylosSeparator10"
        Me.XylosSeparator10.Size = New System.Drawing.Size(585, 2)
        Me.XylosSeparator10.TabIndex = 43
        Me.XylosSeparator10.Text = "XylosSeparator10"
        '
        'XylosSeparator9
        '
        Me.XylosSeparator9.Location = New System.Drawing.Point(6, 91)
        Me.XylosSeparator9.Name = "XylosSeparator9"
        Me.XylosSeparator9.Size = New System.Drawing.Size(302, 2)
        Me.XylosSeparator9.TabIndex = 42
        Me.XylosSeparator9.Text = "XylosSeparator9"
        '
        'XylosSeparator8
        '
        Me.XylosSeparator8.Location = New System.Drawing.Point(6, 159)
        Me.XylosSeparator8.Name = "XylosSeparator8"
        Me.XylosSeparator8.Size = New System.Drawing.Size(297, 2)
        Me.XylosSeparator8.TabIndex = 41
        Me.XylosSeparator8.Text = "XylosSeparator8"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 370)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 15)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Spawn Chance:"
        '
        'lblSpawnRate
        '
        Me.lblSpawnRate.AutoSize = True
        Me.lblSpawnRate.Location = New System.Drawing.Point(176, 370)
        Me.lblSpawnRate.Name = "lblSpawnRate"
        Me.lblSpawnRate.Size = New System.Drawing.Size(23, 15)
        Me.lblSpawnRate.TabIndex = 39
        Me.lblSpawnRate.Text = "0%"
        '
        'lblMostCaught
        '
        Me.lblMostCaught.AutoSize = True
        Me.lblMostCaught.Location = New System.Drawing.Point(499, 58)
        Me.lblMostCaught.Name = "lblMostCaught"
        Me.lblMostCaught.Size = New System.Drawing.Size(31, 15)
        Me.lblMostCaught.TabIndex = 38
        Me.lblMostCaught.Text = "NaN"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(308, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 15)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Frequently Caught:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(308, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 15)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Most Recent:"
        '
        'pbRecent
        '
        Me.pbRecent.BackgroundImage = CType(resources.GetObject("pbRecent.BackgroundImage"), System.Drawing.Image)
        Me.pbRecent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbRecent.Location = New System.Drawing.Point(390, 99)
        Me.pbRecent.Name = "pbRecent"
        Me.pbRecent.Size = New System.Drawing.Size(200, 200)
        Me.pbRecent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbRecent.TabIndex = 35
        Me.pbRecent.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 15)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Recent Catches:"
        '
        'lstRecentCatch
        '
        Me.lstRecentCatch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstRecentCatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lstRecentCatch.FormattingEnabled = True
        Me.lstRecentCatch.ItemHeight = 15
        Me.lstRecentCatch.Location = New System.Drawing.Point(6, 182)
        Me.lstRecentCatch.Name = "lstRecentCatch"
        Me.lstRecentCatch.Size = New System.Drawing.Size(124, 120)
        Me.lstRecentCatch.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Catches Per Minute:"
        '
        'lblCatchPerMin
        '
        Me.lblCatchPerMin.AutoSize = True
        Me.lblCatchPerMin.Location = New System.Drawing.Point(499, 43)
        Me.lblCatchPerMin.Name = "lblCatchPerMin"
        Me.lblCatchPerMin.Size = New System.Drawing.Size(45, 15)
        Me.lblCatchPerMin.TabIndex = 28
        Me.lblCatchPerMin.Text = "0 / min"
        '
        'lblLegendRate
        '
        Me.lblLegendRate.AutoSize = True
        Me.lblLegendRate.Location = New System.Drawing.Point(176, 126)
        Me.lblLegendRate.Name = "lblLegendRate"
        Me.lblLegendRate.Size = New System.Drawing.Size(23, 15)
        Me.lblLegendRate.TabIndex = 27
        Me.lblLegendRate.Text = "0%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Legendary Rate:"
        '
        'lblLegendCaught
        '
        Me.lblLegendCaught.AutoSize = True
        Me.lblLegendCaught.Location = New System.Drawing.Point(176, 58)
        Me.lblLegendCaught.Name = "lblLegendCaught"
        Me.lblLegendCaught.Size = New System.Drawing.Size(13, 15)
        Me.lblLegendCaught.TabIndex = 25
        Me.lblLegendCaught.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 15)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Legendary Caught: "
        '
        'lblAvgTime
        '
        Me.lblAvgTime.AutoSize = True
        Me.lblAvgTime.Location = New System.Drawing.Point(499, 20)
        Me.lblAvgTime.Name = "lblAvgTime"
        Me.lblAvgTime.Size = New System.Drawing.Size(34, 15)
        Me.lblAvgTime.TabIndex = 21
        Me.lblAvgTime.Text = "0 Sec"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(308, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Last Identification Time:"
        '
        'lblElapsed
        '
        Me.lblElapsed.AutoSize = True
        Me.lblElapsed.Location = New System.Drawing.Point(176, 393)
        Me.lblElapsed.Name = "lblElapsed"
        Me.lblElapsed.Size = New System.Drawing.Size(80, 15)
        Me.lblElapsed.TabIndex = 19
        Me.lblElapsed.Text = "0hr 0min 0sec"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Bot Elapsed Time:"
        '
        'lblSentMsg
        '
        Me.lblSentMsg.AutoSize = True
        Me.lblSentMsg.Location = New System.Drawing.Point(176, 355)
        Me.lblSentMsg.Name = "lblSentMsg"
        Me.lblSentMsg.Size = New System.Drawing.Size(13, 15)
        Me.lblSentMsg.TabIndex = 17
        Me.lblSentMsg.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Messages Sent:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(499, 5)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(34, 15)
        Me.lblTime.TabIndex = 14
        Me.lblTime.Text = "0 Sec"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Avg Identification Time:"
        '
        'XylosSeparator7
        '
        Me.XylosSeparator7.Location = New System.Drawing.Point(7, 350)
        Me.XylosSeparator7.Name = "XylosSeparator7"
        Me.XylosSeparator7.Size = New System.Drawing.Size(585, 2)
        Me.XylosSeparator7.TabIndex = 12
        Me.XylosSeparator7.Text = "XylosSeparator7"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(176, 96)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(23, 15)
        Me.lblRate.TabIndex = 10
        Me.lblRate.Text = "0%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Catch Rate:"
        '
        'lblEvo
        '
        Me.lblEvo.AutoSize = True
        Me.lblEvo.Location = New System.Drawing.Point(176, 332)
        Me.lblEvo.Name = "lblEvo"
        Me.lblEvo.Size = New System.Drawing.Size(13, 15)
        Me.lblEvo.TabIndex = 8
        Me.lblEvo.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Gained Evolutions:"
        '
        'lblLevels
        '
        Me.lblLevels.AutoSize = True
        Me.lblLevels.Location = New System.Drawing.Point(176, 317)
        Me.lblLevels.Name = "lblLevels"
        Me.lblLevels.Size = New System.Drawing.Size(13, 15)
        Me.lblLevels.TabIndex = 6
        Me.lblLevels.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Gained Levels:"
        '
        'XylosSeparator6
        '
        Me.XylosSeparator6.Location = New System.Drawing.Point(7, 312)
        Me.XylosSeparator6.Name = "XylosSeparator6"
        Me.XylosSeparator6.Size = New System.Drawing.Size(585, 2)
        Me.XylosSeparator6.TabIndex = 4
        Me.XylosSeparator6.Text = "XylosSeparator6"
        '
        'lblCaught
        '
        Me.lblCaught.AutoSize = True
        Me.lblCaught.Location = New System.Drawing.Point(176, 20)
        Me.lblCaught.Name = "lblCaught"
        Me.lblCaught.Size = New System.Drawing.Size(13, 15)
        Me.lblCaught.TabIndex = 3
        Me.lblCaught.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pokemon Caught: "
        '
        'lblSeen
        '
        Me.lblSeen.AutoSize = True
        Me.lblSeen.Location = New System.Drawing.Point(176, 5)
        Me.lblSeen.Name = "lblSeen"
        Me.lblSeen.Size = New System.Drawing.Size(13, 15)
        Me.lblSeen.TabIndex = 1
        Me.lblSeen.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pokemon Seen: "
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.White
        Me.TabPage9.Controls.Add(Me.Label26)
        Me.TabPage9.Controls.Add(Me.btnClaimRewards)
        Me.TabPage9.Controls.Add(Me.Label25)
        Me.TabPage9.Controls.Add(Me.XylosSeparator12)
        Me.TabPage9.Controls.Add(Me.btnBallance)
        Me.TabPage9.Controls.Add(Me.Label22)
        Me.TabPage9.Controls.Add(Me.btnFavorite)
        Me.TabPage9.Controls.Add(Me.cbPokemon)
        Me.TabPage9.Controls.Add(Me.Label24)
        Me.TabPage9.Controls.Add(Me.txtNickname)
        Me.TabPage9.Controls.Add(Me.btnNickname)
        Me.TabPage9.Controls.Add(Me.Label23)
        Me.TabPage9.Controls.Add(Me.cbPokedex)
        Me.TabPage9.Controls.Add(Me.btnPokedex)
        Me.TabPage9.Controls.Add(Me.Label21)
        Me.TabPage9.Controls.Add(Me.cbInfo)
        Me.TabPage9.Controls.Add(Me.btnPokemon)
        Me.TabPage9.Controls.Add(Me.Label19)
        Me.TabPage9.Controls.Add(Me.btnInfo)
        Me.TabPage9.Controls.Add(Me.Label20)
        Me.TabPage9.Controls.Add(Me.btnSelectLatest)
        Me.TabPage9.Controls.Add(Me.Label18)
        Me.TabPage9.Controls.Add(Me.cbOrderBy)
        Me.TabPage9.Controls.Add(Me.btnOrderBy)
        Me.TabPage9.Controls.Add(Me.XylosSeparator11)
        Me.TabPage9.Controls.Add(Me.Label17)
        Me.TabPage9.Controls.Add(Me.btnDetailed)
        Me.TabPage9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage9.Location = New System.Drawing.Point(184, 4)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(599, 422)
        Me.TabPage9.TabIndex = 9
        Me.TabPage9.Text = "Quick Commands"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(195, 392)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(313, 30)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "p!pokedex claim all [Claims all available pokedex rewards.]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnClaimRewards
        '
        Me.btnClaimRewards.EnabledCalc = True
        Me.btnClaimRewards.Location = New System.Drawing.Point(3, 388)
        Me.btnClaimRewards.Name = "btnClaimRewards"
        Me.btnClaimRewards.Size = New System.Drawing.Size(89, 23)
        Me.btnClaimRewards.TabIndex = 29
        Me.btnClaimRewards.Text = "Claim Rewards"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(195, 363)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(249, 15)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "p!bal [Shows the amount of credits you have.]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XylosSeparator12
        '
        Me.XylosSeparator12.Location = New System.Drawing.Point(3, 351)
        Me.XylosSeparator12.Name = "XylosSeparator12"
        Me.XylosSeparator12.Size = New System.Drawing.Size(588, 2)
        Me.XylosSeparator12.TabIndex = 27
        Me.XylosSeparator12.Text = "XylosSeparator12"
        '
        'btnBallance
        '
        Me.btnBallance.EnabledCalc = True
        Me.btnBallance.Location = New System.Drawing.Point(3, 359)
        Me.btnBallance.Name = "btnBallance"
        Me.btnBallance.Size = New System.Drawing.Size(64, 23)
        Me.btnBallance.TabIndex = 26
        Me.btnBallance.Text = "Ballance"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(195, 324)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(286, 15)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "p!fav [This will show a list of your favorite Pokemon.]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnFavorite
        '
        Me.btnFavorite.EnabledCalc = True
        Me.btnFavorite.Location = New System.Drawing.Point(3, 320)
        Me.btnFavorite.Name = "btnFavorite"
        Me.btnFavorite.Size = New System.Drawing.Size(65, 25)
        Me.btnFavorite.TabIndex = 24
        Me.btnFavorite.Text = "Favorites"
        '
        'cbPokemon
        '
        Me.cbPokemon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPokemon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPokemon.EnabledCalc = True
        Me.cbPokemon.FormattingEnabled = True
        Me.cbPokemon.ItemHeight = 20
        Me.cbPokemon.Items.AddRange(New Object() {"All", "Shiny", "Alolan", "Mega", "Legendary", "Mythic", "Ultra Beast"})
        Me.cbPokemon.Location = New System.Drawing.Point(68, 142)
        Me.cbPokemon.Name = "cbPokemon"
        Me.cbPokemon.Size = New System.Drawing.Size(100, 26)
        Me.cbPokemon.TabIndex = 23
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(195, 293)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(384, 15)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "p!nickname <nickname> [Gives a nickname to your selected Pokemon]"
        '
        'txtNickname
        '
        Me.txtNickname.EnabledCalc = True
        Me.txtNickname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNickname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtNickname.Location = New System.Drawing.Point(74, 289)
        Me.txtNickname.MaxLength = 32767
        Me.txtNickname.MultiLine = False
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.ReadOnly = False
        Me.txtNickname.Size = New System.Drawing.Size(94, 25)
        Me.txtNickname.TabIndex = 21
        Me.txtNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNickname.UseSystemPasswordChar = False
        '
        'btnNickname
        '
        Me.btnNickname.EnabledCalc = True
        Me.btnNickname.Location = New System.Drawing.Point(3, 289)
        Me.btnNickname.Name = "btnNickname"
        Me.btnNickname.Size = New System.Drawing.Size(65, 25)
        Me.btnNickname.TabIndex = 20
        Me.btnNickname.Text = "Nickname"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(194, 252)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(385, 30)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "p!pokedex [Displays your Pokedex with a count of how many you own." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "p!pokedex --u" &
    "nowned [Displays only the Pokemon you need to collect.]"
        '
        'cbPokedex
        '
        Me.cbPokedex.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPokedex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPokedex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPokedex.EnabledCalc = True
        Me.cbPokedex.FormattingEnabled = True
        Me.cbPokedex.ItemHeight = 20
        Me.cbPokedex.Items.AddRange(New Object() {"Owned", "Unowned"})
        Me.cbPokedex.Location = New System.Drawing.Point(68, 257)
        Me.cbPokedex.Name = "cbPokedex"
        Me.cbPokedex.Size = New System.Drawing.Size(100, 26)
        Me.cbPokedex.TabIndex = 18
        '
        'btnPokedex
        '
        Me.btnPokedex.EnabledCalc = True
        Me.btnPokedex.Location = New System.Drawing.Point(3, 257)
        Me.btnPokedex.Name = "btnPokedex"
        Me.btnPokedex.Size = New System.Drawing.Size(59, 26)
        Me.btnPokedex.TabIndex = 17
        Me.btnPokedex.Text = "Pokedex"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(195, 137)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(367, 105)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = resources.GetString("Label21.Text")
        '
        'cbInfo
        '
        Me.cbInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInfo.EnabledCalc = True
        Me.cbInfo.FormattingEnabled = True
        Me.cbInfo.ItemHeight = 20
        Me.cbInfo.Items.AddRange(New Object() {"Selected Pokemon", "Latest Pokemon"})
        Me.cbInfo.Location = New System.Drawing.Point(47, 110)
        Me.cbInfo.Name = "cbInfo"
        Me.cbInfo.Size = New System.Drawing.Size(121, 26)
        Me.cbInfo.TabIndex = 12
        '
        'btnPokemon
        '
        Me.btnPokemon.EnabledCalc = True
        Me.btnPokemon.Location = New System.Drawing.Point(3, 142)
        Me.btnPokemon.Name = "btnPokemon"
        Me.btnPokemon.Size = New System.Drawing.Size(59, 26)
        Me.btnPokemon.TabIndex = 11
        Me.btnPokemon.Text = "Pokemon"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(195, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(376, 15)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "p!info [Displays the information of your SELECTED/LATEST Pokemon.]"
        '
        'btnInfo
        '
        Me.btnInfo.EnabledCalc = True
        Me.btnInfo.Location = New System.Drawing.Point(3, 110)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(38, 26)
        Me.btnInfo.TabIndex = 9
        Me.btnInfo.Text = "Info"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(195, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(394, 15)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "p!select latest [Selects your most recently caught or redeemed Pokemon.]"
        '
        'btnSelectLatest
        '
        Me.btnSelectLatest.EnabledCalc = True
        Me.btnSelectLatest.Location = New System.Drawing.Point(3, 78)
        Me.btnSelectLatest.Name = "btnSelectLatest"
        Me.btnSelectLatest.Size = New System.Drawing.Size(79, 26)
        Me.btnSelectLatest.TabIndex = 7
        Me.btnSelectLatest.Text = "Select Latest"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(195, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(385, 30)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "p!order <option> [This will help you order your Pokemon by whatever -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you like. " &
    "You have the option to do: alphabetical, number, level, or iv.]"
        '
        'cbOrderBy
        '
        Me.cbOrderBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbOrderBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrderBy.EnabledCalc = True
        Me.cbOrderBy.FormattingEnabled = True
        Me.cbOrderBy.ItemHeight = 20
        Me.cbOrderBy.Items.AddRange(New Object() {"alphabetical", "number", "level", "iv"})
        Me.cbOrderBy.Location = New System.Drawing.Point(79, 37)
        Me.cbOrderBy.Name = "cbOrderBy"
        Me.cbOrderBy.Size = New System.Drawing.Size(89, 26)
        Me.cbOrderBy.TabIndex = 4
        '
        'btnOrderBy
        '
        Me.btnOrderBy.EnabledCalc = True
        Me.btnOrderBy.Location = New System.Drawing.Point(3, 37)
        Me.btnOrderBy.Name = "btnOrderBy"
        Me.btnOrderBy.Size = New System.Drawing.Size(70, 26)
        Me.btnOrderBy.TabIndex = 3
        Me.btnOrderBy.Text = "Order by"
        '
        'XylosSeparator11
        '
        Me.XylosSeparator11.Location = New System.Drawing.Point(3, 70)
        Me.XylosSeparator11.Name = "XylosSeparator11"
        Me.XylosSeparator11.Size = New System.Drawing.Size(588, 2)
        Me.XylosSeparator11.TabIndex = 2
        Me.XylosSeparator11.Text = "XylosSeparator11"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(195, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(284, 15)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Toggles p!defailed [Shows IVs of pokemon in p!info.]"
        '
        'btnDetailed
        '
        Me.btnDetailed.EnabledCalc = True
        Me.btnDetailed.Location = New System.Drawing.Point(3, 5)
        Me.btnDetailed.Name = "btnDetailed"
        Me.btnDetailed.Size = New System.Drawing.Size(88, 26)
        Me.btnDetailed.TabIndex = 0
        Me.btnDetailed.Text = "Detailed View"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(599, 422)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Tag = "settings"
        Me.TabPage3.Text = "Settings"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.cbSelect)
        Me.TabPage4.Controls.Add(Me.btnSelect)
        Me.TabPage4.Controls.Add(Me.txtSearch)
        Me.TabPage4.Controls.Add(Me.btnDeselect)
        Me.TabPage4.Controls.Add(Me.lstPkmn)
        Me.TabPage4.Controls.Add(Me.XylosSeparator5)
        Me.TabPage4.Controls.Add(Me.btnClear)
        Me.TabPage4.Controls.Add(Me.btnSave)
        Me.TabPage4.Controls.Add(Me.chkbRandom)
        Me.TabPage4.Controls.Add(Me.lblInterval)
        Me.TabPage4.Controls.Add(Me.cbInterval)
        Me.TabPage4.Controls.Add(Me.XylosSeparator1)
        Me.TabPage4.Controls.Add(Me.noticeBasic)
        Me.TabPage4.Controls.Add(Me.btnRemoveString)
        Me.TabPage4.Controls.Add(Me.btnAddString)
        Me.TabPage4.Controls.Add(Me.txtAddString)
        Me.TabPage4.Controls.Add(Me.lstChatSpam)
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage4.Location = New System.Drawing.Point(184, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(599, 422)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Basic"
        '
        'cbSelect
        '
        Me.cbSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelect.EnabledCalc = True
        Me.cbSelect.FormattingEnabled = True
        Me.cbSelect.ItemHeight = 20
        Me.cbSelect.Items.AddRange(New Object() {"All", "Alolan", "Legendary", "Mythic", "Ultra Beast"})
        Me.cbSelect.Location = New System.Drawing.Point(354, 144)
        Me.cbSelect.Name = "cbSelect"
        Me.cbSelect.Size = New System.Drawing.Size(121, 26)
        Me.cbSelect.TabIndex = 20
        '
        'btnSelect
        '
        Me.btnSelect.EnabledCalc = True
        Me.btnSelect.Location = New System.Drawing.Point(481, 144)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(44, 26)
        Me.btnSelect.TabIndex = 19
        Me.btnSelect.Text = "Select"
        '
        'txtSearch
        '
        Me.txtSearch.EnabledCalc = True
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(8, 8)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.MultiLine = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.ReadOnly = False
        Me.txtSearch.Size = New System.Drawing.Size(583, 29)
        Me.txtSearch.TabIndex = 18
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.UseSystemPasswordChar = False
        '
        'btnDeselect
        '
        Me.btnDeselect.EnabledCalc = True
        Me.btnDeselect.Location = New System.Drawing.Point(531, 144)
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.Size = New System.Drawing.Size(60, 26)
        Me.btnDeselect.TabIndex = 16
        Me.btnDeselect.Text = "Deselect"
        '
        'lstPkmn
        '
        Me.lstPkmn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lstPkmn.FormattingEnabled = True
        Me.lstPkmn.Items.AddRange(New Object() {"Detective Pikachu", "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Alolan Rattata", "Raticate", "Alolan Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Alolan Raichu", "Sandshrew", "Alolan Sandshrew", "Sandslash", "Alolan Sandslash", "Nidoran", "Nidorina", "Nidoqueen", "Nidoran_m", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Alolan Vulpix", "Ninetales", "Alolan Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Alolan Diglett", "Dugtrio", "Alolan Dugtrio", "Meowth", "Alolan Meowth", "Persian", "Alolan Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Alolan Geodude", "Graveler", "Alolan Graveler", "Golem", "Alolan Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetchd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Alolan Grimer", "Muk", "Alolan Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Alolan Exeggutor", "Cubone", "Marowak", "Alolan Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw", "Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat", "Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep", "Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff", "Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking", "Misdreavus", "Unown", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull", "Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo", "Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom", "Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid", "Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia", "Ho-Oh", "Celebi", "Treecko", "Grovyle", "Sceptile", "Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone", "Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf", "Shiftry", "Taillow", "Swellow", "Wingull", "Pelipper", "Ralts", "Kirlia", "Gardevoir", "Surskit", "Masquerain", "Shroomish", "Breloom", "Slakoth", "Vigoroth", "Slaking", "Nincada", "Ninjask", "Shedinja", "Whismur", "Loudred", "Exploud", "Makuhita", "Hariyama", "Azurill", "Nosepass", "Skitty", "Delcatty", "Sableye", "Mawile", "Aron", "Lairon", "Aggron", "Meditite", "Medicham", "Electrike", "Manectric", "Plusle", "Minun", "Volbeat", "Illumise", "Roselia", "Gulpin", "Swalot", "Carvanha", "Sharpedo", "Wailmer", "Wailord", "Numel", "Camerupt", "Torkoal", "Spoink", "Grumpig", "Spinda", "Trapinch", "Vibrava", "Flygon", "Cacnea", "Cacturne", "Swablu", "Altaria", "Zangoose", "Seviper", "Lunatone", "Solrock", "Barboach", "Whiscash", "Corphish", "Crawdaunt", "Baltoy", "Claydol", "Lileep", "Cradily", "Anorith", "Armaldo", "Feebas", "Milotic", "Castform", "Kecleon", "Shuppet", "Banette", "Duskull", "Dusclops", "Tropius", "Chimecho", "Absol", "Wynaut", "Snorunt", "Glalie", "Spheal", "Sealeo", "Walrein", "Clamperl", "Huntail", "Gorebyss", "Relicanth", "Luvdisc", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang", "Metagross", "Regirock", "Regice", "Registeel", "Latias", "Latios", "Kyogre", "Groudon", "Rayquaza", "Jirachi", "Deoxys", "Turtwig", "Grotle", "Torterra", "Chimchar", "Monferno", "Infernape", "Piplup", "Prinplup", "Empoleon", "Starly", "Staravia", "Staraptor", "Bidoof", "Bibarel", "Kricketot", "Kricketune", "Shinx", "Luxio", "Luxray", "Budew", "Roserade", "Cranidos", "Rampardos", "Shieldon", "Bastiodon", "Burmy", "Wormadam", "Mothim", "Combee", "Vespiquen", "Pachirisu", "Buizel", "Floatzel", "Cherubi", "Cherrim", "Shellos", "Gastrodon", "Ambipom", "Drifloon", "Drifblim", "Buneary", "Lopunny", "Mismagius", "Honchkrow", "Glameow", "Purugly", "Chingling", "Stunky", "Skuntank", "Bronzor", "Bronzong", "Bonsly", "Mime Jr.", "Happiny", "Chatot", "Spiritomb", "Gible", "Gabite", "Garchomp", "Munchlax", "Riolu", "Lucario", "Hippopotas", "Hippowdon", "Skorupi", "Drapion", "Croagunk", "Toxicroak", "Carnivine", "Finneon", "Lumineon", "Mantyke", "Snover", "Abomasnow", "Weavile", "Magnezone", "Lickilicky", "Rhyperior", "Tangrowth", "Electivire", "Magmortar", "Togekiss", "Yanmega", "Leafeon", "Glaceon", "Gliscor", "Mamoswine", "Porygon-Z", "Gallade", "Probopass", "Dusknoir", "Froslass", "Rotom", "Uxie", "Mesprit", "Azelf", "Dialga", "Palkia", "Heatran", "Regigigas", "Giratina", "Cresselia", "Phione", "Manaphy", "Darkrai", "Shaymin", "Arceus", "Victini", "Snivy", "Servine", "Serperior", "Tepig", "Pignite", "Emboar", "Oshawott", "Dewott", "Samurott", "Patrat", "Watchog", "Lillipup", "Herdier", "Stoutland", "Purrloin", "Liepard", "Pansage", "Simisage", "Pansear", "Simisear", "Panpour", "Simipour", "Munna", "Musharna", "Pidove", "Tranquill", "Unfezant", "Blitzle", "Zebstrika", "Roggenrola", "Boldore", "Gigalith", "Woobat", "Swoobat", "Drilbur", "Excadrill", "Audino", "Timburr", "Gurdurr", "Conkeldurr", "Tympole", "Palpitoad", "Seismitoad", "Throh", "Sawk", "Sewaddle", "Swadloon", "Leavanny", "Venipede", "Whirlipede", "Scolipede", "Cottonee", "Whimsicott", "Petilil", "Lilligant", "Basculin", "Sandile", "Krokorok", "Krookodile", "Darumaka", "Darmanitan", "Maractus", "Dwebble", "Crustle", "Scraggy", "Scrafty", "Sigilyph", "Yamask", "Cofagrigus", "Tirtouga", "Carracosta", "Archen", "Archeops", "Trubbish", "Garbodor", "Zorua", "Zoroark", "Minccino", "Cinccino", "Gothita", "Gothorita", "Gothitelle", "Solosis", "Duosion", "Reuniclus", "Ducklett", "Swanna", "Vanillite", "Vanillish", "Vanilluxe", "Deerling", "Sawsbuck", "Emolga", "Karrablast", "Escavalier", "Foongus", "Amoonguss", "Frillish", "Jellicent", "Alomomola", "Joltik", "Galvantula", "Ferroseed", "Ferrothorn", "Klink", "Klang", "Klinklang", "Tynamo", "Eelektrik", "Eelektross", "Elgyem", "Beheeyem", "Litwick", "Lampent", "Chandelure", "Axew", "Fraxure", "Haxorus", "Cubchoo", "Beartic", "Cryogonal", "Shelmet", "Accelgor", "Stunfisk", "Mienfoo", "Mienshao", "Druddigon", "Golett", "Golurk", "Pawniard", "Bisharp", "Bouffalant", "Rufflet", "Braviary", "Vullaby", "Mandibuzz", "Heatmor", "Durant", "Deino", "Zweilous", "Hydreigon", "Larvesta", "Volcarona", "Cobalion", "Terrakion", "Virizion", "Tornadus", "Thundurus", "Reshiram", "Zekrom", "Landorus", "Kyurem", "Keldeo", "Meloetta", "Genesect", "Chespin", "Quilladin", "Chesnaught", "Fennekin", "Braixen", "Delphox", "Froakie", "Frogadier", "Greninja", "Bunnelby", "Diggersby", "Fletchling", "Fletchinder", "Talonflame", "Scatterbug", "Spewpa", "Vivillon", "Litleo", "Pyroar", "Flabebe", "Floette", "Florges", "Skiddo", "Gogoat", "Pancham", "Pangoro", "Furfrou", "Espurr", "Meowstic", "Honedge", "Doublade", "Aegislash", "Spritzee", "Aromatisse", "Swirlix", "Slurpuff", "Inkay", "Malamar", "Binacle", "Barbaracle", "Skrelp", "Dragalge", "Clauncher", "Clawitzer", "Helioptile", "Heliolisk", "Tyrunt", "Tyrantrum", "Amaura", "Aurorus", "Sylveon", "Hawlucha", "Dedenne", "Carbink", "Goomy", "Sliggoo", "Goodra", "Klefki", "Phantump", "Trevenant", "Pumpkaboo", "Gourgeist", "Bergmite", "Avalugg", "Noibat", "Noivern", "Xerneas", "Yveltal", "Zygarde", "Diancie", "Hoopa", "Volcanion", "Rowlet", "Dartrix", "Decidueye", "Litten", "Torracat", "Incineroar", "Popplio", "Brionne", "Primarina", "Pikipek", "Trumbeak", "Toucannon", "Yungoos", "Gumshoos", "Grubbin", "Charjabug", "Vikavolt", "Crabrawler", "Crabominable", "Oricorio", "Cutiefly", "Ribombee", "Rockruff", "Lycanroc", "Wishiwashi", "Mareanie", "Toxapex", "Mudbray", "Mudsdale", "Dewpider", "Araquanid", "Fomantis", "Lurantis", "Morelull", "Shiinotic", "Salandit", "Salazzle", "Stufful", "Bewear", "Bounsweet", "Steenee", "Tsareena", "Comfey", "Oranguru", "Passimian", "Wimpod", "Golisopod", "Sandygast", "Palossand", "Pyukumuku", "Type: Null", "Silvally", "Minior", "Komala", "Turtonator", "Togedemaru", "Mimikyu", "Bruxish", "Drampa", "Dhelmise", "Jangmo-o", "Hakamo-o", "Kommo-o", "Tapu Koko", "Tapu Lele", "Tapu Bulu", "Tapu Fini", "Cosmog", "Cosmoem", "Solgaleo", "Lunala", "Nihilego", "Buzzwole", "Pheromosa", "Xurkitree", "Celesteela", "Kartana", "Guzzlord", "Necrozma", "Magearna", "Marshadow", "Poipole", "Naganadel", "Stakataka", "Blacephalon", "Zeraora", "Meltan", "Melmetal"})
        Me.lstPkmn.Location = New System.Drawing.Point(8, 44)
        Me.lstPkmn.Name = "lstPkmn"
        Me.lstPkmn.Size = New System.Drawing.Size(583, 94)
        Me.lstPkmn.TabIndex = 12
        '
        'XylosSeparator5
        '
        Me.XylosSeparator5.Location = New System.Drawing.Point(8, 176)
        Me.XylosSeparator5.Name = "XylosSeparator5"
        Me.XylosSeparator5.Size = New System.Drawing.Size(583, 2)
        Me.XylosSeparator5.TabIndex = 11
        Me.XylosSeparator5.Text = "XylosSeparator5"
        '
        'btnClear
        '
        Me.btnClear.EnabledCalc = True
        Me.btnClear.Location = New System.Drawing.Point(435, 362)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 26)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        '
        'btnSave
        '
        Me.btnSave.EnabledCalc = True
        Me.btnSave.Location = New System.Drawing.Point(516, 362)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 26)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        '
        'chkbRandom
        '
        Me.chkbRandom.Checked = True
        Me.chkbRandom.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkbRandom.EnabledCalc = False
        Me.chkbRandom.Location = New System.Drawing.Point(155, 365)
        Me.chkbRandom.Name = "chkbRandom"
        Me.chkbRandom.Size = New System.Drawing.Size(79, 18)
        Me.chkbRandom.TabIndex = 8
        Me.chkbRandom.Text = "Random?"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(5, 365)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(73, 15)
        Me.lblInterval.TabIndex = 7
        Me.lblInterval.Text = "Interval (ms)"
        '
        'cbInterval
        '
        Me.cbInterval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbInterval.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInterval.EnabledCalc = True
        Me.cbInterval.FormattingEnabled = True
        Me.cbInterval.ItemHeight = 20
        Me.cbInterval.Items.AddRange(New Object() {"500", "1000", "1500", "2000", "5000", "10000"})
        Me.cbInterval.Location = New System.Drawing.Point(84, 362)
        Me.cbInterval.Name = "cbInterval"
        Me.cbInterval.Size = New System.Drawing.Size(65, 26)
        Me.cbInterval.TabIndex = 6
        '
        'XylosSeparator1
        '
        Me.XylosSeparator1.Location = New System.Drawing.Point(8, 354)
        Me.XylosSeparator1.Name = "XylosSeparator1"
        Me.XylosSeparator1.Size = New System.Drawing.Size(583, 2)
        Me.XylosSeparator1.TabIndex = 5
        Me.XylosSeparator1.Text = "XylosSeparator1"
        '
        'noticeBasic
        '
        Me.noticeBasic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.noticeBasic.Cursor = System.Windows.Forms.Cursors.Default
        Me.noticeBasic.Enabled = False
        Me.noticeBasic.Location = New System.Drawing.Point(8, 394)
        Me.noticeBasic.Multiline = True
        Me.noticeBasic.Name = "noticeBasic"
        Me.noticeBasic.ReadOnly = True
        Me.noticeBasic.Size = New System.Drawing.Size(583, 20)
        Me.noticeBasic.TabIndex = 4
        '
        'btnRemoveString
        '
        Me.btnRemoveString.EnabledCalc = True
        Me.btnRemoveString.Location = New System.Drawing.Point(483, 319)
        Me.btnRemoveString.Name = "btnRemoveString"
        Me.btnRemoveString.Size = New System.Drawing.Size(108, 29)
        Me.btnRemoveString.TabIndex = 3
        Me.btnRemoveString.Text = "Remove Selected"
        '
        'btnAddString
        '
        Me.btnAddString.EnabledCalc = True
        Me.btnAddString.Location = New System.Drawing.Point(428, 319)
        Me.btnAddString.Name = "btnAddString"
        Me.btnAddString.Size = New System.Drawing.Size(49, 29)
        Me.btnAddString.TabIndex = 2
        Me.btnAddString.Text = "Add"
        '
        'txtAddString
        '
        Me.txtAddString.EnabledCalc = True
        Me.txtAddString.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtAddString.Location = New System.Drawing.Point(8, 319)
        Me.txtAddString.MaxLength = 32767
        Me.txtAddString.MultiLine = False
        Me.txtAddString.Name = "txtAddString"
        Me.txtAddString.ReadOnly = False
        Me.txtAddString.Size = New System.Drawing.Size(414, 29)
        Me.txtAddString.TabIndex = 1
        Me.txtAddString.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddString.UseSystemPasswordChar = False
        '
        'lstChatSpam
        '
        Me.lstChatSpam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstChatSpam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lstChatSpam.FormattingEnabled = True
        Me.lstChatSpam.ItemHeight = 15
        Me.lstChatSpam.Location = New System.Drawing.Point(8, 188)
        Me.lstChatSpam.Name = "lstChatSpam"
        Me.lstChatSpam.Size = New System.Drawing.Size(583, 120)
        Me.lstChatSpam.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.chkAlolan)
        Me.TabPage5.Controls.Add(Me.chkUltraBeast)
        Me.TabPage5.Controls.Add(Me.chkMythic)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.chkLegendary)
        Me.TabPage5.Controls.Add(Me.XylosSeparator13)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.txtChannelName2)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.txtChannelName)
        Me.TabPage5.Controls.Add(Me.btnTestEmail)
        Me.TabPage5.Controls.Add(Me.noticeAdvanced)
        Me.TabPage5.Controls.Add(Me.btnSaveAdvanced)
        Me.TabPage5.Controls.Add(Me.txtSubject)
        Me.TabPage5.Controls.Add(Me.lblSubject)
        Me.TabPage5.Controls.Add(Me.lblAltEmail)
        Me.TabPage5.Controls.Add(Me.XylosSeparator4)
        Me.TabPage5.Controls.Add(Me.txtAltEmail)
        Me.TabPage5.Controls.Add(Me.chkAltEmail)
        Me.TabPage5.Controls.Add(Me.lblHost)
        Me.TabPage5.Controls.Add(Me.txtHost)
        Me.TabPage5.Controls.Add(Me.lblPort)
        Me.TabPage5.Controls.Add(Me.txtPort)
        Me.TabPage5.Controls.Add(Me.lblPass)
        Me.TabPage5.Controls.Add(Me.txtPass)
        Me.TabPage5.Controls.Add(Me.txtEmail)
        Me.TabPage5.Controls.Add(Me.lblEmail)
        Me.TabPage5.Controls.Add(Me.cbEmail)
        Me.TabPage5.Controls.Add(Me.XylosSeparator3)
        Me.TabPage5.Controls.Add(Me.lblImgDir)
        Me.TabPage5.Controls.Add(Me.btnChange)
        Me.TabPage5.Controls.Add(Me.txtImgDirectory)
        Me.TabPage5.Controls.Add(Me.XylosSeparator2)
        Me.TabPage5.Controls.Add(Me.lblCatchDelay)
        Me.TabPage5.Controls.Add(Me.txtCatchDelay)
        Me.TabPage5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(184, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(599, 422)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Advanced"
        '
        'chkAlolan
        '
        Me.chkAlolan.Checked = False
        Me.chkAlolan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAlolan.EnabledCalc = True
        Me.chkAlolan.Location = New System.Drawing.Point(372, 322)
        Me.chkAlolan.Name = "chkAlolan"
        Me.chkAlolan.Size = New System.Drawing.Size(76, 18)
        Me.chkAlolan.TabIndex = 34
        Me.chkAlolan.Text = "Alolans"
        '
        'chkUltraBeast
        '
        Me.chkUltraBeast.Checked = False
        Me.chkUltraBeast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkUltraBeast.EnabledCalc = True
        Me.chkUltraBeast.Location = New System.Drawing.Point(273, 322)
        Me.chkUltraBeast.Name = "chkUltraBeast"
        Me.chkUltraBeast.Size = New System.Drawing.Size(93, 18)
        Me.chkUltraBeast.TabIndex = 33
        Me.chkUltraBeast.Text = "Ultra Beasts"
        '
        'chkMythic
        '
        Me.chkMythic.Checked = False
        Me.chkMythic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkMythic.EnabledCalc = True
        Me.chkMythic.Location = New System.Drawing.Point(194, 322)
        Me.chkMythic.Name = "chkMythic"
        Me.chkMythic.Size = New System.Drawing.Size(73, 18)
        Me.chkMythic.TabIndex = 32
        Me.chkMythic.Text = "Mythics"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 319)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 15)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "Notifications:"
        '
        'chkLegendary
        '
        Me.chkLegendary.Checked = False
        Me.chkLegendary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkLegendary.EnabledCalc = True
        Me.chkLegendary.Location = New System.Drawing.Point(92, 322)
        Me.chkLegendary.Name = "chkLegendary"
        Me.chkLegendary.Size = New System.Drawing.Size(96, 18)
        Me.chkLegendary.TabIndex = 30
        Me.chkLegendary.Text = "Legendaries"
        '
        'XylosSeparator13
        '
        Me.XylosSeparator13.Location = New System.Drawing.Point(11, 314)
        Me.XylosSeparator13.Name = "XylosSeparator13"
        Me.XylosSeparator13.Size = New System.Drawing.Size(580, 2)
        Me.XylosSeparator13.TabIndex = 29
        Me.XylosSeparator13.Text = "XylosSeparator13"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(480, 13)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 15)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "Bag:"
        '
        'txtChannelName2
        '
        Me.txtChannelName2.EnabledCalc = True
        Me.txtChannelName2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChannelName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtChannelName2.Location = New System.Drawing.Point(516, 8)
        Me.txtChannelName2.MaxLength = 32767
        Me.txtChannelName2.MultiLine = False
        Me.txtChannelName2.Name = "txtChannelName2"
        Me.txtChannelName2.ReadOnly = False
        Me.txtChannelName2.Size = New System.Drawing.Size(75, 29)
        Me.txtChannelName2.TabIndex = 27
        Me.txtChannelName2.Text = "pokebag"
        Me.txtChannelName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtChannelName2.UseSystemPasswordChar = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(265, 13)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(132, 15)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "Discord Channel Name:"
        '
        'txtChannelName
        '
        Me.txtChannelName.EnabledCalc = True
        Me.txtChannelName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChannelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtChannelName.Location = New System.Drawing.Point(403, 8)
        Me.txtChannelName.MaxLength = 32767
        Me.txtChannelName.MultiLine = False
        Me.txtChannelName.Name = "txtChannelName"
        Me.txtChannelName.ReadOnly = False
        Me.txtChannelName.Size = New System.Drawing.Size(71, 29)
        Me.txtChannelName.TabIndex = 25
        Me.txtChannelName.Text = "general"
        Me.txtChannelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtChannelName.UseSystemPasswordChar = False
        '
        'btnTestEmail
        '
        Me.btnTestEmail.EnabledCalc = True
        Me.btnTestEmail.Location = New System.Drawing.Point(11, 365)
        Me.btnTestEmail.Name = "btnTestEmail"
        Me.btnTestEmail.Size = New System.Drawing.Size(115, 23)
        Me.btnTestEmail.TabIndex = 24
        Me.btnTestEmail.Text = "Send test email"
        '
        'noticeAdvanced
        '
        Me.noticeAdvanced.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.noticeAdvanced.Cursor = System.Windows.Forms.Cursors.Default
        Me.noticeAdvanced.Enabled = False
        Me.noticeAdvanced.Location = New System.Drawing.Point(11, 394)
        Me.noticeAdvanced.Multiline = True
        Me.noticeAdvanced.Name = "noticeAdvanced"
        Me.noticeAdvanced.ReadOnly = True
        Me.noticeAdvanced.Size = New System.Drawing.Size(580, 20)
        Me.noticeAdvanced.TabIndex = 23
        '
        'btnSaveAdvanced
        '
        Me.btnSaveAdvanced.EnabledCalc = True
        Me.btnSaveAdvanced.Location = New System.Drawing.Point(516, 365)
        Me.btnSaveAdvanced.Name = "btnSaveAdvanced"
        Me.btnSaveAdvanced.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAdvanced.TabIndex = 22
        Me.btnSaveAdvanced.Text = "Save"
        '
        'txtSubject
        '
        Me.txtSubject.EnabledCalc = True
        Me.txtSubject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSubject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtSubject.Location = New System.Drawing.Point(212, 221)
        Me.txtSubject.MaxLength = 32767
        Me.txtSubject.MultiLine = False
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = False
        Me.txtSubject.Size = New System.Drawing.Size(379, 26)
        Me.txtSubject.TabIndex = 21
        Me.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSubject.UseSystemPasswordChar = False
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(209, 203)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(74, 15)
        Me.lblSubject.TabIndex = 20
        Me.lblSubject.Text = "Subject Line:"
        '
        'lblAltEmail
        '
        Me.lblAltEmail.AutoSize = True
        Me.lblAltEmail.Location = New System.Drawing.Point(8, 264)
        Me.lblAltEmail.Name = "lblAltEmail"
        Me.lblAltEmail.Size = New System.Drawing.Size(90, 15)
        Me.lblAltEmail.TabIndex = 19
        Me.lblAltEmail.Text = "Alternate Email:"
        '
        'XylosSeparator4
        '
        Me.XylosSeparator4.Location = New System.Drawing.Point(11, 253)
        Me.XylosSeparator4.Name = "XylosSeparator4"
        Me.XylosSeparator4.Size = New System.Drawing.Size(580, 2)
        Me.XylosSeparator4.TabIndex = 18
        Me.XylosSeparator4.Text = "XylosSeparator4"
        '
        'txtAltEmail
        '
        Me.txtAltEmail.EnabledCalc = True
        Me.txtAltEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAltEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtAltEmail.Location = New System.Drawing.Point(11, 282)
        Me.txtAltEmail.MaxLength = 32767
        Me.txtAltEmail.MultiLine = False
        Me.txtAltEmail.Name = "txtAltEmail"
        Me.txtAltEmail.ReadOnly = False
        Me.txtAltEmail.Size = New System.Drawing.Size(580, 26)
        Me.txtAltEmail.TabIndex = 17
        Me.txtAltEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAltEmail.UseSystemPasswordChar = False
        '
        'chkAltEmail
        '
        Me.chkAltEmail.Checked = False
        Me.chkAltEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAltEmail.EnabledCalc = True
        Me.chkAltEmail.Location = New System.Drawing.Point(432, 261)
        Me.chkAltEmail.Name = "chkAltEmail"
        Me.chkAltEmail.Size = New System.Drawing.Size(159, 18)
        Me.chkAltEmail.TabIndex = 16
        Me.chkAltEmail.Text = "Send to alternate email?"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(80, 203)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(69, 15)
        Me.lblHost.TabIndex = 15
        Me.lblHost.Text = "SMTP Host:"
        '
        'txtHost
        '
        Me.txtHost.EnabledCalc = True
        Me.txtHost.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtHost.Location = New System.Drawing.Point(83, 221)
        Me.txtHost.MaxLength = 32767
        Me.txtHost.MultiLine = False
        Me.txtHost.Name = "txtHost"
        Me.txtHost.ReadOnly = True
        Me.txtHost.Size = New System.Drawing.Size(123, 26)
        Me.txtHost.TabIndex = 14
        Me.txtHost.Text = "smtp.gmail.com"
        Me.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtHost.UseSystemPasswordChar = False
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(8, 203)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(66, 15)
        Me.lblPort.TabIndex = 13
        Me.lblPort.Text = "SMTP Port:"
        '
        'txtPort
        '
        Me.txtPort.EnabledCalc = True
        Me.txtPort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtPort.Location = New System.Drawing.Point(11, 221)
        Me.txtPort.MaxLength = 32767
        Me.txtPort.MultiLine = False
        Me.txtPort.Name = "txtPort"
        Me.txtPort.ReadOnly = True
        Me.txtPort.Size = New System.Drawing.Size(63, 26)
        Me.txtPort.TabIndex = 12
        Me.txtPort.Text = "587"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPort.UseSystemPasswordChar = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(8, 156)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(60, 15)
        Me.lblPass.TabIndex = 11
        Me.lblPass.Text = "Password:"
        '
        'txtPass
        '
        Me.txtPass.EnabledCalc = True
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(11, 174)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.MultiLine = False
        Me.txtPass.Name = "txtPass"
        Me.txtPass.ReadOnly = False
        Me.txtPass.Size = New System.Drawing.Size(453, 26)
        Me.txtPass.TabIndex = 10
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.EnabledCalc = True
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(11, 127)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.MultiLine = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = False
        Me.txtEmail.Size = New System.Drawing.Size(453, 26)
        Me.txtEmail.TabIndex = 9
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmail.UseSystemPasswordChar = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(8, 109)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email:"
        '
        'cbEmail
        '
        Me.cbEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmail.EnabledCalc = False
        Me.cbEmail.FormattingEnabled = True
        Me.cbEmail.ItemHeight = 20
        Me.cbEmail.Items.AddRange(New Object() {"@gmail.com"})
        Me.cbEmail.Location = New System.Drawing.Point(470, 127)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(121, 26)
        Me.cbEmail.TabIndex = 7
        '
        'XylosSeparator3
        '
        Me.XylosSeparator3.Location = New System.Drawing.Point(11, 101)
        Me.XylosSeparator3.Name = "XylosSeparator3"
        Me.XylosSeparator3.Size = New System.Drawing.Size(580, 2)
        Me.XylosSeparator3.TabIndex = 6
        Me.XylosSeparator3.Text = "XylosSeparator3"
        '
        'lblImgDir
        '
        Me.lblImgDir.AutoSize = True
        Me.lblImgDir.Location = New System.Drawing.Point(8, 48)
        Me.lblImgDir.Name = "lblImgDir"
        Me.lblImgDir.Size = New System.Drawing.Size(94, 15)
        Me.lblImgDir.TabIndex = 5
        Me.lblImgDir.Text = "Image Directory:"
        '
        'btnChange
        '
        Me.btnChange.EnabledCalc = True
        Me.btnChange.Location = New System.Drawing.Point(516, 66)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 29)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Change"
        '
        'txtImgDirectory
        '
        Me.txtImgDirectory.EnabledCalc = True
        Me.txtImgDirectory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtImgDirectory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtImgDirectory.Location = New System.Drawing.Point(11, 66)
        Me.txtImgDirectory.MaxLength = 32767
        Me.txtImgDirectory.MultiLine = False
        Me.txtImgDirectory.Name = "txtImgDirectory"
        Me.txtImgDirectory.ReadOnly = False
        Me.txtImgDirectory.Size = New System.Drawing.Size(499, 29)
        Me.txtImgDirectory.TabIndex = 3
        Me.txtImgDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtImgDirectory.UseSystemPasswordChar = False
        '
        'XylosSeparator2
        '
        Me.XylosSeparator2.Location = New System.Drawing.Point(11, 43)
        Me.XylosSeparator2.Name = "XylosSeparator2"
        Me.XylosSeparator2.Size = New System.Drawing.Size(580, 2)
        Me.XylosSeparator2.TabIndex = 2
        Me.XylosSeparator2.Text = "XylosSeparator2"
        '
        'lblCatchDelay
        '
        Me.lblCatchDelay.AutoSize = True
        Me.lblCatchDelay.Location = New System.Drawing.Point(8, 13)
        Me.lblCatchDelay.Name = "lblCatchDelay"
        Me.lblCatchDelay.Size = New System.Drawing.Size(100, 15)
        Me.lblCatchDelay.TabIndex = 1
        Me.lblCatchDelay.Text = "Catch Delay (ms):"
        '
        'txtCatchDelay
        '
        Me.txtCatchDelay.EnabledCalc = True
        Me.txtCatchDelay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCatchDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtCatchDelay.Location = New System.Drawing.Point(114, 8)
        Me.txtCatchDelay.MaxLength = 32767
        Me.txtCatchDelay.MultiLine = False
        Me.txtCatchDelay.Name = "txtCatchDelay"
        Me.txtCatchDelay.ReadOnly = False
        Me.txtCatchDelay.Size = New System.Drawing.Size(92, 29)
        Me.txtCatchDelay.TabIndex = 0
        Me.txtCatchDelay.Text = "1500"
        Me.txtCatchDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCatchDelay.UseSystemPasswordChar = False
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.White
        Me.TabPage7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage7.Location = New System.Drawing.Point(184, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(599, 422)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Tag = "dev"
        Me.TabPage7.Text = "Debug"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.White
        Me.TabPage8.Controls.Add(Me.lstLogs)
        Me.TabPage8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage8.Location = New System.Drawing.Point(184, 4)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(599, 422)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Logs"
        '
        'lstLogs
        '
        Me.lstLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lstLogs.Location = New System.Drawing.Point(8, 8)
        Me.lstLogs.Name = "lstLogs"
        Me.lstLogs.Size = New System.Drawing.Size(583, 406)
        Me.lstLogs.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lstLogs.TabIndex = 4
        Me.lstLogs.UseCompatibleStateImageBehavior = False
        Me.lstLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Msg"
        Me.ColumnHeader2.Width = 1200
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.White
        Me.TabPage10.Controls.Add(Me.LinkLabel1)
        Me.TabPage10.Controls.Add(Me.Label38)
        Me.TabPage10.Controls.Add(Me.XylosSeparator15)
        Me.TabPage10.Controls.Add(Me.Label37)
        Me.TabPage10.Controls.Add(Me.lblGithub)
        Me.TabPage10.Controls.Add(Me.Label35)
        Me.TabPage10.Controls.Add(Me.Label36)
        Me.TabPage10.Controls.Add(Me.Label34)
        Me.TabPage10.Controls.Add(Me.PictureBox4)
        Me.TabPage10.Controls.Add(Me.PictureBox3)
        Me.TabPage10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage10.Location = New System.Drawing.Point(184, 4)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(599, 422)
        Me.TabPage10.TabIndex = 10
        Me.TabPage10.Text = "About"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(298, 293)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 15)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "github."
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(3, 129)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(595, 180)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = resources.GetString("Label38.Text")
        '
        'XylosSeparator15
        '
        Me.XylosSeparator15.Location = New System.Drawing.Point(3, 109)
        Me.XylosSeparator15.Name = "XylosSeparator15"
        Me.XylosSeparator15.Size = New System.Drawing.Size(588, 2)
        Me.XylosSeparator15.TabIndex = 8
        Me.XylosSeparator15.Text = "XylosSeparator15"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 114)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(70, 15)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Description:"
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(314, 57)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(202, 15)
        Me.lblGithub.TabIndex = 6
        Me.lblGithub.TabStop = True
        Me.lblGithub.Text = "https://github.com/Zydratex/Gotcha"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(262, 57)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(46, 15)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Github:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(262, 42)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(84, 15)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Version: 1.0.0.0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(258, 5)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(323, 37)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Gotcha! A Pokecord Bot"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(109, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(143, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 430)
        Me.Controls.Add(Me.mainTab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Gotcha!"
        Me.mainTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pkmnPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.pbRecent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTab As XylosTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnAddString As XylosButton
    Friend WithEvents txtAddString As XylosTextBox
    Friend WithEvents lstChatSpam As ListBox
    Friend WithEvents noticeBasic As XylosNotice
    Friend WithEvents btnRemoveString As XylosButton
    Friend WithEvents chkbRandom As XylosCheckBox
    Friend WithEvents lblInterval As Label
    Friend WithEvents cbInterval As XylosCombobox
    Friend WithEvents XylosSeparator1 As XylosSeparator
    Friend WithEvents btnClear As XylosButton
    Friend WithEvents btnSave As XylosButton
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents lstLogs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents statsTimer As Timer
    Friend WithEvents btnStartBot As XylosButton
    Friend WithEvents noticeHome As XylosNotice
    Friend WithEvents lblImgDir As Label
    Friend WithEvents btnChange As XylosButton
    Friend WithEvents txtImgDirectory As XylosTextBox
    Friend WithEvents XylosSeparator2 As XylosSeparator
    Friend WithEvents lblCatchDelay As Label
    Friend WithEvents txtCatchDelay As XylosTextBox
    Friend WithEvents fldDialog As FolderBrowserDialog
    Friend WithEvents txtEmail As XylosTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents cbEmail As XylosCombobox
    Friend WithEvents XylosSeparator3 As XylosSeparator
    Friend WithEvents btnSaveAdvanced As XylosButton
    Friend WithEvents txtSubject As XylosTextBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblAltEmail As Label
    Friend WithEvents XylosSeparator4 As XylosSeparator
    Friend WithEvents txtAltEmail As XylosTextBox
    Friend WithEvents chkAltEmail As XylosCheckBox
    Friend WithEvents lblHost As Label
    Friend WithEvents txtHost As XylosTextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents txtPort As XylosTextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtPass As XylosTextBox
    Friend WithEvents noticeAdvanced As XylosNotice
    Friend WithEvents btnTestEmail As XylosButton
    Friend WithEvents lstPkmn As CheckedListBox
    Friend WithEvents XylosSeparator5 As XylosSeparator
    Friend WithEvents btnStopBot As XylosButton
    Friend WithEvents botTimer As Timer
    Friend WithEvents lstOutput As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents pkmnIdentifier As System.ComponentModel.BackgroundWorker
    Friend WithEvents pkmnPreview As PictureBox
    Friend WithEvents btnDeselect As XylosButton
    Friend WithEvents txtSearch As XylosTextBox
    Friend WithEvents btnSelect As XylosButton
    Friend WithEvents imgCatches As ImageList
    Friend WithEvents chatSpammer As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents pbRecent As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lstRecentCatch As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCatchPerMin As Label
    Friend WithEvents lblLegendRate As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblLegendCaught As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblAvgTime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblElapsed As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSentMsg As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents XylosSeparator7 As XylosSeparator
    Friend WithEvents lblRate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEvo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblLevels As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents XylosSeparator6 As XylosSeparator
    Friend WithEvents lblCaught As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSeen As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMostCaught As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblSpawnRate As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents XylosSeparator9 As XylosSeparator
    Friend WithEvents XylosSeparator8 As XylosSeparator
    Friend WithEvents XylosSeparator10 As XylosSeparator
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents Label21 As Label
    Friend WithEvents cbInfo As XylosCombobox
    Friend WithEvents btnPokemon As XylosButton
    Friend WithEvents Label19 As Label
    Friend WithEvents btnInfo As XylosButton
    Friend WithEvents Label20 As Label
    Friend WithEvents btnSelectLatest As XylosButton
    Friend WithEvents Label18 As Label
    Friend WithEvents cbOrderBy As XylosCombobox
    Friend WithEvents btnOrderBy As XylosButton
    Friend WithEvents XylosSeparator11 As XylosSeparator
    Friend WithEvents Label17 As Label
    Friend WithEvents btnDetailed As XylosButton
    Friend WithEvents Label26 As Label
    Friend WithEvents btnClaimRewards As XylosButton
    Friend WithEvents Label25 As Label
    Friend WithEvents XylosSeparator12 As XylosSeparator
    Friend WithEvents btnBallance As XylosButton
    Friend WithEvents Label22 As Label
    Friend WithEvents btnFavorite As XylosButton
    Friend WithEvents cbPokemon As XylosCombobox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtNickname As XylosTextBox
    Friend WithEvents btnNickname As XylosButton
    Friend WithEvents Label23 As Label
    Friend WithEvents cbPokedex As XylosCombobox
    Friend WithEvents btnPokedex As XylosButton
    Friend WithEvents Label27 As Label
    Friend WithEvents txtChannelName As XylosTextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtChannelName2 As XylosTextBox
    Friend WithEvents XylosSeparator13 As XylosSeparator
    Friend WithEvents Label29 As Label
    Friend WithEvents chkLegendary As XylosCheckBox
    Friend WithEvents cbSelect As XylosCombobox
    Friend WithEvents chkAlolan As XylosCheckBox
    Friend WithEvents chkUltraBeast As XylosCheckBox
    Friend WithEvents chkMythic As XylosCheckBox
    Friend WithEvents lblUBCaught As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblMythicCaught As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents XylosSeparator14 As XylosSeparator
    Friend WithEvents lblUBRate As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblMythicRate As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblGithub As LinkLabel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label38 As Label
    Friend WithEvents XylosSeparator15 As XylosSeparator
    Friend WithEvents Label37 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
End Class
