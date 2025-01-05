<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Onboarding
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Onboarding))
        last = New TabPage()
        last_panel = New Panel()
        last_launchBMIMe = New Button()
        last_head = New Label()
        last_checkicon = New PictureBox()
        last_body = New Label()
        summaryTab = New TabPage()
        summaryTab_disclaimer = New Label()
        Label5 = New Label()
        summaryTab_back = New Button()
        summaryTab_next = New Button()
        summaryTab_title = New Label()
        summaryTab_body = New Label()
        summaryPanel = New Panel()
        summaryPanel_age = New Label()
        summaryPanel_height = New Label()
        summaryPanel_weight = New Label()
        summaryPanel_unit = New Label()
        summaryPanel_privacy = New Label()
        summaryPanel_name = New Label()
        summaryPanel_lang = New Label()
        whuTab = New TabPage()
        Panel8 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        whuTab_agebox = New GroupBox()
        whuTab_agetxt = New TextBox()
        whuTab_unitBox = New GroupBox()
        unitBox_imperial = New RadioButton()
        unitBox_metric = New RadioButton()
        whuTab_heightbox = New GroupBox()
        whuTab_hlbl = New Label()
        whuTab_htxt = New TextBox()
        whuTab_weightbox = New GroupBox()
        whuTab_wlbl = New Label()
        whuTab_wtxt = New TextBox()
        whuTab_genderbox = New GroupBox()
        genderbox_other = New RadioButton()
        genderbox_f = New RadioButton()
        genderbox_m = New RadioButton()
        whuTab_back = New Button()
        whuTab_next = New Button()
        whuTab_title = New Label()
        whuTab_body = New Label()
        Panel5 = New Panel()
        Label13 = New Label()
        PictureBox5 = New PictureBox()
        legalTab = New TabPage()
        Panel7 = New Panel()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        legal_back = New Button()
        PictureBox4 = New PictureBox()
        legal_body1 = New Label()
        legal_body = New Label()
        Panel3 = New Panel()
        legal_privacypolicy = New RichTextBox()
        legal_title = New Label()
        legal_next = New Button()
        club = New TabPage()
        Panel6 = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        club_back = New Button()
        club_next = New Button()
        club_title = New Label()
        club_body = New Label()
        Panel2 = New Panel()
        club_u = New Label()
        WelcomeClubPic = New PictureBox()
        supposed_name = New Label()
        usernameTab = New TabPage()
        Panel4 = New Panel()
        NameApp = New Label()
        PictureBox6 = New PictureBox()
        usernameTab_back = New Button()
        usernameTab_body2 = New Label()
        txtName = New TextBox()
        usernameTab_body = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        logo = New PictureBox()
        usernameTab_title = New Label()
        usernameTab_next = New Button()
        welcome = New TabPage()
        welcome_grouplang = New GroupBox()
        welcome_filipino = New RadioButton()
        welcome_english = New RadioButton()
        welcome_letsgo = New Button()
        welcome_body = New Label()
        welcome_title = New Label()
        welcome_footer = New PictureBox()
        welcome_header = New PictureBox()
        OnboardFrame = New TabControl()
        last.SuspendLayout()
        last_panel.SuspendLayout()
        CType(last_checkicon, ComponentModel.ISupportInitialize).BeginInit()
        summaryTab.SuspendLayout()
        summaryPanel.SuspendLayout()
        whuTab.SuspendLayout()
        Panel8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        whuTab_agebox.SuspendLayout()
        whuTab_unitBox.SuspendLayout()
        whuTab_heightbox.SuspendLayout()
        whuTab_weightbox.SuspendLayout()
        whuTab_genderbox.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        legalTab.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        club.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(WelcomeClubPic, ComponentModel.ISupportInitialize).BeginInit()
        usernameTab.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        welcome.SuspendLayout()
        welcome_grouplang.SuspendLayout()
        CType(welcome_footer, ComponentModel.ISupportInitialize).BeginInit()
        CType(welcome_header, ComponentModel.ISupportInitialize).BeginInit()
        OnboardFrame.SuspendLayout()
        SuspendLayout()
        ' 
        ' last
        ' 
        last.Controls.Add(last_panel)
        last.Location = New Point(4, 5)
        last.Margin = New Padding(4, 3, 4, 3)
        last.Name = "last"
        last.Padding = New Padding(4, 3, 4, 3)
        last.Size = New Size(1140, 638)
        last.TabIndex = 8
        last.Text = " "
        last.UseVisualStyleBackColor = True
        ' 
        ' last_panel
        ' 
        last_panel.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(248))
        last_panel.BackgroundImageLayout = ImageLayout.Stretch
        last_panel.Controls.Add(last_launchBMIMe)
        last_panel.Controls.Add(last_head)
        last_panel.Controls.Add(last_checkicon)
        last_panel.Controls.Add(last_body)
        last_panel.Location = New Point(362, 65)
        last_panel.Margin = New Padding(4, 3, 4, 3)
        last_panel.Name = "last_panel"
        last_panel.Size = New Size(424, 531)
        last_panel.TabIndex = 71
        ' 
        ' last_launchBMIMe
        ' 
        last_launchBMIMe.Font = New Font("Segoe UI Variable Display", 10F)
        last_launchBMIMe.Image = CType(resources.GetObject("last_launchBMIMe.Image"), Image)
        last_launchBMIMe.Location = New Point(119, 343)
        last_launchBMIMe.Margin = New Padding(4, 3, 4, 3)
        last_launchBMIMe.Name = "last_launchBMIMe"
        last_launchBMIMe.Size = New Size(187, 47)
        last_launchBMIMe.TabIndex = 73
        last_launchBMIMe.Text = "Launch BMIMe"
        last_launchBMIMe.TextImageRelation = TextImageRelation.TextBeforeImage
        last_launchBMIMe.UseVisualStyleBackColor = True
        ' 
        ' last_head
        ' 
        last_head.BackColor = Color.Transparent
        last_head.Font = New Font("Manrope ExtraBold", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        last_head.ForeColor = Color.Black
        last_head.Location = New Point(5, 211)
        last_head.Margin = New Padding(4, 0, 4, 0)
        last_head.Name = "last_head"
        last_head.Size = New Size(416, 71)
        last_head.TabIndex = 72
        last_head.Text = "All set!"
        last_head.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' last_checkicon
        ' 
        last_checkicon.Image = CType(resources.GetObject("last_checkicon.Image"), Image)
        last_checkicon.Location = New Point(163, 98)
        last_checkicon.Margin = New Padding(4, 3, 4, 3)
        last_checkicon.Name = "last_checkicon"
        last_checkicon.Size = New Size(106, 97)
        last_checkicon.SizeMode = PictureBoxSizeMode.Zoom
        last_checkicon.TabIndex = 41
        last_checkicon.TabStop = False
        ' 
        ' last_body
        ' 
        last_body.BackColor = Color.Transparent
        last_body.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        last_body.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        last_body.ImageAlign = ContentAlignment.MiddleLeft
        last_body.Location = New Point(69, 282)
        last_body.Margin = New Padding(4, 0, 4, 0)
        last_body.Name = "last_body"
        last_body.Size = New Size(295, 58)
        last_body.TabIndex = 62
        last_body.Text = "Your configurations have been saved!"
        last_body.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' summaryTab
        ' 
        summaryTab.Controls.Add(summaryTab_disclaimer)
        summaryTab.Controls.Add(Label5)
        summaryTab.Controls.Add(summaryTab_back)
        summaryTab.Controls.Add(summaryTab_next)
        summaryTab.Controls.Add(summaryTab_title)
        summaryTab.Controls.Add(summaryTab_body)
        summaryTab.Controls.Add(summaryPanel)
        summaryTab.Location = New Point(4, 5)
        summaryTab.Margin = New Padding(4, 3, 4, 3)
        summaryTab.Name = "summaryTab"
        summaryTab.Padding = New Padding(4, 3, 4, 3)
        summaryTab.Size = New Size(1140, 638)
        summaryTab.TabIndex = 7
        summaryTab.Text = "CheckInfo"
        summaryTab.UseVisualStyleBackColor = True
        ' 
        ' summaryTab_disclaimer
        ' 
        summaryTab_disclaimer.BackColor = Color.Transparent
        summaryTab_disclaimer.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        summaryTab_disclaimer.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryTab_disclaimer.ImageAlign = ContentAlignment.MiddleLeft
        summaryTab_disclaimer.Location = New Point(28, 258)
        summaryTab_disclaimer.Margin = New Padding(4, 0, 4, 0)
        summaryTab_disclaimer.Name = "summaryTab_disclaimer"
        summaryTab_disclaimer.Size = New Size(491, 54)
        summaryTab_disclaimer.TabIndex = 74
        summaryTab_disclaimer.Text = "Disclaimer: BMIMe is a tool for informational purposes only and should not be considered a substitute for professional medical advice, diagnosis, or treatment."
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        Label5.ImageAlign = ContentAlignment.MiddleLeft
        Label5.Location = New Point(27, 603)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(491, 30)
        Label5.TabIndex = 73
        Label5.Text = "Press Ctrl + Shift + R to restart your progress if you've encountered problems"
        ' 
        ' summaryTab_back
        ' 
        summaryTab_back.Font = New Font("Segoe UI Variable Display", 10F)
        summaryTab_back.Image = CType(resources.GetObject("summaryTab_back.Image"), Image)
        summaryTab_back.Location = New Point(33, 449)
        summaryTab_back.Margin = New Padding(4, 3, 4, 3)
        summaryTab_back.Name = "summaryTab_back"
        summaryTab_back.Size = New Size(141, 47)
        summaryTab_back.TabIndex = 72
        summaryTab_back.Text = "Back"
        summaryTab_back.TextImageRelation = TextImageRelation.TextBeforeImage
        summaryTab_back.UseVisualStyleBackColor = True
        ' 
        ' summaryTab_next
        ' 
        summaryTab_next.Font = New Font("Segoe UI Variable Display", 10F)
        summaryTab_next.Image = CType(resources.GetObject("summaryTab_next.Image"), Image)
        summaryTab_next.Location = New Point(33, 352)
        summaryTab_next.Margin = New Padding(4, 3, 4, 3)
        summaryTab_next.Name = "summaryTab_next"
        summaryTab_next.Size = New Size(141, 47)
        summaryTab_next.TabIndex = 71
        summaryTab_next.Text = "Next"
        summaryTab_next.TextImageRelation = TextImageRelation.TextBeforeImage
        summaryTab_next.UseVisualStyleBackColor = True
        ' 
        ' summaryTab_title
        ' 
        summaryTab_title.BackColor = Color.Transparent
        summaryTab_title.Font = New Font("Manrope ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryTab_title.ForeColor = Color.Black
        summaryTab_title.Location = New Point(27, 189)
        summaryTab_title.Margin = New Padding(4, 0, 4, 0)
        summaryTab_title.Name = "summaryTab_title"
        summaryTab_title.Size = New Size(397, 36)
        summaryTab_title.TabIndex = 69
        summaryTab_title.Text = "Check everything!"
        ' 
        ' summaryTab_body
        ' 
        summaryTab_body.BackColor = Color.Transparent
        summaryTab_body.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryTab_body.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryTab_body.ImageAlign = ContentAlignment.MiddleLeft
        summaryTab_body.Location = New Point(28, 225)
        summaryTab_body.Margin = New Padding(4, 0, 4, 0)
        summaryTab_body.Name = "summaryTab_body"
        summaryTab_body.Size = New Size(491, 33)
        summaryTab_body.TabIndex = 68
        summaryTab_body.Text = "Please check if the information is correct."
        ' 
        ' summaryPanel
        ' 
        summaryPanel.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(248))
        summaryPanel.BackgroundImageLayout = ImageLayout.Stretch
        summaryPanel.Controls.Add(summaryPanel_age)
        summaryPanel.Controls.Add(summaryPanel_height)
        summaryPanel.Controls.Add(summaryPanel_weight)
        summaryPanel.Controls.Add(summaryPanel_unit)
        summaryPanel.Controls.Add(summaryPanel_privacy)
        summaryPanel.Controls.Add(summaryPanel_name)
        summaryPanel.Controls.Add(summaryPanel_lang)
        summaryPanel.Location = New Point(558, 132)
        summaryPanel.Margin = New Padding(4, 3, 4, 3)
        summaryPanel.Name = "summaryPanel"
        summaryPanel.Size = New Size(560, 321)
        summaryPanel.TabIndex = 70
        ' 
        ' summaryPanel_age
        ' 
        summaryPanel_age.BackColor = Color.Transparent
        summaryPanel_age.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryPanel_age.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryPanel_age.ImageAlign = ContentAlignment.MiddleLeft
        summaryPanel_age.Location = New Point(16, 227)
        summaryPanel_age.Margin = New Padding(4, 0, 4, 0)
        summaryPanel_age.Name = "summaryPanel_age"
        summaryPanel_age.Size = New Size(295, 33)
        summaryPanel_age.TabIndex = 68
        summaryPanel_age.Text = "Age: 15 years old."
        summaryPanel_age.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' summaryPanel_height
        ' 
        summaryPanel_height.BackColor = Color.Transparent
        summaryPanel_height.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryPanel_height.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryPanel_height.ImageAlign = ContentAlignment.MiddleLeft
        summaryPanel_height.Location = New Point(16, 194)
        summaryPanel_height.Margin = New Padding(4, 0, 4, 0)
        summaryPanel_height.Name = "summaryPanel_height"
        summaryPanel_height.Size = New Size(295, 33)
        summaryPanel_height.TabIndex = 67
        summaryPanel_height.Text = "Height: 180 cm"
        summaryPanel_height.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' summaryPanel_weight
        ' 
        summaryPanel_weight.BackColor = Color.Transparent
        summaryPanel_weight.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryPanel_weight.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryPanel_weight.ImageAlign = ContentAlignment.MiddleLeft
        summaryPanel_weight.Location = New Point(16, 160)
        summaryPanel_weight.Margin = New Padding(4, 0, 4, 0)
        summaryPanel_weight.Name = "summaryPanel_weight"
        summaryPanel_weight.Size = New Size(295, 33)
        summaryPanel_weight.TabIndex = 66
        summaryPanel_weight.Text = "Weight: 70kg"
        summaryPanel_weight.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' summaryPanel_unit
        ' 
        summaryPanel_unit.BackColor = Color.Transparent
        summaryPanel_unit.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryPanel_unit.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryPanel_unit.ImageAlign = ContentAlignment.MiddleLeft
        summaryPanel_unit.Location = New Point(16, 127)
        summaryPanel_unit.Margin = New Padding(4, 0, 4, 0)
        summaryPanel_unit.Name = "summaryPanel_unit"
        summaryPanel_unit.Size = New Size(295, 33)
        summaryPanel_unit.TabIndex = 65
        summaryPanel_unit.Text = "Chosen Unit: Metric"
        summaryPanel_unit.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' summaryPanel_privacy
        ' 
        summaryPanel_privacy.BackColor = Color.Transparent
        summaryPanel_privacy.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryPanel_privacy.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryPanel_privacy.ImageAlign = ContentAlignment.MiddleLeft
        summaryPanel_privacy.Location = New Point(16, 93)
        summaryPanel_privacy.Margin = New Padding(4, 0, 4, 0)
        summaryPanel_privacy.Name = "summaryPanel_privacy"
        summaryPanel_privacy.Size = New Size(295, 33)
        summaryPanel_privacy.TabIndex = 64
        summaryPanel_privacy.Text = "Accepted Privacy Policy: true"
        summaryPanel_privacy.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' summaryPanel_name
        ' 
        summaryPanel_name.BackColor = Color.Transparent
        summaryPanel_name.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryPanel_name.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryPanel_name.ImageAlign = ContentAlignment.MiddleLeft
        summaryPanel_name.Location = New Point(16, 60)
        summaryPanel_name.Margin = New Padding(4, 0, 4, 0)
        summaryPanel_name.Name = "summaryPanel_name"
        summaryPanel_name.Size = New Size(295, 33)
        summaryPanel_name.TabIndex = 63
        summaryPanel_name.Text = "Name: Gabriel Martin"
        summaryPanel_name.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' summaryPanel_lang
        ' 
        summaryPanel_lang.BackColor = Color.Transparent
        summaryPanel_lang.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        summaryPanel_lang.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        summaryPanel_lang.ImageAlign = ContentAlignment.MiddleLeft
        summaryPanel_lang.Location = New Point(16, 27)
        summaryPanel_lang.Margin = New Padding(4, 0, 4, 0)
        summaryPanel_lang.Name = "summaryPanel_lang"
        summaryPanel_lang.Size = New Size(295, 33)
        summaryPanel_lang.TabIndex = 62
        summaryPanel_lang.Text = "Language: en-US"
        summaryPanel_lang.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' whuTab
        ' 
        whuTab.Controls.Add(Panel8)
        whuTab.Controls.Add(whuTab_agebox)
        whuTab.Controls.Add(whuTab_unitBox)
        whuTab.Controls.Add(whuTab_heightbox)
        whuTab.Controls.Add(whuTab_weightbox)
        whuTab.Controls.Add(whuTab_genderbox)
        whuTab.Controls.Add(whuTab_back)
        whuTab.Controls.Add(whuTab_next)
        whuTab.Controls.Add(whuTab_title)
        whuTab.Controls.Add(whuTab_body)
        whuTab.Controls.Add(Panel5)
        whuTab.Location = New Point(4, 5)
        whuTab.Margin = New Padding(4, 3, 4, 3)
        whuTab.Name = "whuTab"
        whuTab.Padding = New Padding(4, 3, 4, 3)
        whuTab.Size = New Size(1140, 638)
        whuTab.TabIndex = 6
        whuTab.Text = "WeightHeightUnit"
        whuTab.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Label3)
        Panel8.Controls.Add(PictureBox3)
        Panel8.Location = New Point(18, 33)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(157, 55)
        Panel8.TabIndex = 76
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(58, 12)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 31)
        Label3.TabIndex = 65
        Label3.Text = "BMIMe"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 8)
        PictureBox3.Margin = New Padding(4, 3, 4, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(54, 39)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 66
        PictureBox3.TabStop = False
        ' 
        ' whuTab_agebox
        ' 
        whuTab_agebox.Controls.Add(whuTab_agetxt)
        whuTab_agebox.FlatStyle = FlatStyle.Flat
        whuTab_agebox.Font = New Font("Manrope", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        whuTab_agebox.Location = New Point(29, 286)
        whuTab_agebox.Margin = New Padding(4, 3, 4, 3)
        whuTab_agebox.Name = "whuTab_agebox"
        whuTab_agebox.Padding = New Padding(4, 3, 4, 3)
        whuTab_agebox.Size = New Size(237, 103)
        whuTab_agebox.TabIndex = 75
        whuTab_agebox.TabStop = False
        whuTab_agebox.Text = "Age"
        ' 
        ' whuTab_agetxt
        ' 
        whuTab_agetxt.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        whuTab_agetxt.Location = New Point(24, 39)
        whuTab_agetxt.Margin = New Padding(4, 3, 4, 3)
        whuTab_agetxt.Multiline = True
        whuTab_agetxt.Name = "whuTab_agetxt"
        whuTab_agetxt.Size = New Size(97, 36)
        whuTab_agetxt.TabIndex = 44
        ' 
        ' whuTab_unitBox
        ' 
        whuTab_unitBox.Controls.Add(unitBox_imperial)
        whuTab_unitBox.Controls.Add(unitBox_metric)
        whuTab_unitBox.FlatStyle = FlatStyle.Flat
        whuTab_unitBox.Font = New Font("Manrope", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        whuTab_unitBox.Location = New Point(289, 286)
        whuTab_unitBox.Margin = New Padding(4, 3, 4, 3)
        whuTab_unitBox.Name = "whuTab_unitBox"
        whuTab_unitBox.Padding = New Padding(4, 3, 4, 3)
        whuTab_unitBox.Size = New Size(204, 103)
        whuTab_unitBox.TabIndex = 74
        whuTab_unitBox.TabStop = False
        whuTab_unitBox.Text = "Unit"
        ' 
        ' unitBox_imperial
        ' 
        unitBox_imperial.AutoSize = True
        unitBox_imperial.Font = New Font("Manrope", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        unitBox_imperial.Location = New Point(19, 62)
        unitBox_imperial.Margin = New Padding(4, 3, 4, 3)
        unitBox_imperial.Name = "unitBox_imperial"
        unitBox_imperial.Size = New Size(126, 23)
        unitBox_imperial.TabIndex = 3
        unitBox_imperial.Text = "imperial lbs/in"
        unitBox_imperial.UseVisualStyleBackColor = True
        ' 
        ' unitBox_metric
        ' 
        unitBox_metric.AutoSize = True
        unitBox_metric.Font = New Font("Manrope", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        unitBox_metric.Location = New Point(19, 32)
        unitBox_metric.Margin = New Padding(4, 3, 4, 3)
        unitBox_metric.Name = "unitBox_metric"
        unitBox_metric.Size = New Size(111, 23)
        unitBox_metric.TabIndex = 2
        unitBox_metric.Text = "metric kg/m"
        unitBox_metric.UseVisualStyleBackColor = True
        ' 
        ' whuTab_heightbox
        ' 
        whuTab_heightbox.Controls.Add(whuTab_hlbl)
        whuTab_heightbox.Controls.Add(whuTab_htxt)
        whuTab_heightbox.FlatStyle = FlatStyle.Flat
        whuTab_heightbox.Font = New Font("Manrope", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        whuTab_heightbox.Location = New Point(289, 407)
        whuTab_heightbox.Margin = New Padding(4, 3, 4, 3)
        whuTab_heightbox.Name = "whuTab_heightbox"
        whuTab_heightbox.Padding = New Padding(4, 3, 4, 3)
        whuTab_heightbox.Size = New Size(204, 103)
        whuTab_heightbox.TabIndex = 75
        whuTab_heightbox.TabStop = False
        whuTab_heightbox.Text = "Height"
        ' 
        ' whuTab_hlbl
        ' 
        whuTab_hlbl.Font = New Font("Manrope", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        whuTab_hlbl.Location = New Point(124, 45)
        whuTab_hlbl.Margin = New Padding(4, 0, 4, 0)
        whuTab_hlbl.Name = "whuTab_hlbl"
        whuTab_hlbl.Size = New Size(55, 33)
        whuTab_hlbl.TabIndex = 45
        whuTab_hlbl.Text = "m"
        ' 
        ' whuTab_htxt
        ' 
        whuTab_htxt.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        whuTab_htxt.Location = New Point(19, 39)
        whuTab_htxt.Margin = New Padding(4, 3, 4, 3)
        whuTab_htxt.Multiline = True
        whuTab_htxt.Name = "whuTab_htxt"
        whuTab_htxt.Size = New Size(97, 36)
        whuTab_htxt.TabIndex = 44
        ' 
        ' whuTab_weightbox
        ' 
        whuTab_weightbox.Controls.Add(whuTab_wlbl)
        whuTab_weightbox.Controls.Add(whuTab_wtxt)
        whuTab_weightbox.FlatStyle = FlatStyle.Flat
        whuTab_weightbox.Font = New Font("Manrope", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        whuTab_weightbox.Location = New Point(29, 407)
        whuTab_weightbox.Margin = New Padding(4, 3, 4, 3)
        whuTab_weightbox.Name = "whuTab_weightbox"
        whuTab_weightbox.Padding = New Padding(4, 3, 4, 3)
        whuTab_weightbox.Size = New Size(237, 103)
        whuTab_weightbox.TabIndex = 74
        whuTab_weightbox.TabStop = False
        whuTab_weightbox.Text = "Weight"
        ' 
        ' whuTab_wlbl
        ' 
        whuTab_wlbl.Font = New Font("Manrope", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        whuTab_wlbl.Location = New Point(130, 45)
        whuTab_wlbl.Margin = New Padding(4, 0, 4, 0)
        whuTab_wlbl.Name = "whuTab_wlbl"
        whuTab_wlbl.Size = New Size(100, 33)
        whuTab_wlbl.TabIndex = 45
        whuTab_wlbl.Text = "kg"
        ' 
        ' whuTab_wtxt
        ' 
        whuTab_wtxt.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        whuTab_wtxt.Location = New Point(24, 39)
        whuTab_wtxt.Margin = New Padding(4, 3, 4, 3)
        whuTab_wtxt.Multiline = True
        whuTab_wtxt.Name = "whuTab_wtxt"
        whuTab_wtxt.Size = New Size(97, 36)
        whuTab_wtxt.TabIndex = 44
        ' 
        ' whuTab_genderbox
        ' 
        whuTab_genderbox.Controls.Add(genderbox_other)
        whuTab_genderbox.Controls.Add(genderbox_f)
        whuTab_genderbox.Controls.Add(genderbox_m)
        whuTab_genderbox.FlatStyle = FlatStyle.Flat
        whuTab_genderbox.Font = New Font("Manrope", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        whuTab_genderbox.Location = New Point(29, 203)
        whuTab_genderbox.Margin = New Padding(4, 3, 4, 3)
        whuTab_genderbox.Name = "whuTab_genderbox"
        whuTab_genderbox.Padding = New Padding(4, 3, 4, 3)
        whuTab_genderbox.Size = New Size(464, 76)
        whuTab_genderbox.TabIndex = 73
        whuTab_genderbox.TabStop = False
        whuTab_genderbox.Text = "Gender"
        ' 
        ' genderbox_other
        ' 
        genderbox_other.AutoSize = True
        genderbox_other.Font = New Font("Manrope", 10F, FontStyle.Bold)
        genderbox_other.Location = New Point(303, 32)
        genderbox_other.Margin = New Padding(4, 3, 4, 3)
        genderbox_other.Name = "genderbox_other"
        genderbox_other.Size = New Size(66, 23)
        genderbox_other.TabIndex = 61
        genderbox_other.TabStop = True
        genderbox_other.Text = "Other"
        genderbox_other.UseVisualStyleBackColor = True
        ' 
        ' genderbox_f
        ' 
        genderbox_f.AutoSize = True
        genderbox_f.Font = New Font("Manrope", 10F, FontStyle.Bold)
        genderbox_f.Location = New Point(173, 32)
        genderbox_f.Margin = New Padding(4, 3, 4, 3)
        genderbox_f.Name = "genderbox_f"
        genderbox_f.Size = New Size(75, 23)
        genderbox_f.TabIndex = 60
        genderbox_f.TabStop = True
        genderbox_f.Text = "Female"
        genderbox_f.UseVisualStyleBackColor = True
        ' 
        ' genderbox_m
        ' 
        genderbox_m.AutoSize = True
        genderbox_m.Font = New Font("Manrope", 10F, FontStyle.Bold)
        genderbox_m.Location = New Point(36, 32)
        genderbox_m.Margin = New Padding(4, 3, 4, 3)
        genderbox_m.Name = "genderbox_m"
        genderbox_m.Size = New Size(59, 23)
        genderbox_m.TabIndex = 59
        genderbox_m.TabStop = True
        genderbox_m.Text = "Male"
        genderbox_m.UseVisualStyleBackColor = True
        ' 
        ' whuTab_back
        ' 
        whuTab_back.Font = New Font("Segoe UI Variable Display", 10F)
        whuTab_back.Image = CType(resources.GetObject("whuTab_back.Image"), Image)
        whuTab_back.Location = New Point(57, 542)
        whuTab_back.Margin = New Padding(4, 3, 4, 3)
        whuTab_back.Name = "whuTab_back"
        whuTab_back.Size = New Size(80, 47)
        whuTab_back.TabIndex = 72
        whuTab_back.TextImageRelation = TextImageRelation.TextBeforeImage
        whuTab_back.UseVisualStyleBackColor = True
        ' 
        ' whuTab_next
        ' 
        whuTab_next.Font = New Font("Segoe UI Variable Display", 10F)
        whuTab_next.Image = CType(resources.GetObject("whuTab_next.Image"), Image)
        whuTab_next.Location = New Point(156, 542)
        whuTab_next.Margin = New Padding(4, 3, 4, 3)
        whuTab_next.Name = "whuTab_next"
        whuTab_next.Size = New Size(141, 47)
        whuTab_next.TabIndex = 71
        whuTab_next.Text = "Next"
        whuTab_next.TextImageRelation = TextImageRelation.TextBeforeImage
        whuTab_next.UseVisualStyleBackColor = True
        ' 
        ' whuTab_title
        ' 
        whuTab_title.BackColor = Color.Transparent
        whuTab_title.Font = New Font("Manrope ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        whuTab_title.ForeColor = Color.Black
        whuTab_title.Location = New Point(21, 120)
        whuTab_title.Margin = New Padding(4, 0, 4, 0)
        whuTab_title.Name = "whuTab_title"
        whuTab_title.Size = New Size(533, 36)
        whuTab_title.TabIndex = 69
        whuTab_title.Text = "Enter your health details"
        ' 
        ' whuTab_body
        ' 
        whuTab_body.BackColor = Color.Transparent
        whuTab_body.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        whuTab_body.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        whuTab_body.ImageAlign = ContentAlignment.MiddleLeft
        whuTab_body.Location = New Point(24, 162)
        whuTab_body.Margin = New Padding(4, 0, 4, 0)
        whuTab_body.Name = "whuTab_body"
        whuTab_body.Size = New Size(583, 38)
        whuTab_body.TabIndex = 68
        whuTab_body.Text = "This is important for calculating your BMI and recommendations."
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(248))
        Panel5.BackgroundImageLayout = ImageLayout.Stretch
        Panel5.Controls.Add(Label13)
        Panel5.Controls.Add(PictureBox5)
        Panel5.Location = New Point(684, 33)
        Panel5.Margin = New Padding(4, 3, 4, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(424, 531)
        Panel5.TabIndex = 70
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        Label13.ImageAlign = ContentAlignment.MiddleLeft
        Label13.Location = New Point(68, 383)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(295, 58)
        Label13.TabIndex = 62
        Label13.Text = "This is me while trying to code this application"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(68, 52)
        PictureBox5.Margin = New Padding(4, 3, 4, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(295, 314)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 41
        PictureBox5.TabStop = False
        ' 
        ' legalTab
        ' 
        legalTab.Controls.Add(Panel7)
        legalTab.Controls.Add(legal_back)
        legalTab.Controls.Add(PictureBox4)
        legalTab.Controls.Add(legal_body1)
        legalTab.Controls.Add(legal_body)
        legalTab.Controls.Add(Panel3)
        legalTab.Controls.Add(legal_title)
        legalTab.Controls.Add(legal_next)
        legalTab.Location = New Point(4, 5)
        legalTab.Margin = New Padding(4, 3, 4, 3)
        legalTab.Name = "legalTab"
        legalTab.Padding = New Padding(4, 3, 4, 3)
        legalTab.Size = New Size(1140, 638)
        legalTab.TabIndex = 3
        legalTab.Text = "Legal"
        legalTab.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label1)
        Panel7.Controls.Add(PictureBox2)
        Panel7.Location = New Point(18, 33)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(157, 55)
        Panel7.TabIndex = 72
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 12)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 31)
        Label1.TabIndex = 65
        Label1.Text = "BMIMe"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 8)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(54, 39)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 66
        PictureBox2.TabStop = False
        ' 
        ' legal_back
        ' 
        legal_back.Font = New Font("Segoe UI Variable Display", 10F)
        legal_back.Image = CType(resources.GetObject("legal_back.Image"), Image)
        legal_back.Location = New Point(57, 542)
        legal_back.Margin = New Padding(4, 3, 4, 3)
        legal_back.Name = "legal_back"
        legal_back.Size = New Size(80, 47)
        legal_back.TabIndex = 71
        legal_back.TextImageRelation = TextImageRelation.TextBeforeImage
        legal_back.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(280, 298)
        PictureBox4.Margin = New Padding(4, 3, 4, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(252, 173)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' legal_body1
        ' 
        legal_body1.BackColor = Color.Transparent
        legal_body1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        legal_body1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        legal_body1.Location = New Point(19, 200)
        legal_body1.Margin = New Padding(4, 0, 4, 0)
        legal_body1.Name = "legal_body1"
        legal_body1.Size = New Size(442, 115)
        legal_body1.TabIndex = 70
        legal_body1.Text = resources.GetString("legal_body1.Text")
        ' 
        ' legal_body
        ' 
        legal_body.BackColor = Color.Transparent
        legal_body.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        legal_body.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        legal_body.Location = New Point(19, 165)
        legal_body.Margin = New Padding(4, 0, 4, 0)
        legal_body.Name = "legal_body"
        legal_body.Size = New Size(196, 24)
        legal_body.TabIndex = 68
        legal_body.Text = "Please read them..."
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(251), CByte(251), CByte(251))
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(legal_privacypolicy)
        Panel3.Location = New Point(604, 9)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(518, 620)
        Panel3.TabIndex = 67
        ' 
        ' legal_privacypolicy
        ' 
        legal_privacypolicy.BackColor = Color.FromArgb(CByte(251), CByte(251), CByte(251))
        legal_privacypolicy.BorderStyle = BorderStyle.None
        legal_privacypolicy.Font = New Font("Segoe UI Variable Display", 12F)
        legal_privacypolicy.Location = New Point(15, 48)
        legal_privacypolicy.Margin = New Padding(4, 3, 4, 3)
        legal_privacypolicy.Name = "legal_privacypolicy"
        legal_privacypolicy.ReadOnly = True
        legal_privacypolicy.Size = New Size(488, 528)
        legal_privacypolicy.TabIndex = 64
        legal_privacypolicy.Text = "Please wait while we retrieve the document..."
        ' 
        ' legal_title
        ' 
        legal_title.BackColor = Color.Transparent
        legal_title.Font = New Font("Manrope ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        legal_title.ForeColor = Color.Black
        legal_title.Location = New Point(18, 118)
        legal_title.Margin = New Padding(4, 0, 4, 0)
        legal_title.Name = "legal_title"
        legal_title.Size = New Size(372, 47)
        legal_title.TabIndex = 65
        legal_title.Text = "Here are some legal stuff.."
        ' 
        ' legal_next
        ' 
        legal_next.Font = New Font("Segoe UI Variable Display", 10F)
        legal_next.Image = CType(resources.GetObject("legal_next.Image"), Image)
        legal_next.Location = New Point(156, 542)
        legal_next.Margin = New Padding(4, 3, 4, 3)
        legal_next.Name = "legal_next"
        legal_next.Size = New Size(141, 47)
        legal_next.TabIndex = 66
        legal_next.Text = "Next"
        legal_next.TextImageRelation = TextImageRelation.TextBeforeImage
        legal_next.UseVisualStyleBackColor = True
        ' 
        ' club
        ' 
        club.BackgroundImageLayout = ImageLayout.Stretch
        club.Controls.Add(Panel6)
        club.Controls.Add(club_back)
        club.Controls.Add(club_next)
        club.Controls.Add(club_title)
        club.Controls.Add(club_body)
        club.Controls.Add(Panel2)
        club.Controls.Add(supposed_name)
        club.Location = New Point(4, 5)
        club.Margin = New Padding(4, 3, 4, 3)
        club.Name = "club"
        club.Padding = New Padding(4, 3, 4, 3)
        club.Size = New Size(1140, 638)
        club.TabIndex = 2
        club.Text = "WelcomeUser"
        club.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(PictureBox1)
        Panel6.Location = New Point(18, 33)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(157, 55)
        Panel6.TabIndex = 68
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(58, 12)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 31)
        Label2.TabIndex = 65
        Label2.Text = "BMIMe"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(11, 8)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 66
        PictureBox1.TabStop = False
        ' 
        ' club_back
        ' 
        club_back.Font = New Font("Segoe UI Variable Display", 10F)
        club_back.Image = CType(resources.GetObject("club_back.Image"), Image)
        club_back.Location = New Point(57, 542)
        club_back.Margin = New Padding(4, 3, 4, 3)
        club_back.Name = "club_back"
        club_back.Size = New Size(80, 47)
        club_back.TabIndex = 66
        club_back.TextImageRelation = TextImageRelation.TextBeforeImage
        club_back.UseVisualStyleBackColor = True
        ' 
        ' club_next
        ' 
        club_next.Font = New Font("Segoe UI Variable Display", 10F)
        club_next.Image = CType(resources.GetObject("club_next.Image"), Image)
        club_next.Location = New Point(156, 542)
        club_next.Margin = New Padding(4, 3, 4, 3)
        club_next.Name = "club_next"
        club_next.Size = New Size(141, 47)
        club_next.TabIndex = 65
        club_next.Text = "Next"
        club_next.TextImageRelation = TextImageRelation.TextBeforeImage
        club_next.UseVisualStyleBackColor = True
        ' 
        ' club_title
        ' 
        club_title.BackColor = Color.Transparent
        club_title.Font = New Font("Manrope ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        club_title.ForeColor = Color.Black
        club_title.Location = New Point(40, 134)
        club_title.Margin = New Padding(4, 0, 4, 0)
        club_title.Name = "club_title"
        club_title.Size = New Size(397, 36)
        club_title.TabIndex = 59
        club_title.Text = "Welcome to the club,"
        ' 
        ' club_body
        ' 
        club_body.BackColor = Color.Transparent
        club_body.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        club_body.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        club_body.ImageAlign = ContentAlignment.MiddleLeft
        club_body.Location = New Point(41, 234)
        club_body.Margin = New Padding(4, 0, 4, 0)
        club_body.Name = "club_body"
        club_body.Size = New Size(491, 66)
        club_body.TabIndex = 42
        club_body.Text = "Health is super important! That's why BMIMe is here to help you on how to make yourself ✨more healthy✨."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(248))
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(club_u)
        Panel2.Controls.Add(WelcomeClubPic)
        Panel2.Location = New Point(685, 36)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(424, 531)
        Panel2.TabIndex = 61
        ' 
        ' club_u
        ' 
        club_u.BackColor = Color.Transparent
        club_u.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        club_u.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        club_u.ImageAlign = ContentAlignment.MiddleLeft
        club_u.Location = New Point(68, 383)
        club_u.Margin = New Padding(4, 0, 4, 0)
        club_u.Name = "club_u"
        club_u.Size = New Size(295, 33)
        club_u.TabIndex = 62
        club_u.Text = "This is u while using BMIMe"
        club_u.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' WelcomeClubPic
        ' 
        WelcomeClubPic.Image = CType(resources.GetObject("WelcomeClubPic.Image"), Image)
        WelcomeClubPic.Location = New Point(68, 52)
        WelcomeClubPic.Margin = New Padding(4, 3, 4, 3)
        WelcomeClubPic.Name = "WelcomeClubPic"
        WelcomeClubPic.Size = New Size(295, 314)
        WelcomeClubPic.SizeMode = PictureBoxSizeMode.StretchImage
        WelcomeClubPic.TabIndex = 41
        WelcomeClubPic.TabStop = False
        ' 
        ' supposed_name
        ' 
        supposed_name.BackColor = Color.Transparent
        supposed_name.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        supposed_name.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        supposed_name.Location = New Point(40, 170)
        supposed_name.Margin = New Padding(4, 0, 4, 0)
        supposed_name.Name = "supposed_name"
        supposed_name.Size = New Size(223, 37)
        supposed_name.TabIndex = 40
        supposed_name.Text = "{user}!"
        supposed_name.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' usernameTab
        ' 
        usernameTab.BackColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        usernameTab.Controls.Add(Panel4)
        usernameTab.Controls.Add(usernameTab_back)
        usernameTab.Controls.Add(usernameTab_body2)
        usernameTab.Controls.Add(txtName)
        usernameTab.Controls.Add(usernameTab_body)
        usernameTab.Controls.Add(Panel1)
        usernameTab.Controls.Add(usernameTab_title)
        usernameTab.Controls.Add(usernameTab_next)
        usernameTab.Location = New Point(4, 5)
        usernameTab.Margin = New Padding(4, 3, 4, 3)
        usernameTab.Name = "usernameTab"
        usernameTab.Padding = New Padding(4, 3, 4, 3)
        usernameTab.Size = New Size(1140, 638)
        usernameTab.TabIndex = 1
        usernameTab.Text = "Name"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(NameApp)
        Panel4.Controls.Add(PictureBox6)
        Panel4.Location = New Point(18, 33)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(157, 55)
        Panel4.TabIndex = 67
        ' 
        ' NameApp
        ' 
        NameApp.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameApp.Location = New Point(58, 12)
        NameApp.Margin = New Padding(4, 0, 4, 0)
        NameApp.Name = "NameApp"
        NameApp.Size = New Size(95, 31)
        NameApp.TabIndex = 65
        NameApp.Text = "BMIMe"
        NameApp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(11, 8)
        PictureBox6.Margin = New Padding(4, 3, 4, 3)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(54, 39)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 66
        PictureBox6.TabStop = False
        ' 
        ' usernameTab_back
        ' 
        usernameTab_back.Font = New Font("Segoe UI Variable Display", 10F)
        usernameTab_back.Image = CType(resources.GetObject("usernameTab_back.Image"), Image)
        usernameTab_back.Location = New Point(57, 542)
        usernameTab_back.Margin = New Padding(4, 3, 4, 3)
        usernameTab_back.Name = "usernameTab_back"
        usernameTab_back.Size = New Size(80, 47)
        usernameTab_back.TabIndex = 64
        usernameTab_back.TextImageRelation = TextImageRelation.TextBeforeImage
        usernameTab_back.UseVisualStyleBackColor = True
        ' 
        ' usernameTab_body2
        ' 
        usernameTab_body2.BackColor = Color.Transparent
        usernameTab_body2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTab_body2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        usernameTab_body2.Location = New Point(29, 243)
        usernameTab_body2.Margin = New Padding(4, 0, 4, 0)
        usernameTab_body2.Name = "usernameTab_body2"
        usernameTab_body2.Size = New Size(420, 45)
        usernameTab_body2.TabIndex = 63
        usernameTab_body2.Text = "Type your name down below."
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Manrope", 12F, FontStyle.Bold)
        txtName.Location = New Point(34, 292)
        txtName.Margin = New Padding(4, 3, 4, 3)
        txtName.Name = "txtName"
        txtName.Size = New Size(347, 29)
        txtName.TabIndex = 62
        ' 
        ' usernameTab_body
        ' 
        usernameTab_body.BackColor = Color.Transparent
        usernameTab_body.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTab_body.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        usernameTab_body.Location = New Point(29, 168)
        usernameTab_body.Margin = New Padding(4, 0, 4, 0)
        usernameTab_body.Name = "usernameTab_body"
        usernameTab_body.Size = New Size(465, 75)
        usernameTab_body.TabIndex = 61
        usernameTab_body.Text = "Of course, we have to know your name so that you know that your health is linked to you."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(251), CByte(251), CByte(251))
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(logo)
        Panel1.Location = New Point(615, 13)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(518, 620)
        Panel1.TabIndex = 60
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(178, 524)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(189, 33)
        Label4.TabIndex = 63
        Label4.Text = "ermm.. actually..."
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' logo
        ' 
        logo.Image = CType(resources.GetObject("logo.Image"), Image)
        logo.Location = New Point(59, 78)
        logo.Margin = New Padding(4, 3, 4, 3)
        logo.Name = "logo"
        logo.Size = New Size(411, 430)
        logo.SizeMode = PictureBoxSizeMode.StretchImage
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' usernameTab_title
        ' 
        usernameTab_title.BackColor = Color.Transparent
        usernameTab_title.Font = New Font("Manrope ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTab_title.ForeColor = Color.Black
        usernameTab_title.Location = New Point(28, 121)
        usernameTab_title.Margin = New Padding(4, 0, 4, 0)
        usernameTab_title.Name = "usernameTab_title"
        usernameTab_title.Size = New Size(182, 47)
        usernameTab_title.TabIndex = 58
        usernameTab_title.Text = "Who are you?"
        ' 
        ' usernameTab_next
        ' 
        usernameTab_next.Font = New Font("Segoe UI Variable Display", 10F)
        usernameTab_next.Image = CType(resources.GetObject("usernameTab_next.Image"), Image)
        usernameTab_next.Location = New Point(156, 542)
        usernameTab_next.Margin = New Padding(4, 3, 4, 3)
        usernameTab_next.Name = "usernameTab_next"
        usernameTab_next.Size = New Size(141, 47)
        usernameTab_next.TabIndex = 59
        usernameTab_next.Text = "Next"
        usernameTab_next.TextImageRelation = TextImageRelation.TextBeforeImage
        usernameTab_next.UseVisualStyleBackColor = True
        ' 
        ' welcome
        ' 
        welcome.Controls.Add(welcome_grouplang)
        welcome.Controls.Add(welcome_letsgo)
        welcome.Controls.Add(welcome_body)
        welcome.Controls.Add(welcome_title)
        welcome.Controls.Add(welcome_footer)
        welcome.Controls.Add(welcome_header)
        welcome.Location = New Point(4, 5)
        welcome.Margin = New Padding(4, 3, 4, 3)
        welcome.Name = "welcome"
        welcome.Padding = New Padding(4, 3, 4, 3)
        welcome.Size = New Size(1140, 638)
        welcome.TabIndex = 0
        welcome.Text = "Welcome"
        welcome.UseVisualStyleBackColor = True
        ' 
        ' welcome_grouplang
        ' 
        welcome_grouplang.Controls.Add(welcome_filipino)
        welcome_grouplang.Controls.Add(welcome_english)
        welcome_grouplang.FlatStyle = FlatStyle.Flat
        welcome_grouplang.Font = New Font("Manrope", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcome_grouplang.Location = New Point(379, 263)
        welcome_grouplang.Margin = New Padding(4, 3, 4, 3)
        welcome_grouplang.Name = "welcome_grouplang"
        welcome_grouplang.Padding = New Padding(4, 3, 4, 3)
        welcome_grouplang.Size = New Size(401, 76)
        welcome_grouplang.TabIndex = 60
        welcome_grouplang.TabStop = False
        welcome_grouplang.Text = "Choose your language"
        ' 
        ' welcome_filipino
        ' 
        welcome_filipino.AutoSize = True
        welcome_filipino.Font = New Font("Manrope", 10F, FontStyle.Bold)
        welcome_filipino.Location = New Point(234, 32)
        welcome_filipino.Margin = New Padding(4, 3, 4, 3)
        welcome_filipino.Name = "welcome_filipino"
        welcome_filipino.Size = New Size(77, 23)
        welcome_filipino.TabIndex = 60
        welcome_filipino.TabStop = True
        welcome_filipino.Text = "Filipino"
        welcome_filipino.UseVisualStyleBackColor = True
        ' 
        ' welcome_english
        ' 
        welcome_english.AutoSize = True
        welcome_english.Font = New Font("Manrope", 10F, FontStyle.Bold)
        welcome_english.Location = New Point(70, 32)
        welcome_english.Margin = New Padding(4, 3, 4, 3)
        welcome_english.Name = "welcome_english"
        welcome_english.Size = New Size(78, 23)
        welcome_english.TabIndex = 59
        welcome_english.TabStop = True
        welcome_english.Text = "English"
        welcome_english.UseVisualStyleBackColor = True
        ' 
        ' welcome_letsgo
        ' 
        welcome_letsgo.Font = New Font("Segoe UI Variable Display", 10F)
        welcome_letsgo.Image = CType(resources.GetObject("welcome_letsgo.Image"), Image)
        welcome_letsgo.Location = New Point(516, 387)
        welcome_letsgo.Margin = New Padding(4, 3, 4, 3)
        welcome_letsgo.Name = "welcome_letsgo"
        welcome_letsgo.Size = New Size(133, 47)
        welcome_letsgo.TabIndex = 57
        welcome_letsgo.Text = "Let's Go!"
        welcome_letsgo.TextImageRelation = TextImageRelation.TextBeforeImage
        welcome_letsgo.UseVisualStyleBackColor = True
        ' 
        ' welcome_body
        ' 
        welcome_body.BackColor = Color.Transparent
        welcome_body.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        welcome_body.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        welcome_body.Location = New Point(232, 198)
        welcome_body.Margin = New Padding(4, 0, 4, 0)
        welcome_body.Name = "welcome_body"
        welcome_body.Size = New Size(719, 40)
        welcome_body.TabIndex = 38
        welcome_body.Text = "Before we dive in, let’s get you all set up. "
        welcome_body.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' welcome_title
        ' 
        welcome_title.BackColor = Color.Transparent
        welcome_title.Font = New Font("Manrope ExtraBold", 30.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcome_title.ForeColor = Color.FromArgb(CByte(41), CByte(45), CByte(53))
        welcome_title.Location = New Point(130, 129)
        welcome_title.Margin = New Padding(4, 0, 4, 0)
        welcome_title.Name = "welcome_title"
        welcome_title.Size = New Size(931, 69)
        welcome_title.TabIndex = 37
        welcome_title.Text = "Welcome to BMIMe!"
        welcome_title.TextAlign = ContentAlignment.TopCenter
        ' 
        ' welcome_footer
        ' 
        welcome_footer.Image = CType(resources.GetObject("welcome_footer.Image"), Image)
        welcome_footer.Location = New Point(-5, 576)
        welcome_footer.Margin = New Padding(4, 3, 4, 3)
        welcome_footer.Name = "welcome_footer"
        welcome_footer.Size = New Size(1153, 72)
        welcome_footer.SizeMode = PictureBoxSizeMode.StretchImage
        welcome_footer.TabIndex = 1
        welcome_footer.TabStop = False
        ' 
        ' welcome_header
        ' 
        welcome_header.Image = CType(resources.GetObject("welcome_header.Image"), Image)
        welcome_header.Location = New Point(0, 0)
        welcome_header.Margin = New Padding(4, 3, 4, 3)
        welcome_header.Name = "welcome_header"
        welcome_header.Size = New Size(1148, 72)
        welcome_header.SizeMode = PictureBoxSizeMode.StretchImage
        welcome_header.TabIndex = 0
        welcome_header.TabStop = False
        ' 
        ' OnboardFrame
        ' 
        OnboardFrame.Appearance = TabAppearance.FlatButtons
        OnboardFrame.Controls.Add(welcome)
        OnboardFrame.Controls.Add(usernameTab)
        OnboardFrame.Controls.Add(club)
        OnboardFrame.Controls.Add(legalTab)
        OnboardFrame.Controls.Add(whuTab)
        OnboardFrame.Controls.Add(summaryTab)
        OnboardFrame.Controls.Add(last)
        OnboardFrame.Dock = DockStyle.Fill
        OnboardFrame.ItemSize = New Size(0, 1)
        OnboardFrame.Location = New Point(0, 0)
        OnboardFrame.Margin = New Padding(4, 3, 4, 3)
        OnboardFrame.Name = "OnboardFrame"
        OnboardFrame.SelectedIndex = 0
        OnboardFrame.Size = New Size(1148, 647)
        OnboardFrame.SizeMode = TabSizeMode.Fixed
        OnboardFrame.TabIndex = 0
        ' 
        ' Onboarding
        ' 
        AcceptButton = usernameTab_next
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1148, 647)
        Controls.Add(OnboardFrame)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Onboarding"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Onboarding"
        last.ResumeLayout(False)
        last_panel.ResumeLayout(False)
        CType(last_checkicon, ComponentModel.ISupportInitialize).EndInit()
        summaryTab.ResumeLayout(False)
        summaryPanel.ResumeLayout(False)
        whuTab.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        whuTab_agebox.ResumeLayout(False)
        whuTab_agebox.PerformLayout()
        whuTab_unitBox.ResumeLayout(False)
        whuTab_unitBox.PerformLayout()
        whuTab_heightbox.ResumeLayout(False)
        whuTab_heightbox.PerformLayout()
        whuTab_weightbox.ResumeLayout(False)
        whuTab_weightbox.PerformLayout()
        whuTab_genderbox.ResumeLayout(False)
        whuTab_genderbox.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        legalTab.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        club.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(WelcomeClubPic, ComponentModel.ISupportInitialize).EndInit()
        usernameTab.ResumeLayout(False)
        usernameTab.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        welcome.ResumeLayout(False)
        welcome_grouplang.ResumeLayout(False)
        welcome_grouplang.PerformLayout()
        CType(welcome_footer, ComponentModel.ISupportInitialize).EndInit()
        CType(welcome_header, ComponentModel.ISupportInitialize).EndInit()
        OnboardFrame.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents last As TabPage
    Friend WithEvents summaryTab As TabPage
    Friend WithEvents whuTab As TabPage
    Friend WithEvents legalTab As TabPage
    Friend WithEvents club As TabPage
    Friend WithEvents club_title As Label
    Friend WithEvents club_body As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents club_u As Label
    Friend WithEvents WelcomeClubPic As PictureBox
    Friend WithEvents supposed_name As Label
    Friend WithEvents usernameTab As TabPage
    Friend WithEvents txtName As TextBox
    Friend WithEvents usernameTab_body As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents usernameTab_title As Label
    Friend WithEvents usernameTab_next As Button
    Friend WithEvents welcome As TabPage
    Friend WithEvents welcome_grouplang As GroupBox
    Friend WithEvents welcome_filipino As RadioButton
    Friend WithEvents welcome_english As RadioButton
    Friend WithEvents welcome_letsgo As Button
    Friend WithEvents welcome_body As Label
    Friend WithEvents welcome_title As Label
    Friend WithEvents welcome_footer As PictureBox
    Friend WithEvents welcome_header As PictureBox
    Friend WithEvents OnboardFrame As TabControl
    Friend WithEvents usernameTab_body2 As Label
    Friend WithEvents usernameTab_back As Button
    Friend WithEvents legal_back As Button
    Friend WithEvents legal_body1 As Label
    Friend WithEvents legal_body As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents legal_title As Label
    Friend WithEvents legal_next As Button
    Friend WithEvents legal_privacypolicy As RichTextBox
    Friend WithEvents club_back As Button
    Friend WithEvents club_next As Button
    Friend WithEvents summaryTab_back As Button
    Friend WithEvents summaryTab_next As Button
    Friend WithEvents summaryTab_title As Label
    Friend WithEvents summaryTab_body As Label
    Friend WithEvents summaryPanel As Panel
    Friend WithEvents summaryPanel_age As Label
    Friend WithEvents summaryPanel_height As Label
    Friend WithEvents summaryPanel_weight As Label
    Friend WithEvents summaryPanel_unit As Label
    Friend WithEvents summaryPanel_privacy As Label
    Friend WithEvents summaryPanel_name As Label
    Friend WithEvents summaryPanel_lang As Label
    Friend WithEvents whuTab_weightbox As GroupBox
    Friend WithEvents whuTab_genderbox As GroupBox
    Friend WithEvents genderbox_f As RadioButton
    Friend WithEvents genderbox_m As RadioButton
    Friend WithEvents whuTab_back As Button
    Friend WithEvents whuTab_next As Button
    Friend WithEvents whuTab_title As Label
    Friend WithEvents whuTab_body As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents whuTab_unitBox As GroupBox
    Friend WithEvents whuTab_heightbox As GroupBox
    Friend WithEvents whuTab_hlbl As Label
    Friend WithEvents whuTab_htxt As TextBox
    Friend WithEvents whuTab_wlbl As Label
    Friend WithEvents whuTab_wtxt As TextBox
    Friend WithEvents unitBox_imperial As RadioButton
    Friend WithEvents unitBox_metric As RadioButton
    Friend WithEvents genderbox_other As RadioButton
    Friend WithEvents whuTab_agebox As GroupBox
    Friend WithEvents whuTab_agetxt As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents NameApp As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents last_panel As Panel
    Friend WithEvents last_head As Label
    Friend WithEvents last_checkicon As PictureBox
    Friend WithEvents last_body As Label
    Friend WithEvents last_launchBMIMe As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents summaryTab_disclaimer As Label
End Class
