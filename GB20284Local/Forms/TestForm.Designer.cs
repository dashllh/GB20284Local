namespace GB20284Local.Forms;

partial class TestForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
        tbSpecimenTest = new ToolStrip();
        btnNewTest = new ToolStripButton();
        btnStartTimer = new ToolStripButton();
        btnStopTimer = new ToolStripButton();
        btnTestRecord = new ToolStripButton();
        chartHRR = new System.Windows.Forms.DataVisualization.Charting.Chart();
        panel1 = new Panel();
        groupBox1 = new GroupBox();
        lblCounter = new Label();
        label1 = new Label();
        tbSpecimenTest.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartHRR).BeginInit();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // tbSpecimenTest
        // 
        tbSpecimenTest.Items.AddRange(new ToolStripItem[] { btnNewTest, btnStartTimer, btnStopTimer, btnTestRecord });
        tbSpecimenTest.Location = new Point(0, 0);
        tbSpecimenTest.Name = "tbSpecimenTest";
        tbSpecimenTest.Size = new Size(1181, 25);
        tbSpecimenTest.TabIndex = 0;
        tbSpecimenTest.Text = "toolStrip1";
        // 
        // btnNewTest
        // 
        btnNewTest.Image = (Image)resources.GetObject("btnNewTest.Image");
        btnNewTest.ImageTransparentColor = Color.Magenta;
        btnNewTest.Name = "btnNewTest";
        btnNewTest.Size = new Size(76, 22);
        btnNewTest.Text = "新建试验";
        // 
        // btnStartTimer
        // 
        btnStartTimer.Image = (Image)resources.GetObject("btnStartTimer.Image");
        btnStartTimer.ImageTransparentColor = Color.Magenta;
        btnStartTimer.Name = "btnStartTimer";
        btnStartTimer.Size = new Size(76, 22);
        btnStartTimer.Text = "开始计时";
        btnStartTimer.Click += btnStartTimer_Click;
        // 
        // btnStopTimer
        // 
        btnStopTimer.Image = (Image)resources.GetObject("btnStopTimer.Image");
        btnStopTimer.ImageTransparentColor = Color.Magenta;
        btnStopTimer.Name = "btnStopTimer";
        btnStopTimer.Size = new Size(76, 22);
        btnStopTimer.Text = "停止计时";
        // 
        // btnTestRecord
        // 
        btnTestRecord.Image = (Image)resources.GetObject("btnTestRecord.Image");
        btnTestRecord.ImageTransparentColor = Color.Magenta;
        btnTestRecord.Name = "btnTestRecord";
        btnTestRecord.Size = new Size(76, 22);
        btnTestRecord.Text = "试验记录";
        // 
        // chartHRR
        // 
        chartHRR.BorderlineColor = Color.Transparent;
        chartHRR.BorderSkin.PageColor = Color.Silver;
        chartArea1.AxisX.Interval = 60D;
        chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
        chartArea1.AxisX.LabelStyle.ForeColor = Color.Gray;
        chartArea1.AxisX.LineColor = Color.LightGray;
        chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
        chartArea1.AxisX.Maximum = 300D;
        chartArea1.AxisX.Minimum = 0D;
        chartArea1.AxisY.LabelStyle.ForeColor = Color.Gray;
        chartArea1.AxisY.LineColor = Color.LightGray;
        chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
        chartArea1.AxisY.Minimum = 0D;
        chartArea1.AxisY.Title = "HRR (kw)";
        chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        chartArea1.AxisY.TitleForeColor = Color.Gray;
        chartArea1.BackColor = Color.Transparent;
        chartArea1.BorderColor = Color.Transparent;
        chartArea1.Name = "areaHRR";
        chartHRR.ChartAreas.Add(chartArea1);
        legend1.Alignment = StringAlignment.Center;
        legend1.BackColor = Color.Transparent;
        legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
        legend1.ForeColor = Color.Red;
        legend1.Name = "legendHRR";
        legend1.TitleForeColor = Color.Red;
        chartHRR.Legends.Add(legend1);
        chartHRR.Location = new Point(197, 41);
        chartHRR.Name = "chartHRR";
        series1.BorderColor = Color.Transparent;
        series1.ChartArea = "areaHRR";
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series1.Color = Color.Red;
        series1.Legend = "legendHRR";
        series1.Name = "HRR";
        series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        chartHRR.Series.Add(series1);
        chartHRR.Size = new Size(528, 250);
        chartHRR.TabIndex = 1;
        chartHRR.Text = "热释放速率(HRR)";
        title1.Name = "热释放速率(HRR)";
        title1.Text = "热释放速率曲线";
        chartHRR.Titles.Add(title1);
        // 
        // panel1
        // 
        panel1.Controls.Add(groupBox1);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 25);
        panel1.Name = "panel1";
        panel1.Size = new Size(155, 491);
        panel1.TabIndex = 2;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lblCounter);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(17, 9);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(121, 82);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // lblCounter
        // 
        lblCounter.BackColor = Color.Black;
        lblCounter.Dock = DockStyle.Bottom;
        lblCounter.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        lblCounter.ForeColor = Color.FromArgb(255, 255, 15);
        lblCounter.Location = new Point(3, 36);
        lblCounter.Name = "lblCounter";
        lblCounter.Size = new Size(115, 43);
        lblCounter.TabIndex = 1;
        lblCounter.Text = "8888";
        lblCounter.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.FlatStyle = FlatStyle.Flat;
        label1.Location = new Point(6, 15);
        label1.Name = "label1";
        label1.Size = new Size(65, 23);
        label1.TabIndex = 0;
        label1.Text = "计时(s)";
        // 
        // TestForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1181, 516);
        Controls.Add(panel1);
        Controls.Add(chartHRR);
        Controls.Add(tbSpecimenTest);
        Name = "TestForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "样品试验控制面板";
        tbSpecimenTest.ResumeLayout(false);
        tbSpecimenTest.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)chartHRR).EndInit();
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip tbSpecimenTest;
    private ToolStripButton btnNewTest;
    private ToolStripButton btnStartTimer;
    private ToolStripButton btnStopTimer;
    private ToolStripButton btnTestRecord;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartHRR;
    private Panel panel1;
    private GroupBox groupBox1;
    private Label lblCounter;
    private Label label1;
}