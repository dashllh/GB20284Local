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
        tbSpecimenTest = new ToolStrip();
        btnNewTest = new ToolStripButton();
        btnStartTimer = new ToolStripButton();
        btnStopTimer = new ToolStripButton();
        btnTestRecord = new ToolStripButton();
        tbSpecimenTest.SuspendLayout();
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
        // TestForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1252, 608);
        Controls.Add(tbSpecimenTest);
        Name = "TestForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "样品试验控制面板";
        tbSpecimenTest.ResumeLayout(false);
        tbSpecimenTest.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip tbSpecimenTest;
    private ToolStripButton btnNewTest;
    private ToolStripButton btnStartTimer;
    private ToolStripButton btnStopTimer;
    private ToolStripButton btnTestRecord;
}