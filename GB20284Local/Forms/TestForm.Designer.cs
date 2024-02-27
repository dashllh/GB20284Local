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
        tbSpecimenTest.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartHRR).BeginInit();
        SuspendLayout();
        // 
        // tbSpecimenTest
        // 
        tbSpecimenTest.Items.AddRange(new ToolStripItem[] { btnNewTest, btnStartTimer, btnStopTimer, btnTestRecord });
        tbSpecimenTest.Location = new Point(0, 0);
        tbSpecimenTest.Name = "tbSpecimenTest";
        tbSpecimenTest.Size = new Size(1252, 25);
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
        chartArea1.AxisX.Interval = 300D;
        chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
        chartArea1.AxisX.LineColor = Color.LightGray;
        chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
        chartArea1.AxisX.Maximum = 1600D;
        chartArea1.AxisX.Minimum = 0D;
        chartArea1.AxisY.LineColor = Color.LightGray;
        chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
        chartArea1.AxisY.Minimum = 0D;
        chartArea1.BackColor = Color.Transparent;
        chartArea1.BorderColor = Color.Transparent;
        chartArea1.Name = "areaHRR";
        chartHRR.ChartAreas.Add(chartArea1);
        legend1.BackColor = Color.Transparent;
        legend1.ForeColor = Color.Red;
        legend1.Name = "legendHRR";
        legend1.TitleForeColor = Color.Red;
        chartHRR.Legends.Add(legend1);
        chartHRR.Location = new Point(223, 46);
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
        chartHRR.Size = new Size(953, 250);
        chartHRR.TabIndex = 1;
        chartHRR.Text = "热释放速率(HRR)";
        title1.Name = "热释放速率(HRR)";
        chartHRR.Titles.Add(title1);
        // 
        // TestForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1252, 608);
        Controls.Add(chartHRR);
        Controls.Add(tbSpecimenTest);
        Name = "TestForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "样品试验控制面板";
        tbSpecimenTest.ResumeLayout(false);
        tbSpecimenTest.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)chartHRR).EndInit();
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
}