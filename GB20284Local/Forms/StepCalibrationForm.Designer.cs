namespace GB20284Local.Forms
{
    partial class StepCalibrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepCalibrationForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tbStepCalibration = new ToolStrip();
            btnStartTimer_StepCalibration = new ToolStripButton();
            pnlSystemMessage_StepCalibration = new Panel();
            lblSystemMessage_StepCalibration = new Label();
            splitMain = new SplitContainer();
            splitSub = new SplitContainer();
            gridChartContainer = new TableLayoutPanel();
            chartHRR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartSPR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lvSystemMessage_StepCalibration = new ListView();
            time = new ColumnHeader();
            message = new ColumnHeader();
            pnlRealTimeData_StepCalibration = new Panel();
            groupBox1 = new GroupBox();
            lblTimer_StepCalibration = new Label();
            label1 = new Label();
            lvSensorData_StepCalibration = new ListView();
            timer = new ColumnHeader();
            propane = new ColumnHeader();
            tbStepCalibration.SuspendLayout();
            pnlSystemMessage_StepCalibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitSub).BeginInit();
            splitSub.Panel1.SuspendLayout();
            splitSub.Panel2.SuspendLayout();
            splitSub.SuspendLayout();
            gridChartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartHRR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartSPR).BeginInit();
            pnlRealTimeData_StepCalibration.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbStepCalibration
            // 
            tbStepCalibration.ImageScalingSize = new Size(20, 20);
            tbStepCalibration.Items.AddRange(new ToolStripItem[] { btnStartTimer_StepCalibration });
            tbStepCalibration.Location = new Point(0, 0);
            tbStepCalibration.Name = "tbStepCalibration";
            tbStepCalibration.Size = new Size(1657, 27);
            tbStepCalibration.TabIndex = 1;
            tbStepCalibration.Text = "toolStrip1";
            // 
            // btnStartTimer_StepCalibration
            // 
            btnStartTimer_StepCalibration.Image = (Image)resources.GetObject("btnStartTimer_StepCalibration.Image");
            btnStartTimer_StepCalibration.ImageTransparentColor = Color.Magenta;
            btnStartTimer_StepCalibration.Name = "btnStartTimer_StepCalibration";
            btnStartTimer_StepCalibration.Size = new Size(93, 24);
            btnStartTimer_StepCalibration.Text = "开始计时";
            // 
            // pnlSystemMessage_StepCalibration
            // 
            pnlSystemMessage_StepCalibration.BackColor = Color.FromArgb(224, 224, 224);
            pnlSystemMessage_StepCalibration.Controls.Add(lblSystemMessage_StepCalibration);
            pnlSystemMessage_StepCalibration.Dock = DockStyle.Top;
            pnlSystemMessage_StepCalibration.Location = new Point(0, 27);
            pnlSystemMessage_StepCalibration.Margin = new Padding(4, 4, 4, 4);
            pnlSystemMessage_StepCalibration.Name = "pnlSystemMessage_StepCalibration";
            pnlSystemMessage_StepCalibration.Size = new Size(1657, 39);
            pnlSystemMessage_StepCalibration.TabIndex = 2;
            // 
            // lblSystemMessage_StepCalibration
            // 
            lblSystemMessage_StepCalibration.Dock = DockStyle.Fill;
            lblSystemMessage_StepCalibration.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSystemMessage_StepCalibration.ForeColor = Color.Red;
            lblSystemMessage_StepCalibration.Location = new Point(0, 0);
            lblSystemMessage_StepCalibration.Margin = new Padding(4, 0, 4, 0);
            lblSystemMessage_StepCalibration.Name = "lblSystemMessage_StepCalibration";
            lblSystemMessage_StepCalibration.Size = new Size(1657, 39);
            lblSystemMessage_StepCalibration.TabIndex = 0;
            lblSystemMessage_StepCalibration.Text = "系统消息";
            lblSystemMessage_StepCalibration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 66);
            splitMain.Margin = new Padding(4, 4, 4, 4);
            splitMain.Name = "splitMain";
            splitMain.Orientation = Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(splitSub);
            splitMain.Panel1.Controls.Add(pnlRealTimeData_StepCalibration);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(lvSensorData_StepCalibration);
            splitMain.Panel2.Padding = new Padding(6, 6, 6, 6);
            splitMain.Size = new Size(1657, 768);
            splitMain.SplitterDistance = 555;
            splitMain.SplitterWidth = 2;
            splitMain.TabIndex = 3;
            // 
            // splitSub
            // 
            splitSub.Dock = DockStyle.Fill;
            splitSub.Location = new Point(165, 0);
            splitSub.Margin = new Padding(4, 4, 4, 4);
            splitSub.Name = "splitSub";
            // 
            // splitSub.Panel1
            // 
            splitSub.Panel1.Controls.Add(gridChartContainer);
            // 
            // splitSub.Panel2
            // 
            splitSub.Panel2.Controls.Add(lvSystemMessage_StepCalibration);
            splitSub.Panel2.Padding = new Padding(6, 6, 6, 0);
            splitSub.Size = new Size(1492, 555);
            splitSub.SplitterDistance = 1213;
            splitSub.SplitterWidth = 3;
            splitSub.TabIndex = 1;
            // 
            // gridChartContainer
            // 
            gridChartContainer.ColumnCount = 1;
            gridChartContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gridChartContainer.Controls.Add(chartHRR, 0, 0);
            gridChartContainer.Controls.Add(chartSPR, 0, 1);
            gridChartContainer.Dock = DockStyle.Fill;
            gridChartContainer.Location = new Point(0, 0);
            gridChartContainer.Margin = new Padding(4, 4, 4, 4);
            gridChartContainer.Name = "gridChartContainer";
            gridChartContainer.Padding = new Padding(3, 2, 3, 2);
            gridChartContainer.RowCount = 2;
            gridChartContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridChartContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridChartContainer.Size = new Size(1213, 555);
            gridChartContainer.TabIndex = 0;
            // 
            // chartHRR
            // 
            chartArea1.Name = "ChartArea1";
            chartHRR.ChartAreas.Add(chartArea1);
            chartHRR.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartHRR.Legends.Add(legend1);
            chartHRR.Location = new Point(7, 6);
            chartHRR.Margin = new Padding(4, 4, 4, 4);
            chartHRR.Name = "chartHRR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartHRR.Series.Add(series1);
            chartHRR.Size = new Size(1199, 267);
            chartHRR.TabIndex = 0;
            chartHRR.Text = "chart1";
            // 
            // chartSPR
            // 
            chartArea2.Name = "ChartArea1";
            chartSPR.ChartAreas.Add(chartArea2);
            chartSPR.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartSPR.Legends.Add(legend2);
            chartSPR.Location = new Point(7, 281);
            chartSPR.Margin = new Padding(4, 4, 4, 4);
            chartSPR.Name = "chartSPR";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartSPR.Series.Add(series2);
            chartSPR.Size = new Size(1199, 268);
            chartSPR.TabIndex = 1;
            chartSPR.Text = "chart1";
            // 
            // lvSystemMessage_StepCalibration
            // 
            lvSystemMessage_StepCalibration.Columns.AddRange(new ColumnHeader[] { time, message });
            lvSystemMessage_StepCalibration.Dock = DockStyle.Fill;
            lvSystemMessage_StepCalibration.GridLines = true;
            lvSystemMessage_StepCalibration.Location = new Point(6, 6);
            lvSystemMessage_StepCalibration.Margin = new Padding(4, 4, 4, 4);
            lvSystemMessage_StepCalibration.Name = "lvSystemMessage_StepCalibration";
            lvSystemMessage_StepCalibration.Size = new Size(264, 549);
            lvSystemMessage_StepCalibration.TabIndex = 0;
            lvSystemMessage_StepCalibration.UseCompatibleStateImageBehavior = false;
            lvSystemMessage_StepCalibration.View = View.Details;
            // 
            // time
            // 
            time.Text = "时间";
            // 
            // message
            // 
            message.Text = "消息内容";
            message.TextAlign = HorizontalAlignment.Center;
            message.Width = 180;
            // 
            // pnlRealTimeData_StepCalibration
            // 
            pnlRealTimeData_StepCalibration.Controls.Add(groupBox1);
            pnlRealTimeData_StepCalibration.Dock = DockStyle.Left;
            pnlRealTimeData_StepCalibration.Location = new Point(0, 0);
            pnlRealTimeData_StepCalibration.Margin = new Padding(4, 4, 4, 4);
            pnlRealTimeData_StepCalibration.Name = "pnlRealTimeData_StepCalibration";
            pnlRealTimeData_StepCalibration.Size = new Size(165, 555);
            pnlRealTimeData_StepCalibration.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTimer_StepCalibration);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 2);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(143, 93);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblTimer_StepCalibration
            // 
            lblTimer_StepCalibration.BackColor = Color.Black;
            lblTimer_StepCalibration.Dock = DockStyle.Bottom;
            lblTimer_StepCalibration.FlatStyle = FlatStyle.Flat;
            lblTimer_StepCalibration.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimer_StepCalibration.ForeColor = Color.FromArgb(255, 255, 15);
            lblTimer_StepCalibration.Location = new Point(4, 37);
            lblTimer_StepCalibration.Margin = new Padding(1);
            lblTimer_StepCalibration.Name = "lblTimer_StepCalibration";
            lblTimer_StepCalibration.Size = new Size(135, 52);
            lblTimer_StepCalibration.TabIndex = 1;
            lblTimer_StepCalibration.Text = "8888";
            lblTimer_StepCalibration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(5, 14);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "计时(s)";
            // 
            // lvSensorData_StepCalibration
            // 
            lvSensorData_StepCalibration.Columns.AddRange(new ColumnHeader[] { timer, propane });
            lvSensorData_StepCalibration.Dock = DockStyle.Fill;
            lvSensorData_StepCalibration.FullRowSelect = true;
            lvSensorData_StepCalibration.GridLines = true;
            lvSensorData_StepCalibration.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvSensorData_StepCalibration.Location = new Point(6, 6);
            lvSensorData_StepCalibration.Margin = new Padding(4, 4, 4, 4);
            lvSensorData_StepCalibration.MultiSelect = false;
            lvSensorData_StepCalibration.Name = "lvSensorData_StepCalibration";
            lvSensorData_StepCalibration.Size = new Size(1645, 199);
            lvSensorData_StepCalibration.TabIndex = 0;
            lvSensorData_StepCalibration.UseCompatibleStateImageBehavior = false;
            lvSensorData_StepCalibration.View = View.Details;
            // 
            // timer
            // 
            timer.Text = "计时(s)";
            timer.Width = 120;
            // 
            // propane
            // 
            propane.Text = "丙烷流量(g/s)";
            propane.TextAlign = HorizontalAlignment.Center;
            propane.Width = 120;
            // 
            // StepCalibrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1657, 834);
            Controls.Add(splitMain);
            Controls.Add(pnlSystemMessage_StepCalibration);
            Controls.Add(tbStepCalibration);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StepCalibrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "梯级校准控制面板";
            tbStepCalibration.ResumeLayout(false);
            tbStepCalibration.PerformLayout();
            pnlSystemMessage_StepCalibration.ResumeLayout(false);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            splitSub.Panel1.ResumeLayout(false);
            splitSub.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitSub).EndInit();
            splitSub.ResumeLayout(false);
            gridChartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartHRR).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartSPR).EndInit();
            pnlRealTimeData_StepCalibration.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tbStepCalibration;
        private ToolStripButton btnStartTimer_StepCalibration;
        private Panel pnlSystemMessage_StepCalibration;
        private Label lblSystemMessage_StepCalibration;
        private SplitContainer splitMain;
        private SplitContainer splitSub;
        private ListView lvSystemMessage_StepCalibration;
        private ColumnHeader time;
        private ColumnHeader message;
        private Panel pnlRealTimeData_StepCalibration;
        private ListView lvSensorData_StepCalibration;
        private ColumnHeader timer;
        private ColumnHeader propane;
        private GroupBox groupBox1;
        private Label lblTimer_StepCalibration;
        private Label label1;
        private TableLayoutPanel gridChartContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHRR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSPR;
    }
}