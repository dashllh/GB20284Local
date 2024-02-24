namespace GB20284Local.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnOpenTestView = new Button();
            btnCalibration = new Button();
            btnSystemTools = new Button();
            btnViews = new Button();
            btnAbout = new Button();
            btnQuit = new Button();
            menuCalibration = new ContextMenuStrip(components);
            menuItemKtv = new ToolStripMenuItem();
            menuItemKtvStep = new ToolStripMenuItem();
            menuItemHeptane = new ToolStripMenuItem();
            menuSystemTools = new ContextMenuStrip(components);
            menuItemSystemStatus = new ToolStripMenuItem();
            menuCalibration.SuspendLayout();
            menuSystemTools.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenTestView
            // 
            btnOpenTestView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOpenTestView.BackColor = Color.FromArgb(79, 105, 145);
            btnOpenTestView.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnOpenTestView.FlatStyle = FlatStyle.Flat;
            btnOpenTestView.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenTestView.ForeColor = Color.White;
            btnOpenTestView.Image = (Image)resources.GetObject("btnOpenTestView.Image");
            btnOpenTestView.Location = new Point(91, 501);
            btnOpenTestView.Margin = new Padding(3, 4, 3, 4);
            btnOpenTestView.Name = "btnOpenTestView";
            btnOpenTestView.Size = new Size(140, 44);
            btnOpenTestView.TabIndex = 0;
            btnOpenTestView.Text = "样品试验";
            btnOpenTestView.TextAlign = ContentAlignment.MiddleRight;
            btnOpenTestView.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOpenTestView.UseVisualStyleBackColor = false;
            btnOpenTestView.Click += btnNewTest_Click;
            // 
            // btnCalibration
            // 
            btnCalibration.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCalibration.BackColor = Color.FromArgb(79, 105, 145);
            btnCalibration.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCalibration.FlatStyle = FlatStyle.Flat;
            btnCalibration.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalibration.ForeColor = Color.White;
            btnCalibration.Image = (Image)resources.GetObject("btnCalibration.Image");
            btnCalibration.Location = new Point(262, 501);
            btnCalibration.Margin = new Padding(3, 4, 3, 4);
            btnCalibration.Name = "btnCalibration";
            btnCalibration.Size = new Size(140, 44);
            btnCalibration.TabIndex = 1;
            btnCalibration.Text = "系统校准";
            btnCalibration.TextAlign = ContentAlignment.MiddleRight;
            btnCalibration.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCalibration.UseVisualStyleBackColor = false;
            btnCalibration.Click += btnCalibration_Click;
            // 
            // btnSystemTools
            // 
            btnSystemTools.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSystemTools.BackColor = Color.FromArgb(79, 105, 145);
            btnSystemTools.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSystemTools.FlatStyle = FlatStyle.Flat;
            btnSystemTools.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSystemTools.ForeColor = Color.White;
            btnSystemTools.Image = (Image)resources.GetObject("btnSystemTools.Image");
            btnSystemTools.Location = new Point(433, 501);
            btnSystemTools.Margin = new Padding(3, 4, 3, 4);
            btnSystemTools.Name = "btnSystemTools";
            btnSystemTools.Size = new Size(140, 44);
            btnSystemTools.TabIndex = 2;
            btnSystemTools.Text = "系统工具";
            btnSystemTools.TextAlign = ContentAlignment.MiddleRight;
            btnSystemTools.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSystemTools.UseVisualStyleBackColor = false;
            btnSystemTools.Click += btnSystemTools_Click;
            // 
            // btnViews
            // 
            btnViews.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnViews.BackColor = Color.FromArgb(79, 105, 145);
            btnViews.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnViews.FlatStyle = FlatStyle.Flat;
            btnViews.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViews.ForeColor = Color.White;
            btnViews.Image = (Image)resources.GetObject("btnViews.Image");
            btnViews.Location = new Point(604, 501);
            btnViews.Margin = new Padding(3, 4, 3, 4);
            btnViews.Name = "btnViews";
            btnViews.Size = new Size(140, 44);
            btnViews.TabIndex = 3;
            btnViews.Text = "视图组件";
            btnViews.TextAlign = ContentAlignment.MiddleRight;
            btnViews.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnViews.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbout.BackColor = Color.FromArgb(79, 105, 145);
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.White;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.Location = new Point(1076, 501);
            btnAbout.Margin = new Padding(3, 4, 3, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(140, 44);
            btnAbout.TabIndex = 4;
            btnAbout.Text = "关于系统";
            btnAbout.TextAlign = ContentAlignment.MiddleRight;
            btnAbout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuit.BackColor = Color.FromArgb(79, 105, 145);
            btnQuit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.White;
            btnQuit.Image = (Image)resources.GetObject("btnQuit.Image");
            btnQuit.Location = new Point(1237, 501);
            btnQuit.Margin = new Padding(3, 4, 3, 4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(140, 44);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "退出";
            btnQuit.TextAlign = ContentAlignment.MiddleRight;
            btnQuit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // menuCalibration
            // 
            menuCalibration.ImageScalingSize = new Size(20, 20);
            menuCalibration.Items.AddRange(new ToolStripItem[] { menuItemKtv, menuItemKtvStep, menuItemHeptane });
            menuCalibration.Name = "menuCalibration";
            menuCalibration.Size = new Size(169, 76);
            menuCalibration.ItemClicked += menuCalibration_ItemClicked;
            // 
            // menuItemKtv
            // 
            menuItemKtv.Name = "menuItemKtv";
            menuItemKtv.Size = new Size(168, 24);
            menuItemKtv.Text = "风速因子校准";
            // 
            // menuItemKtvStep
            // 
            menuItemKtvStep.Name = "menuItemKtvStep";
            menuItemKtvStep.Size = new Size(168, 24);
            menuItemKtvStep.Text = "梯级校准";
            menuItemKtvStep.Click += menuItemKtvStep_Click;
            // 
            // menuItemHeptane
            // 
            menuItemHeptane.Name = "menuItemHeptane";
            menuItemHeptane.Size = new Size(168, 24);
            menuItemHeptane.Text = "正庚烷校准";
            // 
            // menuSystemTools
            // 
            menuSystemTools.ImageScalingSize = new Size(20, 20);
            menuSystemTools.Items.AddRange(new ToolStripItem[] { menuItemSystemStatus });
            menuSystemTools.Name = "menuSystemTools";
            menuSystemTools.Size = new Size(211, 56);
            menuSystemTools.ItemClicked += menuSystemTools_ItemClicked;
            // 
            // menuItemSystemStatus
            // 
            menuItemSystemStatus.Name = "menuItemSystemStatus";
            menuItemSystemStatus.Size = new Size(210, 24);
            menuItemSystemStatus.Text = "查看系统状态";
            menuItemSystemStatus.Click += menuItemSystemStatus_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1413, 668);
            Controls.Add(btnQuit);
            Controls.Add(btnAbout);
            Controls.Add(btnViews);
            Controls.Add(btnSystemTools);
            Controls.Add(btnCalibration);
            Controls.Add(btnOpenTestView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "建筑材料及制品的单体燃烧试验控制系统  版本 2.0";
            Load += frmMain_Load;
            menuCalibration.ResumeLayout(false);
            menuSystemTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenTestView;
        private Button btnCalibration;
        private Button btnSystemTools;
        private Button btnViews;
        private Button btnAbout;
        private Button btnQuit;
        private ContextMenuStrip menuCalibration;
        private ToolStripMenuItem menuItemKtv;
        private ToolStripMenuItem menuItemKtvStep;
        private ToolStripMenuItem menuItemHeptane;
        private ContextMenuStrip menuSystemTools;
        private ToolStripMenuItem menuItemSystemStatus;
    }
}