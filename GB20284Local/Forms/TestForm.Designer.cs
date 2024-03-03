using GB20284Local.Models;

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
        System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
        tbSpecimenTest = new ToolStrip();
        btnNewTest = new ToolStripButton();
        btnStartTimer = new ToolStripButton();
        btnStopTimer = new ToolStripButton();
        btnTestRecord = new ToolStripButton();
        chartHRR = new System.Windows.Forms.DataVisualization.Charting.Chart();
        panel1 = new Panel();
        groupBox3 = new GroupBox();
        lblPropaneflow = new Label();
        label4 = new Label();
        groupBox2 = new GroupBox();
        lblV298 = new Label();
        label3 = new Label();
        groupBox1 = new GroupBox();
        lblCounter = new Label();
        label1 = new Label();
        chartSPR = new System.Windows.Forms.DataVisualization.Charting.Chart();
        tabInformation = new TabControl();
        tpSensorData = new TabPage();
        lvSensorData = new ListView();
        Counter = new ColumnHeader();
        PropaneFlow = new ColumnHeader();
        DPT = new ColumnHeader();
        Light = new ColumnHeader();
        O2Concentration = new ColumnHeader();
        CO2Concentration = new ColumnHeader();
        COConcentration = new ColumnHeader();
        DuctTemperature1 = new ColumnHeader();
        DuctTemperature2 = new ColumnHeader();
        DuctTemperature3 = new ColumnHeader();
        AmbientPressure = new ColumnHeader();
        tpKeyValue = new TabPage();
        label5 = new Label();
        label2 = new Label();
        groupBox4 = new GroupBox();
        lblTotalHRR = new Label();
        label7 = new Label();
        groupBox5 = new GroupBox();
        lblFigra = new Label();
        label8 = new Label();
        groupBox6 = new GroupBox();
        lblSPR = new Label();
        label9 = new Label();
        groupBox7 = new GroupBox();
        lblSMOGRA = new Label();
        label10 = new Label();
        tbSpecimenTest.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartHRR).BeginInit();
        panel1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartSPR).BeginInit();
        tabInformation.SuspendLayout();
        tpSensorData.SuspendLayout();
        tpKeyValue.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox7.SuspendLayout();
        SuspendLayout();
        // 
        // tbSpecimenTest
        // 
        tbSpecimenTest.Items.AddRange(new ToolStripItem[] { btnNewTest, btnStartTimer, btnStopTimer, btnTestRecord });
        tbSpecimenTest.Location = new Point(0, 0);
        tbSpecimenTest.Name = "tbSpecimenTest";
        tbSpecimenTest.Size = new Size(1233, 25);
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
        chartHRR.BackColor = Color.Transparent;
        chartHRR.BorderlineColor = Color.Transparent;
        chartHRR.BorderSkin.PageColor = Color.Silver;
        chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
        chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
        chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
        chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
        chartArea1.AxisX.Interval = 60D;
        chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
        chartArea1.AxisX.LabelStyle.ForeColor = Color.Gray;
        chartArea1.AxisX.LineColor = Color.LightGray;
        chartArea1.AxisX.MajorGrid.Enabled = false;
        chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
        chartArea1.AxisX.MajorTickMark.LineColor = Color.Gray;
        chartArea1.AxisX.Maximum = 300D;
        chartArea1.AxisX.Minimum = 0D;
        chartArea1.AxisX.MinorTickMark.LineColor = Color.Gray;
        chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
        chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
        chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
        chartArea1.AxisY.LabelStyle.ForeColor = Color.Gray;
        chartArea1.AxisY.LineColor = Color.Transparent;
        chartArea1.AxisY.MajorGrid.Enabled = false;
        chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
        chartArea1.AxisY.MajorTickMark.LineColor = Color.LightGray;
        chartArea1.AxisY.Minimum = 0D;
        chartArea1.AxisY.MinorGrid.LineColor = Color.LightGray;
        chartArea1.AxisY.MinorTickMark.LineColor = Color.LightGray;
        chartArea1.AxisY.Title = "HRR (kw)";
        chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        chartArea1.AxisY.TitleForeColor = Color.Gray;
        chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
        chartArea1.AxisY2.LabelStyle.ForeColor = Color.Gray;
        chartArea1.AxisY2.LineColor = Color.Transparent;
        chartArea1.AxisY2.MajorGrid.Enabled = false;
        chartArea1.AxisY2.MajorGrid.LineColor = Color.LightGray;
        chartArea1.AxisY2.MajorTickMark.LineColor = Color.LightGray;
        chartArea1.AxisY2.Minimum = 0D;
        chartArea1.AxisY2.MinorGrid.LineColor = Color.LightGray;
        chartArea1.AxisY2.MinorTickMark.LineColor = Color.LightGray;
        chartArea1.AxisY2.Title = "FIGRA (W/s)";
        chartArea1.AxisY2.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        chartArea1.AxisY2.TitleForeColor = Color.Gray;
        chartArea1.BackColor = Color.Black;
        chartArea1.BorderColor = Color.Transparent;
        chartArea1.Name = "areaHRR";
        chartHRR.ChartAreas.Add(chartArea1);
        legend1.BackColor = Color.Transparent;
        legend1.DockedToChartArea = "areaHRR";
        legend1.ForeColor = Color.Gray;
        legend1.Name = "legendHRR";
        legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
        legend1.TitleForeColor = Color.Transparent;
        chartHRR.Legends.Add(legend1);
        chartHRR.Location = new Point(176, 34);
        chartHRR.Name = "chartHRR";
        series1.BorderColor = Color.Transparent;
        series1.ChartArea = "areaHRR";
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series1.Color = Color.Red;
        series1.Legend = "legendHRR";
        series1.LegendText = "HRR";
        series1.Name = "HRR";
        series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        series2.BorderColor = Color.Transparent;
        series2.ChartArea = "areaHRR";
        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series2.Color = Color.FromArgb(128, 128, 255);
        series2.Legend = "legendHRR";
        series2.LegendText = "FIGRA";
        series2.Name = "Figra";
        series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
        series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        chartHRR.Series.Add(series1);
        chartHRR.Series.Add(series2);
        chartHRR.Size = new Size(884, 217);
        chartHRR.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.Controls.Add(groupBox3);
        panel1.Controls.Add(groupBox2);
        panel1.Controls.Add(groupBox1);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 25);
        panel1.Name = "panel1";
        panel1.Size = new Size(170, 649);
        panel1.TabIndex = 2;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lblPropaneflow);
        groupBox3.Controls.Add(label4);
        groupBox3.Location = new Point(35, 196);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(121, 82);
        groupBox3.TabIndex = 3;
        groupBox3.TabStop = false;
        // 
        // lblPropaneflow
        // 
        lblPropaneflow.BackColor = Color.Black;
        lblPropaneflow.Dock = DockStyle.Bottom;
        lblPropaneflow.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        lblPropaneflow.ForeColor = Color.FromArgb(255, 255, 15);
        lblPropaneflow.Location = new Point(3, 36);
        lblPropaneflow.Name = "lblPropaneflow";
        lblPropaneflow.Size = new Size(115, 43);
        lblPropaneflow.TabIndex = 1;
        lblPropaneflow.Text = "8888";
        lblPropaneflow.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.FlatStyle = FlatStyle.Flat;
        label4.Location = new Point(6, 15);
        label4.Name = "label4";
        label4.Size = new Size(95, 23);
        label4.TabIndex = 0;
        label4.Text = "丙烷流量(g/s)";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(lblV298);
        groupBox2.Controls.Add(label3);
        groupBox2.Location = new Point(35, 102);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(121, 82);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // lblV298
        // 
        lblV298.BackColor = Color.Black;
        lblV298.Dock = DockStyle.Bottom;
        lblV298.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        lblV298.ForeColor = Color.FromArgb(255, 255, 15);
        lblV298.Location = new Point(3, 36);
        lblV298.Name = "lblV298";
        lblV298.Size = new Size(115, 43);
        lblV298.TabIndex = 1;
        lblV298.Text = "8888";
        lblV298.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.FlatStyle = FlatStyle.Flat;
        label3.Location = new Point(6, 15);
        label3.Name = "label3";
        label3.Size = new Size(85, 23);
        label3.TabIndex = 0;
        label3.Text = "V298(m3/s)";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lblCounter);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(35, 9);
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
        // chartSPR
        // 
        chartSPR.BackColor = Color.Transparent;
        chartSPR.BorderlineColor = Color.Transparent;
        chartArea2.AxisX.LabelStyle.ForeColor = Color.Gray;
        chartArea2.AxisX.MajorTickMark.LineColor = Color.Gray;
        chartArea2.AxisX.Minimum = 0D;
        chartArea2.AxisX.TitleForeColor = Color.LightGray;
        chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
        chartArea2.AxisY.LabelStyle.ForeColor = Color.Gray;
        chartArea2.AxisY.MajorTickMark.LineColor = Color.Gray;
        chartArea2.AxisY.Minimum = 0D;
        chartArea2.AxisY.Title = "SPR(m2/s)";
        chartArea2.AxisY.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        chartArea2.AxisY.TitleForeColor = Color.Gray;
        chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
        chartArea2.AxisY2.LabelStyle.ForeColor = Color.Gray;
        chartArea2.AxisY2.MajorTickMark.LineColor = Color.Gray;
        chartArea2.AxisY2.Minimum = 0D;
        chartArea2.AxisY2.MinorTickMark.LineColor = Color.Gray;
        chartArea2.AxisY2.Title = "SMOGRA(cm2/s2)";
        chartArea2.AxisY2.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        chartArea2.AxisY2.TitleForeColor = Color.Gray;
        chartArea2.BackColor = Color.Black;
        chartArea2.Name = "areaSPR";
        chartSPR.ChartAreas.Add(chartArea2);
        legend2.Alignment = StringAlignment.Far;
        legend2.BackColor = Color.Transparent;
        legend2.DockedToChartArea = "areaSPR";
        legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
        legend2.ForeColor = Color.Gray;
        legend2.Name = "legendSPR";
        legend2.TitleBackColor = Color.Transparent;
        chartSPR.Legends.Add(legend2);
        chartSPR.Location = new Point(176, 276);
        chartSPR.Name = "chartSPR";
        series3.ChartArea = "areaSPR";
        series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series3.Legend = "legendSPR";
        series3.LegendText = "SPR";
        series3.Name = "serieSPR";
        series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        series4.ChartArea = "areaSPR";
        series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series4.Legend = "legendSPR";
        series4.LegendText = "SMOGRA";
        series4.Name = "serieSMOGRA";
        series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
        series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        chartSPR.Series.Add(series3);
        chartSPR.Series.Add(series4);
        chartSPR.Size = new Size(884, 217);
        chartSPR.TabIndex = 3;
        // 
        // tabInformation
        // 
        tabInformation.Alignment = TabAlignment.Bottom;
        tabInformation.Controls.Add(tpSensorData);
        tabInformation.Controls.Add(tpKeyValue);
        tabInformation.Location = new Point(206, 512);
        tabInformation.Margin = new Padding(6);
        tabInformation.Multiline = true;
        tabInformation.Name = "tabInformation";
        tabInformation.SelectedIndex = 0;
        tabInformation.Size = new Size(991, 147);
        tabInformation.TabIndex = 4;
        // 
        // tpSensorData
        // 
        tpSensorData.BackColor = Color.White;
        tpSensorData.BorderStyle = BorderStyle.FixedSingle;
        tpSensorData.Controls.Add(lvSensorData);
        tpSensorData.Location = new Point(4, 4);
        tpSensorData.Name = "tpSensorData";
        tpSensorData.Padding = new Padding(3);
        tpSensorData.Size = new Size(983, 117);
        tpSensorData.TabIndex = 0;
        tpSensorData.Text = "传感器实时值";
        // 
        // lvSensorData
        // 
        lvSensorData.BorderStyle = BorderStyle.None;
        lvSensorData.Columns.AddRange(new ColumnHeader[] { Counter, PropaneFlow, DPT, Light, O2Concentration, CO2Concentration, COConcentration, DuctTemperature1, DuctTemperature2, DuctTemperature3, AmbientPressure });
        lvSensorData.Dock = DockStyle.Fill;
        lvSensorData.FullRowSelect = true;
        lvSensorData.GridLines = true;
        lvSensorData.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        lvSensorData.Location = new Point(3, 3);
        lvSensorData.Name = "lvSensorData";
        lvSensorData.Size = new Size(975, 109);
        lvSensorData.TabIndex = 0;
        lvSensorData.UseCompatibleStateImageBehavior = false;
        lvSensorData.View = View.Details;
        // 
        // Counter
        // 
        Counter.Text = "计时(s)";
        // 
        // PropaneFlow
        // 
        PropaneFlow.Text = "丙烷流量(g/s)";
        PropaneFlow.TextAlign = HorizontalAlignment.Center;
        PropaneFlow.Width = 90;
        // 
        // DPT
        // 
        DPT.Text = "管道压差(Pa)";
        DPT.TextAlign = HorizontalAlignment.Center;
        DPT.Width = 85;
        // 
        // Light
        // 
        Light.Text = "透光率(%)";
        Light.TextAlign = HorizontalAlignment.Center;
        Light.Width = 80;
        // 
        // O2Concentration
        // 
        O2Concentration.Text = "O2浓度(%)";
        O2Concentration.TextAlign = HorizontalAlignment.Center;
        O2Concentration.Width = 80;
        // 
        // CO2Concentration
        // 
        CO2Concentration.Text = "CO2浓度(%)";
        CO2Concentration.TextAlign = HorizontalAlignment.Center;
        CO2Concentration.Width = 81;
        // 
        // COConcentration
        // 
        COConcentration.Text = "CO浓度(%)";
        COConcentration.TextAlign = HorizontalAlignment.Center;
        COConcentration.Width = 80;
        // 
        // DuctTemperature1
        // 
        DuctTemperature1.Text = "管道温度1(℃)";
        DuctTemperature1.TextAlign = HorizontalAlignment.Center;
        DuctTemperature1.Width = 90;
        // 
        // DuctTemperature2
        // 
        DuctTemperature2.Text = "管道温度2(℃)";
        DuctTemperature2.TextAlign = HorizontalAlignment.Center;
        DuctTemperature2.Width = 90;
        // 
        // DuctTemperature3
        // 
        DuctTemperature3.Text = "管道温度3(℃)";
        DuctTemperature3.TextAlign = HorizontalAlignment.Center;
        DuctTemperature3.Width = 90;
        // 
        // AmbientPressure
        // 
        AmbientPressure.Text = "环境压力(kPa)";
        AmbientPressure.TextAlign = HorizontalAlignment.Center;
        AmbientPressure.Width = 90;
        // 
        // tpKeyValue
        // 
        tpKeyValue.BackColor = Color.White;
        tpKeyValue.BorderStyle = BorderStyle.FixedSingle;
        tpKeyValue.Controls.Add(label5);
        tpKeyValue.Controls.Add(label2);
        tpKeyValue.Location = new Point(4, 4);
        tpKeyValue.Name = "tpKeyValue";
        tpKeyValue.Padding = new Padding(3);
        tpKeyValue.Size = new Size(983, 117);
        tpKeyValue.TabIndex = 1;
        tpKeyValue.Text = "试验初始条件";
        // 
        // label5
        // 
        label5.Location = new Point(19, 49);
        label5.Name = "label5";
        label5.Size = new Size(133, 23);
        label5.TabIndex = 1;
        label5.Text = "燃烧器平均HRR标准差:";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Location = new Point(19, 12);
        label2.Name = "label2";
        label2.Size = new Size(133, 23);
        label2.TabIndex = 0;
        label2.Text = "燃烧器平均HRR(kW):";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(lblTotalHRR);
        groupBox4.Controls.Add(label7);
        groupBox4.Location = new Point(1076, 43);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(121, 82);
        groupBox4.TabIndex = 4;
        groupBox4.TabStop = false;
        // 
        // lblTotalHRR
        // 
        lblTotalHRR.BackColor = Color.Black;
        lblTotalHRR.Dock = DockStyle.Bottom;
        lblTotalHRR.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        lblTotalHRR.ForeColor = Color.FromArgb(255, 255, 15);
        lblTotalHRR.Location = new Point(3, 36);
        lblTotalHRR.Name = "lblTotalHRR";
        lblTotalHRR.Size = new Size(115, 43);
        lblTotalHRR.TabIndex = 1;
        lblTotalHRR.Text = "8888";
        lblTotalHRR.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label7
        // 
        label7.FlatStyle = FlatStyle.Flat;
        label7.Location = new Point(6, 15);
        label7.Name = "label7";
        label7.Size = new Size(95, 23);
        label7.TabIndex = 0;
        label7.Text = "HRR(kW)";
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(lblFigra);
        groupBox5.Controls.Add(label8);
        groupBox5.Location = new Point(1076, 132);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(121, 82);
        groupBox5.TabIndex = 5;
        groupBox5.TabStop = false;
        // 
        // lblFigra
        // 
        lblFigra.BackColor = Color.Black;
        lblFigra.Dock = DockStyle.Bottom;
        lblFigra.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        lblFigra.ForeColor = Color.FromArgb(255, 255, 15);
        lblFigra.Location = new Point(3, 36);
        lblFigra.Name = "lblFigra";
        lblFigra.Size = new Size(115, 43);
        lblFigra.TabIndex = 1;
        lblFigra.Text = "8888";
        lblFigra.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label8
        // 
        label8.FlatStyle = FlatStyle.Flat;
        label8.Location = new Point(6, 15);
        label8.Name = "label8";
        label8.Size = new Size(95, 23);
        label8.TabIndex = 0;
        label8.Text = "FIGRA(W/s)";
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(lblSPR);
        groupBox6.Controls.Add(label9);
        groupBox6.Location = new Point(1076, 286);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(121, 82);
        groupBox6.TabIndex = 6;
        groupBox6.TabStop = false;
        // 
        // lblSPR
        // 
        lblSPR.BackColor = Color.Black;
        lblSPR.Dock = DockStyle.Bottom;
        lblSPR.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        lblSPR.ForeColor = Color.FromArgb(255, 255, 15);
        lblSPR.Location = new Point(3, 36);
        lblSPR.Name = "lblSPR";
        lblSPR.Size = new Size(115, 43);
        lblSPR.TabIndex = 1;
        lblSPR.Text = "8888";
        lblSPR.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label9
        // 
        label9.FlatStyle = FlatStyle.Flat;
        label9.Location = new Point(6, 15);
        label9.Name = "label9";
        label9.Size = new Size(95, 23);
        label9.TabIndex = 0;
        label9.Text = "SPR(m2/s)";
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(lblSMOGRA);
        groupBox7.Controls.Add(label10);
        groupBox7.Location = new Point(1076, 383);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new Size(121, 82);
        groupBox7.TabIndex = 7;
        groupBox7.TabStop = false;
        // 
        // lblSMOGRA
        // 
        lblSMOGRA.BackColor = Color.Black;
        lblSMOGRA.Dock = DockStyle.Bottom;
        lblSMOGRA.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        lblSMOGRA.ForeColor = Color.FromArgb(255, 255, 15);
        lblSMOGRA.Location = new Point(3, 36);
        lblSMOGRA.Name = "lblSMOGRA";
        lblSMOGRA.Size = new Size(115, 43);
        lblSMOGRA.TabIndex = 1;
        lblSMOGRA.Text = "8888";
        lblSMOGRA.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label10
        // 
        label10.FlatStyle = FlatStyle.Flat;
        label10.Location = new Point(6, 15);
        label10.Name = "label10";
        label10.Size = new Size(112, 23);
        label10.TabIndex = 0;
        label10.Text = "SMOGRA(cm2/s2)";
        // 
        // TestForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1233, 674);
        Controls.Add(groupBox7);
        Controls.Add(groupBox6);
        Controls.Add(groupBox5);
        Controls.Add(groupBox4);
        Controls.Add(tabInformation);
        Controls.Add(chartSPR);
        Controls.Add(panel1);
        Controls.Add(chartHRR);
        Controls.Add(tbSpecimenTest);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TestForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "样品试验控制面板";
        tbSpecimenTest.ResumeLayout(false);
        tbSpecimenTest.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)chartHRR).EndInit();
        panel1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chartSPR).EndInit();
        tabInformation.ResumeLayout(false);
        tpSensorData.ResumeLayout(false);
        tpKeyValue.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox5.ResumeLayout(false);
        groupBox6.ResumeLayout(false);
        groupBox7.ResumeLayout(false);
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
    private GroupBox groupBox2;
    private Label lblV298;
    private Label label3;
    private GroupBox groupBox3;
    private Label lblPropaneflow;
    private Label label4;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartSPR;
    private TabControl tabInformation;
    private TabPage tpSensorData;
    private TabPage tpKeyValue;
    private ListView lvSensorData;
    private ColumnHeader Counter;
    private Label label2;
    private Label label5;
    private ColumnHeader PropaneFlow;
    private ColumnHeader DPT;
    private ColumnHeader Light;
    private ColumnHeader O2Concentration;
    private ColumnHeader CO2Concentration;
    private GroupBox groupBox4;
    private Label lblTotalHRR;
    private Label label7;
    private GroupBox groupBox5;
    private Label lblFigra;
    private Label label8;
    private GroupBox groupBox6;
    private Label lblSPR;
    private Label label9;
    private GroupBox groupBox7;
    private Label lblSMOGRA;
    private Label label10;
    private ColumnHeader COConcentration;
    private ColumnHeader DuctTemperature1;
    private ColumnHeader DuctTemperature2;
    private ColumnHeader DuctTemperature3;
    private ColumnHeader AmbientPressure;
}