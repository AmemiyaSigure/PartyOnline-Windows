namespace PartyOnlineWindows
{
    partial class UpdateCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCheck));
            this.ProcessBar = new System.Windows.Forms.ProgressBar();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelUpdateCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcessBar
            // 
            this.ProcessBar.Location = new System.Drawing.Point(12, 12);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Size = new System.Drawing.Size(459, 23);
            this.ProcessBar.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(397, 41);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "取消";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // LabelUpdateCheck
            // 
            this.LabelUpdateCheck.AutoSize = true;
            this.LabelUpdateCheck.Location = new System.Drawing.Point(10, 46);
            this.LabelUpdateCheck.Name = "LabelUpdateCheck";
            this.LabelUpdateCheck.Size = new System.Drawing.Size(100, 17);
            this.LabelUpdateCheck.TabIndex = 2;
            this.LabelUpdateCheck.Text = "正在检查更新……";
            // 
            // UpdateCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(483, 77);
            this.Controls.Add(this.LabelUpdateCheck);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ProcessBar);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查 PartyOnline 更新……";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProcessBar;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label LabelUpdateCheck;
    }
}