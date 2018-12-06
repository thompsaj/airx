<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnMainCalc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.chkSensibleOnly = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtWheelRPM = New System.Windows.Forms.TextBox()
        Me.ddlModel = New System.Windows.Forms.ComboBox()
        Me.lblPurge = New System.Windows.Forms.Label()
        Me.rbCalcPurge = New System.Windows.Forms.RadioButton()
        Me.rbSetPurge = New System.Windows.Forms.RadioButton()
        Me.txtPurgeAngle = New System.Windows.Forms.TextBox()
        Me.txtWheels = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOutFlow = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFreshFlow = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtInWBSum = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtInDBSum = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtInDBWin = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtInWBWin = New System.Windows.Forms.TextBox()
        Me.txtOutWBWin = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtOutDBWin = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtOutWBSum = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtOutDBSum = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtOutDBbin3 = New System.Windows.Forms.TextBox()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkUseDesignDB = New System.Windows.Forms.CheckBox()
        Me.btnBrowseFileLoc = New System.Windows.Forms.Button()
        Me.btnLoadLocations = New System.Windows.Forms.Button()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ddlCountry = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.ddlRegion = New System.Windows.Forms.ComboBox()
        Me.ddlState = New System.Windows.Forms.ComboBox()
        Me.ddlCity = New System.Windows.Forms.ComboBox()
        Me.txtElev = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtFileLoc = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtSumDemandCost = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtSumElecCost = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtFuelCost = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtWinElecCost = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtSumEER = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtHeatEff = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtHeatCOP = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtHeatIndex = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.chkPrintRpts = New System.Windows.Forms.CheckBox()
        Me.folderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtRptLoc = New System.Windows.Forms.TextBox()
        Me.btnRptLocation = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.btnCalcOutputs = New System.Windows.Forms.Button()
        Me.BtnCalcEnergy = New System.Windows.Forms.Button()
        Me.btnCalcEco = New System.Windows.Forms.Button()
        Me.btnCalcEER = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSSPressT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtESPressT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFanEff = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSSPress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtESPressure = New System.Windows.Forms.TextBox()
        Me.chkTdbEco = New System.Windows.Forms.CheckBox()
        Me.chkhEco = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFeb = New System.Windows.Forms.CheckBox()
        Me.chkMarch = New System.Windows.Forms.CheckBox()
        Me.chkApr = New System.Windows.Forms.CheckBox()
        Me.chkMay = New System.Windows.Forms.CheckBox()
        Me.chkJune = New System.Windows.Forms.CheckBox()
        Me.chkJuly = New System.Windows.Forms.CheckBox()
        Me.chkAug = New System.Windows.Forms.CheckBox()
        Me.chkSept = New System.Windows.Forms.CheckBox()
        Me.chkOct = New System.Windows.Forms.CheckBox()
        Me.chkNov = New System.Windows.Forms.CheckBox()
        Me.chkDec = New System.Windows.Forms.CheckBox()
        Me.chkAllHours = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtSun = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtMon = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtTues = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtWed = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtThurs = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtFri = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtSat = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkJan = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFrostControl = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtTOD0 = New System.Windows.Forms.TextBox()
        Me.chkTOD = New System.Windows.Forms.CheckBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtTOD1 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtTOD2 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtTOD5 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtTOD4 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtTOD3 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtEER = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRTUCapacity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMainCalc
        '
        Me.btnMainCalc.Location = New System.Drawing.Point(525, 359)
        Me.btnMainCalc.Name = "btnMainCalc"
        Me.btnMainCalc.Size = New System.Drawing.Size(127, 23)
        Me.btnMainCalc.TabIndex = 1
        Me.btnMainCalc.Text = "All Calcs"
        Me.btnMainCalc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.chkSensibleOnly)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.txtWheelRPM)
        Me.GroupBox1.Controls.Add(Me.ddlModel)
        Me.GroupBox1.Controls.Add(Me.lblPurge)
        Me.GroupBox1.Controls.Add(Me.rbCalcPurge)
        Me.GroupBox1.Controls.Add(Me.rbSetPurge)
        Me.GroupBox1.Controls.Add(Me.txtPurgeAngle)
        Me.GroupBox1.Controls.Add(Me.txtWheels)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtOutFlow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFreshFlow)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(189, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 217)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unit Data"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(11, 153)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(38, 13)
        Me.Label51.TabIndex = 16
        Me.Label51.Text = "Purge:"
        '
        'chkSensibleOnly
        '
        Me.chkSensibleOnly.AutoSize = True
        Me.chkSensibleOnly.Location = New System.Drawing.Point(14, 120)
        Me.chkSensibleOnly.Name = "chkSensibleOnly"
        Me.chkSensibleOnly.Size = New System.Drawing.Size(98, 17)
        Me.chkSensibleOnly.TabIndex = 15
        Me.chkSensibleOnly.Text = "Sensible ONLY"
        Me.chkSensibleOnly.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(12, 195)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(68, 13)
        Me.Label45.TabIndex = 14
        Me.Label45.Text = "Wheel RPM:"
        '
        'txtWheelRPM
        '
        Me.txtWheelRPM.Location = New System.Drawing.Point(101, 192)
        Me.txtWheelRPM.Name = "txtWheelRPM"
        Me.txtWheelRPM.Size = New System.Drawing.Size(49, 20)
        Me.txtWheelRPM.TabIndex = 13
        Me.txtWheelRPM.Text = "0"
        '
        'ddlModel
        '
        Me.ddlModel.FormattingEnabled = True
        Me.ddlModel.Location = New System.Drawing.Point(52, 16)
        Me.ddlModel.Name = "ddlModel"
        Me.ddlModel.Size = New System.Drawing.Size(104, 21)
        Me.ddlModel.TabIndex = 10
        '
        'lblPurge
        '
        Me.lblPurge.AutoSize = True
        Me.lblPurge.Location = New System.Drawing.Point(11, 174)
        Me.lblPurge.Name = "lblPurge"
        Me.lblPurge.Size = New System.Drawing.Size(68, 13)
        Me.lblPurge.TabIndex = 12
        Me.lblPurge.Text = "Purge Angle:"
        '
        'rbCalcPurge
        '
        Me.rbCalcPurge.AutoSize = True
        Me.rbCalcPurge.Location = New System.Drawing.Point(104, 151)
        Me.rbCalcPurge.Name = "rbCalcPurge"
        Me.rbCalcPurge.Size = New System.Drawing.Size(46, 17)
        Me.rbCalcPurge.TabIndex = 11
        Me.rbCalcPurge.Text = "Calc"
        Me.rbCalcPurge.UseVisualStyleBackColor = True
        '
        'rbSetPurge
        '
        Me.rbSetPurge.AutoSize = True
        Me.rbSetPurge.Checked = True
        Me.rbSetPurge.Location = New System.Drawing.Point(52, 151)
        Me.rbSetPurge.Name = "rbSetPurge"
        Me.rbSetPurge.Size = New System.Drawing.Size(41, 17)
        Me.rbSetPurge.TabIndex = 10
        Me.rbSetPurge.TabStop = True
        Me.rbSetPurge.Text = "Set"
        Me.rbSetPurge.UseVisualStyleBackColor = True
        '
        'txtPurgeAngle
        '
        Me.txtPurgeAngle.Location = New System.Drawing.Point(101, 171)
        Me.txtPurgeAngle.Name = "txtPurgeAngle"
        Me.txtPurgeAngle.Size = New System.Drawing.Size(49, 20)
        Me.txtPurgeAngle.TabIndex = 9
        Me.txtPurgeAngle.Text = "0"
        '
        'txtWheels
        '
        Me.txtWheels.Location = New System.Drawing.Point(107, 85)
        Me.txtWheels.Name = "txtWheels"
        Me.txtWheels.Size = New System.Drawing.Size(49, 20)
        Me.txtWheels.TabIndex = 7
        Me.txtWheels.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Wheels:"
        '
        'txtOutFlow
        '
        Me.txtOutFlow.Location = New System.Drawing.Point(107, 63)
        Me.txtOutFlow.Name = "txtOutFlow"
        Me.txtOutFlow.Size = New System.Drawing.Size(49, 20)
        Me.txtOutFlow.TabIndex = 5
        Me.txtOutFlow.Text = "210"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Out Flow:"
        '
        'txtFreshFlow
        '
        Me.txtFreshFlow.Location = New System.Drawing.Point(107, 41)
        Me.txtFreshFlow.Name = "txtFreshFlow"
        Me.txtFreshFlow.Size = New System.Drawing.Size(49, 20)
        Me.txtFreshFlow.TabIndex = 3
        Me.txtFreshFlow.Text = "210"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fresh Flow:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Model:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtInWBSum)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txtInDBSum)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtInDBWin)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.txtInWBWin)
        Me.GroupBox6.Location = New System.Drawing.Point(2, 136)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(163, 138)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Indoor Conditions"
        '
        'txtInWBSum
        '
        Me.txtInWBSum.Location = New System.Drawing.Point(121, 55)
        Me.txtInWBSum.Name = "txtInWBSum"
        Me.txtInWBSum.Size = New System.Drawing.Size(36, 20)
        Me.txtInWBSum.TabIndex = 3
        Me.txtInWBSum.Text = "62.5"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Indoor WB Summer:"
        '
        'txtInDBSum
        '
        Me.txtInDBSum.Location = New System.Drawing.Point(121, 24)
        Me.txtInDBSum.Name = "txtInDBSum"
        Me.txtInDBSum.Size = New System.Drawing.Size(36, 20)
        Me.txtInDBSum.TabIndex = 1
        Me.txtInDBSum.Text = "75"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Indoor DB Summer:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Indoor DB Winter:"
        '
        'txtInDBWin
        '
        Me.txtInDBWin.Location = New System.Drawing.Point(121, 83)
        Me.txtInDBWin.Name = "txtInDBWin"
        Me.txtInDBWin.Size = New System.Drawing.Size(36, 20)
        Me.txtInDBWin.TabIndex = 9
        Me.txtInDBWin.Text = "72"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Indoor WB Winter:"
        '
        'txtInWBWin
        '
        Me.txtInWBWin.Location = New System.Drawing.Point(121, 111)
        Me.txtInWBWin.Name = "txtInWBWin"
        Me.txtInWBWin.Size = New System.Drawing.Size(36, 20)
        Me.txtInWBWin.TabIndex = 11
        Me.txtInWBWin.Text = "60"
        '
        'txtOutWBWin
        '
        Me.txtOutWBWin.Location = New System.Drawing.Point(123, 364)
        Me.txtOutWBWin.Name = "txtOutWBWin"
        Me.txtOutWBWin.Size = New System.Drawing.Size(36, 20)
        Me.txtOutWBWin.TabIndex = 15
        Me.txtOutWBWin.Text = "72.5"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 367)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "WB Bin 2:"
        '
        'txtOutDBWin
        '
        Me.txtOutDBWin.Location = New System.Drawing.Point(123, 338)
        Me.txtOutDBWin.Name = "txtOutDBWin"
        Me.txtOutDBWin.Size = New System.Drawing.Size(36, 20)
        Me.txtOutDBWin.TabIndex = 13
        Me.txtOutDBWin.Text = "77.5"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 341)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "DB Bin 2:"
        '
        'txtOutWBSum
        '
        Me.txtOutWBSum.Location = New System.Drawing.Point(123, 309)
        Me.txtOutWBSum.Name = "txtOutWBSum"
        Me.txtOutWBSum.Size = New System.Drawing.Size(36, 20)
        Me.txtOutWBSum.TabIndex = 7
        Me.txtOutWBSum.Text = "82.5"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 312)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "WB Bin 1:"
        '
        'txtOutDBSum
        '
        Me.txtOutDBSum.Location = New System.Drawing.Point(123, 280)
        Me.txtOutDBSum.Name = "txtOutDBSum"
        Me.txtOutDBSum.Size = New System.Drawing.Size(36, 20)
        Me.txtOutDBSum.TabIndex = 5
        Me.txtOutDBSum.Text = "87.5"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 283)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "DB Bin 1:"
        '
        'txtOutDBbin3
        '
        Me.txtOutDBbin3.Location = New System.Drawing.Point(123, 390)
        Me.txtOutDBbin3.Name = "txtOutDBbin3"
        Me.txtOutDBbin3.Size = New System.Drawing.Size(36, 20)
        Me.txtOutDBbin3.TabIndex = 2
        Me.txtOutDBbin3.Text = "67.5"
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Location = New System.Drawing.Point(17, 393)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(52, 13)
        Me.Label150.TabIndex = 4
        Me.Label150.Text = "DB Bin 3:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkUseDesignDB)
        Me.GroupBox7.Controls.Add(Me.btnBrowseFileLoc)
        Me.GroupBox7.Controls.Add(Me.btnLoadLocations)
        Me.GroupBox7.Controls.Add(Me.Label53)
        Me.GroupBox7.Controls.Add(Me.ddlCountry)
        Me.GroupBox7.Controls.Add(Me.Label52)
        Me.GroupBox7.Controls.Add(Me.ddlRegion)
        Me.GroupBox7.Controls.Add(Me.ddlState)
        Me.GroupBox7.Controls.Add(Me.ddlCity)
        Me.GroupBox7.Controls.Add(Me.txtElev)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.lblCity)
        Me.GroupBox7.Controls.Add(Me.txtFileLoc)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(350, 120)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        '
        'chkUseDesignDB
        '
        Me.chkUseDesignDB.AutoSize = True
        Me.chkUseDesignDB.Checked = True
        Me.chkUseDesignDB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseDesignDB.Location = New System.Drawing.Point(238, 38)
        Me.chkUseDesignDB.Name = "chkUseDesignDB"
        Me.chkUseDesignDB.Size = New System.Drawing.Size(99, 17)
        Me.chkUseDesignDB.TabIndex = 16
        Me.chkUseDesignDB.Text = "Use Design DB"
        Me.chkUseDesignDB.UseVisualStyleBackColor = True
        '
        'btnBrowseFileLoc
        '
        Me.btnBrowseFileLoc.Location = New System.Drawing.Point(262, 7)
        Me.btnBrowseFileLoc.Name = "btnBrowseFileLoc"
        Me.btnBrowseFileLoc.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseFileLoc.TabIndex = 15
        Me.btnBrowseFileLoc.Text = "Browse ..."
        Me.btnBrowseFileLoc.UseVisualStyleBackColor = True
        '
        'btnLoadLocations
        '
        Me.btnLoadLocations.Location = New System.Drawing.Point(234, 61)
        Me.btnLoadLocations.Name = "btnLoadLocations"
        Me.btnLoadLocations.Size = New System.Drawing.Size(106, 23)
        Me.btnLoadLocations.TabIndex = 14
        Me.btnLoadLocations.Text = "Load Data"
        Me.btnLoadLocations.UseVisualStyleBackColor = True
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(6, 14)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(81, 13)
        Me.Label53.TabIndex = 13
        Me.Label53.Text = "Config File Path"
        '
        'ddlCountry
        '
        Me.ddlCountry.FormattingEnabled = True
        Me.ddlCountry.Location = New System.Drawing.Point(104, 53)
        Me.ddlCountry.Name = "ddlCountry"
        Me.ddlCountry.Size = New System.Drawing.Size(121, 21)
        Me.ddlCountry.TabIndex = 12
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(6, 56)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(46, 13)
        Me.Label52.TabIndex = 11
        Me.Label52.Text = "Country:"
        '
        'ddlRegion
        '
        Me.ddlRegion.FormattingEnabled = True
        Me.ddlRegion.Location = New System.Drawing.Point(104, 33)
        Me.ddlRegion.Name = "ddlRegion"
        Me.ddlRegion.Size = New System.Drawing.Size(121, 21)
        Me.ddlRegion.TabIndex = 10
        '
        'ddlState
        '
        Me.ddlState.FormattingEnabled = True
        Me.ddlState.Location = New System.Drawing.Point(104, 75)
        Me.ddlState.Name = "ddlState"
        Me.ddlState.Size = New System.Drawing.Size(121, 21)
        Me.ddlState.TabIndex = 9
        '
        'ddlCity
        '
        Me.ddlCity.FormattingEnabled = True
        Me.ddlCity.Location = New System.Drawing.Point(104, 96)
        Me.ddlCity.Name = "ddlCity"
        Me.ddlCity.Size = New System.Drawing.Size(121, 21)
        Me.ddlCity.TabIndex = 8
        '
        'txtElev
        '
        Me.txtElev.Enabled = False
        Me.txtElev.Location = New System.Drawing.Point(291, 94)
        Me.txtElev.Name = "txtElev"
        Me.txtElev.Size = New System.Drawing.Size(49, 20)
        Me.txtElev.TabIndex = 7
        Me.txtElev.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(231, 97)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Elevation:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 78)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "State:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(6, 99)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City:"
        '
        'txtFileLoc
        '
        Me.txtFileLoc.Location = New System.Drawing.Point(104, 14)
        Me.txtFileLoc.Name = "txtFileLoc"
        Me.txtFileLoc.Size = New System.Drawing.Size(152, 20)
        Me.txtFileLoc.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Region:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtSumDemandCost)
        Me.GroupBox8.Controls.Add(Me.Label35)
        Me.GroupBox8.Controls.Add(Me.txtSumElecCost)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Controls.Add(Me.txtFuelCost)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.txtWinElecCost)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.txtSumEER)
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Controls.Add(Me.txtHeatEff)
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Controls.Add(Me.txtHeatCOP)
        Me.GroupBox8.Controls.Add(Me.Label33)
        Me.GroupBox8.Controls.Add(Me.txtHeatIndex)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Location = New System.Drawing.Point(391, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(177, 250)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Utility Data"
        '
        'txtSumDemandCost
        '
        Me.txtSumDemandCost.Location = New System.Drawing.Point(134, 215)
        Me.txtSumDemandCost.Name = "txtSumDemandCost"
        Me.txtSumDemandCost.Size = New System.Drawing.Size(36, 20)
        Me.txtSumDemandCost.TabIndex = 17
        Me.txtSumDemandCost.Text = "10"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(15, 107)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 13)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "Summer EER:"
        '
        'txtSumElecCost
        '
        Me.txtSumElecCost.Location = New System.Drawing.Point(134, 187)
        Me.txtSumElecCost.Name = "txtSumElecCost"
        Me.txtSumElecCost.Size = New System.Drawing.Size(36, 20)
        Me.txtSumElecCost.TabIndex = 15
        Me.txtSumElecCost.Text = "0.1"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 191)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Summer Elec Cost:"
        '
        'txtFuelCost
        '
        Me.txtFuelCost.Location = New System.Drawing.Point(134, 159)
        Me.txtFuelCost.Name = "txtFuelCost"
        Me.txtFuelCost.Size = New System.Drawing.Size(36, 20)
        Me.txtFuelCost.TabIndex = 13
        Me.txtFuelCost.Text = "10"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(15, 163)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(54, 13)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "Fuel Cost:"
        '
        'txtWinElecCost
        '
        Me.txtWinElecCost.Location = New System.Drawing.Point(134, 131)
        Me.txtWinElecCost.Name = "txtWinElecCost"
        Me.txtWinElecCost.Size = New System.Drawing.Size(36, 20)
        Me.txtWinElecCost.TabIndex = 11
        Me.txtWinElecCost.Text = "0.1"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(15, 134)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(89, 13)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Winter Elec Cost:"
        '
        'txtSumEER
        '
        Me.txtSumEER.Location = New System.Drawing.Point(134, 103)
        Me.txtSumEER.Name = "txtSumEER"
        Me.txtSumEER.Size = New System.Drawing.Size(36, 20)
        Me.txtSumEER.TabIndex = 9
        Me.txtSumEER.Text = "10"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(15, 219)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(115, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Summer Demand Cost:"
        '
        'txtHeatEff
        '
        Me.txtHeatEff.Location = New System.Drawing.Point(134, 75)
        Me.txtHeatEff.Name = "txtHeatEff"
        Me.txtHeatEff.Size = New System.Drawing.Size(36, 20)
        Me.txtHeatEff.TabIndex = 5
        Me.txtHeatEff.Text = "78"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(15, 80)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 13)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Heating EFF:"
        '
        'txtHeatCOP
        '
        Me.txtHeatCOP.Location = New System.Drawing.Point(134, 47)
        Me.txtHeatCOP.Name = "txtHeatCOP"
        Me.txtHeatCOP.Size = New System.Drawing.Size(36, 20)
        Me.txtHeatCOP.TabIndex = 3
        Me.txtHeatCOP.Text = "4.395"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(15, 53)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 13)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Heating COP:"
        '
        'txtHeatIndex
        '
        Me.txtHeatIndex.Location = New System.Drawing.Point(134, 19)
        Me.txtHeatIndex.Name = "txtHeatIndex"
        Me.txtHeatIndex.Size = New System.Drawing.Size(36, 20)
        Me.txtHeatIndex.TabIndex = 1
        Me.txtHeatIndex.Text = "0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(15, 26)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Heating Index:"
        '
        'chkPrintRpts
        '
        Me.chkPrintRpts.AutoSize = True
        Me.chkPrintRpts.Location = New System.Drawing.Point(391, 357)
        Me.chkPrintRpts.Name = "chkPrintRpts"
        Me.chkPrintRpts.Size = New System.Drawing.Size(106, 17)
        Me.chkPrintRpts.TabIndex = 14
        Me.chkPrintRpts.Text = "Print Report Files"
        Me.chkPrintRpts.UseVisualStyleBackColor = True
        '
        'txtRptLoc
        '
        Me.txtRptLoc.Location = New System.Drawing.Point(480, 275)
        Me.txtRptLoc.Name = "txtRptLoc"
        Me.txtRptLoc.Size = New System.Drawing.Size(70, 20)
        Me.txtRptLoc.TabIndex = 16
        '
        'btnRptLocation
        '
        Me.btnRptLocation.Location = New System.Drawing.Point(556, 273)
        Me.btnRptLocation.Name = "btnRptLocation"
        Me.btnRptLocation.Size = New System.Drawing.Size(91, 23)
        Me.btnRptLocation.TabIndex = 17
        Me.btnRptLocation.Text = "Select Location"
        Me.btnRptLocation.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(393, 278)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(86, 13)
        Me.Label50.TabIndex = 18
        Me.Label50.Text = "Report Location:"
        '
        'btnCalcOutputs
        '
        Me.btnCalcOutputs.Location = New System.Drawing.Point(391, 300)
        Me.btnCalcOutputs.Name = "btnCalcOutputs"
        Me.btnCalcOutputs.Size = New System.Drawing.Size(127, 23)
        Me.btnCalcOutputs.TabIndex = 19
        Me.btnCalcOutputs.Text = "Design Point"
        Me.btnCalcOutputs.UseVisualStyleBackColor = True
        '
        'BtnCalcEnergy
        '
        Me.BtnCalcEnergy.Location = New System.Drawing.Point(391, 329)
        Me.BtnCalcEnergy.Name = "BtnCalcEnergy"
        Me.BtnCalcEnergy.Size = New System.Drawing.Size(127, 23)
        Me.BtnCalcEnergy.TabIndex = 20
        Me.BtnCalcEnergy.Text = "Energy Calcs"
        Me.BtnCalcEnergy.UseVisualStyleBackColor = True
        '
        'btnCalcEco
        '
        Me.btnCalcEco.Location = New System.Drawing.Point(525, 300)
        Me.btnCalcEco.Name = "btnCalcEco"
        Me.btnCalcEco.Size = New System.Drawing.Size(127, 23)
        Me.btnCalcEco.TabIndex = 21
        Me.btnCalcEco.Text = "Economic Calcs"
        Me.btnCalcEco.UseVisualStyleBackColor = True
        '
        'btnCalcEER
        '
        Me.btnCalcEER.Location = New System.Drawing.Point(525, 329)
        Me.btnCalcEER.Name = "btnCalcEER"
        Me.btnCalcEER.Size = New System.Drawing.Size(127, 23)
        Me.btnCalcEER.TabIndex = 22
        Me.btnCalcEER.Text = "System Efficiency Calcs"
        Me.btnCalcEER.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "SS Pressure T:"
        '
        'txtSSPressT
        '
        Me.txtSSPressT.Location = New System.Drawing.Point(105, 17)
        Me.txtSSPressT.Name = "txtSSPressT"
        Me.txtSSPressT.Size = New System.Drawing.Size(33, 20)
        Me.txtSSPressT.TabIndex = 1
        Me.txtSSPressT.Text = "oa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ES Pressure T"
        '
        'txtESPressT
        '
        Me.txtESPressT.Location = New System.Drawing.Point(105, 42)
        Me.txtESPressT.Name = "txtESPressT"
        Me.txtESPressT.Size = New System.Drawing.Size(33, 20)
        Me.txtESPressT.TabIndex = 3
        Me.txtESPressT.Text = "ra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Fan Eff:"
        '
        'txtFanEff
        '
        Me.txtFanEff.Location = New System.Drawing.Point(104, 129)
        Me.txtFanEff.Name = "txtFanEff"
        Me.txtFanEff.Size = New System.Drawing.Size(34, 20)
        Me.txtFanEff.TabIndex = 5
        Me.txtFanEff.Text = "40.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SS Pressure:"
        '
        'txtSSPress
        '
        Me.txtSSPress.Location = New System.Drawing.Point(105, 70)
        Me.txtSSPress.Name = "txtSSPress"
        Me.txtSSPress.Size = New System.Drawing.Size(33, 20)
        Me.txtSSPress.TabIndex = 13
        Me.txtSSPress.Text = "-0.1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ES Pressure:"
        '
        'txtESPressure
        '
        Me.txtESPressure.Location = New System.Drawing.Point(105, 96)
        Me.txtESPressure.Name = "txtESPressure"
        Me.txtESPressure.Size = New System.Drawing.Size(33, 20)
        Me.txtESPressure.TabIndex = 15
        Me.txtESPressure.Text = "-0.1"
        '
        'chkTdbEco
        '
        Me.chkTdbEco.AutoSize = True
        Me.chkTdbEco.Location = New System.Drawing.Point(17, 161)
        Me.chkTdbEco.Name = "chkTdbEco"
        Me.chkTdbEco.Size = New System.Drawing.Size(134, 17)
        Me.chkTdbEco.TabIndex = 16
        Me.chkTdbEco.Text = "Tdb based economiser"
        Me.chkTdbEco.UseVisualStyleBackColor = True
        Me.chkTdbEco.Visible = False
        '
        'chkhEco
        '
        Me.chkhEco.AutoSize = True
        Me.chkhEco.Location = New System.Drawing.Point(17, 187)
        Me.chkhEco.Name = "chkhEco"
        Me.chkhEco.Size = New System.Drawing.Size(121, 17)
        Me.chkhEco.TabIndex = 17
        Me.chkhEco.Text = "h based economiser"
        Me.chkhEco.UseVisualStyleBackColor = True
        Me.chkhEco.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkhEco)
        Me.GroupBox2.Controls.Add(Me.chkTdbEco)
        Me.GroupBox2.Controls.Add(Me.txtESPressure)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSSPress)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtFanEff)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtESPressT)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtSSPressT)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(574, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 250)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pressures"
        '
        'chkFeb
        '
        Me.chkFeb.AutoSize = True
        Me.chkFeb.Checked = True
        Me.chkFeb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFeb.Location = New System.Drawing.Point(64, 19)
        Me.chkFeb.Name = "chkFeb"
        Me.chkFeb.Size = New System.Drawing.Size(67, 17)
        Me.chkFeb.TabIndex = 1
        Me.chkFeb.Text = "February"
        Me.chkFeb.UseVisualStyleBackColor = True
        '
        'chkMarch
        '
        Me.chkMarch.AutoSize = True
        Me.chkMarch.Checked = True
        Me.chkMarch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMarch.Location = New System.Drawing.Point(133, 19)
        Me.chkMarch.Name = "chkMarch"
        Me.chkMarch.Size = New System.Drawing.Size(56, 17)
        Me.chkMarch.TabIndex = 2
        Me.chkMarch.Text = "March"
        Me.chkMarch.UseVisualStyleBackColor = True
        '
        'chkApr
        '
        Me.chkApr.AutoSize = True
        Me.chkApr.Checked = True
        Me.chkApr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkApr.Location = New System.Drawing.Point(210, 19)
        Me.chkApr.Name = "chkApr"
        Me.chkApr.Size = New System.Drawing.Size(46, 17)
        Me.chkApr.TabIndex = 3
        Me.chkApr.Text = "April"
        Me.chkApr.UseVisualStyleBackColor = True
        '
        'chkMay
        '
        Me.chkMay.AutoSize = True
        Me.chkMay.Checked = True
        Me.chkMay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMay.Location = New System.Drawing.Point(269, 19)
        Me.chkMay.Name = "chkMay"
        Me.chkMay.Size = New System.Drawing.Size(46, 17)
        Me.chkMay.TabIndex = 4
        Me.chkMay.Text = "May"
        Me.chkMay.UseVisualStyleBackColor = True
        '
        'chkJune
        '
        Me.chkJune.AutoSize = True
        Me.chkJune.Checked = True
        Me.chkJune.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJune.Location = New System.Drawing.Point(344, 19)
        Me.chkJune.Name = "chkJune"
        Me.chkJune.Size = New System.Drawing.Size(49, 17)
        Me.chkJune.TabIndex = 5
        Me.chkJune.Text = "June"
        Me.chkJune.UseVisualStyleBackColor = True
        '
        'chkJuly
        '
        Me.chkJuly.AutoSize = True
        Me.chkJuly.Checked = True
        Me.chkJuly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJuly.Location = New System.Drawing.Point(6, 42)
        Me.chkJuly.Name = "chkJuly"
        Me.chkJuly.Size = New System.Drawing.Size(44, 17)
        Me.chkJuly.TabIndex = 6
        Me.chkJuly.Text = "July"
        Me.chkJuly.UseVisualStyleBackColor = True
        '
        'chkAug
        '
        Me.chkAug.AutoSize = True
        Me.chkAug.Checked = True
        Me.chkAug.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAug.Location = New System.Drawing.Point(64, 42)
        Me.chkAug.Name = "chkAug"
        Me.chkAug.Size = New System.Drawing.Size(59, 17)
        Me.chkAug.TabIndex = 7
        Me.chkAug.Text = "August"
        Me.chkAug.UseVisualStyleBackColor = True
        '
        'chkSept
        '
        Me.chkSept.AutoSize = True
        Me.chkSept.Checked = True
        Me.chkSept.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSept.Location = New System.Drawing.Point(133, 42)
        Me.chkSept.Name = "chkSept"
        Me.chkSept.Size = New System.Drawing.Size(77, 17)
        Me.chkSept.TabIndex = 8
        Me.chkSept.Text = "September"
        Me.chkSept.UseVisualStyleBackColor = True
        '
        'chkOct
        '
        Me.chkOct.AutoSize = True
        Me.chkOct.Checked = True
        Me.chkOct.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOct.Location = New System.Drawing.Point(210, 42)
        Me.chkOct.Name = "chkOct"
        Me.chkOct.Size = New System.Drawing.Size(64, 17)
        Me.chkOct.TabIndex = 9
        Me.chkOct.Text = "October"
        Me.chkOct.UseVisualStyleBackColor = True
        '
        'chkNov
        '
        Me.chkNov.AutoSize = True
        Me.chkNov.Checked = True
        Me.chkNov.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNov.Location = New System.Drawing.Point(269, 42)
        Me.chkNov.Name = "chkNov"
        Me.chkNov.Size = New System.Drawing.Size(75, 17)
        Me.chkNov.TabIndex = 10
        Me.chkNov.Text = "November"
        Me.chkNov.UseVisualStyleBackColor = True
        '
        'chkDec
        '
        Me.chkDec.AutoSize = True
        Me.chkDec.Checked = True
        Me.chkDec.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDec.Location = New System.Drawing.Point(344, 42)
        Me.chkDec.Name = "chkDec"
        Me.chkDec.Size = New System.Drawing.Size(75, 17)
        Me.chkDec.TabIndex = 11
        Me.chkDec.Text = "December"
        Me.chkDec.UseVisualStyleBackColor = True
        '
        'chkAllHours
        '
        Me.chkAllHours.AutoSize = True
        Me.chkAllHours.Checked = True
        Me.chkAllHours.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAllHours.Location = New System.Drawing.Point(291, 93)
        Me.chkAllHours.Name = "chkAllHours"
        Me.chkAllHours.Size = New System.Drawing.Size(100, 17)
        Me.chkAllHours.TabIndex = 12
        Me.chkAllHours.Text = "All Hours (24/7)"
        Me.chkAllHours.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 68)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 13)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Sunday"
        '
        'txtSun
        '
        Me.txtSun.Location = New System.Drawing.Point(54, 65)
        Me.txtSun.Name = "txtSun"
        Me.txtSun.Size = New System.Drawing.Size(37, 20)
        Me.txtSun.TabIndex = 14
        Me.txtSun.Text = "1111111111111111111111"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(96, 66)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(45, 13)
        Me.Label42.TabIndex = 15
        Me.Label42.Text = "Monday"
        '
        'txtMon
        '
        Me.txtMon.Location = New System.Drawing.Point(150, 66)
        Me.txtMon.Name = "txtMon"
        Me.txtMon.Size = New System.Drawing.Size(37, 20)
        Me.txtMon.TabIndex = 16
        Me.txtMon.Text = "1111111111111111111111"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(194, 67)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(48, 13)
        Me.Label54.TabIndex = 17
        Me.Label54.Text = "Tuesday"
        '
        'txtTues
        '
        Me.txtTues.Location = New System.Drawing.Point(246, 64)
        Me.txtTues.Name = "txtTues"
        Me.txtTues.Size = New System.Drawing.Size(37, 20)
        Me.txtTues.TabIndex = 18
        Me.txtTues.Text = "1111111111111111111111"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(288, 68)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(69, 13)
        Me.Label57.TabIndex = 19
        Me.Label57.Text = "Wednessday"
        '
        'txtWed
        '
        Me.txtWed.Location = New System.Drawing.Point(362, 68)
        Me.txtWed.Name = "txtWed"
        Me.txtWed.Size = New System.Drawing.Size(37, 20)
        Me.txtWed.TabIndex = 20
        Me.txtWed.Text = "1111111111111111111111"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(5, 93)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(51, 13)
        Me.Label56.TabIndex = 21
        Me.Label56.Text = "Thursday"
        '
        'txtThurs
        '
        Me.txtThurs.Location = New System.Drawing.Point(54, 90)
        Me.txtThurs.Name = "txtThurs"
        Me.txtThurs.Size = New System.Drawing.Size(37, 20)
        Me.txtThurs.TabIndex = 22
        Me.txtThurs.Text = "1111111111111111111111"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(97, 94)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(35, 13)
        Me.Label55.TabIndex = 23
        Me.Label55.Text = "Friday"
        '
        'txtFri
        '
        Me.txtFri.Location = New System.Drawing.Point(150, 91)
        Me.txtFri.Name = "txtFri"
        Me.txtFri.Size = New System.Drawing.Size(37, 20)
        Me.txtFri.TabIndex = 24
        Me.txtFri.Text = "1111111111111111111111"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(193, 91)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(49, 13)
        Me.Label58.TabIndex = 25
        Me.Label58.Text = "Saturday"
        '
        'txtSat
        '
        Me.txtSat.Location = New System.Drawing.Point(248, 88)
        Me.txtSat.Name = "txtSat"
        Me.txtSat.Size = New System.Drawing.Size(37, 20)
        Me.txtSat.TabIndex = 26
        Me.txtSat.Text = "1111111111111111111111"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtSat)
        Me.GroupBox10.Controls.Add(Me.Label58)
        Me.GroupBox10.Controls.Add(Me.txtFri)
        Me.GroupBox10.Controls.Add(Me.Label55)
        Me.GroupBox10.Controls.Add(Me.txtThurs)
        Me.GroupBox10.Controls.Add(Me.Label56)
        Me.GroupBox10.Controls.Add(Me.Label57)
        Me.GroupBox10.Controls.Add(Me.txtTues)
        Me.GroupBox10.Controls.Add(Me.txtWed)
        Me.GroupBox10.Controls.Add(Me.Label54)
        Me.GroupBox10.Controls.Add(Me.Label42)
        Me.GroupBox10.Controls.Add(Me.txtSun)
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Controls.Add(Me.chkAllHours)
        Me.GroupBox10.Controls.Add(Me.txtMon)
        Me.GroupBox10.Controls.Add(Me.chkDec)
        Me.GroupBox10.Controls.Add(Me.chkNov)
        Me.GroupBox10.Controls.Add(Me.chkOct)
        Me.GroupBox10.Controls.Add(Me.chkSept)
        Me.GroupBox10.Controls.Add(Me.chkAug)
        Me.GroupBox10.Controls.Add(Me.chkJuly)
        Me.GroupBox10.Controls.Add(Me.chkJune)
        Me.GroupBox10.Controls.Add(Me.chkMay)
        Me.GroupBox10.Controls.Add(Me.chkApr)
        Me.GroupBox10.Controls.Add(Me.chkMarch)
        Me.GroupBox10.Controls.Add(Me.chkFeb)
        Me.GroupBox10.Controls.Add(Me.chkJan)
        Me.GroupBox10.Location = New System.Drawing.Point(653, 266)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(422, 120)
        Me.GroupBox10.TabIndex = 13
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Scheduling"
        '
        'chkJan
        '
        Me.chkJan.AutoSize = True
        Me.chkJan.Checked = True
        Me.chkJan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJan.Location = New System.Drawing.Point(6, 19)
        Me.chkJan.Name = "chkJan"
        Me.chkJan.Size = New System.Drawing.Size(63, 17)
        Me.chkJan.TabIndex = 0
        Me.chkJan.Text = "January"
        Me.chkJan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "PreHeat:"
        '
        'txtFrostControl
        '
        Me.txtFrostControl.Location = New System.Drawing.Point(81, 17)
        Me.txtFrostControl.Name = "txtFrostControl"
        Me.txtFrostControl.Size = New System.Drawing.Size(16, 20)
        Me.txtFrostControl.TabIndex = 16
        Me.txtFrostControl.Text = "0"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(97, 20)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(60, 13)
        Me.Label41.TabIndex = 17
        Me.Label41.Text = "0/1 Off/On"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "RPM"
        Me.Label8.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(16, 20)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Text = "0"
        Me.TextBox1.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(11, 124)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(68, 13)
        Me.Label44.TabIndex = 21
        Me.Label44.Text = "Return Heat:"
        Me.Label44.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(16, 20)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "0"
        Me.TextBox2.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(97, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "0/1 Off/On"
        Me.Label13.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(11, 96)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(57, 13)
        Me.Label47.TabIndex = 24
        Me.Label47.Text = "Stop / Jog"
        Me.Label47.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(81, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(16, 20)
        Me.TextBox4.TabIndex = 25
        Me.TextBox4.Text = "0"
        Me.TextBox4.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(97, 96)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(60, 13)
        Me.Label46.TabIndex = 26
        Me.Label46.Text = "0/1 Off/On"
        Me.Label46.Visible = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(11, 44)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(42, 13)
        Me.Label49.TabIndex = 27
        Me.Label49.Text = "ByPass"
        Me.Label49.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(81, 41)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(16, 20)
        Me.TextBox5.TabIndex = 28
        Me.TextBox5.Text = "0"
        Me.TextBox5.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(97, 44)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(60, 13)
        Me.Label48.TabIndex = 29
        Me.Label48.Text = "0/1 Off/On"
        Me.Label48.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(99, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "0/1 Off/On"
        Me.Label7.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label48)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.txtFrostControl)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(912, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(163, 145)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Frost Control"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(22, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(78, 13)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "MidNight - 4am"
        '
        'txtTOD0
        '
        Me.txtTOD0.Location = New System.Drawing.Point(119, 42)
        Me.txtTOD0.Name = "txtTOD0"
        Me.txtTOD0.Size = New System.Drawing.Size(34, 20)
        Me.txtTOD0.TabIndex = 3
        Me.txtTOD0.Text = "0.1"
        '
        'chkTOD
        '
        Me.chkTOD.AutoSize = True
        Me.chkTOD.Location = New System.Drawing.Point(15, 19)
        Me.chkTOD.Name = "chkTOD"
        Me.chkTOD.Size = New System.Drawing.Size(131, 17)
        Me.chkTOD.TabIndex = 4
        Me.chkTOD.Text = "Use Time of Day rates"
        Me.chkTOD.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(22, 73)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 13)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "4am - 8am"
        '
        'txtTOD1
        '
        Me.txtTOD1.Location = New System.Drawing.Point(119, 67)
        Me.txtTOD1.Name = "txtTOD1"
        Me.txtTOD1.Size = New System.Drawing.Size(34, 20)
        Me.txtTOD1.TabIndex = 6
        Me.txtTOD1.Text = "0.1"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(22, 98)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(62, 13)
        Me.Label38.TabIndex = 7
        Me.Label38.Text = "8am - Noon"
        '
        'txtTOD2
        '
        Me.txtTOD2.Location = New System.Drawing.Point(119, 92)
        Me.txtTOD2.Name = "txtTOD2"
        Me.txtTOD2.Size = New System.Drawing.Size(34, 20)
        Me.txtTOD2.TabIndex = 8
        Me.txtTOD2.Text = "0.1"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(22, 174)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(76, 13)
        Me.Label39.TabIndex = 9
        Me.Label39.Text = "8pm - Midnight"
        '
        'txtTOD5
        '
        Me.txtTOD5.Location = New System.Drawing.Point(119, 168)
        Me.txtTOD5.Name = "txtTOD5"
        Me.txtTOD5.Size = New System.Drawing.Size(34, 20)
        Me.txtTOD5.TabIndex = 10
        Me.txtTOD5.Text = "0.1"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(22, 149)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 13)
        Me.Label40.TabIndex = 11
        Me.Label40.Text = "4pm - 8pm"
        '
        'txtTOD4
        '
        Me.txtTOD4.Location = New System.Drawing.Point(119, 143)
        Me.txtTOD4.Name = "txtTOD4"
        Me.txtTOD4.Size = New System.Drawing.Size(34, 20)
        Me.txtTOD4.TabIndex = 12
        Me.txtTOD4.Text = "0.1"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(22, 124)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(62, 13)
        Me.Label43.TabIndex = 15
        Me.Label43.Text = "Noon - 4pm"
        '
        'txtTOD3
        '
        Me.txtTOD3.Location = New System.Drawing.Point(119, 118)
        Me.txtTOD3.Name = "txtTOD3"
        Me.txtTOD3.Size = New System.Drawing.Size(34, 20)
        Me.txtTOD3.TabIndex = 16
        Me.txtTOD3.Text = "0.1"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtTOD3)
        Me.GroupBox9.Controls.Add(Me.Label43)
        Me.GroupBox9.Controls.Add(Me.txtTOD4)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Controls.Add(Me.txtTOD5)
        Me.GroupBox9.Controls.Add(Me.Label39)
        Me.GroupBox9.Controls.Add(Me.txtTOD2)
        Me.GroupBox9.Controls.Add(Me.Label38)
        Me.GroupBox9.Controls.Add(Me.txtTOD1)
        Me.GroupBox9.Controls.Add(Me.Label37)
        Me.GroupBox9.Controls.Add(Me.chkTOD)
        Me.GroupBox9.Controls.Add(Me.txtTOD0)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Location = New System.Drawing.Point(743, 10)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(163, 252)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Time of Day"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtEER)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtRTUCapacity)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(912, 162)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(163, 100)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Combined Efficiency"
        '
        'txtEER
        '
        Me.txtEER.Location = New System.Drawing.Point(105, 44)
        Me.txtEER.Name = "txtEER"
        Me.txtEER.Size = New System.Drawing.Size(49, 20)
        Me.txtEER.TabIndex = 3
        Me.txtEER.Text = "10"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "RTU EER"
        '
        'txtRTUCapacity
        '
        Me.txtRTUCapacity.Location = New System.Drawing.Point(105, 19)
        Me.txtRTUCapacity.Name = "txtRTUCapacity"
        Me.txtRTUCapacity.Size = New System.Drawing.Size(49, 20)
        Me.txtRTUCapacity.TabIndex = 1
        Me.txtRTUCapacity.Text = "200000"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "RTU Capacity:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 665)
        Me.Controls.Add(Me.txtOutWBWin)
        Me.Controls.Add(Me.btnCalcEER)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnCalcEco)
        Me.Controls.Add(Me.txtOutDBWin)
        Me.Controls.Add(Me.BtnCalcEnergy)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnCalcOutputs)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.btnRptLocation)
        Me.Controls.Add(Me.txtRptLoc)
        Me.Controls.Add(Me.chkPrintRpts)
        Me.Controls.Add(Me.txtOutWBSum)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.txtOutDBSum)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtOutDBbin3)
        Me.Controls.Add(Me.Label150)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMainCalc)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "DLL Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainCalc As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWheels As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOutFlow As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFreshFlow As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutWBWin As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtOutDBWin As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtInWBWin As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtInDBWin As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtOutWBSum As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtOutDBSum As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    'Bin 3
    Friend WithEvents txtOutDBbin3 As System.Windows.Forms.TextBox
    Friend WithEvents Label150 As System.Windows.Forms.Label

    Friend WithEvents txtInWBSum As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtInDBSum As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtElev As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtFileLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSumDemandCost As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtSumElecCost As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtFuelCost As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtWinElecCost As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtSumEER As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtHeatEff As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtHeatCOP As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtHeatIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtPurgeAngle As System.Windows.Forms.TextBox
    Friend WithEvents rbCalcPurge As System.Windows.Forms.RadioButton
    Friend WithEvents rbSetPurge As System.Windows.Forms.RadioButton
    Friend WithEvents lblPurge As System.Windows.Forms.Label
    Friend WithEvents ddlState As System.Windows.Forms.ComboBox
    Friend WithEvents ddlCity As System.Windows.Forms.ComboBox
    Friend WithEvents ddlModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtWheelRPM As System.Windows.Forms.TextBox
    Friend WithEvents chkPrintRpts As System.Windows.Forms.CheckBox
    Friend WithEvents folderDialog As System.Windows.Forms.FolderBrowserDialog
    'Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRptLoc As System.Windows.Forms.TextBox
    Friend WithEvents btnRptLocation As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents btnCalcOutputs As System.Windows.Forms.Button
    Friend WithEvents BtnCalcEnergy As System.Windows.Forms.Button
    Friend WithEvents btnCalcEco As System.Windows.Forms.Button
    Friend WithEvents btnCalcEER As System.Windows.Forms.Button
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents chkSensibleOnly As System.Windows.Forms.CheckBox
    Friend WithEvents ddlRegion As System.Windows.Forms.ComboBox
    Friend WithEvents ddlCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents btnLoadLocations As System.Windows.Forms.Button
    Friend WithEvents btnBrowseFileLoc As System.Windows.Forms.Button
    Friend WithEvents chkUseDesignDB As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSSPressT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtESPressT As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFanEff As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSSPress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtESPressure As TextBox
    Friend WithEvents chkTdbEco As CheckBox
    Friend WithEvents chkhEco As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkFeb As CheckBox
    Friend WithEvents chkMarch As CheckBox
    Friend WithEvents chkApr As CheckBox
    Friend WithEvents chkMay As CheckBox
    Friend WithEvents chkJune As CheckBox
    Friend WithEvents chkJuly As CheckBox
    Friend WithEvents chkAug As CheckBox
    Friend WithEvents chkSept As CheckBox
    Friend WithEvents chkOct As CheckBox
    Friend WithEvents chkNov As CheckBox
    Friend WithEvents chkDec As CheckBox
    Friend WithEvents chkAllHours As CheckBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtSun As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtMon As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtTues As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents txtWed As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents txtThurs As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtFri As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents txtSat As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFrostControl As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtTOD0 As TextBox
    Friend WithEvents chkTOD As CheckBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtTOD1 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtTOD2 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtTOD5 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtTOD4 As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtTOD3 As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtEER As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRTUCapacity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents chkJan As CheckBox
End Class
