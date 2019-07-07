Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Mail

'  __  __       _       
' |  \/  |     (_)      
' | \  / | __ _ _ _ __  
' | |\/| |/ _` | | '_ \ 
' | |  | | (_| | | | | |
' |_|  |_|\__,_|_|_| |_|

Public Class frmMain
    ' Variabls
    Dim path As String = Application.StartupPath
    Dim intC As Integer = My.Settings.intervalc
    Dim random As Boolean = My.Settings.random
    Dim imgPath As String = My.Settings.imgDirectory
    Dim intDelay As Integer = My.Settings.catchDelay
    Dim lc As Integer = 0
    Dim ec As Integer = 0
    Public levelSeen As Boolean = False
    Dim evoSeen As Boolean = False
    Dim caught As Boolean = False
    Public startTime As Date
    Dim endTime As Date
    Dim botRunning As Boolean = False
    Dim StopWatch As New Diagnostics.Stopwatch
    Dim catchTimes As New List(Of Integer)
    Dim tSize As Integer
    Dim pokemon() As String = {"bulbasaur", "ivysaur", "venusaur", "charmander", "charmeleon", "charizard", "squirtle", "wartortle", "blastoise", "caterpie", "metapod", "butterfree", "weedle", "kakuna", "beedrill", "pidgey", "pidgeotto", "pidgeot", "rattata", "raticate", "spearow", "fearow", "ekans", "arbok", "pikachu", "raichu", "sandshrew", "sandslash", "nidoran-f", "nidorina", "nidoqueen", "nidoran-m", "nidorino", "nidoking", "clefairy", "clefable", "vulpix", "ninetales", "jigglypuff", "wigglytuff", "zubat", "golbat", "oddish", "gloom", "vileplume", "paras", "parasect", "venonat", "venomoth", "diglett", "dugtrio", "meowth", "persian", "psyduck", "golduck", "mankey", "primeape", "growlithe", "arcanine", "poliwag", "poliwhirl", "poliwrath", "abra", "kadabra", "alakazam", "machop", "machoke", "machamp", "bellsprout", "weepinbell", "victreebel", "tentacool", "tentacruel", "geodude", "graveler", "golem", "ponyta", "rapidash", "slowpoke", "slowbro", "magnemite", "magneton", "farfetchd", "doduo", "dodrio", "seel", "dewgong", "grimer", "muk", "shellder", "cloyster", "gastly", "haunter", "gengar", "onix", "drowzee", "hypno", "krabby", "kingler", "voltorb", "electrode", "exeggcute", "exeggutor", "cubone", "marowak", "hitmonlee", "hitmonchan", "lickitung", "koffing", "weezing", "rhyhorn", "rhydon", "chansey", "tangela", "kangaskhan", "horsea", "seadra", "goldeen", "seaking", "staryu", "starmie", "mr-mime", "scyther", "jynx", "electabuzz", "magmar", "pinsir", "tauros", "magikarp", "gyarados", "lapras", "ditto", "eevee", "vaporeon", "jolteon", "flareon", "porygon", "omanyte", "omastar", "kabuto", "kabutops", "aerodactyl", "snorlax", "articuno", "zapdos", "moltres", "dratini", "dragonair", "dragonite", "mewtwo", "mew", "chikorita", "bayleef", "meganium", "cyndaquil", "quilava", "typhlosion", "totodile", "croconaw", "feraligatr", "sentret", "furret", "hoothoot", "noctowl", "ledyba", "ledian", "spinarak", "ariados", "crobat", "chinchou", "lanturn", "pichu", "cleffa", "igglybuff", "togepi", "togetic", "natu", "xatu", "mareep", "flaaffy", "ampharos", "bellossom", "marill", "azumarill", "sudowoodo", "politoed", "hoppip", "skiploom", "jumpluff", "aipom", "sunkern", "sunflora", "yanma", "wooper", "quagsire", "espeon", "umbreon", "murkrow", "slowking", "misdreavus", "unown", "wobbuffet", "girafarig", "pineco", "forretress", "dunsparce", "gligar", "steelix", "snubbull", "granbull", "qwilfish", "scizor", "shuckle", "heracross", "sneasel", "teddiursa", "ursaring", "slugma", "magcargo", "swinub", "piloswine", "corsola", "remoraid", "octillery", "delibird", "mantine", "skarmory", "houndour", "houndoom", "kingdra", "phanpy", "donphan", "porygon2", "stantler", "smeargle", "tyrogue", "hitmontop", "smoochum", "elekid", "magby", "miltank", "blissey", "raikou", "entei", "suicune", "larvitar", "pupitar", "tyranitar", "lugia", "ho-oh", "celebi", "treecko", "grovyle", "sceptile", "torchic", "combusken", "blaziken", "mudkip", "marshtomp", "swampert", "poochyena", "mightyena", "zigzagoon", "linoone", "wurmple", "silcoon", "beautifly", "cascoon", "dustox", "lotad", "lombre", "ludicolo", "seedot", "nuzleaf", "shiftry", "taillow", "swellow", "wingull", "pelipper", "ralts", "kirlia", "gardevoir", "surskit", "masquerain", "shroomish", "breloom", "slakoth", "vigoroth", "slaking", "nincada", "ninjask", "shedinja", "whismur", "loudred", "exploud", "makuhita", "hariyama", "azurill", "nosepass", "skitty", "delcatty", "sableye", "mawile", "aron", "lairon", "aggron", "meditite", "medicham", "electrike", "manectric", "plusle", "minun", "volbeat", "illumise", "roselia", "gulpin", "swalot", "carvanha", "sharpedo", "wailmer", "wailord", "numel", "camerupt", "torkoal", "spoink", "grumpig", "spinda", "trapinch", "vibrava", "flygon", "cacnea", "cacturne", "swablu", "altaria", "zangoose", "seviper", "lunatone", "solrock", "barboach", "whiscash", "corphish", "crawdaunt", "baltoy", "claydol", "lileep", "cradily", "anorith", "armaldo", "feebas", "milotic", "castform", "kecleon", "shuppet", "banette", "duskull", "dusclops", "tropius", "chimecho", "absol", "wynaut", "snorunt", "glalie", "spheal", "sealeo", "walrein", "clamperl", "huntail", "gorebyss", "relicanth", "luvdisc", "bagon", "shelgon", "salamence", "beldum", "metang", "metagross", "regirock", "regice", "registeel", "latias", "latios", "kyogre", "groudon", "rayquaza", "jirachi", "deoxys", "turtwig", "grotle", "torterra", "chimchar", "monferno", "infernape", "piplup", "prinplup", "empoleon", "starly", "staravia", "staraptor", "bidoof", "bibarel", "kricketot", "kricketune", "shinx", "luxio", "luxray", "budew", "roserade", "cranidos", "rampardos", "shieldon", "bastiodon", "burmy", "wormadam", "mothim", "combee", "vespiquen", "pachirisu", "buizel", "floatzel", "cherubi", "cherrim", "shellos", "gastrodon", "ambipom", "drifloon", "drifblim", "buneary", "lopunny", "mismagius", "honchkrow", "glameow", "purugly", "chingling", "stunky", "skuntank", "bronzor", "bronzong", "bonsly", "mime-jr", "happiny", "chatot", "spiritomb", "gible", "gabite", "garchomp", "munchlax", "riolu", "lucario", "hippopotas", "hippowdon", "skorupi", "drapion", "croagunk", "toxicroak", "carnivine", "finneon", "lumineon", "mantyke", "snover", "abomasnow", "weavile", "magnezone", "lickilicky", "rhyperior", "tangrowth", "electivire", "magmortar", "togekiss", "yanmega", "leafeon", "glaceon", "gliscor", "mamoswine", "porygon-z", "gallade", "probopass", "dusknoir", "froslass", "rotom", "uxie", "mesprit", "azelf", "dialga", "palkia", "heatran", "regigigas", "giratina", "cresselia", "phione", "manaphy", "darkrai", "shaymin", "arceus", "victini", "snivy", "servine", "serperior", "tepig", "pignite", "emboar", "oshawott", "dewott", "samurott", "patrat", "watchog", "lillipup", "herdier", "stoutland", "purrloin", "liepard", "pansage", "simisage", "pansear", "simisear", "panpour", "simipour", "munna", "musharna", "pidove", "tranquill", "unfezant", "blitzle", "zebstrika", "roggenrola", "boldore", "gigalith", "woobat", "swoobat", "drilbur", "excadrill", "audino", "timburr", "gurdurr", "conkeldurr", "tympole", "palpitoad", "seismitoad", "throh", "sawk", "sewaddle", "swadloon", "leavanny", "venipede", "whirlipede", "scolipede", "cottonee", "whimsicott", "petilil", "lilligant", "basculin", "sandile", "krokorok", "krookodile", "darumaka", "darmanitan", "maractus", "dwebble", "crustle", "scraggy", "scrafty", "sigilyph", "yamask", "cofagrigus", "tirtouga", "carracosta", "archen", "archeops", "trubbish", "garbodor", "zorua", "zoroark", "minccino", "cinccino", "gothita", "gothorita", "gothitelle", "solosis", "duosion", "reuniclus", "ducklett", "swanna", "vanillite", "vanillish", "vanilluxe", "deerling", "sawsbuck", "emolga", "karrablast", "escavalier", "foongus", "amoonguss", "frillish", "jellicent", "alomomola", "joltik", "galvantula", "ferroseed", "ferrothorn", "klink", "klang", "klinklang", "tynamo", "eelektrik", "eelektross", "elgyem", "beheeyem", "litwick", "lampent", "chandelure", "axew", "fraxure", "haxorus", "cubchoo", "beartic", "cryogonal", "shelmet", "accelgor", "stunfisk", "mienfoo", "mienshao", "druddigon", "golett", "golurk", "pawniard", "bisharp", "bouffalant", "rufflet", "braviary", "vullaby", "mandibuzz", "heatmor", "durant", "deino", "zweilous", "hydreigon", "larvesta", "volcarona", "cobalion", "terrakion", "virizion", "tornadus", "thundurus", "reshiram", "zekrom", "landorus", "kyurem", "keldeo", "meloetta", "genesect", "chespin", "quilladin", "chesnaught", "fennekin", "braixen", "delphox", "froakie", "frogadier", "greninja", "bunnelby", "diggersby", "fletchling", "fletchinder", "talonflame", "scatterbug", "spewpa", "vivillon", "litleo", "pyroar", "flabebe", "floette", "florges", "skiddo", "gogoat", "pancham", "pangoro", "furfrou", "espurr", "meowstic", "honedge", "doublade", "aegislash", "spritzee", "aromatisse", "swirlix", "slurpuff", "inkay", "malamar", "binacle", "barbaracle", "skrelp", "dragalge", "clauncher", "clawitzer", "helioptile", "heliolisk", "tyrunt", "tyrantrum", "amaura", "aurorus", "sylveon", "hawlucha", "dedenne", "carbink", "goomy", "sliggoo", "goodra", "klefki", "phantump", "trevenant", "pumpkaboo", "gourgeist", "bergmite", "avalugg", "noibat", "noivern", "xerneas", "yveltal", "zygarde", "diancie", "hoopa", "volcanion", "rowlet", "dartrix", "decidueye", "litten", "torracat", "incineroar", "popplio", "brionne", "primarina", "pikipek", "trumbeak", "toucannon", "yungoos", "gumshoos", "grubbin", "charjabug", "vikavolt", "crabrawler", "crabominable", "oricorio", "cutiefly", "ribombee", "rockruff", "lycanroc", "wishiwashi", "mareanie", "toxapex", "mudbray", "mudsdale", "dewpider", "araquanid", "fomantis", "lurantis", "morelull", "shiinotic", "salandit", "salazzle", "stufful", "bewear", "bounsweet", "steenee", "tsareena", "comfey", "oranguru", "passimian", "wimpod", "golisopod", "sandygast", "palossand", "pyukumuku", "type-null", "silvally", "minior", "komala", "turtonator", "togedemaru", "mimikyu", "bruxish", "drampa", "dhelmise", "jangmo-o", "hakamo-o", "kommo-o", "tapu-koko", "tapu-lele", "tapu-bulu", "tapu-fini", "cosmog", "cosmoem", "solgaleo", "lunala", "nihilego", "buzzwole", "pheromosa", "xurkitree", "celesteela", "kartana", "guzzlord", "necrozma", "magearna", "marshadow"}
    Dim mythics() As String = {"Arceus", "Darkrai", "Deoxys", "Celebi", "Shaymin", "Mew", "Jerachi", "Hoopa", "Victini", "Phione", "Magearna", "Volcanion", "Diancie", "Genesect", "Keldeo", "Meloetta", "Manaphy", "Magearna", "Marshadow", "Zeraora", "Meltan", "Melmetal"}
    Dim alolans() As String = {"Alolan Rattata", "Alolan Raticate", " Alolan Raichu", "Alolan Sandshrew", "Alolan Sandslash", "Alolan Vulpix", " Alolan Ninetales", "Alolan Diglett", "Alolan Dugtrio", "Alolan Meowth", "Alolan Persian", "Alolan Geodude", "Alolan Graveler", "Alolan Golem", "Alolan Grimer", "Alolan Muk", "Alolan Exeggutor", "Alolan Marowak"}
    Dim ultrabeasts() As String = {"Nihilego", "Buzzwole", "Pheromosa", "Xurkitree", "Celesteela", "Kartana", "Guzzlord", "Poipole", "Naganadel", "Stakataka", "Blacephalon"}
    Dim legends() As String = {"Articuno", "Zapdos", "Moltres", "Mewtwo", "Raikou", "Entei", "Suicune", "Ho-Oh", "Lugia", "Regirock", "Regice", "Registeel", "Regigigas", "Latios", "Latias", "Kyogre", "Groudon", "Rayquaza", "Dialga", "Palkia", "Heatran", "Giratina", "Cresselia", "Uxie", "Azelf", "Cobalion", "Terrakion", "Virizion", "Tornadus", "Thundrus", "Reshiram", "Zekrom", "Landorus", "Kyurem", "Xeneas", "Yveltal", "Zygarde", "Type: Null", "Silvally", "Cosmog", "Cosmoem", "Solgaleo", "Lunala", "Necrozma"}
    Dim listLegends As List(Of String) = New List(Of String)(legends)
    Dim topcount As Integer = 0
    Dim channel1 As String = My.Settings.channel1
    Dim channel2 As String = My.Settings.channel2

    ' Clear list
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstChatSpam.Items.Clear()

        ' Logs
        noticeUpdater("basic", "[INFO] Cleared the spam list...")
        appendLogs(DateTime.Now, "[INFO] Cleared the spam list...")
    End Sub

    ' Form load
    Private Async Sub frmMain_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load pokemon
        If File.Exists(path & "\pkmn.txt") Then
            Dim pokes() As String = File.ReadAllLines(path & "\pkmn.txt")
            lstPkmn.Items.Clear()
            lstPkmn.Items.AddRange(pokes)
        End If

        ' Set combo  boxes
        cbPokedex.SelectedIndex = 0
        cbPokemon.SelectedIndex = 0
        cbInfo.SelectedIndex = 0
        cbSelect.SelectedIndex = 0

        ' Background worker enable cancelation and progress reports
        pkmnIdentifier.WorkerSupportsCancellation = True
        pkmnIdentifier.WorkerReportsProgress = True

        ' Select all in checked listbox of pokemon as default
        For i As Integer = 0 To lstPkmn.Items.Count - 1
            lstPkmn.SetItemChecked(i, True)
        Next

        ' Resize output log columns
        lstOutput.Columns(0).Width = lstOutput.Width / 4
        lstOutput.Columns(1).Width = lstOutput.Width / 2 + 120

        ' Set tab index to show home
        mainTab.SelectedIndex = 1

        ' Hotkey check enabled
        Me.KeyPreview = True

        ' Stats updater
        statsTimer.Start()

        ' Load spam chat file if saved before
        Try
            If My.Computer.FileSystem.FileExists(path & "\spamchat.txt") = True Then
                Dim xRead As StreamReader
                xRead = File.OpenText(path & "\spamchat.txt")
                Do Until xRead.EndOfStream
                    lstChatSpam.Items.Add(xRead.ReadLine())
                Loop

                ' close reader
                xRead.Dispose()

                ' Logs
                noticeUpdater("basic", "[INFO] Loaded spam chat settings...")
                appendLogs(DateTime.Now, "[INFO] Loaded " & path & "\spamchat.txt")
            End If

            ' Load basic settings
            If random = True Then chkbRandom.Checked = True
            cbInterval.Text = intC

            ' Log
            noticeUpdater("basic", "[INFO] Loaded basic settings...")
            appendLogs(DateTime.Now, "[INFO] Basic settings loaded successfully...")

            ' Begin loading advanced settings
            imgPath = My.Settings.imgDirectory

            txtImgDirectory.Text = imgPath
            txtCatchDelay.Text = My.Settings.catchDelay

            txtEmail.Text = My.Settings.email
            txtAltEmail.Text = My.Settings.altEmail
            txtPass.Text = My.Settings.pass
            txtPort.Text = My.Settings.port
            txtHost.Text = My.Settings.smtp
            txtSubject.Text = My.Settings.subject
            cbEmail.Text = "@gmail.com"
            txtChannelName.Text = My.Settings.channel1
            txtChannelName2.Text = My.Settings.channel2

            If My.Settings.altBool = True Then
                chkAltEmail.Checked = True
            Else
                chkAltEmail.Checked = False
            End If

            If My.Settings.legendary = True Then
                chkLegendary.Checked = True
            Else
                chkLegendary.Checked = False
            End If
            If My.Settings.mythic = True Then
                chkMythic.Checked = True
            Else
                chkMythic.Checked = False
            End If
            If My.Settings.ultrabeast = True Then
                chkUltraBeast.Checked = True
            Else
                chkUltraBeast.Checked = False
            End If
            If My.Settings.alolan = True Then
                chkAlolan.Checked = True
            Else
                chkAlolan.Checked = False
            End If

            ' Log
            noticeUpdater("advanced", "[INFO] Loaded advanced settings...")
            appendLogs(DateTime.Now, "[INFO] Advanced settings loaded successfully...")
        Catch ex As Exception
            ' Log error
            appendLogs(DateTime.Now, "[ERROR] Couldn't load settings...")
            appendLogs(DateTime.Now, ex.ToString)
        End Try
    End Sub

    ' Log in dev logs
    Public Sub appendLogs(ByVal datetime As String, ByVal msg As String)
        Dim newItem As New ListViewItem(datetime)
        newItem.SubItems.Add(msg)

        lstLogs.Items.Add(newItem)
    End Sub

    ' Add item to spam list
    Private Sub btnAddString_Click(sender As Object, e As EventArgs) Handles btnAddString.Click
        If txtAddString.Text <> "" Then
            lstChatSpam.Items.Add(txtAddString.Text)
            lstChatSpam.SelectedIndex = lstChatSpam.Items.Count - 1
            txtAddString.Text = ""

            ' Log
            noticeUpdater("basic", "[INFO] Item added to list...")
            appendLogs(DateTime.Now, "[INFO] Added " & txtAddString.Text & " to spam list...")
        Else
            ' Log
            noticeUpdater("basic", "[ERROR] Text can NOT be blank...")
            appendLogs(DateTime.Now, "[ERROR] Attempted to add blank text to spam list...")
        End If
    End Sub

    ' Remove item from spam list
    Private Sub btnRemoveString_Click(sender As Object, e As EventArgs) Handles btnRemoveString.Click
        ' Remove item from Spam List
        lstChatSpam.Items.RemoveAt(lstChatSpam.SelectedIndex)

        ' Log first to get index
        noticeUpdater("basic", "[INFO] Removed item from list...")
        appendLogs(DateTime.Now, "[INFO] Removed item #" & lstChatSpam.SelectedIndex & " from spam list...")
    End Sub

    ' Save basic settings
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save spam chat first
        If My.Computer.FileSystem.FileExists(path & "\spamchat.txt") Then
            ' Delete if exists
            My.Computer.FileSystem.DeleteFile(path & "\spamchat.txt")

            ' Log deletion
            noticeUpdater("basic", "[INFO] Deleted old spamchat.txt...")
            appendLogs(DateTime.Now, "[INFO] Deleted " & path & "\spamchat.txt")
        End If

        Try
            Dim i As Integer
            Dim s As New IO.StreamWriter(path & "\spamchat.txt")

            For i = 0 To lstChatSpam.Items.Count - 1
                s.WriteLine(lstChatSpam.Items.Item(i))
            Next

            ' Log spamchat saved
            noticeUpdater("basic", "[INFO] Saved new spamchat.txt...")
            appendLogs(DateTime.Now, "[INFO] Saved " & path & "\spamchat.txt")

            ' Close writer
            s.Dispose()

            ' Save settings
            My.Settings.intervalc = cbInterval.Text
            If chkbRandom.Checked = True Then
                My.Settings.random = True
            Else
                My.Settings.random = False
            End If

            My.Settings.Save()

            ' Set variable
            intC = My.Settings.intervalc
            random = My.Settings.random

            ' Log settings saved
            noticeUpdater("basic", "[INFO] Basic settings saved successfully...")
            appendLogs(DateTime.Now, "[INFO] Basic settings saved successfully...")
        Catch ex As Exception
            ' Logs
            noticeUpdater("basic", ex.ToString)
            appendLogs(DateTime.Now, ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' File dialog
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' Change img directory
        If fldDialog.ShowDialog() = DialogResult.OK Then
            txtImgDirectory.Text = fldDialog.SelectedPath
            My.Settings.imgDirectory = fldDialog.SelectedPath
            My.Settings.Save()

            ' Logs
            noticeUpdater("advanced", "[INFO] Image directory successfully changed...")
            appendLogs(DateTime.Now, "[INFO] Updated img directory to: " & My.Settings.imgDirectory)
        End If
    End Sub

    ' Advanced settings
    Private Sub btnSaveAdvanced_Click(sender As Object, e As EventArgs) Handles btnSaveAdvanced.Click
        ' Set settings
        My.Settings.catchDelay = txtCatchDelay.Text
        My.Settings.imgDirectory = txtImgDirectory.Text
        My.Settings.email = txtEmail.Text
        My.Settings.pass = txtPass.Text
        My.Settings.altEmail = txtAltEmail.Text
        My.Settings.port = txtPort.Text
        My.Settings.smtp = txtHost.Text
        My.Settings.subject = txtSubject.Text
        My.Settings.provider = cbEmail.Text
        My.Settings.channel1 = txtChannelName.Text
        My.Settings.channel2 = txtChannelName2.Text
        If chkAltEmail.Checked = True Then
            My.Settings.altBool = True
        Else
            My.Settings.altBool = False
        End If
        If chkLegendary.Checked = True Then
            My.Settings.legendary = True
        Else
            My.Settings.legendary = False
        End If
        If chkMythic.Checked = True Then
            My.Settings.mythic = True
        Else
            My.Settings.mythic = False
        End If
        If chkUltraBeast.Checked = True Then
            My.Settings.ultrabeast = True
        Else
            My.Settings.ultrabeast = False
        End If
        If chkAlolan.Checked = True Then
            My.Settings.alolan = True
        Else
            My.Settings.alolan = False
        End If

        ' Save settings
        My.Settings.Save()
        channel1 = txtChannelName.Text
        channel2 = txtChannelName2.Text

        ' Logs
        noticeUpdater("advanced", "[INFO] Advanced settings saved successfully...")
        appendLogs(DateTime.Now, "[INFO] Advanced settings saved successfully...")
    End Sub

    ' Test email
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTestEmail.Click
        Try
            ' Save email settings first
            My.Settings.email = txtEmail.Text
            My.Settings.provider = cbEmail.Text
            My.Settings.port = txtPort.Text
            My.Settings.smtp = txtHost.Text
            If chkAltEmail.Checked = True Then
                My.Settings.altBool = True
                My.Settings.altEmail = txtAltEmail.Text
            End If
            My.Settings.Save()


            ' Sending test email
            sendEmail("Gotcha! - Email settings test", "This is just a test.")

            ' Logs
            noticeUpdater("advanced", "[INFO] Email sent successfully...")
        Catch ex As Exception
            noticeUpdater("advanced", "[ERROR] Couldn't send email, check settings...")
        End Try
    End Sub

    ' Random number generator
    Dim old As Integer = 6572
    Public Function Rand(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim random As New Random(old + Date.Now.Millisecond)
        old = random.Next(min, max + CInt(IIf(Date.Now.Millisecond Mod 2 = 0, 1, 0)))
        Return old
    End Function

    ' Start bot
    Private Sub btnStartBot_Click(sender As Object, e As EventArgs) Handles btnStartBot.Click
        Try
            botRunning = True
            StopWatch.Start()

            botTimer.Interval = cbInterval.Text
            botTimer.Start()

            noticeUpdater("home", "[INFO] Bot started...")
            appendLogs(DateTime.Now, "[INFO] Bot started...")
            appendOutput(DateTime.Now, "[INFO] Bot started...")
        Catch ex As Exception
            appendOutput(DateTime.Now, "[ERROR] Couldn't start bot...")
            noticeUpdater("home", "[ERROR] Couldn't start bot...")
            appendLogs(DateTime.Now, ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Stop bot
    Private Sub btnStop_Click_1(sender As Object, e As EventArgs) Handles btnStopBot.Click
        Try
            botTimer.Stop()
            StopWatch.Stop()

            If pkmnIdentifier.IsBusy Then
                appendOutput(DateTime.Now, "[INFO] Closing background worker, please wait...")
                noticeUpdater("home", "[INFO] Closing background worker, please wait...")
                pkmnIdentifier.CancelAsync()
            End If

            chatSpammer.CancelAsync()

            appendOutput(DateTime.Now, "[INFO] Bot stopped...")
            noticeUpdater("home", "[INFO] Bot stopped...")
            appendLogs(DateTime.Now, "[INFO] Bot stopped...")
        Catch ex As Exception
            appendOutput(DateTime.Now, "[ERROR] Couldn't stop bot...")
            noticeUpdater("home", "[ERROR] Couldn't stop bot...")
            appendLogs(DateTime.Now, ex.ToString)
        End Try
    End Sub

    ' Log output
    Public Sub appendOutput(ByVal datetime As String, ByVal msg As String)
        Dim newItem As New ListViewItem(datetime)
        newItem.SubItems.Add(msg)

        lstOutput.Items.Add(newItem)
    End Sub

    ' Select item from list and spam it
    Public Sub SpamChat()
        FindDiscord(channel1)
        If chatSpammer.IsBusy = False Then
            chatSpammer.RunWorkerAsync()
        End If

        lblSentMsg.Text = lblSentMsg.Text + 1

        FindEncounter()
        FindLevel()
    End Sub

    ' Bot timer
    Private Sub botTimer_Tick(sender As Object, e As EventArgs) Handles botTimer.Tick
        SpamChat()
    End Sub

    ' Set focus window
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As IntPtr

    Private Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As IntPtr) As Long

    ' Find discord
    Public Sub FindDiscord(ByVal channel As String)
        Dim nWnd As IntPtr
        Dim ceroIntPtr As New IntPtr(0)
        Dim Wnd_name As String

        Wnd_name = "#" & channel & " - Discord"
        nWnd = FindWindow(Nothing, Wnd_name)

        SetForegroundWindow(nWnd)
    End Sub

    ' Capture screen
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
            ' Logs
            appendLogs(DateTime.Now, "[ERROR] Couldn't capture desktop screen...")
            appendLogs(DateTime.Now, ex.ToString)
        End Try
    End Function

    ' Find encounter
    Public Sub FindEncounter()
        ' Get screen
        CaptureScreen()
        Try
            Dim img1 As Bitmap
            Dim img2 As Bitmap
            Dim scImage As Image = CaptureScreen()
            Dim chkImage As Image = Image.FromFile(path & "\Pokecord.png")
            img1 = New Bitmap(scImage)
            img2 = New Bitmap(chkImage)

            Dim p As Point = img1.Contains(img2)

            If p <> Nothing Then
                Try
                    ' Log encounter time
                    startTime = DateTime.Now

                    ' Log
                    noticeUpdater("home", "[ENCOUNTER] Attempting identification...")
                    appendOutput(DateTime.Now, "[ENCOUNTER] Attempting identification...")
                    appendLogs(DateTime.Now, "[INFO] Encounter found...")

                    ' Update stats
                    lblSeen.Text = lblSeen.Text + 1

                    ' Pause spam
                    botTimer.Stop()

                    ' Identify pokemon
                    pkmnIdentifier.RunWorkerAsync()

                Catch ex As Exception
                    noticeUpdater("home", "[ENCOUNTER] Attempting identification...")
                    appendOutput(DateTime.Now, "[ERROR] Couldn't start pokemon identification")
                    appendLogs(DateTime.Now, ex.ToString)
                    botTimer.Stop()
                End Try
            End If
        Catch ex As Exception
            noticeUpdater("home", "[ENCOUNTER] Attempting identification...")
            appendOutput(DateTime.Now, "[ERROR] Couldn't capture and compare images...")
            appendLogs(DateTime.Now, ex.ToString)
            botTimer.Stop()
        End Try
    End Sub

    ' Find levelup
    Public Sub FindLevel()
        CaptureScreen()
        If levelSeen = False Then
            Try
                Dim img1 As Bitmap
                Dim img2 As Bitmap
                Dim scImage As Image = CaptureScreen()
                Dim chkImage As Image = Image.FromFile(path & "\levelup.png")
                img1 = New Bitmap(scImage)
                img2 = New Bitmap(chkImage)

                Dim p As Point = img1.Contains(img2)

                If p <> Nothing Then
                    ' Toggle boolean
                    levelSeen = True

                    ' Stats
                    lblLevels.Text = lblLevels.Text + 1

                    ' Logs
                    noticeUpdater("home", "[LEVEL] Your Pokemon leveled up! You've gained " & lblLevels.Text & " level(s)...")
                    appendOutput(DateTime.Now, "[LEVEL] Your Pokemon leveled up! You've gained " & lblLevels.Text & " level(s)...")
                    appendLogs(DateTime.Now, "[INFO] Level up detected...")
                Else
                    ' Find evolution if no level up
                    FindEvo()
                End If
            Catch ex As Exception
                noticeUpdater("home", "[ERROR] Couldn't capture and compare images...")
                appendOutput(DateTime.Now, "[ERROR] Couldn't capture and compare images...")
                appendLogs(DateTime.Now, ex.ToString)
            End Try
        Else
            If lc < 20 Then
                lc = lc + 1
            Else
                levelSeen = False
                lc = 0
            End If
        End If
    End Sub

    ' Find  evolution
    Public Sub FindEvo()
        CaptureScreen()
        If evoSeen = False Then
            Try
                Dim img1 As Bitmap
                Dim img2 As Bitmap
                Dim scImage As Image = CaptureScreen()
                Dim chkImage As Image = Image.FromFile(path & "\evolution.png")
                img1 = New Bitmap(scImage)
                img2 = New Bitmap(chkImage)

                Dim p As Point = img1.Contains(img2)

                If p <> Nothing Then
                    ' Toggle boolean
                    evoSeen = True

                    ' Stats
                    lblLevels.Text = lblLevels.Text + 1
                    lblEvo.Text = lblEvo.Text + 1

                    'Logs
                    noticeUpdater("home", "[LEVEL] Your Pokemon evolved! You've gained " & lblEvo.Text & " evolutions & " & lblLevels.Text & " level(s)...")
                    appendOutput(DateTime.Now, "[LEVEL] Your Pokemon evolved! You've gained " & lblEvo.Text & " evolutions & " & lblLevels.Text & " level(s)...")
                    appendLogs(DateTime.Now, "[INFO] Evolution detected...")
                End If
            Catch ex As Exception
                noticeUpdater("home", "[ERROR] Couldn't capture and compare images..")
                appendOutput(DateTime.Now, "[ERROR] Couldn't capture and compare images..")
                appendLogs(DateTime.Now, ex.ToString)
            End Try
        Else
            If ec < 20 Then
                ec = lc + 1
            Else
                evoSeen = False
                ec = 0
            End If
        End If
    End Sub

    ' Pokemon identifier
    Dim pkmn As String = "Bulbasaur"
    Dim checking As Boolean = False
    Private Sub pkmnIdentifier_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles pkmnIdentifier.DoWork
        ' Find pokemon
        CaptureScreen()

        checking = True
        Try
            For i = 0 To (lstPkmn.Items.Count - 1)
                Dim img1 As Bitmap
                Dim img2 As Bitmap
                Dim scImage As Image = CaptureScreen()
                If lstPkmn.GetItemChecked(i) = True Then
                    Dim pkmnName As String = lstPkmn.Items(i).ToString
                    If pkmnName = "Type: Null" Then
                        pkmnName = "TypeNull"
                    End If
                    ' Dynamic images
                    Dim chkImage2 As Image = Image.FromFile(txtImgDirectory.Text & "\" & pkmnName & ".png")
                    img2 = New Bitmap(chkImage2)
                    pkmn = lstPkmn.Items(i).ToString
                End If
                img1 = New Bitmap(scImage)

                Dim p As Point = img1.Contains(img2)

                If p <> Nothing Then
                    ' Toggle
                    caught = True

                    ' Catch
                    catchPoke()
                    pkmnIdentifier.CancelAsync()
                    Exit For
                End If
            Next
        Catch ex As Exception
            'appendLogs(DateTime.Now, ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Catch pokemon
    Public Sub catchPoke()
        Try
            ' Find discord and send catch
            FindDiscord(channel1)
            If pkmn = "Nidoran_m" Then pkmn = "Nidoran"
            SendKeys.SendWait("p!catch " & pkmn)
            SendKeys.SendWait("{Enter}")
        Catch ex As Exception
            ' Catch exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Background searcher
    Private Sub pkmnIdebtifier_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles pkmnIdentifier.RunWorkerCompleted
        ' Background work is complete, now restart
        Restart()
    End Sub

    Dim recentCatches As List(Of String) = New List(Of String)
    ' Restarter
    Public Sub Restart()
        ' Log end time
        endTime = DateTime.Now

        ' Calc difference and update stats
        Dim secDif As Integer
        secDif = DateDiff(DateInterval.Second, startTime, endTime)
        lblTime.Text = secDif & "sec"
        catchTimes.Add(secDif)

        ' Update and log
        checking = False
        noticeUpdater("home", "[ENCOUNTER] Finished identifying pokemon in " & secDif & "sec")
        appendOutput(DateTime.Now, "[ENCOUNTER] Finished identifying pokemon in " & secDif & "sec")
        pkmnPreview.BackgroundImage = My.Resources.Spr_3r_000

        ' Catch triggrer
        CatchTrigger()

        ' Restart bot
        botTimer.Start()
        appendLogs(DateTime.Now, "[INFO] Restarting spammer...")
    End Sub

    ' Deselect button
    Private Sub btnDeselect_Click(sender As Object, e As EventArgs) Handles btnDeselect.Click
        If cbSelect.Text = "All" Then
            ' Deselect all in checked listbox
            For i As Integer = 0 To lstPkmn.Items.Count - 1
                lstPkmn.SetItemChecked(i, False)
            Next

            ' Logs
            appendLogs(DateTime.Now, "[INFO] All pokemon deselected in list...")
            noticeUpdater("basic", "[INFO] All pokemon deselected in the list...")
        ElseIf cbSelect.Text = "Legendary" Then
            ' Deselect legendary
            For i As Integer = 0 To legends.Count - 1
                lstPkmn.FindItemAndSetChecked(legends(i).ToString, False)
            Next

            ' Logs
            appendOutput(DateTime.Now, "[INFO] All legendary pokemon have been deselected...")
            noticeUpdater("basic", "[INFO] All legendary pokemon have been deselected...")
        ElseIf cbSelect.Text = "Mythic" Then
            ' Deselect mythic
            For i As Integer = 0 To mythics.Count - 1
                lstPkmn.FindItemAndSetChecked(mythics(i).ToString, False)
            Next

            ' Logs
            appendOutput(DateTime.Now, "[INFO] All mythic pokemon have been deselected...")
            noticeUpdater("basic", "[INFO] All mythic pokemon have been deselected...")
        ElseIf cbSelect.Text = "Alolan" Then
            ' Deselect alolans
            For i As Integer = 0 To alolans.Count - 1
                lstPkmn.FindItemAndSetChecked(alolans(i).ToString, False)
            Next

            ' Log
            appendOutput(DateTime.Now, "[INFO] All alolan forms have been deselected...")
            noticeUpdater("basic", "[INFO] All alolan forms have been deselected...")
        ElseIf cbSelect.Text = "Ultra Beast" Then
            ' Deselect ultra beasts
            For i As Integer = 0 To ultrabeasts.Count - 1
                lstPkmn.FindItemAndSetChecked(ultrabeasts(i).ToString, True)
            Next

            ' Log
            appendOutput(DateTime.Now, "[INFO] All ultra beasts have been deselected...")
            noticeUpdater("basic", "[INFO] All ultra bests have been deselected...")
        End If
    End Sub

    ' Select button
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If cbSelect.Text = "All" Then
            ' Deselect all in checked listbox
            For i As Integer = 0 To lstPkmn.Items.Count - 1
                lstPkmn.SetItemChecked(i, True)
            Next

            ' Logs
            appendLogs(DateTime.Now, "[INFO] All pokemon selected in list...")
            noticeUpdater("basic", "[INFO] All pokemon selected in the list...")
        ElseIf cbSelect.Text = "Legendary" Then
            ' Deselect legendary
            For i As Integer = 0 To legends.Count - 1
                lstPkmn.FindItemAndSetChecked(legends(i).ToString, True)
            Next

            ' Logs
            appendOutput(DateTime.Now, "[INFO] All legendary pokemon have been selected...")
            noticeUpdater("basic", "[INFO] All legendary pokemon have been selected...")
        ElseIf cbSelect.Text = "Mythic" Then
            ' Deselect mythics
            For i As Integer = 0 To mythics.Count - 1
                lstPkmn.FindItemAndSetChecked(mythics(i).ToString, True)
            Next

            ' Logs
            appendOutput(DateTime.Now, "[INFO] All mythic pokemon have been selected...")
            noticeUpdater("basic", "[INFO] All mythic pokemon have been selected...")
        ElseIf cbSelect.Text = "Alolan" Then
            ' Deselect alolans
            For i As Integer = 0 To alolans.Count - 1
                lstPkmn.FindItemAndSetChecked(alolans(i).ToString, True)
            Next

            ' Log
            appendOutput(DateTime.Now, "[INFO] All alolan forms have been selected...")
            noticeUpdater("basic", "[INFO] All alolan forms have been selected...")
        ElseIf cbSelect.Text = "Ultra Beast" Then
            ' Select ultra beasts
            For i As Integer = 0 To ultrabeasts.Count - 1
                lstPkmn.FindItemAndSetChecked(ultrabeasts(i).ToString, True)
            Next

            ' Log
            appendOutput(DateTime.Now, "[INFO] All ultra beasts have been selected...")
            noticeUpdater("basic", "[INFO] All ultra beasts have been selected...")

        End If
    End Sub

    ' Search bar
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim index As Integer = lstPkmn.FindString(txtSearch.Text)

        If 0 <= index Then
            lstPkmn.SelectedIndex = index
        End If
    End Sub

    ' Stats timers
    Private Sub statsTimer_Tick(sender As Object, e As EventArgs) Handles statsTimer.Tick
        ' Update stats
        Dim elapsed As TimeSpan = Me.StopWatch.Elapsed
        If botRunning = True Then
            lblElapsed.Text = String.Format("{0}days {1}hr {2}min {3}sec", elapsed.Days, elapsed.Hours, elapsed.Minutes, elapsed.Seconds)
        End If

        Dim spawn As Double = Math.Round(Double.Parse(lblSeen.Text / lblSentMsg.Text * 100))
        lblSpawnRate.Text = spawn & "%"

        ' Catches per 
        Dim catchesPerMin As Double = Math.Round(lblCaught.Text / elapsed.TotalSeconds * 60, 2, MidpointRounding.AwayFromZero)
        lblCatchPerMin.Text = catchesPerMin & " / min"

        ' Average times
        tSize = catchTimes.Count
        For i = 1 To tSize
            Dim avgCatch = catchTimes.Average
            lblAvgTime.Text = Math.Round(avgCatch, 2, MidpointRounding.AwayFromZero) & "sec"
        Next

        ' Update pokemon icons
        If checking = True Then
            Dim pkmnNew As String = pkmn.ToLower
            If pkmnNew = "mr. mime" Then pkmnNew = "mr-mime"
            If pkmnNew = "mime jr." Then pkmnNew = "mime-jr"
            If pkmnNew = "detective pikachu" Then pkmnNew = "pikachu"
            If pkmnNew = "type: null" Then pkmnNew = "type-null"
            If pkmnNew = "tapu koko" Then pkmnNew = "tapu-koko"
            If pkmnNew = "tapu bulu" Then pkmnNew = "tapu-bulu"
            If pkmnNew = "tapu fini" Then pkmnNew = "tapu-fini"
            If pkmnNew = "tapu lele" Then pkmnNew = "tapu-lele"
            If pkmnNew = "nidoran" Then pkmnNew = "nidoran-f"
            If pkmnNew = "nidoran_m" Then pkmnNew = "nidoran-m"

            Dim url As String = "https://img.pokemondb.net/sprites/sun-moon/icon/" & pkmnNew.ToLower & ".png"
            Dim tClient As WebClient = New WebClient

            If pkmnNew.Contains("alolan") Then
                pkmnPreview.BackgroundImage = My.Resources.Spr_3r_000
            Else
                Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(url)))
                pkmnPreview.BackgroundImage = tImage
            End If

            ' Log
            noticeUpdater("home", "[INFO] Scanning: " & pkmn)
        End If
    End Sub

    ' Chat spam in background
    Private Sub chatSpammer_DoWork(sender As Object, e As DoWorkEventArgs) Handles chatSpammer.DoWork
        SendKeys.SendWait(lstChatSpam.Items((Rand(0, lstChatSpam.Items.Count - 1))))
        SendKeys.SendWait("{Enter}")
        chatSpammer.CancelAsync()
    End Sub

    ' Updates notices
    Public Sub noticeUpdater(ByVal dest As String, ByVal msg As String)
        If dest = "home" Then
            noticeHome.Text = msg
        ElseIf dest = "advanced" Then
            noticeAdvanced.Text = msg
        ElseIf dest = "basic" Then
            noticeBasic.Text = msg
        End If
    End Sub

    ' Closing procedures
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Saving log file
        Dim write As New StreamWriter(path & "\logs\" & DateTime.Now.ToString("ddMMyyHHmmss") & ".txt")
        Dim k As ListView.ColumnHeaderCollection = lstOutput.Columns
        For Each x As ListViewItem In lstOutput.Items
            Dim strLn As String = ""
            For i = 0 To x.SubItems.Count - 1
                strLn += k(i).Text + " | " + x.SubItems(i).Text + Space(3)
            Next
            write.WriteLine(strLn)
        Next
        write.Close()
    End Sub

    ' Email template
    Public Sub sendEmail(ByVal subject As String, ByVal body As String)
        ' Sending test email
        Try
            Dim SmtpServer As New SmtpClient
            Dim mail As New MailMessage
            SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.email & My.Settings.provider, My.Settings.pass)
            SmtpServer.Port = My.Settings.port
            SmtpServer.Host = My.Settings.smtp
            SmtpServer.EnableSsl = True
            mail = New MailMessage
            mail.From = New MailAddress(My.Settings.email & My.Settings.provider)
            If My.Settings.altBool = True Then
                mail.To.Add(My.Settings.altEmail)
            Else
                mail.To.Add(My.Settings.email & My.Settings.provider)
            End If
            mail.Subject = subject
            mail.Body = body
            SmtpServer.Send(mail)

            ' Logs
            appendLogs(DateTime.Now, "[INFO] Email sent successfully...")
        Catch ex As Exception
            ' Logs
            appendLogs(DateTime.Now, "[ERROR] Couldn't send email...")
            appendLogs(DateTime.Now, ex.ToString)
        End Try
    End Sub

    ' Catch trigger
    Public Sub CatchTrigger()
        If caught = True Then
            ' Log
            appendOutput(DateTime.Now, "[ENCOUNTER] You successfully caught " & pkmn & "!")
            appendLogs(DateTime.Now, "[INFO] Pokemon caught...")

            ' Recent catches
            lstRecentCatch.Items.Insert(0, pkmn)

            ' Get animated sprite
            Dim pkmnNew As String = pkmn.ToLower
            If pkmnNew = "mr. mime" Then pkmnNew = "mr-mime"
            If pkmnNew = "mime jr." Then pkmnNew = "mime-jr"
            If pkmnNew = "detective pikachu" Then pkmnNew = "pikachu"
            If pkmnNew = "type: null" Then pkmnNew = "type-null"
            If pkmnNew = "tapu koko" Then pkmnNew = "tapu-koko"
            If pkmnNew = "tapu bulu" Then pkmnNew = "tapu-bulu"
            If pkmnNew = "tapu fini" Then pkmnNew = "tapu-fini"
            If pkmnNew = "tapu lele" Then pkmnNew = "tapu-lele"
            If pkmnNew = "nidoran" Then pkmnNew = "nidoran-f"
            If pkmnNew = "nidoran_m" Then pkmnNew = "nidoran-m"

            For i As Integer = 0 To pokemon.Count - 1
                Dim pkmnid As Integer = i + 1
                Dim dexid As String = String.Format("{00:00}", pkmnid)
                If pokemon(i).ToString = pkmnNew Then
                    If pkmnNew.Contains("alolan") Then
                        dexid = String.Format("{00:00}", 0)
                    End If
                    If dexid.Length < 3 Then dexid = "0" & dexid
                    Try
                        If File.Exists(imgPath & "\cache\" & dexid & ".gif") Then
                            pbRecent.Image = Image.FromFile(imgPath & "\cache\" & dexid & ".gif")
                        Else
                            Dim url As String = "http://pokemon-online.eu/images/pokemon/s-m/animated/" & dexid & ".gif"
                            Dim tclient As WebClient = New WebClient
                            Dim timage As Bitmap = Bitmap.FromStream(New IO.MemoryStream(tclient.DownloadData(url)))

                            timage.Save(imgPath & "\cache\" & dexid & ".gif")
                            pbRecent.Image = Image.FromFile(imgPath & "\cache\" & dexid & ".gif")
                        End If
                    Catch ex As Exception
                        Dim tclient As WebClient = New WebClient
                        Dim timage As Bitmap = Bitmap.FromStream(New IO.MemoryStream(tclient.DownloadData("https://vignette.wikia.nocookie.net/pokemon/images/0/05/Ghost_Lavender_Town_RBY.png")))
                        pbRecent.Image = timage
                    End Try
                End If
            Next

            ' Count the most frequently caught pokemon
            Dim pkmncount As Integer = 0
            For Each i As String In lstRecentCatch.Items
                If i.Contains(pkmn) Then pkmncount += 1
            Next

            If pkmncount >= topcount Then
                topcount = pkmncount
                lblMostCaught.Text = "[" & topcount & "]" & " " & pkmn
            End If

            ' Toggle
            caught = False

            ' Stats
            lblCaught.Text = lblCaught.Text + 1

            Dim levelRate As Integer = lblCaught.Text / lblSeen.Text * 100
            lblRate.Text = Math.Round(levelRate) & "%"

            ' Legendary / mythic / ultra beast / alolan
            If listLegends.Contains(pkmn) Then
                lblLegendCaught.Text += 1
                If chkLegendary.Checked = True Then
                    sendEmail("Discord Bot v2 " & pkmn & " (Legendary) Caught!", "You have successfully caught:" & Environment.NewLine & pkmn & Environment.NewLine & DateTime.Now)
                End If
            End If

            If mythics.Contains(pkmn) Then
                lblMythicCaught.Text += 1
                If chkMythic.Checked = True Then
                    sendEmail("Discord Bot v2 " & pkmn & " (Mythic) Caught!", "You have successfully caught:" & Environment.NewLine & pkmn & Environment.NewLine & DateTime.Now)
                End If
            End If

            If ultrabeasts.Contains(pkmn) Then
                lblUBCaught.Text += 1
                If chkUltraBeast.Checked = True Then
                    sendEmail("Discord Bot v2 " & pkmn & " (Ultra Beast) Caught!", "You have successfully caught:" & Environment.NewLine & pkmn & Environment.NewLine & DateTime.Now)
                End If
            End If

            If alolans.Contains(pkmn) AndAlso chkAlolan.Checked = True Then
                sendEmail("Discord Bot v2 " & pkmn & " (Alolan) Caught!", "You have successfully caught:" & Environment.NewLine & pkmn & Environment.NewLine & DateTime.Now)
            End If

            ' Rate %
            Dim legendRate As Integer = lblLegendCaught.Text / lblCaught.Text * 100
            lblLegendRate.Text = Math.Round(legendRate) & "%"

            Dim mythicRate As Integer = lblMythicCaught.Text / lblCaught.Text * 100
            lblMythicRate.Text = Math.Round(mythicRate) & "%"

            Dim ubRate As Integer = lblUBCaught.Text / lblCaught.Text * 100
            lblUBRate.Text = Math.Round(ubRate) & "%"
        Else
            ' Log
            appendOutput(DateTime.Now, "[ENCOUNTER] Failed to identify pokemon...")
        End If
    End Sub

    ' Github
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://zydratex.github.io/Gotcha/")
    End Sub

    ' Github issues
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://github.com/Zydratex/Gotcha/issues")
    End Sub


    '  ____        _      _       _____                                          _     
    ' / __ \      (_)    | |     / ____|                                        | |    
    '| |  | |_   _ _  ___| | __ | |     ___  _ __ ___  _ __ ___   __ _ _ __   __| |___ 
    '| |  | | | | | |/ __| |/ / | |    / _ \| '_ ` _ \| '_ ` _ \ / _` | '_ \ / _` / __|
    '| |__| | |_| | | (__|   <  | |___| (_) | | | | | || |  (_| | | | | (_| \ |_| \ \__
    ' \___\_\\__,_|_|\___|_|\_\  \_____\___/|_| |_| |_|_| |_| |_|\__,_|_| |_|\__,_|/___|


    ' Toggle detailed view
    Private Sub btnDetailed_Click_2(sender As Object, e As EventArgs) Handles btnDetailed.Click
        FindDiscord(channel2)
        SendKeys.SendWait("p!detailed")
        SendKeys.SendWait("{Enter}")
    End Sub

    ' Ordedr by
    Private Sub btnOrderBy_Click(sender As Object, e As EventArgs) Handles btnOrderBy.Click
        FindDiscord(channel2)
        SendKeys.SendWait("p!order " & cbOrderBy.Text)
        SendKeys.SendWait("{Enter}")
    End Sub

    ' Select latest
    Private Sub btnSelectLatest_Click(sender As Object, e As EventArgs) Handles btnSelectLatest.Click
        FindDiscord(channel2)
        SendKeys.SendWait("p!select latest")
        SendKeys.SendWait("{Enter}")
    End Sub

    ' Pkmn Info
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        If cbInfo.Text = "Selected Pokemon" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!info")
            SendKeys.SendWait("{Enter}")
        ElseIf cbInfo.Text = "Latest Pokemon" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!info latest")
            SendKeys.SendWait("{Enter}")
        End If
    End Sub

    ' Pokemon lists
    Private Sub btnPokemon_Click(sender As Object, e As EventArgs) Handles btnPokemon.Click
        If cbPokemon.Text = "All" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokemon")
            SendKeys.SendWait("{Enter}")
        ElseIf cbPokemon.Text = "Shiny" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokemon --shiny")
            SendKeys.SendWait("{Enter}")
        ElseIf cbPokemon.Text = "Alolan" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokemon --alolan")
            SendKeys.SendWait("{Enter}")
        ElseIf cbPokemon.Text = "Mega" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokemon --mega")
            SendKeys.SendWait("{Enter}")
        ElseIf cbPokemon.Text = "Legendary" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokemon --legendary")
            SendKeys.SendWait("{Enter}")
        ElseIf cbPokemon.Text = "Mythic" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokemon --mythical")
            SendKeys.SendWait("{Enter}")
        ElseIf cbPokemon.Text = "Ultra Beast" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokemon --ub")
            SendKeys.SendWait("{Enter}")
        End If
    End Sub

    ' Pokedex
    Private Sub btnPokedex_Click(sender As Object, e As EventArgs) Handles btnPokedex.Click
        If cbPokedex.Text = "Owned" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokedex")
            SendKeys.SendWait("{Enter}")
        ElseIf cbPokedex.Text = "Unowned" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!pokedex unowned")
            SendKeys.SendWait("{Enter}")
        End If
    End Sub

    ' Nickname
    Private Sub btnNickname_Click(sender As Object, e As EventArgs) Handles btnNickname.Click
        If txtNickname.Text <> "" Then
            FindDiscord(channel2)
            SendKeys.SendWait("p!nickname " & txtNickname.Text)
            SendKeys.SendWait("{Enter}")
        End If
    End Sub

    ' Favorite
    Private Sub btnFavorite_Click(sender As Object, e As EventArgs) Handles btnFavorite.Click
        FindDiscord(channel2)
        SendKeys.SendWait("p!fav")
        SendKeys.SendWait("{Enter}")
    End Sub

    ' Balance
    Private Sub btnBallance_Click(sender As Object, e As EventArgs) Handles btnBallance.Click
        FindDiscord(channel2)
        SendKeys.SendWait("p!bal")
        SendKeys.SendWait("{Enter}")
    End Sub

    ' Pokedex rewards
    Private Sub btnClaimRewards_Click(sender As Object, e As EventArgs) Handles btnClaimRewards.Click
        FindDiscord(channel2)
        SendKeys.SendWait("p!pokedex claim all")
        SendKeys.SendWait("{Enter}")
    End Sub

    ' Image tester
    Private Sub XylosButton1_Click(sender As Object, e As EventArgs) Handles XylosButton1.Click
        frmTester.Show()
    End Sub

    Private Async Sub btnScrape_ClickAsync(sender As Object, e As EventArgs) Handles btnScrape.Click
        frmScrape.Show()
    End Sub
End Class
