<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAPIS
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
        Me.components = New System.ComponentModel.Container()
        Me.msMainMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectFromFOAMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabManifestData = New System.Windows.Forms.TabControl()
        Me.tabPageItinerary = New System.Windows.Forms.TabPage()
        Me.pnlNOAAircraftInfo = New System.Windows.Forms.Panel()
        Me.lblNOAAircraftInformation = New System.Windows.Forms.Label()
        Me.txtNOAAircraftTailNumber = New System.Windows.Forms.TextBox()
        Me.lblNOAAircraftTailNumber = New System.Windows.Forms.Label()
        Me.pnlNOAArrInfo = New System.Windows.Forms.Panel()
        Me.txtNOAArrState = New System.Windows.Forms.TextBox()
        Me.lblNOAArrState = New System.Windows.Forms.Label()
        Me.txtNOAArrLocationDescription = New System.Windows.Forms.TextBox()
        Me.lblNOAArrLocationDescription = New System.Windows.Forms.Label()
        Me.lblNOAArrDate = New System.Windows.Forms.Label()
        Me.txtNOAArrCity = New System.Windows.Forms.TextBox()
        Me.lblNOAArrCity = New System.Windows.Forms.Label()
        Me.txtNOAArrAirport = New System.Windows.Forms.TextBox()
        Me.lblNOAArrAirport = New System.Windows.Forms.Label()
        Me.dtmNOAArrDateTime = New System.Windows.Forms.DateTimePicker()
        Me.lblNOAArrInfo = New System.Windows.Forms.Label()
        Me.pnlNOADepInfo = New System.Windows.Forms.Panel()
        Me.txtNOABorderCrossing = New System.Windows.Forms.TextBox()
        Me.lblNOABorderCrossing = New System.Windows.Forms.Label()
        Me.txtNOAForeignArpt5 = New System.Windows.Forms.TextBox()
        Me.txtNOAForeignArpt4 = New System.Windows.Forms.TextBox()
        Me.txtNOAForeignArpt3 = New System.Windows.Forms.TextBox()
        Me.txtNOAForeignArpt2 = New System.Windows.Forms.TextBox()
        Me.txtNOAForeignArpt1 = New System.Windows.Forms.TextBox()
        Me.lblNOACompleteItinerary = New System.Windows.Forms.Label()
        Me.lblNOADepDate = New System.Windows.Forms.Label()
        Me.txtNOADepCity = New System.Windows.Forms.TextBox()
        Me.lblNOADepartureCity = New System.Windows.Forms.Label()
        Me.txtNOADepAirport = New System.Windows.Forms.TextBox()
        Me.lblNOADepAirport = New System.Windows.Forms.Label()
        Me.txtNOADepCountry = New System.Windows.Forms.TextBox()
        Me.lblNOADepCountry = New System.Windows.Forms.Label()
        Me.dtmNOADepDateTime = New System.Windows.Forms.DateTimePicker()
        Me.lblNOADepInfo = New System.Windows.Forms.Label()
        Me.tabAircraft = New System.Windows.Forms.TabPage()
        Me.tabFlightCrew = New System.Windows.Forms.TabPage()
        Me.tabPassengers = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSelectFromFOAMS = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.msMainMenu.SuspendLayout()
        Me.tabManifestData.SuspendLayout()
        Me.tabPageItinerary.SuspendLayout()
        Me.pnlNOAAircraftInfo.SuspendLayout()
        Me.pnlNOAArrInfo.SuspendLayout()
        Me.pnlNOADepInfo.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msMainMenu
        '
        Me.msMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmXML})
        Me.msMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMainMenu.Name = "msMainMenu"
        Me.msMainMenu.Size = New System.Drawing.Size(1251, 24)
        Me.msMainMenu.TabIndex = 0
        Me.msMainMenu.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectFromFOAMSToolStripMenuItem, Me.OpenFromToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmFile.Text = "File"
        '
        'SelectFromFOAMSToolStripMenuItem
        '
        Me.SelectFromFOAMSToolStripMenuItem.Name = "SelectFromFOAMSToolStripMenuItem"
        Me.SelectFromFOAMSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectFromFOAMSToolStripMenuItem.Text = "Select  from FOAMS"
        '
        'OpenFromToolStripMenuItem
        '
        Me.OpenFromToolStripMenuItem.Name = "OpenFromToolStripMenuItem"
        Me.OpenFromToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenFromToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'tsmXML
        '
        Me.tsmXML.Name = "tsmXML"
        Me.tsmXML.Size = New System.Drawing.Size(43, 20)
        Me.tsmXML.Text = "XML"
        '
        'tabManifestData
        '
        Me.tabManifestData.Controls.Add(Me.tabPageItinerary)
        Me.tabManifestData.Controls.Add(Me.tabAircraft)
        Me.tabManifestData.Controls.Add(Me.tabFlightCrew)
        Me.tabManifestData.Controls.Add(Me.tabPassengers)
        Me.tabManifestData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabManifestData.Location = New System.Drawing.Point(199, 62)
        Me.tabManifestData.Name = "tabManifestData"
        Me.tabManifestData.SelectedIndex = 0
        Me.tabManifestData.Size = New System.Drawing.Size(1019, 561)
        Me.tabManifestData.TabIndex = 1
        '
        'tabPageItinerary
        '
        Me.tabPageItinerary.AutoScroll = True
        Me.tabPageItinerary.Controls.Add(Me.pnlNOAAircraftInfo)
        Me.tabPageItinerary.Controls.Add(Me.pnlNOAArrInfo)
        Me.tabPageItinerary.Controls.Add(Me.pnlNOADepInfo)
        Me.tabPageItinerary.Location = New System.Drawing.Point(4, 24)
        Me.tabPageItinerary.Name = "tabPageItinerary"
        Me.tabPageItinerary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageItinerary.Size = New System.Drawing.Size(1011, 533)
        Me.tabPageItinerary.TabIndex = 0
        Me.tabPageItinerary.Text = "Notice of Arrival Itinerary"
        Me.tabPageItinerary.UseVisualStyleBackColor = True
        '
        'pnlNOAAircraftInfo
        '
        Me.pnlNOAAircraftInfo.BackColor = System.Drawing.Color.PowderBlue
        Me.pnlNOAAircraftInfo.Controls.Add(Me.lblNOAAircraftInformation)
        Me.pnlNOAAircraftInfo.Controls.Add(Me.txtNOAAircraftTailNumber)
        Me.pnlNOAAircraftInfo.Controls.Add(Me.lblNOAAircraftTailNumber)
        Me.pnlNOAAircraftInfo.Location = New System.Drawing.Point(15, 5)
        Me.pnlNOAAircraftInfo.Name = "pnlNOAAircraftInfo"
        Me.pnlNOAAircraftInfo.Size = New System.Drawing.Size(981, 48)
        Me.pnlNOAAircraftInfo.TabIndex = 0
        '
        'lblNOAAircraftInformation
        '
        Me.lblNOAAircraftInformation.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNOAAircraftInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNOAAircraftInformation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOAAircraftInformation.ForeColor = System.Drawing.Color.White
        Me.lblNOAAircraftInformation.Location = New System.Drawing.Point(14, 11)
        Me.lblNOAAircraftInformation.Name = "lblNOAAircraftInformation"
        Me.lblNOAAircraftInformation.Size = New System.Drawing.Size(208, 18)
        Me.lblNOAAircraftInformation.TabIndex = 0
        Me.lblNOAAircraftInformation.Text = "Aircraft Information"
        '
        'txtNOAAircraftTailNumber
        '
        Me.txtNOAAircraftTailNumber.Location = New System.Drawing.Point(292, 21)
        Me.txtNOAAircraftTailNumber.Name = "txtNOAAircraftTailNumber"
        Me.txtNOAAircraftTailNumber.Size = New System.Drawing.Size(100, 21)
        Me.txtNOAAircraftTailNumber.TabIndex = 2
        '
        'lblNOAAircraftTailNumber
        '
        Me.lblNOAAircraftTailNumber.AutoSize = True
        Me.lblNOAAircraftTailNumber.Location = New System.Drawing.Point(289, 5)
        Me.lblNOAAircraftTailNumber.Name = "lblNOAAircraftTailNumber"
        Me.lblNOAAircraftTailNumber.Size = New System.Drawing.Size(118, 15)
        Me.lblNOAAircraftTailNumber.TabIndex = 1
        Me.lblNOAAircraftTailNumber.Text = "Aircraft Tail Number:"
        '
        'pnlNOAArrInfo
        '
        Me.pnlNOAArrInfo.BackColor = System.Drawing.Color.PowderBlue
        Me.pnlNOAArrInfo.Controls.Add(Me.txtNOAArrState)
        Me.pnlNOAArrInfo.Controls.Add(Me.lblNOAArrState)
        Me.pnlNOAArrInfo.Controls.Add(Me.txtNOAArrLocationDescription)
        Me.pnlNOAArrInfo.Controls.Add(Me.lblNOAArrLocationDescription)
        Me.pnlNOAArrInfo.Controls.Add(Me.lblNOAArrDate)
        Me.pnlNOAArrInfo.Controls.Add(Me.txtNOAArrCity)
        Me.pnlNOAArrInfo.Controls.Add(Me.lblNOAArrCity)
        Me.pnlNOAArrInfo.Controls.Add(Me.txtNOAArrAirport)
        Me.pnlNOAArrInfo.Controls.Add(Me.lblNOAArrAirport)
        Me.pnlNOAArrInfo.Controls.Add(Me.dtmNOAArrDateTime)
        Me.pnlNOAArrInfo.Controls.Add(Me.lblNOAArrInfo)
        Me.pnlNOAArrInfo.Location = New System.Drawing.Point(15, 270)
        Me.pnlNOAArrInfo.Name = "pnlNOAArrInfo"
        Me.pnlNOAArrInfo.Size = New System.Drawing.Size(981, 159)
        Me.pnlNOAArrInfo.TabIndex = 2
        '
        'txtNOAArrState
        '
        Me.txtNOAArrState.Location = New System.Drawing.Point(565, 30)
        Me.txtNOAArrState.Name = "txtNOAArrState"
        Me.txtNOAArrState.Size = New System.Drawing.Size(45, 21)
        Me.txtNOAArrState.TabIndex = 6
        '
        'lblNOAArrState
        '
        Me.lblNOAArrState.AutoSize = True
        Me.lblNOAArrState.Location = New System.Drawing.Point(562, 14)
        Me.lblNOAArrState.Name = "lblNOAArrState"
        Me.lblNOAArrState.Size = New System.Drawing.Size(35, 15)
        Me.lblNOAArrState.TabIndex = 5
        Me.lblNOAArrState.Text = "State"
        '
        'txtNOAArrLocationDescription
        '
        Me.txtNOAArrLocationDescription.Location = New System.Drawing.Point(292, 119)
        Me.txtNOAArrLocationDescription.Name = "txtNOAArrLocationDescription"
        Me.txtNOAArrLocationDescription.Size = New System.Drawing.Size(318, 21)
        Me.txtNOAArrLocationDescription.TabIndex = 10
        '
        'lblNOAArrLocationDescription
        '
        Me.lblNOAArrLocationDescription.AutoSize = True
        Me.lblNOAArrLocationDescription.Location = New System.Drawing.Point(289, 103)
        Me.lblNOAArrLocationDescription.Name = "lblNOAArrLocationDescription"
        Me.lblNOAArrLocationDescription.Size = New System.Drawing.Size(155, 15)
        Me.lblNOAArrLocationDescription.TabIndex = 9
        Me.lblNOAArrLocationDescription.Text = "Arrival Location Description"
        '
        'lblNOAArrDate
        '
        Me.lblNOAArrDate.AutoSize = True
        Me.lblNOAArrDate.Location = New System.Drawing.Point(289, 57)
        Me.lblNOAArrDate.Name = "lblNOAArrDate"
        Me.lblNOAArrDate.Size = New System.Drawing.Size(33, 15)
        Me.lblNOAArrDate.TabIndex = 7
        Me.lblNOAArrDate.Text = "Date"
        '
        'txtNOAArrCity
        '
        Me.txtNOAArrCity.Location = New System.Drawing.Point(358, 30)
        Me.txtNOAArrCity.Name = "txtNOAArrCity"
        Me.txtNOAArrCity.Size = New System.Drawing.Size(201, 21)
        Me.txtNOAArrCity.TabIndex = 4
        '
        'lblNOAArrCity
        '
        Me.lblNOAArrCity.AutoSize = True
        Me.lblNOAArrCity.Location = New System.Drawing.Point(355, 14)
        Me.lblNOAArrCity.Name = "lblNOAArrCity"
        Me.lblNOAArrCity.Size = New System.Drawing.Size(26, 15)
        Me.lblNOAArrCity.TabIndex = 3
        Me.lblNOAArrCity.Text = "City"
        '
        'txtNOAArrAirport
        '
        Me.txtNOAArrAirport.Location = New System.Drawing.Point(292, 30)
        Me.txtNOAArrAirport.Name = "txtNOAArrAirport"
        Me.txtNOAArrAirport.Size = New System.Drawing.Size(58, 21)
        Me.txtNOAArrAirport.TabIndex = 2
        '
        'lblNOAArrAirport
        '
        Me.lblNOAArrAirport.AutoSize = True
        Me.lblNOAArrAirport.Location = New System.Drawing.Point(289, 14)
        Me.lblNOAArrAirport.Name = "lblNOAArrAirport"
        Me.lblNOAArrAirport.Size = New System.Drawing.Size(42, 15)
        Me.lblNOAArrAirport.TabIndex = 1
        Me.lblNOAArrAirport.Text = "Airport"
        '
        'dtmNOAArrDateTime
        '
        Me.dtmNOAArrDateTime.CustomFormat = "dd / MMM / yyyy      HH:mm"
        Me.dtmNOAArrDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmNOAArrDateTime.Location = New System.Drawing.Point(292, 73)
        Me.dtmNOAArrDateTime.Name = "dtmNOAArrDateTime"
        Me.dtmNOAArrDateTime.Size = New System.Drawing.Size(174, 21)
        Me.dtmNOAArrDateTime.TabIndex = 8
        '
        'lblNOAArrInfo
        '
        Me.lblNOAArrInfo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNOAArrInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNOAArrInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOAArrInfo.ForeColor = System.Drawing.Color.White
        Me.lblNOAArrInfo.Location = New System.Drawing.Point(14, 9)
        Me.lblNOAArrInfo.Name = "lblNOAArrInfo"
        Me.lblNOAArrInfo.Size = New System.Drawing.Size(208, 18)
        Me.lblNOAArrInfo.TabIndex = 0
        Me.lblNOAArrInfo.Text = "US Arrival Information"
        '
        'pnlNOADepInfo
        '
        Me.pnlNOADepInfo.BackColor = System.Drawing.Color.PowderBlue
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOABorderCrossing)
        Me.pnlNOADepInfo.Controls.Add(Me.lblNOABorderCrossing)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOAForeignArpt5)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOAForeignArpt4)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOAForeignArpt3)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOAForeignArpt2)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOAForeignArpt1)
        Me.pnlNOADepInfo.Controls.Add(Me.lblNOACompleteItinerary)
        Me.pnlNOADepInfo.Controls.Add(Me.lblNOADepDate)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOADepCity)
        Me.pnlNOADepInfo.Controls.Add(Me.lblNOADepartureCity)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOADepAirport)
        Me.pnlNOADepInfo.Controls.Add(Me.lblNOADepAirport)
        Me.pnlNOADepInfo.Controls.Add(Me.txtNOADepCountry)
        Me.pnlNOADepInfo.Controls.Add(Me.lblNOADepCountry)
        Me.pnlNOADepInfo.Controls.Add(Me.dtmNOADepDateTime)
        Me.pnlNOADepInfo.Controls.Add(Me.lblNOADepInfo)
        Me.pnlNOADepInfo.Location = New System.Drawing.Point(15, 59)
        Me.pnlNOADepInfo.Name = "pnlNOADepInfo"
        Me.pnlNOADepInfo.Size = New System.Drawing.Size(981, 205)
        Me.pnlNOADepInfo.TabIndex = 1
        '
        'txtNOABorderCrossing
        '
        Me.txtNOABorderCrossing.Location = New System.Drawing.Point(292, 169)
        Me.txtNOABorderCrossing.Name = "txtNOABorderCrossing"
        Me.txtNOABorderCrossing.Size = New System.Drawing.Size(318, 21)
        Me.txtNOABorderCrossing.TabIndex = 16
        '
        'lblNOABorderCrossing
        '
        Me.lblNOABorderCrossing.AutoSize = True
        Me.lblNOABorderCrossing.Location = New System.Drawing.Point(289, 153)
        Me.lblNOABorderCrossing.Name = "lblNOABorderCrossing"
        Me.lblNOABorderCrossing.Size = New System.Drawing.Size(349, 15)
        Me.lblNOABorderCrossing.TabIndex = 15
        Me.lblNOABorderCrossing.Text = "Estimated time and location of crossing US Border or Coastline"
        '
        'txtNOAForeignArpt5
        '
        Me.txtNOAForeignArpt5.Location = New System.Drawing.Point(552, 119)
        Me.txtNOAForeignArpt5.Name = "txtNOAForeignArpt5"
        Me.txtNOAForeignArpt5.Size = New System.Drawing.Size(58, 21)
        Me.txtNOAForeignArpt5.TabIndex = 14
        '
        'txtNOAForeignArpt4
        '
        Me.txtNOAForeignArpt4.Location = New System.Drawing.Point(487, 119)
        Me.txtNOAForeignArpt4.Name = "txtNOAForeignArpt4"
        Me.txtNOAForeignArpt4.Size = New System.Drawing.Size(58, 21)
        Me.txtNOAForeignArpt4.TabIndex = 13
        '
        'txtNOAForeignArpt3
        '
        Me.txtNOAForeignArpt3.Location = New System.Drawing.Point(422, 119)
        Me.txtNOAForeignArpt3.Name = "txtNOAForeignArpt3"
        Me.txtNOAForeignArpt3.Size = New System.Drawing.Size(58, 21)
        Me.txtNOAForeignArpt3.TabIndex = 12
        '
        'txtNOAForeignArpt2
        '
        Me.txtNOAForeignArpt2.Location = New System.Drawing.Point(357, 119)
        Me.txtNOAForeignArpt2.Name = "txtNOAForeignArpt2"
        Me.txtNOAForeignArpt2.Size = New System.Drawing.Size(58, 21)
        Me.txtNOAForeignArpt2.TabIndex = 11
        '
        'txtNOAForeignArpt1
        '
        Me.txtNOAForeignArpt1.Location = New System.Drawing.Point(292, 119)
        Me.txtNOAForeignArpt1.Name = "txtNOAForeignArpt1"
        Me.txtNOAForeignArpt1.Size = New System.Drawing.Size(58, 21)
        Me.txtNOAForeignArpt1.TabIndex = 10
        '
        'lblNOACompleteItinerary
        '
        Me.lblNOACompleteItinerary.AutoSize = True
        Me.lblNOACompleteItinerary.Location = New System.Drawing.Point(289, 103)
        Me.lblNOACompleteItinerary.Name = "lblNOACompleteItinerary"
        Me.lblNOACompleteItinerary.Size = New System.Drawing.Size(189, 15)
        Me.lblNOACompleteItinerary.TabIndex = 9
        Me.lblNOACompleteItinerary.Text = "Airport landed in the last 24 hours"
        '
        'lblNOADepDate
        '
        Me.lblNOADepDate.AutoSize = True
        Me.lblNOADepDate.Location = New System.Drawing.Point(289, 57)
        Me.lblNOADepDate.Name = "lblNOADepDate"
        Me.lblNOADepDate.Size = New System.Drawing.Size(33, 15)
        Me.lblNOADepDate.TabIndex = 7
        Me.lblNOADepDate.Text = "Date"
        '
        'txtNOADepCity
        '
        Me.txtNOADepCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtNOADepCity.Location = New System.Drawing.Point(439, 30)
        Me.txtNOADepCity.Name = "txtNOADepCity"
        Me.txtNOADepCity.Size = New System.Drawing.Size(203, 21)
        Me.txtNOADepCity.TabIndex = 6
        '
        'lblNOADepartureCity
        '
        Me.lblNOADepartureCity.AutoSize = True
        Me.lblNOADepartureCity.Location = New System.Drawing.Point(436, 14)
        Me.lblNOADepartureCity.Name = "lblNOADepartureCity"
        Me.lblNOADepartureCity.Size = New System.Drawing.Size(26, 15)
        Me.lblNOADepartureCity.TabIndex = 5
        Me.lblNOADepartureCity.Text = "City"
        '
        'txtNOADepAirport
        '
        Me.txtNOADepAirport.Location = New System.Drawing.Point(358, 30)
        Me.txtNOADepAirport.Name = "txtNOADepAirport"
        Me.txtNOADepAirport.Size = New System.Drawing.Size(58, 21)
        Me.txtNOADepAirport.TabIndex = 4
        '
        'lblNOADepAirport
        '
        Me.lblNOADepAirport.AutoSize = True
        Me.lblNOADepAirport.Location = New System.Drawing.Point(355, 14)
        Me.lblNOADepAirport.Name = "lblNOADepAirport"
        Me.lblNOADepAirport.Size = New System.Drawing.Size(42, 15)
        Me.lblNOADepAirport.TabIndex = 3
        Me.lblNOADepAirport.Text = "Airport"
        '
        'txtNOADepCountry
        '
        Me.txtNOADepCountry.Location = New System.Drawing.Point(292, 30)
        Me.txtNOADepCountry.Name = "txtNOADepCountry"
        Me.txtNOADepCountry.Size = New System.Drawing.Size(40, 21)
        Me.txtNOADepCountry.TabIndex = 2
        '
        'lblNOADepCountry
        '
        Me.lblNOADepCountry.AutoSize = True
        Me.lblNOADepCountry.Location = New System.Drawing.Point(289, 14)
        Me.lblNOADepCountry.Name = "lblNOADepCountry"
        Me.lblNOADepCountry.Size = New System.Drawing.Size(48, 15)
        Me.lblNOADepCountry.TabIndex = 1
        Me.lblNOADepCountry.Text = "Country"
        '
        'dtmNOADepDateTime
        '
        Me.dtmNOADepDateTime.CustomFormat = "dd / MMM / yyyy      HH:mm"
        Me.dtmNOADepDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmNOADepDateTime.Location = New System.Drawing.Point(292, 73)
        Me.dtmNOADepDateTime.Name = "dtmNOADepDateTime"
        Me.dtmNOADepDateTime.Size = New System.Drawing.Size(174, 21)
        Me.dtmNOADepDateTime.TabIndex = 8
        '
        'lblNOADepInfo
        '
        Me.lblNOADepInfo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNOADepInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNOADepInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOADepInfo.ForeColor = System.Drawing.Color.White
        Me.lblNOADepInfo.Location = New System.Drawing.Point(14, 12)
        Me.lblNOADepInfo.Name = "lblNOADepInfo"
        Me.lblNOADepInfo.Size = New System.Drawing.Size(208, 18)
        Me.lblNOADepInfo.TabIndex = 0
        Me.lblNOADepInfo.Text = "Foreign Departure Information"
        '
        'tabAircraft
        '
        Me.tabAircraft.Location = New System.Drawing.Point(4, 25)
        Me.tabAircraft.Name = "tabAircraft"
        Me.tabAircraft.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAircraft.Size = New System.Drawing.Size(1011, 532)
        Me.tabAircraft.TabIndex = 1
        Me.tabAircraft.Text = "Aircraft"
        Me.tabAircraft.UseVisualStyleBackColor = True
        '
        'tabFlightCrew
        '
        Me.tabFlightCrew.Location = New System.Drawing.Point(4, 25)
        Me.tabFlightCrew.Name = "tabFlightCrew"
        Me.tabFlightCrew.Size = New System.Drawing.Size(1011, 532)
        Me.tabFlightCrew.TabIndex = 2
        Me.tabFlightCrew.Text = "Flight Crew"
        Me.tabFlightCrew.UseVisualStyleBackColor = True
        '
        'tabPassengers
        '
        Me.tabPassengers.Location = New System.Drawing.Point(4, 33)
        Me.tabPassengers.Name = "tabPassengers"
        Me.tabPassengers.Size = New System.Drawing.Size(1011, 524)
        Me.tabPassengers.TabIndex = 3
        Me.tabPassengers.Text = "Passengers"
        Me.tabPassengers.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSelectFromFOAMS
        '
        Me.btnSelectFromFOAMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFromFOAMS.Location = New System.Drawing.Point(12, 62)
        Me.btnSelectFromFOAMS.Name = "btnSelectFromFOAMS"
        Me.btnSelectFromFOAMS.Size = New System.Drawing.Size(156, 32)
        Me.btnSelectFromFOAMS.TabIndex = 2
        Me.btnSelectFromFOAMS.Text = "Select from FOAMS"
        Me.btnSelectFromFOAMS.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAPIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 614)
        Me.Controls.Add(Me.btnSelectFromFOAMS)
        Me.Controls.Add(Me.tabManifestData)
        Me.Controls.Add(Me.msMainMenu)
        Me.MainMenuStrip = Me.msMainMenu
        Me.Name = "frmAPIS"
        Me.Text = "eAPIS Manifest Editor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMainMenu.ResumeLayout(False)
        Me.msMainMenu.PerformLayout()
        Me.tabManifestData.ResumeLayout(False)
        Me.tabPageItinerary.ResumeLayout(False)
        Me.pnlNOAAircraftInfo.ResumeLayout(False)
        Me.pnlNOAAircraftInfo.PerformLayout()
        Me.pnlNOAArrInfo.ResumeLayout(False)
        Me.pnlNOAArrInfo.PerformLayout()
        Me.pnlNOADepInfo.ResumeLayout(False)
        Me.pnlNOADepInfo.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectFromFOAMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFromToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmXML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabManifestData As System.Windows.Forms.TabControl
    Friend WithEvents tabPageItinerary As System.Windows.Forms.TabPage
    Friend WithEvents tabAircraft As System.Windows.Forms.TabPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSelectFromFOAMS As System.Windows.Forms.Button
    Friend WithEvents txtNOAAircraftTailNumber As System.Windows.Forms.TextBox
    Friend WithEvents dtmNOADepDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabFlightCrew As System.Windows.Forms.TabPage
    Friend WithEvents tabPassengers As System.Windows.Forms.TabPage
    Friend WithEvents lblNOAAircraftTailNumber As System.Windows.Forms.Label
    Friend WithEvents pnlNOADepInfo As System.Windows.Forms.Panel
    Friend WithEvents txtNOADepAirport As System.Windows.Forms.TextBox
    Friend WithEvents lblNOADepAirport As System.Windows.Forms.Label
    Friend WithEvents txtNOADepCountry As System.Windows.Forms.TextBox
    Friend WithEvents lblNOADepCountry As System.Windows.Forms.Label
    Friend WithEvents lblNOADepInfo As System.Windows.Forms.Label
    Friend WithEvents txtNOADepCity As System.Windows.Forms.TextBox
    Friend WithEvents lblNOADepartureCity As System.Windows.Forms.Label
    Friend WithEvents lblNOADepDate As System.Windows.Forms.Label
    Friend WithEvents txtNOAForeignArpt5 As System.Windows.Forms.TextBox
    Friend WithEvents txtNOAForeignArpt4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNOAForeignArpt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNOAForeignArpt2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNOAForeignArpt1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNOACompleteItinerary As System.Windows.Forms.Label
    Friend WithEvents pnlNOAArrInfo As System.Windows.Forms.Panel
    Friend WithEvents txtNOAArrLocationDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblNOAArrLocationDescription As System.Windows.Forms.Label
    Friend WithEvents lblNOAArrDate As System.Windows.Forms.Label
    Friend WithEvents txtNOAArrCity As System.Windows.Forms.TextBox
    Friend WithEvents lblNOAArrCity As System.Windows.Forms.Label
    Friend WithEvents txtNOAArrAirport As System.Windows.Forms.TextBox
    Friend WithEvents lblNOAArrAirport As System.Windows.Forms.Label
    Friend WithEvents dtmNOAArrDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNOAArrInfo As System.Windows.Forms.Label
    Friend WithEvents txtNOABorderCrossing As System.Windows.Forms.TextBox
    Friend WithEvents lblNOABorderCrossing As System.Windows.Forms.Label
    Friend WithEvents pnlNOAAircraftInfo As System.Windows.Forms.Panel
    Friend WithEvents lblNOAAircraftInformation As System.Windows.Forms.Label
    Friend WithEvents txtNOAArrState As System.Windows.Forms.TextBox
    Friend WithEvents lblNOAArrState As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
