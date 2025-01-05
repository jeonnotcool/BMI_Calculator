<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        TabControl1 = New TabControl()
        Settings = New TabPage()
        Abt = New TabPage()
        Dashboard = New TabPage()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        Label10 = New Label()
        Label9 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        GroupBox4 = New GroupBox()
        Label16 = New Label()
        ComboBox1 = New ComboBox()
        Label13 = New Label()
        TextBox3 = New TextBox()
        Label12 = New Label()
        TextBox2 = New TextBox()
        Label11 = New Label()
        TextBox1 = New TextBox()
        GroupBox5 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label7 = New Label()
        HomeP = New TabPage()
        aShort = New Label()
        ageLabel = New Label()
        txtAge = New TextBox()
        GroupBox1 = New GroupBox()
        rbImperial = New RadioButton()
        rbMetric = New RadioButton()
        reset = New Button()
        calculate = New Button()
        hShort = New Label()
        wShort = New Label()
        StatusLabel = New Label()
        Status = New Label()
        calcLabel = New Label()
        heightLabel = New Label()
        weighLabel = New Label()
        calculated = New Label()
        txtHeight = New TextBox()
        txtWeight = New TextBox()
        About = New TabPage()
        Label17 = New Label()
        Label18 = New Label()
        Button1 = New Button()
        GroupBox6 = New GroupBox()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        TabControl1.SuspendLayout()
        Dashboard.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        HomeP.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Settings)
        TabControl1.Controls.Add(Abt)
        TabControl1.Controls.Add(Dashboard)
        TabControl1.Controls.Add(HomeP)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.ItemSize = New Size(60, 20)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(890, 558)
        TabControl1.TabIndex = 0
        ' 
        ' Settings
        ' 
        Settings.Font = New Font("Manrope", 8.25F)
        Settings.Location = New Point(4, 24)
        Settings.Name = "Settings"
        Settings.Padding = New Padding(3)
        Settings.Size = New Size(925, 553)
        Settings.TabIndex = 1
        Settings.Text = "Settings"
        Settings.UseVisualStyleBackColor = True
        ' 
        ' Abt
        ' 
        Abt.Location = New Point(4, 24)
        Abt.Name = "Abt"
        Abt.Padding = New Padding(3)
        Abt.Size = New Size(925, 553)
        Abt.TabIndex = 2
        Abt.Text = "About"
        Abt.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        Dashboard.Controls.Add(GroupBox6)
        Dashboard.Controls.Add(GroupBox2)
        Dashboard.Controls.Add(GroupBox3)
        Dashboard.Controls.Add(GroupBox4)
        Dashboard.Controls.Add(Label7)
        Dashboard.Location = New Point(4, 24)
        Dashboard.Name = "Dashboard"
        Dashboard.Size = New Size(882, 530)
        Dashboard.TabIndex = 3
        Dashboard.Text = "Dashboard"
        Dashboard.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Font = New Font("Manrope", 10F, FontStyle.Bold)
        GroupBox2.Location = New Point(20, 110)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(386, 154)
        GroupBox2.TabIndex = 60
        GroupBox2.TabStop = False
        GroupBox2.Text = "Your Information"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Manrope", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(8, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(218, 25)
        Label8.TabIndex = 62
        Label8.Text = "January 6, 2025"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold)
        Label5.Location = New Point(231, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 27)
        Label5.TabIndex = 64
        Label5.Text = "Height"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(229, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 44)
        Label6.TabIndex = 63
        Label6.Text = "185cm"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold)
        Label3.Location = New Point(112, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 27)
        Label3.TabIndex = 62
        Label3.Text = "Weight"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(120, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 44)
        Label4.TabIndex = 61
        Label4.Text = "60kg"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold)
        Label2.Location = New Point(8, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 27)
        Label2.TabIndex = 60
        Label2.Text = "Age"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 44)
        Label1.TabIndex = 59
        Label1.Text = "15"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Font = New Font("Manrope", 10F, FontStyle.Bold)
        GroupBox3.Location = New Point(20, 283)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(184, 154)
        GroupBox3.TabIndex = 65
        GroupBox3.TabStop = False
        GroupBox3.Text = "Last BMI Calculation"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold)
        Label10.Location = New Point(65, 100)
        Label10.Name = "Label10"
        Label10.Size = New Size(119, 27)
        Label10.TabIndex = 63
        Label10.Text = "Good"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Manrope", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(8, 27)
        Label9.Name = "Label9"
        Label9.Size = New Size(176, 25)
        Label9.TabIndex = 62
        Label9.Text = "January 5, 2025"
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold)
        Label14.Location = New Point(8, 61)
        Label14.Name = "Label14"
        Label14.Size = New Size(119, 27)
        Label14.TabIndex = 60
        Label14.Text = "Your BMI was:"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("Segoe UI Variable Display Semib", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(8, 88)
        Label15.Name = "Label15"
        Label15.Size = New Size(50, 44)
        Label15.TabIndex = 59
        Label15.Text = "21"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Button1)
        GroupBox4.Controls.Add(Label18)
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(Label16)
        GroupBox4.Controls.Add(ComboBox1)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(TextBox3)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(TextBox2)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(TextBox1)
        GroupBox4.Controls.Add(GroupBox5)
        GroupBox4.Font = New Font("Manrope", 10F, FontStyle.Bold)
        GroupBox4.Location = New Point(460, 110)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(383, 327)
        GroupBox4.TabIndex = 65
        GroupBox4.TabStop = False
        GroupBox4.Text = "Calculate your BMI"
        ' 
        ' Label16
        ' 
        Label16.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(21, 182)
        Label16.Name = "Label16"
        Label16.Size = New Size(126, 31)
        Label16.TabIndex = 75
        Label16.Text = "Exercise Level"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Select", "Sedentary (Little to No Exercise)", "Lightly Active (1-3 days /wk)", "Moderately Active (3-5 days /wk)", "Very Active (6-7 days /wk)"})
        ComboBox1.Location = New Point(21, 216)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(335, 26)
        ComboBox1.TabIndex = 74
        ComboBox1.Text = "Select"
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(185, 105)
        Label13.Name = "Label13"
        Label13.Size = New Size(80, 31)
        Label13.TabIndex = 73
        Label13.Text = "Height"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        TextBox3.Location = New Point(185, 131)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(84, 32)
        TextBox3.TabIndex = 72
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(20, 105)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 31)
        Label12.TabIndex = 71
        Label12.Text = "Weight"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        TextBox2.Location = New Point(20, 131)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(84, 32)
        TextBox2.TabIndex = 70
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(272, 26)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 31)
        Label11.TabIndex = 69
        Label11.Text = "Age"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        TextBox1.Location = New Point(272, 52)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(84, 32)
        TextBox1.TabIndex = 68
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(RadioButton3)
        GroupBox5.Controls.Add(RadioButton1)
        GroupBox5.Controls.Add(RadioButton2)
        GroupBox5.Font = New Font("Manrope", 10F, FontStyle.Bold)
        GroupBox5.Location = New Point(6, 27)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(250, 61)
        GroupBox5.TabIndex = 66
        GroupBox5.TabStop = False
        GroupBox5.Text = "Gender"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Manrope", 10F, FontStyle.Bold)
        RadioButton3.Location = New Point(165, 25)
        RadioButton3.Margin = New Padding(4, 3, 4, 3)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(66, 23)
        RadioButton3.TabIndex = 63
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Manrope", 10F, FontStyle.Bold)
        RadioButton1.Location = New Point(82, 25)
        RadioButton1.Margin = New Padding(4, 3, 4, 3)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 23)
        RadioButton1.TabIndex = 62
        RadioButton1.TabStop = True
        RadioButton1.Text = "Female"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Manrope", 10F, FontStyle.Bold)
        RadioButton2.Location = New Point(15, 25)
        RadioButton2.Margin = New Padding(4, 3, 4, 3)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(59, 23)
        RadioButton2.TabIndex = 61
        RadioButton2.TabStop = True
        RadioButton2.Text = "Male"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(20, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(218, 39)
        Label7.TabIndex = 61
        Label7.Text = "Hi, Gabriel Martin!"
        ' 
        ' HomeP
        ' 
        HomeP.Controls.Add(aShort)
        HomeP.Controls.Add(ageLabel)
        HomeP.Controls.Add(txtAge)
        HomeP.Controls.Add(GroupBox1)
        HomeP.Controls.Add(reset)
        HomeP.Controls.Add(calculate)
        HomeP.Controls.Add(hShort)
        HomeP.Controls.Add(wShort)
        HomeP.Controls.Add(StatusLabel)
        HomeP.Controls.Add(Status)
        HomeP.Controls.Add(calcLabel)
        HomeP.Controls.Add(heightLabel)
        HomeP.Controls.Add(weighLabel)
        HomeP.Controls.Add(calculated)
        HomeP.Controls.Add(txtHeight)
        HomeP.Controls.Add(txtWeight)
        HomeP.Font = New Font("Manrope", 8.25F)
        HomeP.Location = New Point(4, 24)
        HomeP.Name = "HomeP"
        HomeP.Padding = New Padding(3)
        HomeP.Size = New Size(925, 553)
        HomeP.TabIndex = 0
        HomeP.Text = "Home"
        HomeP.UseVisualStyleBackColor = True
        ' 
        ' aShort
        ' 
        aShort.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        aShort.Location = New Point(476, 206)
        aShort.Name = "aShort"
        aShort.Size = New Size(137, 29)
        aShort.TabIndex = 68
        aShort.Text = "years old"
        ' 
        ' ageLabel
        ' 
        ageLabel.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ageLabel.Location = New Point(376, 161)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(218, 39)
        ageLabel.TabIndex = 67
        ageLabel.Text = "Age"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        txtAge.Location = New Point(386, 203)
        txtAge.Multiline = True
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(84, 32)
        txtAge.TabIndex = 66
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbImperial)
        GroupBox1.Controls.Add(rbMetric)
        GroupBox1.Location = New Point(44, 319)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(216, 66)
        GroupBox1.TabIndex = 65
        GroupBox1.TabStop = False
        GroupBox1.Text = "Unit"
        ' 
        ' rbImperial
        ' 
        rbImperial.AutoSize = True
        rbImperial.Location = New Point(93, 27)
        rbImperial.Name = "rbImperial"
        rbImperial.Size = New Size(98, 19)
        rbImperial.TabIndex = 1
        rbImperial.Text = "imperial lbs/in"
        rbImperial.UseVisualStyleBackColor = True
        ' 
        ' rbMetric
        ' 
        rbMetric.AutoSize = True
        rbMetric.Location = New Point(6, 27)
        rbMetric.Name = "rbMetric"
        rbMetric.Size = New Size(84, 19)
        rbMetric.TabIndex = 0
        rbMetric.Text = "metric kg/m"
        rbMetric.UseVisualStyleBackColor = True
        ' 
        ' reset
        ' 
        reset.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        reset.Location = New Point(423, 412)
        reset.Name = "reset"
        reset.Size = New Size(190, 57)
        reset.TabIndex = 64
        reset.Text = "Reset"
        reset.UseVisualStyleBackColor = True
        ' 
        ' calculate
        ' 
        calculate.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        calculate.Location = New Point(151, 412)
        calculate.Name = "calculate"
        calculate.Size = New Size(190, 57)
        calculate.TabIndex = 63
        calculate.Text = "Calculate"
        calculate.UseVisualStyleBackColor = True
        ' 
        ' hShort
        ' 
        hShort.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hShort.Location = New Point(146, 267)
        hShort.Name = "hShort"
        hShort.Size = New Size(68, 31)
        hShort.TabIndex = 62
        hShort.Text = "m"
        ' 
        ' wShort
        ' 
        wShort.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        wShort.Location = New Point(142, 161)
        wShort.Name = "wShort"
        wShort.Size = New Size(42, 29)
        wShort.TabIndex = 61
        wShort.Text = "kg"
        ' 
        ' StatusLabel
        ' 
        StatusLabel.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusLabel.Location = New Point(394, 254)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New Size(171, 44)
        StatusLabel.TabIndex = 60
        StatusLabel.Text = "Status"
        ' 
        ' Status
        ' 
        Status.BackColor = Color.White
        Status.BorderStyle = BorderStyle.Fixed3D
        Status.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        Status.Location = New Point(399, 301)
        Status.Name = "Status"
        Status.Size = New Size(342, 84)
        Status.TabIndex = 59
        ' 
        ' calcLabel
        ' 
        calcLabel.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calcLabel.Location = New Point(394, 60)
        calcLabel.Name = "calcLabel"
        calcLabel.Size = New Size(200, 44)
        calcLabel.TabIndex = 58
        calcLabel.Text = "Calculated BMI"
        ' 
        ' heightLabel
        ' 
        heightLabel.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        heightLabel.Location = New Point(42, 237)
        heightLabel.Name = "heightLabel"
        heightLabel.Size = New Size(172, 30)
        heightLabel.TabIndex = 57
        heightLabel.Text = "Height"
        ' 
        ' weighLabel
        ' 
        weighLabel.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        weighLabel.Location = New Point(42, 116)
        weighLabel.Name = "weighLabel"
        weighLabel.Size = New Size(218, 39)
        weighLabel.TabIndex = 56
        weighLabel.Text = "Weight"
        ' 
        ' calculated
        ' 
        calculated.BackColor = SystemColors.Control
        calculated.Font = New Font("Segoe UI Variable Display Semib", 25F, FontStyle.Bold)
        calculated.Location = New Point(391, 102)
        calculated.Name = "calculated"
        calculated.Size = New Size(305, 48)
        calculated.TabIndex = 54
        calculated.Text = "wait for update"
        ' 
        ' txtHeight
        ' 
        txtHeight.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        txtHeight.Location = New Point(52, 269)
        txtHeight.Multiline = True
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(84, 32)
        txtHeight.TabIndex = 53
        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        txtWeight.Location = New Point(52, 158)
        txtWeight.Multiline = True
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(84, 32)
        txtWeight.TabIndex = 52
        ' 
        ' About
        ' 
        About.Font = New Font("Manrope", 8.25F)
        About.Location = New Point(4, 24)
        About.Name = "About"
        About.Size = New Size(781, 509)
        About.TabIndex = 2
        About.Text = "About"
        About.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(106, 125)
        Label17.Name = "Label17"
        Label17.Size = New Size(41, 44)
        Label17.TabIndex = 65
        Label17.Text = "kg"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(272, 125)
        Label18.Name = "Label18"
        Label18.Size = New Size(41, 44)
        Label18.TabIndex = 76
        Label18.Text = "in"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Variable Display Semib", 15F, FontStyle.Bold)
        Button1.Location = New Point(97, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 45)
        Button1.TabIndex = 77
        Button1.Text = "Calculate BMI"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(Label19)
        GroupBox6.Controls.Add(Label20)
        GroupBox6.Controls.Add(Label21)
        GroupBox6.Controls.Add(Label22)
        GroupBox6.Font = New Font("Manrope", 10F, FontStyle.Bold)
        GroupBox6.Location = New Point(222, 283)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(184, 154)
        GroupBox6.TabIndex = 66
        GroupBox6.TabStop = False
        GroupBox6.Text = "Last BMI Calculation"
        ' 
        ' Label19
        ' 
        Label19.Font = New Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold)
        Label19.Location = New Point(65, 100)
        Label19.Name = "Label19"
        Label19.Size = New Size(119, 27)
        Label19.TabIndex = 63
        Label19.Text = "Good"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label20
        ' 
        Label20.Font = New Font("Manrope", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(8, 27)
        Label20.Name = "Label20"
        Label20.Size = New Size(176, 25)
        Label20.TabIndex = 62
        Label20.Text = "January 5, 2025"
        ' 
        ' Label21
        ' 
        Label21.Font = New Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold)
        Label21.Location = New Point(8, 61)
        Label21.Name = "Label21"
        Label21.Size = New Size(119, 27)
        Label21.TabIndex = 60
        Label21.Text = "Your BMI was:"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label22
        ' 
        Label22.Font = New Font("Segoe UI Variable Display Semib", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(8, 88)
        Label22.Name = "Label22"
        Label22.Size = New Size(50, 44)
        Label22.TabIndex = 59
        Label22.Text = "21"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(6F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 558)
        Controls.Add(TabControl1)
        Font = New Font("Segoe UI Variable Text", 8.25F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        Dashboard.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        HomeP.ResumeLayout(False)
        HomeP.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox6.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents HomeP As TabPage
    Friend WithEvents RealHomeP As TabPage
    Friend WithEvents Settings As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Home As TabPage
    Friend WithEvents About As TabPage
    Friend WithEvents aShort As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbImperial As RadioButton
    Friend WithEvents rbMetric As RadioButton
    Friend WithEvents reset As Button
    Friend WithEvents calculate As Button
    Friend WithEvents hShort As Label
    Friend WithEvents wShort As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Status As Label
    Friend WithEvents calcLabel As Label
    Friend WithEvents heightLabel As Label
    Friend WithEvents weighLabel As Label
    Friend WithEvents calculated As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Abt As TabPage
    Friend WithEvents Dashboard As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
End Class
