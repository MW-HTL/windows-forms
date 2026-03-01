using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SensorHub
{
    public partial class GraphForm : Form, IObserver<SensorReading>
    {
        private IDisposable Subscription;
        private Queue<SensorReading> LastValues;   // list of last (MaxPoints) values
        private const int MaxPoints = 20;

        public GraphForm(IObservable<SensorReading> hub)
        {
            InitializeComponent();
            Subscription = hub.Subscribe(this);
            this.FormClosed += GraphForm_FormClosed;

            SetupChart();

        }

        private void GraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Subscription.Dispose();
        }

        private void SetupChart()
        {
            // set up graph
            LastValues = new Queue<SensorReading>();
            chtTimeSeries.Series.Clear();
            chtTimeSeries.ChartAreas.Clear();

            ChartArea area = new ChartArea("MainArea");

            // format x-axis as time
            area.AxisX.LabelStyle.Format = "HH:mm:ss";
            area.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chtTimeSeries.ChartAreas.Add(area);

            Legend legend = new Legend("MainLegend");

            legend.Docking = Docking.Top;
            legend.Alignment = StringAlignment.Center;
            legend.IsDockedInsideChartArea = true;
            chtTimeSeries.Legends.Add(legend);

            Series temperatureSeries = new Series("Temperature");
            temperatureSeries.ChartType = SeriesChartType.Line;
            temperatureSeries.BorderWidth = 2;
            temperatureSeries.XValueType = ChartValueType.DateTime;
            temperatureSeries.Legend = "MainLegend";
            chtTimeSeries.Series.Add(temperatureSeries);
        }

        private void UpdateChart()
        {
            Series s = chtTimeSeries.Series["Temperature"];
            s.Points.Clear();

            int index = 0;

            foreach (SensorReading v in LastValues)
            {
                s.Points.AddXY(v.Timestamp, v.Temperature);
                index++;
            }
        }

        // ===== IObserver =====

        // OnNext: 
        public void OnNext(SensorReading value)
        {
            if (LastValues.Count >= MaxPoints)
            {
                LastValues.Dequeue();
            }

            LastValues.Enqueue(value);

            UpdateChart();
        }

        // OnError: required by IObserver -> keep empty
        public void OnError(Exception error)
        {
            MessageBox.Show(error.Message, "Error");
        }

        // OnCompleted: required by IObserver -> keep empty
        public void OnCompleted()
        {

        }
    }
}
