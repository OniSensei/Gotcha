<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTester
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTester))
        Me.XylosTabControl1 = New Gotcha.XylosTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.cbPkmn = New Gotcha.XylosCombobox()
        Me.btnTest = New Gotcha.XylosButton()
        Me.pbImg = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.XylosTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XylosTabControl1
        '
        Me.XylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.XylosTabControl1.Controls.Add(Me.TabPage1)
        Me.XylosTabControl1.Controls.Add(Me.TabPage2)
        Me.XylosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XylosTabControl1.FirstHeaderBorder = False
        Me.XylosTabControl1.ItemSize = New System.Drawing.Size(40, 180)
        Me.XylosTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XylosTabControl1.Multiline = True
        Me.XylosTabControl1.Name = "XylosTabControl1"
        Me.XylosTabControl1.SelectedIndex = 0
        Me.XylosTabControl1.Size = New System.Drawing.Size(422, 211)
        Me.XylosTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.XylosTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.txtOutput)
        Me.TabPage1.Controls.Add(Me.cbPkmn)
        Me.TabPage1.Controls.Add(Me.btnTest)
        Me.TabPage1.Controls.Add(Me.pbImg)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(234, 203)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "dashboard"
        Me.TabPage1.Text = "Dashboard"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(207, 8)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(19, 20)
        Me.TextBox1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TextBox1, resources.GetString("TextBox1.ToolTip"))
        Me.TextBox1.Visible = False
        '
        'txtOutput
        '
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtOutput.Location = New System.Drawing.Point(6, 62)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(220, 133)
        Me.txtOutput.TabIndex = 4
        Me.txtOutput.Text = ""
        '
        'cbPkmn
        '
        Me.cbPkmn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPkmn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPkmn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPkmn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPkmn.EnabledCalc = True
        Me.cbPkmn.ForeColor = System.Drawing.Color.Black
        Me.cbPkmn.FormattingEnabled = True
        Me.cbPkmn.ItemHeight = 20
        Me.cbPkmn.Items.AddRange(New Object() {"Abomasnow", "Abra", "Absol", "Accelgor", "Aegislash", "Aerodactyl", "Aggron", "Aipom", "Alakazam", "Alolan Diglett", "Alolan Dugtrio", "Alolan Exeggutor", "Alolan Geodude", "Alolan Golem", "Alolan Graveler", "Alolan Grimer", "Alolan Marowak", "Alolan Meowth", "Alolan Muk", "Alolan Ninetales", "Alolan Persian", "Alolan Raichu", "Alolan Raticate", "Alolan Rattata", "Alolan Sandshrew", "Alolan Sandslash", "Alolan Vulpix", "Alomomola", "Altaria", "Amaura", "Ambipom", "Amoonguss", "Ampharos", "Anorith", "Araquanid", "Arbok", "Arcanine", "Arceus", "Archen", "Archeops", "Ariados", "Armaldo", "Aromatisse", "Aron", "Articuno", "Audino", "Aurorus", "Avalugg", "Axew", "Azelf", "Azumarill", "Azurill", "Bagon", "Baltoy", "Banette", "Barbaracle", "Barboach", "Basculin", "Bastiodon", "Bayleef", "Beartic", "Beautifly", "Beedrill", "Beheeyem", "Beldum", "Bellossom", "Bellsprout", "Bergmite", "Bewear", "Bibarel", "Bidoof", "Binacle", "Bisharp", "Blacephalon", "Blastoise", "Blaziken", "Blissey", "Blitzle", "Boldore", "Bonsly", "Bouffalant", "Bounsweet", "Braixen", "Braviary", "Breloom", "Brionne", "Bronzong", "Bronzor", "Bruxish", "Budew", "Buizel", "Bulbasaur", "Buneary", "Bunnelby", "Burmy", "Butterfree", "Buzzwole", "Cacnea", "Cacturne", "Camerupt", "Carbink", "Carnivine", "Carracosta", "Carvanha", "Cascoon", "Castform", "Caterpie", "Celebi", "Celesteela", "Chandelure", "Chansey", "Charizard", "Charjabug", "Charmander", "Charmeleon", "Chatot", "Cherrim", "Cherubi", "Chesnaught", "Chespin", "Chikorita", "Chimchar", "Chimecho", "Chinchou", "Chingling", "Cinccino", "Clamperl", "Clauncher", "Clawitzer", "Claydol", "Clefable", "Clefairy", "Cleffa", "Cloyster", "Cobalion", "Cofagrigus", "Combee", "Combusken", "Comfey", "Conkeldurr", "Corphish", "Corsola", "Cosmoem", "Cosmog", "Cottonee", "Crabominable", "Crabrawler", "Cradily", "Cranidos", "Crawdaunt", "Cresselia", "Croagunk", "Crobat", "Croconaw", "Crustle", "Cryogonal", "Cubchoo", "Cubone", "Cutiefly", "Cyndaquil", "Darkrai", "Darmanitan", "Dartrix", "Darumaka", "Decidueye", "Dedenne", "Deerling", "Deino", "Delcatty", "Delibird", "Delphox", "Deoxys", "Detective Pikachu", "Dewgong", "Dewott", "Dewpider", "Dhelmise", "Dialga", "Diancie", "Diggersby", "Diglett", "Ditto", "Dodrio", "Doduo", "Donphan", "Doublade", "Dragalge", "Dragonair", "Dragonite", "Drampa", "Drapion", "Dratini", "Drifblim", "Drifloon", "Drilbur", "Drowzee", "Druddigon", "Ducklett", "Dugtrio", "Dunsparce", "Duosion", "Durant", "Dusclops", "Dusknoir", "Duskull", "Dustox", "Dwebble", "Eelektrik", "Eelektross", "Eevee", "Ekans", "Electabuzz", "Electivire", "Electrike", "Electrode", "Elekid", "Elgyem", "Emboar", "Emolga", "Empoleon", "Entei", "Escavalier", "Espeon", "Espurr", "Excadrill", "Exeggcute", "Exeggutor", "Exploud", "Farfetchd", "Fearow", "Feebas", "Fennekin", "Feraligatr", "Ferroseed", "Ferrothorn", "Finneon", "Flaaffy", "Flabebe", "Flareon", "Fletchinder", "Fletchling", "Floatzel", "Floette", "Florges", "Flygon", "Fomantis", "Foongus", "Forretress", "Fraxure", "Frillish", "Froakie", "Frogadier", "Froslass", "Furfrou", "Furret", "Gabite", "Gallade", "Galvantula", "Garbodor", "Garchomp", "Gardevoir", "Gastly", "Gastrodon", "Genesect", "Gengar", "Geodude", "Gible", "Gigalith", "Girafarig", "Giratina", "Glaceon", "Glalie", "Glameow", "Gligar", "Gliscor", "Gloom", "Gogoat", "Golbat", "Goldeen", "Golduck", "Golem", "Golett", "Golisopod", "Golurk", "Goodra", "Goomy", "Gorebyss", "Gothita", "Gothitelle", "Gothorita", "Gourgeist", "Granbull", "Graveler", "Greninja", "Grimer", "Grotle", "Groudon", "Grovyle", "Growlithe", "Grubbin", "Grumpig", "Gulpin", "Gumshoos", "Gurdurr", "Guzzlord", "Gyarados", "Hakamo-o", "Happiny", "Hariyama", "Haunter", "Hawlucha", "Haxorus", "Heatmor", "Heatran", "Heliolisk", "Helioptile", "Heracross", "Herdier", "Hippopotas", "Hippowdon", "Hitmonchan", "Hitmonlee", "Hitmontop", "Ho-Oh", "Honchkrow", "Honedge", "Hoopa", "Hoothoot", "Hoppip", "Horsea", "Houndoom", "Houndour", "Huntail", "Hydreigon", "Hypno", "Igglybuff", "Illumise", "Incineroar", "Infernape", "Inkay", "Ivysaur", "Jangmo-o", "Jellicent", "Jigglypuff", "Jirachi", "Jolteon", "Joltik", "Jumpluff", "Jynx", "Kabuto", "Kabutops", "Kadabra", "Kakuna", "Kangaskhan", "Karrablast", "Kartana", "Kecleon", "Keldeo", "Kingdra", "Kingler", "Kirlia", "Klang", "Klefki", "Klink", "Klinklang", "Koffing", "Komala", "Kommo-o", "Krabby", "Kricketot", "Kricketune", "Krokorok", "Krookodile", "Kyogre", "Kyurem", "Lairon", "Lampent", "Landorus", "Lanturn", "Lapras", "Larvesta", "Larvitar", "Latias", "Latios", "Leafeon", "Leavanny", "Ledian", "Ledyba", "Lickilicky", "Lickitung", "Liepard", "Lileep", "Lilligant", "Lillipup", "Linoone", "Litleo", "Litten", "Litwick", "Lombre", "Lopunny", "Lotad", "Loudred", "Lucario", "Ludicolo", "Lugia", "Lumineon", "Lunala", "Lunatone", "Lurantis", "Luvdisc", "Luxio", "Luxray", "Lycanroc", "Machamp", "Machoke", "Machop", "Magby", "Magcargo", "Magearna", "Magikarp", "Magmar", "Magmortar", "Magnemite", "Magneton", "Magnezone", "Makuhita", "Malamar", "Mamoswine", "Manaphy", "Mandibuzz", "Manectric", "Mankey", "Mantine", "Mantyke", "Maractus", "Mareanie", "Mareep", "Marill", "Marowak", "Marshadow", "Marshtomp", "Masquerain", "Mawile", "Medicham", "Meditite", "Meganium", "Melmetal", "Meloetta", "Meltan", "Meowstic", "Meowth", "Mesprit", "Metagross", "Metang", "Metapod", "Mew", "Mewtwo", "Mienfoo", "Mienshao", "Mightyena", "Milotic", "Miltank", "Mime Jr.", "Mimikyu", "Minccino", "Minior", "Minun", "Misdreavus", "Mismagius", "Moltres", "Monferno", "Morelull", "Mothim", "Mr. Mime", "Mudbray", "Mudkip", "Mudsdale", "Muk", "Munchlax", "Munna", "Murkrow", "Musharna", "Naganadel", "Natu", "Necrozma", "Nidoking", "Nidoqueen", "Nidoran", "Nidoran_m", "Nidorina", "Nidorino", "Nihilego", "Nincada", "Ninetales", "Ninjask", "Noctowl", "Noibat", "Noivern", "Nosepass", "Numel", "Nuzleaf", "Octillery", "Oddish", "Omanyte", "Omastar", "Onix", "Oranguru", "Oricorio", "Oshawott", "Pachirisu", "Palkia", "Palossand", "Palpitoad", "Pancham", "Pangoro", "Panpour", "Pansage", "Pansear", "Paras", "Parasect", "Passimian", "Patrat", "Pawniard", "Pelipper", "Persian", "Petilil", "Phanpy", "Phantump", "Pheromosa", "Phione", "Pichu", "Pidgeot", "Pidgeotto", "Pidgey", "Pidove", "Pignite", "Pikachu", "Pikipek", "Piloswine", "Pineco", "Pinsir", "Piplup", "Plusle", "Poipole", "Politoed", "Poliwag", "Poliwhirl", "Poliwrath", "Ponyta", "Poochyena", "Popplio", "Porygon", "Porygon-Z", "Porygon2", "Primarina", "Primeape", "Prinplup", "Probopass", "Psyduck", "Pumpkaboo", "Pupitar", "Purrloin", "Purugly", "Pyroar", "Pyukumuku", "Quagsire", "Quilava", "Quilladin", "Qwilfish", "Raichu", "Raikou", "Ralts", "Rampardos", "Rapidash", "Raticate", "Rattata", "Rayquaza", "Regice", "Regigigas", "Regirock", "Registeel", "Relicanth", "Remoraid", "Reshiram", "Reuniclus", "Rhydon", "Rhyhorn", "Rhyperior", "Ribombee", "Riolu", "Rockruff", "Roggenrola", "Roselia", "Roserade", "Rotom", "Rowlet", "Rufflet", "Sableye", "Salamence", "Salandit", "Salazzle", "Samurott", "Sandile", "Sandshrew", "Sandslash", "Sandygast", "Sawk", "Sawsbuck", "Scatterbug", "Sceptile", "Scizor", "Scolipede", "Scrafty", "Scraggy", "Scyther", "Seadra", "Seaking", "Sealeo", "Seedot", "Seel", "Seismitoad", "Sentret", "Serperior", "Servine", "Seviper", "Sewaddle", "Sharpedo", "Shaymin", "Shedinja", "Shelgon", "Shellder", "Shellos", "Shelmet", "Shieldon", "Shiftry", "Shiinotic", "Shinx", "Shroomish", "Shuckle", "Shuppet", "Sigilyph", "Silcoon", "Silvally", "Simipour", "Simisage", "Simisear", "Skarmory", "Skiddo", "Skiploom", "Skitty", "Skorupi", "Skrelp", "Skuntank", "Slaking", "Slakoth", "Sliggoo", "Slowbro", "Slowking", "Slowpoke", "Slugma", "Slurpuff", "Smeargle", "Smoochum", "Sneasel", "Snivy", "Snorlax", "Snorunt", "Snover", "Snubbull", "Solgaleo", "Solosis", "Solrock", "Spearow", "Spewpa", "Spheal", "Spinarak", "Spinda", "Spiritomb", "Spoink", "Spritzee", "Squirtle", "Stakataka", "Stantler", "Staraptor", "Staravia", "Starly", "Starmie", "Staryu", "Steelix", "Steenee", "Stoutland", "Stufful", "Stunfisk", "Stunky", "Sudowoodo", "Suicune", "Sunflora", "Sunkern", "Surskit", "Swablu", "Swadloon", "Swalot", "Swampert", "Swanna", "Swellow", "Swinub", "Swirlix", "Swoobat", "Sylveon", "Taillow", "Talonflame", "Tangela", "Tangrowth", "Tapu Bulu", "Tapu Fini", "Tapu Koko", "Tapu Lele", "Tauros", "Teddiursa", "Tentacool", "Tentacruel", "Tepig", "Terrakion", "Throh", "Thundurus", "Timburr", "Tirtouga", "Togedemaru", "Togekiss", "Togepi", "Togetic", "Torchic", "Torkoal", "Tornadus", "Torracat", "Torterra", "Totodile", "Toucannon", "Toxapex", "Toxicroak", "Tranquill", "Trapinch", "Treecko", "Trevenant", "Tropius", "Trubbish", "Trumbeak", "Tsareena", "Turtonator", "Turtwig", "Tympole", "Tynamo", "Type: Null", "Typhlosion", "Tyranitar", "Tyrantrum", "Tyrogue", "Tyrunt", "Umbreon", "Unfezant", "Unown", "Ursaring", "Uxie", "Vanillish", "Vanillite", "Vanilluxe", "Vaporeon", "Venipede", "Venomoth", "Venonat", "Venusaur", "Vespiquen", "Vibrava", "Victini", "Victreebel", "Vigoroth", "Vikavolt", "Vileplume", "Virizion", "Vivillon", "Volbeat", "Volcanion", "Volcarona", "Voltorb", "Vullaby", "Vulpix", "Wailmer", "Wailord", "Walrein", "Wartortle", "Watchog", "Weavile", "Weedle", "Weepinbell", "Weezing", "Whimsicott", "Whirlipede", "Whiscash", "Whismur", "Wigglytuff", "Wimpod", "Wingull", "Wishiwashi", "Wobbuffet", "Woobat", "Wooper", "Wormadam", "Wurmple", "Wynaut", "Xatu", "Xerneas", "Xurkitree", "Yamask", "Yanma", "Yanmega", "Yungoos", "Yveltal", "Zangoose", "Zapdos", "Zebstrika", "Zekrom", "Zeraora", "Zigzagoon", "Zoroark", "Zorua", "Zubat", "Zweilous", "Zygarde"})
        Me.cbPkmn.Location = New System.Drawing.Point(62, 30)
        Me.cbPkmn.Name = "cbPkmn"
        Me.cbPkmn.Size = New System.Drawing.Size(121, 26)
        Me.cbPkmn.TabIndex = 3
        '
        'btnTest
        '
        Me.btnTest.EnabledCalc = True
        Me.btnTest.Location = New System.Drawing.Point(62, 6)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 21)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test"
        Me.ToolTip1.SetToolTip(Me.btnTest, resources.GetString("btnTest.ToolTip"))
        '
        'pbImg
        '
        Me.pbImg.Image = Global.Gotcha.My.Resources.Resources.iconfinder_Invisible_728947
        Me.pbImg.Location = New System.Drawing.Point(6, 6)
        Me.pbImg.Name = "pbImg"
        Me.pbImg.Size = New System.Drawing.Size(50, 50)
        Me.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImg.TabIndex = 0
        Me.pbImg.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(234, 203)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tester"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "About image tester"
        '
        'frmTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 211)
        Me.Controls.Add(Me.XylosTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTester"
        Me.Text = "Gotcha! - Image Tester"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.XylosTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XylosTabControl1 As XylosTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnTest As XylosButton
    Friend WithEvents pbImg As PictureBox
    Friend WithEvents cbPkmn As XylosCombobox
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox1 As TextBox
End Class
