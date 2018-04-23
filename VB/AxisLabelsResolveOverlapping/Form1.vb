Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace AxisLabelsResolveOverlapping
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim chartControl1 As New ChartControl()

			' Create a series and add points to it.
			Dim series1 As New Series("Series 1", ViewType.Bar)

			series1.Points.Add(New SeriesPoint("First Argument", 10.5678))
			series1.Points.Add(New SeriesPoint("Second Argument", 12.5798))
			series1.Points.Add(New SeriesPoint("Third Argument", 11.6483))
			series1.Points.Add(New SeriesPoint("Fourth Argument", 12.3154))
			series1.Points.Add(New SeriesPoint("Fifth Argument", 12.7865))

			' Add the series to the chart.
			chartControl1.Series.Add(series1)

			' Hide the legend (optional).
			chartControl1.Legend.Visible = False

			' Cast the chart's diagram to the XYDiagram type,
			' to access its axes.
			Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)

			' Make the X-axis labels staggered.
			diagram.AxisX.Label.Staggered = True

			' Add a prefix to the Y-axis labels, and rotate them.
			diagram.AxisY.Label.BeginText = "Axis value = "
			diagram.AxisY.Label.Angle = -30
			diagram.AxisY.Label.Antialiasing = True

			' Add the chart to the form.
			chartControl1.Dock = DockStyle.Fill
			Me.Controls.Add(chartControl1)
		End Sub

	End Class
End Namespace