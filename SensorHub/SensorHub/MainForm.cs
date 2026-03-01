using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorHub
{
    // main form class
    // - used to control the application (start, stop, show/hide windows)
    // - also implements IObserver to display the actual reading
    public partial class MainForm : Form, IObserver<SensorReading>
    {
        private bool isRunning = false;
        private SensorHub Hub;              // generates sensor readings
        private IDisposable Subscription;

        private GraphForm Graph;

        public MainForm()
        {
            InitializeComponent();

            Hub = new SensorHub(500);       // create new sensor hub with given measurement interval

            // this form (frmMain) is also a subscriber/observer
            Subscription = Hub.Subscribe(this);

            // show Graph Form
            cbxGraph.Checked = true;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                btnStartStop.Text = "Stop";
                Hub.Start();
            }
            else
            {
                btnStartStop.Text = "Start";
                Hub.Stop();
            }
        }

        // ===== IObserver =====

        // OnNext: 
        public void OnNext(SensorReading value)
        {
            // convert temperature value to string and display
            lblTemperatureValue.Text = value.Temperature.ToString("0.00") + " °C";
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

        // ===== Show/Close Forms =====

        private void cbxGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxGraph.Checked)
            {
                ShowGraph();
            }
            else
            {
                CloseGraph();
            }
        }

        private void ShowGraph()
        {
            if (Graph == null || Graph.IsDisposed)
            {
                Graph = new GraphForm(Hub);
                Graph.FormClosed += Graph_FormClosed;
            }

            Graph.Show();
            Graph.BringToFront();
        }

        private void CloseGraph()
        {
            if (Graph != null && !Graph.IsDisposed)
            { 
                Graph.Close(); // triggers Subscription.Dispose() in GraphForm
            }

            Graph = null;
        }

        private void Graph_FormClosed(object sender, FormClosedEventArgs e)
        {
            Graph = null;
            cbxGraph.Checked = false;
        }

        private void cbxTable_CheckedChanged(object sender, EventArgs e)
        {
            // todo: add code here to Show/Close Table Form
        }

        private void cbxAlarm_CheckedChanged(object sender, EventArgs e)
        {
            // todo: add code here to Show/Close Alarm Form
        }

        private void cbxStatistics_CheckedChanged(object sender, EventArgs e)
        {
            // todo: add code here to Show/Close Statistics Form
        }
    }
}
