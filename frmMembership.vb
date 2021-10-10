Imports System.Data.SqlClient
Imports System.IO



Public Class frmMembership
#Region "Toolbar stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHome.MouseEnter, tsbHelp.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'we need to do this only because we are not putting our images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHome.MouseLeave, tsbHelp.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'we need to do this only because we are not putting our images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub


    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click

    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub

#End Region

    Private objMembers As CMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private MemberReport As frmMemberReport
    Private objMemberRole As CMemberRoles

    Dim strPhotoName As String
    Dim strPhotoPath As String
    Dim strFirstName As String

    Private Sub LoadMembers()
        Dim objDR As SqlDataReader
        lstCurrentMembers.Items.Clear()
        Try
            objDR = objMembers.GetAllMembers()
            Do While objDR.Read
                lstCurrentMembers.Items.Add(objDR.Item("PID"))
            Loop
            objDR.Close()
        Catch ex As Exception

        End Try
        If objMembers.CurrentObject.PID <> "" Then
            lstCurrentMembers.SelectedIndex = lstCurrentMembers.FindStringExact(objMembers.CurrentObject.PID)
        End If
        blnReloading = False
    End Sub

    Private Sub frmMembership_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
        'Me.ReportViewer1.RefreshReport()
        FilterData("")
        objMemberRole = New CMemberRoles

    End Sub


    Private Sub frmMembership_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadMembers()
        grpEditMember.Enabled = False
    End Sub

    Private Sub lstCurrentMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCurrentMembers.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            tslStatus.Text = ""
            Exit Sub
        End If
        If lstCurrentMembers.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNewMember.Checked = False
        LoadSelectedRecord()
        grpEditMember.Enabled = True

    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objMembers.GetMemberByPID(lstCurrentMembers.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtPID.Text = .PID
                txtFirstName.Text = .FName
                txtMI.Text = .MI
                txtLastName.Text = .LName
                txtEmail.Text = .Email
                mskPhoneNumber.Text = .Phone
                picMember.Image = Image.FromFile(.Photo)
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Member information. Only available information has been loaded.", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkNewMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewMember.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNewMember.Checked Then
            tslStatus.Text = ""
            txtPID.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtMI.Clear()
            txtEmail.Clear()
            mskPhoneNumber.Clear()
            lstCurrentMembers.SelectedIndex = -1
            grpEditMember.Enabled = True
            grpMembers.Enabled = False
            grpSearch.Enabled = False
            txtPID.Focus()
            objMembers.CreateNewMember()
            'objMemberRole.
            picMember.Image = Nothing
        Else
            grpMembers.Enabled = True
            grpSearch.Enabled = True
            grpEditMember.Enabled = False
            objMembers.CurrentObject.IsNewMember = False

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""
        '----add validation
        'check maxlength of the fields
        If Not ValidatetextBoxLength(txtPID, errP) Then
            blnErrors = True
        End If
        If Not ValidatetextBoxLength(txtFirstName, errP) Then
            blnErrors = True
        End If
        If Not ValidatetextBoxLength(txtLastName, errP) Then
            blnErrors = True
        End If
        If Not ValidatetextBoxLength(txtMI, errP) Then
            blnErrors = True
        End If
        If Not ValidatetextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If
        If Not ValidateMaskedTextBoxLength(mskPhoneNumber, errP) Then
            blnErrors = True
        End If
        If picMember.Image Is Nothing Then
            blnErrors = True
            errP.SetError(picMember, "You must upload an image")
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objMembers.CurrentObject
            .PID = txtPID.Text
            .FName = txtFirstName.Text
            .LName = txtLastName.Text
            .MI = txtMI.Text
            .Phone = mskPhoneNumber.Text
            .Email = txtEmail.Text
            .Photo = strPhotoPath
        End With
        With objMemberRole.CurrentObject
            .PID = txtPID.Text
            .RoleID = "Member"
            .SemesterID = "sp21"
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intNextAction = objMembers.Save
            If intResult = 1 Then
                tslStatus.Text = "Member record saved"
            End If
            If intResult = -1 Then
                MessageBox.Show("Member must be unique. Unable to save Member record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Member record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Try
            intNextAction = objMemberRole.save()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        


        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadMembers()
        chkNewMember.Checked = False
        grpMembers.Enabled = True
    End Sub



    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        ofdOpen.ShowDialog()
        If ofdOpen.ShowDialog = DialogResult.OK Then
            picMember.Image = Image.FromFile(ofdOpen.FileName)
            strPhotoPath = System.IO.Path.GetFullPath(ofdOpen.FileName)
        End If
    End Sub


    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If lstCurrentMembers.Items.Count = 0 Then
            MessageBox.Show("There are no records to print")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        MemberReport = New frmMemberReport
        MemberReport.Display()
    End Sub

    Private Sub grpEditMember_Enter(sender As Object, e As EventArgs) Handles grpEditMember.Enter

    End Sub

    Public Sub FilterData(strValue As String)
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alain\source\repos\STARSORG\STARSDB.mdf;Integrated Security=True")

        Dim strQuery As String = "SELECT * FROM MEMBER WHERE CONCAT (FName, Lname, PID, MI, Email, Phone) like '%" & strValue & "%'"

        Dim cmd As New SqlCommand(strQuery, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgvSearch.DataSource = table
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterData(txtSearch.Text)
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        grpEditMember.Enabled = True

        Dim i As Integer
        i = dgvSearch.CurrentRow.Index
        txtPID.Text = dgvSearch.Item(0, i).Value
        txtFirstName.Text = dgvSearch.Item(1, i).Value
        txtLastName.Text = dgvSearch.Item(2, i).Value
        txtMI.Text = dgvSearch.Item(3, i).Value
        txtEmail.Text = dgvSearch.Item(4, i).Value
        mskPhoneNumber.Text = dgvSearch.Item(5, i).Value
        picMember.Image = Image.FromFile(dgvSearch.Item(6, i).Value)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        tslStatus.Text = ""
        chkNewMember.Checked = False
        errP.Clear()
        If lstCurrentMembers.SelectedIndex <> -1 Then
            LoadSelectedRecord()
        Else
            grpEditMember.Enabled = False
        End If
        blnClearing = False
        objMembers.CurrentObject.IsNewMember = False
        grpMembers.Enabled = True
    End Sub
End Class