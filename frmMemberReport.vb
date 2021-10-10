Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class frmMemberReport
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Member As CMember
    Private Sub frmMemberReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvMemberReport.RefreshReport()
    End Sub
    Public Sub Display()
        Member = New CMember
        rpvMemberReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptMembers.rdlc"
        ds = New DataSet
        da = Member.GetReportData()
        da.Fill(ds)
        rpvMemberReport.LocalReport.DataSources.Add(New ReportDataSource("dsMember", ds.Tables(0)))
        rpvMemberReport.SetDisplayMode(DisplayMode.PrintLayout)
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class