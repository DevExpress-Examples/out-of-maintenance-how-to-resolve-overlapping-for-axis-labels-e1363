using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace AxisLabelsResolveOverlapping {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl chartControl1 = new ChartControl();

            // Create a series and add points to it.
            Series series1 = new Series("Series 1", ViewType.Bar);

            series1.Points.Add(new SeriesPoint("First Argument", 10.5678));
            series1.Points.Add(new SeriesPoint("Second Argument", 12.5798));
            series1.Points.Add(new SeriesPoint("Third Argument", 11.6483));
            series1.Points.Add(new SeriesPoint("Fourth Argument", 12.3154));
            series1.Points.Add(new SeriesPoint("Fifth Argument", 12.7865));

            // Add the series to the chart.
            chartControl1.Series.Add(series1);

            // Hide the legend (optional).
            chartControl1.Legend.Visible = false;
            
            // Cast the chart's diagram to the XYDiagram type,
            // to access its axes.
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            // Make the X-axis labels staggered.
            diagram.AxisX.Label.Staggered = true;

            // Add a prefix to the Y-axis labels, and rotate them.
            diagram.AxisY.Label.BeginText = "Axis value = ";
            diagram.AxisY.Label.Angle = -30;
            diagram.AxisY.Label.Antialiasing = true;
            
            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }

    }
}