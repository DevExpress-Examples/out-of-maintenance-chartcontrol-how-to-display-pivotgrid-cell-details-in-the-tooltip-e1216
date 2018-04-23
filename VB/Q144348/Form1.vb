Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid

Namespace Q144348
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

		End Sub

		Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
			Dim point As SeriesPoint = TryCast(e.AdditionalObject, SeriesPoint)

			If point IsNot Nothing Then
				Dim coord As PivotChartDataSourceRowItem = TryCast(point.Tag, PivotChartDataSourceRowItem)

				Dim chart As ChartControl = CType(sender, ChartControl)
				Dim pivot As PivotGridControl = CType(chart.DataSource, PivotGridControl)
				Dim info As PivotCellEventArgs = pivot.Cells.GetCellInfo(coord.CellX, coord.CellY)
				Dim source As PivotSummaryDataSource = info.CreateSummaryDataSource()
				Dim s As String = String.Empty
				For i As Integer = 0 To source.RowCount - 1
					s &= "Country = " & source.GetValue(i, 0).ToString() & Constants.vbCr + Constants.vbTab & "Year = " & source.GetValue(i, 1).ToString() & Constants.vbCr + Constants.vbTab & "Extended Price = " & source.GetValue(i, 2).ToString() & Constants.vbCrLf
				Next i
				toolTipController1.ShowHint(s)
			Else
				toolTipController1.HideHint()
			End If
		End Sub
	End Class
End Namespace