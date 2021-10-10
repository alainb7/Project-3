<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMembership
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpNewMember = New System.Windows.Forms.GroupBox()
        Me.chkNewMember = New System.Windows.Forms.CheckBox()
        Me.grpEditMember = New System.Windows.Forms.GroupBox()
        Me.picMember = New System.Windows.Forms.PictureBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpMembers = New System.Windows.Forms.GroupBox()
        Me.lstCurrentMembers = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.grpNewMember.SuspendLayout()
        Me.grpEditMember.SuspendLayout()
        CType(Me.picMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembers.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbHome, Me.ToolStripSeparator7, Me.tsbMember, Me.ToolStripSeparator6, Me.tsbRole, Me.ToolStripSeparator5, Me.tsbEvent, Me.ToolStripSeparator4, Me.tsbRSVP, Me.ToolStripSeparator3, Me.tsbCourse, Me.ToolStripSeparator2, Me.tsbSemester, Me.ToolStripSeparator8, Me.tsbTutor, Me.tsbLogOut, Me.ToolStripSeparator1, Me.tsbHelp, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1449, 54)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSORG.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSORG.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSORG.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLE"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.STARSORG.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENT"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSORG.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSORG.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSORG.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSORG.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSORG.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOGOUT"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSORG.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1383, 56)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Membership"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNewMember
        '
        Me.grpNewMember.Controls.Add(Me.chkNewMember)
        Me.grpNewMember.Location = New System.Drawing.Point(40, 167)
        Me.grpNewMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNewMember.Name = "grpNewMember"
        Me.grpNewMember.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNewMember.Size = New System.Drawing.Size(297, 65)
        Me.grpNewMember.TabIndex = 5
        Me.grpNewMember.TabStop = False
        Me.grpNewMember.Text = "New Member"
        '
        'chkNewMember
        '
        Me.chkNewMember.AutoSize = True
        Me.chkNewMember.Location = New System.Drawing.Point(29, 30)
        Me.chkNewMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNewMember.Name = "chkNewMember"
        Me.chkNewMember.Size = New System.Drawing.Size(141, 21)
        Me.chkNewMember.TabIndex = 0
        Me.chkNewMember.Text = "Add New Member"
        Me.chkNewMember.UseVisualStyleBackColor = True
        '
        'grpEditMember
        '
        Me.grpEditMember.Controls.Add(Me.picMember)
        Me.grpEditMember.Controls.Add(Me.btnUploadImage)
        Me.grpEditMember.Controls.Add(Me.txtPID)
        Me.grpEditMember.Controls.Add(Me.Label7)
        Me.grpEditMember.Controls.Add(Me.mskPhoneNumber)
        Me.grpEditMember.Controls.Add(Me.txtEmail)
        Me.grpEditMember.Controls.Add(Me.txtLastName)
        Me.grpEditMember.Controls.Add(Me.Label6)
        Me.grpEditMember.Controls.Add(Me.Label5)
        Me.grpEditMember.Controls.Add(Me.Label2)
        Me.grpEditMember.Controls.Add(Me.btnCancel)
        Me.grpEditMember.Controls.Add(Me.btnSave)
        Me.grpEditMember.Controls.Add(Me.txtMI)
        Me.grpEditMember.Controls.Add(Me.txtFirstName)
        Me.grpEditMember.Controls.Add(Me.Label3)
        Me.grpEditMember.Controls.Add(Me.lblName)
        Me.grpEditMember.Location = New System.Drawing.Point(804, 164)
        Me.grpEditMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEditMember.Name = "grpEditMember"
        Me.grpEditMember.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEditMember.Size = New System.Drawing.Size(620, 312)
        Me.grpEditMember.TabIndex = 7
        Me.grpEditMember.TabStop = False
        Me.grpEditMember.Text = "Member Information"
        '
        'picMember
        '
        Me.picMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMember.Location = New System.Drawing.Point(364, 28)
        Me.picMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picMember.Name = "picMember"
        Me.picMember.Size = New System.Drawing.Size(226, 193)
        Me.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picMember.TabIndex = 16
        Me.picMember.TabStop = False
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(135, 28)
        Me.txtPID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPID.MaxLength = 15
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(173, 22)
        Me.txtPID.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "PID:"
        '
        'mskPhoneNumber
        '
        Me.mskPhoneNumber.Location = New System.Drawing.Point(135, 199)
        Me.mskPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskPhoneNumber.Mask = "(999) 000-0000"
        Me.mskPhoneNumber.Name = "mskPhoneNumber"
        Me.mskPhoneNumber.Size = New System.Drawing.Size(171, 22)
        Me.mskPhoneNumber.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(135, 169)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.MaxLength = 15
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 22)
        Me.txtEmail.TabIndex = 12
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(135, 137)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.MaxLength = 15
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(173, 22)
        Me.txtLastName.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "MI"
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(135, 105)
        Me.txtMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMI.MaxLength = 15
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(173, 22)
        Me.txtMI.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(135, 69)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.MaxLength = 15
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(173, 22)
        Me.txtFirstName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 71)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(80, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "First Name:"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(639, 432)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 28)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(341, 268)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(44, 268)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpMembers
        '
        Me.grpMembers.Controls.Add(Me.lstCurrentMembers)
        Me.grpMembers.Location = New System.Drawing.Point(40, 247)
        Me.grpMembers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMembers.Size = New System.Drawing.Size(296, 164)
        Me.grpMembers.TabIndex = 10
        Me.grpMembers.TabStop = False
        Me.grpMembers.Text = "Current Members"
        '
        'lstCurrentMembers
        '
        Me.lstCurrentMembers.FormattingEnabled = True
        Me.lstCurrentMembers.ItemHeight = 16
        Me.lstCurrentMembers.Location = New System.Drawing.Point(5, 18)
        Me.lstCurrentMembers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCurrentMembers.Name = "lstCurrentMembers"
        Me.lstCurrentMembers.Size = New System.Drawing.Size(284, 132)
        Me.lstCurrentMembers.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 478)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1449, 24)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.AutoSize = False
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(500, 18)
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Location = New System.Drawing.Point(193, 268)
        Me.btnUploadImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(115, 33)
        Me.btnUploadImage.TabIndex = 17
        Me.btnUploadImage.Text = "Upload Image"
        Me.btnUploadImage.UseVisualStyleBackColor = True
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(16, 84)
        Me.dgvSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.RowHeadersWidth = 51
        Me.dgvSearch.Size = New System.Drawing.Size(339, 133)
        Me.dgvSearch.TabIndex = 19
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(16, 42)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(339, 22)
        Me.txtSearch.TabIndex = 20
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.dgvSearch)
        Me.grpSearch.Location = New System.Drawing.Point(379, 164)
        Me.grpSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSearch.Size = New System.Drawing.Size(380, 247)
        Me.grpSearch.TabIndex = 21
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Members"
        '
        'frmMembership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1449, 502)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpMembers)
        Me.Controls.Add(Me.grpEditMember)
        Me.Controls.Add(Me.grpNewMember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnReport)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMembership"
        Me.Text = "frmMembership"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpNewMember.ResumeLayout(False)
        Me.grpNewMember.PerformLayout()
        Me.grpEditMember.ResumeLayout(False)
        Me.grpEditMember.PerformLayout()
        CType(Me.picMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembers.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents grpNewMember As GroupBox
    Friend WithEvents chkNewMember As CheckBox
    Friend WithEvents grpEditMember As GroupBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents grpMembers As GroupBox
    Friend WithEvents lstCurrentMembers As ListBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMI As TextBox
    Friend WithEvents mskPhoneNumber As MaskedTextBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslStatus As ToolStripStatusLabel
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents picMember As PictureBox
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvSearch As DataGridView
End Class
