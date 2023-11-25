Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportdoc As New ReportDocument
        reportdoc.Load("C:\Users\ITLAB-30\source\repos\OOPIT2B_cruz,a\OOPIT2B_cruz,a\reportByID.rpt")

        Dim pdef As ParameterFieldDefinition
        Dim pdefs As ParameterFieldDefinitions
        Dim pvalues As New ParameterValues
        Dim pdvalue As New ParameterDiscreteValue
        pdvalue.Value = Convert.ToInt32(Form1.txtuserid.Text)
        pdefs = reportdoc.DataDefinition.ParameterFields
        pdef = pdefs.Item("studID")
        pvalues = pdef.CurrentValues
        pvalues.Clear()
        pvalues.Add(pdvalue)
        pdef.ApplyCurrentValues(pvalues)
        idviewer.ReportSource = reportdoc
        idviewer.Refresh()
    End Sub
End Class