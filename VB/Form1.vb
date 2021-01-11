Imports DevExpress.XtraReports.UI
Imports System
Imports System.Windows.Forms

Namespace Reporting_Create_Custom_Numeric_Label
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim designTool As New ReportDesignTool(New XtraReport1())
			designTool.ShowDesigner()
		End Sub
	End Class
End Namespace
