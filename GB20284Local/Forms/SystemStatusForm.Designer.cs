namespace GB20284Local.Forms
{
    partial class SystemStatusForm
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
            label1 = new Label();
            lblGasFlow = new Label();
            label2 = new Label();
            lblO2Concentration = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 50);
            label1.Name = "label1";
            label1.Size = new Size(97, 27);
            label1.TabIndex = 0;
            label1.Text = "丙烷流量:";
            // 
            // lblGasFlow
            // 
            lblGasFlow.BackColor = Color.Black;
            lblGasFlow.FlatStyle = FlatStyle.Flat;
            lblGasFlow.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblGasFlow.ForeColor = Color.FromArgb(255, 255, 15);
            lblGasFlow.Location = new Point(160, 40);
            lblGasFlow.Name = "lblGasFlow";
            lblGasFlow.Size = new Size(145, 46);
            lblGasFlow.TabIndex = 1;
            lblGasFlow.Text = "8888";
            lblGasFlow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 129);
            label2.Name = "label2";
            label2.Size = new Size(97, 27);
            label2.TabIndex = 2;
            label2.Text = "氧气浓度:";
            // 
            // lblO2Concentration
            // 
            lblO2Concentration.BackColor = Color.Black;
            lblO2Concentration.FlatStyle = FlatStyle.Flat;
            lblO2Concentration.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblO2Concentration.ForeColor = Color.FromArgb(255, 255, 15);
            lblO2Concentration.Location = new Point(160, 119);
            lblO2Concentration.Name = "lblO2Concentration";
            lblO2Concentration.Size = new Size(145, 46);
            lblO2Concentration.TabIndex = 3;
            lblO2Concentration.Text = "8888";
            lblO2Concentration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SystemStatusForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 523);
            Controls.Add(lblO2Concentration);
            Controls.Add(label2);
            Controls.Add(lblGasFlow);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SystemStatusForm";
            Text = "系统状态";
            Load += SystemStatusForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblGasFlow;
        private Label label2;
        private Label lblO2Concentration;
    }
}