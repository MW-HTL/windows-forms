
namespace SensorHub
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblTemperatureValue = new System.Windows.Forms.Label();
            this.lblTemperatureCaption = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxStatistics = new System.Windows.Forms.CheckBox();
            this.cbxAlarm = new System.Windows.Forms.CheckBox();
            this.cbxTable = new System.Windows.Forms.CheckBox();
            this.cbxGraph = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartStop);
            this.groupBox1.Controls.Add(this.lblTemperatureValue);
            this.groupBox1.Controls.Add(this.lblTemperatureCaption);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Control";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(113, 111);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(92, 36);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblTemperatureValue
            // 
            this.lblTemperatureValue.AutoSize = true;
            this.lblTemperatureValue.Location = new System.Drawing.Point(110, 35);
            this.lblTemperatureValue.Name = "lblTemperatureValue";
            this.lblTemperatureValue.Size = new System.Drawing.Size(97, 13);
            this.lblTemperatureValue.TabIndex = 2;
            this.lblTemperatureValue.Text = "Temperature Value";
            // 
            // lblTemperatureCaption
            // 
            this.lblTemperatureCaption.AutoSize = true;
            this.lblTemperatureCaption.Location = new System.Drawing.Point(22, 35);
            this.lblTemperatureCaption.Name = "lblTemperatureCaption";
            this.lblTemperatureCaption.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatureCaption.TabIndex = 1;
            this.lblTemperatureCaption.Text = "Temperature:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxStatistics);
            this.groupBox2.Controls.Add(this.cbxAlarm);
            this.groupBox2.Controls.Add(this.cbxTable);
            this.groupBox2.Controls.Add(this.cbxGraph);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observers";
            // 
            // cbxStatistics
            // 
            this.cbxStatistics.AutoSize = true;
            this.cbxStatistics.Enabled = false;
            this.cbxStatistics.Location = new System.Drawing.Point(155, 69);
            this.cbxStatistics.Name = "cbxStatistics";
            this.cbxStatistics.Size = new System.Drawing.Size(73, 17);
            this.cbxStatistics.TabIndex = 3;
            this.cbxStatistics.Text = "Statsistics";
            this.cbxStatistics.UseVisualStyleBackColor = true;
            this.cbxStatistics.CheckedChanged += new System.EventHandler(this.cbxStatistics_CheckedChanged);
            // 
            // cbxAlarm
            // 
            this.cbxAlarm.AutoSize = true;
            this.cbxAlarm.Enabled = false;
            this.cbxAlarm.Location = new System.Drawing.Point(155, 35);
            this.cbxAlarm.Name = "cbxAlarm";
            this.cbxAlarm.Size = new System.Drawing.Size(52, 17);
            this.cbxAlarm.TabIndex = 2;
            this.cbxAlarm.Text = "Alarm";
            this.cbxAlarm.UseVisualStyleBackColor = true;
            this.cbxAlarm.CheckedChanged += new System.EventHandler(this.cbxAlarm_CheckedChanged);
            // 
            // cbxTable
            // 
            this.cbxTable.AutoSize = true;
            this.cbxTable.Enabled = false;
            this.cbxTable.Location = new System.Drawing.Point(25, 69);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(59, 17);
            this.cbxTable.TabIndex = 1;
            this.cbxTable.Text = "Logger";
            this.cbxTable.UseVisualStyleBackColor = true;
            this.cbxTable.CheckedChanged += new System.EventHandler(this.cbxTable_CheckedChanged);
            // 
            // cbxGraph
            // 
            this.cbxGraph.AutoSize = true;
            this.cbxGraph.Location = new System.Drawing.Point(25, 35);
            this.cbxGraph.Name = "cbxGraph";
            this.cbxGraph.Size = new System.Drawing.Size(55, 17);
            this.cbxGraph.TabIndex = 0;
            this.cbxGraph.Text = "Graph";
            this.cbxGraph.UseVisualStyleBackColor = true;
            this.cbxGraph.CheckedChanged += new System.EventHandler(this.cbxGraph_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SensorHub Main Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblTemperatureValue;
        private System.Windows.Forms.Label lblTemperatureCaption;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxStatistics;
        private System.Windows.Forms.CheckBox cbxAlarm;
        private System.Windows.Forms.CheckBox cbxTable;
        private System.Windows.Forms.CheckBox cbxGraph;
    }
}

