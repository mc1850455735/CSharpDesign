namespace CSharpDesign
{
    partial class UserForm
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
            this.btnSearchPaper = new System.Windows.Forms.Button();
            this.btnMakePaper = new System.Windows.Forms.Button();
            this.btnManaPaper = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchPaper
            // 
            this.btnSearchPaper.Location = new System.Drawing.Point(106, 133);
            this.btnSearchPaper.Name = "btnSearchPaper";
            this.btnSearchPaper.Size = new System.Drawing.Size(130, 40);
            this.btnSearchPaper.TabIndex = 0;
            this.btnSearchPaper.Text = "试卷查询";
            this.btnSearchPaper.UseVisualStyleBackColor = true;
            // 
            // btnMakePaper
            // 
            this.btnMakePaper.Location = new System.Drawing.Point(106, 227);
            this.btnMakePaper.Name = "btnMakePaper";
            this.btnMakePaper.Size = new System.Drawing.Size(130, 40);
            this.btnMakePaper.TabIndex = 0;
            this.btnMakePaper.Text = "组卷";
            this.btnMakePaper.UseVisualStyleBackColor = true;
            // 
            // btnManaPaper
            // 
            this.btnManaPaper.Location = new System.Drawing.Point(106, 321);
            this.btnManaPaper.Name = "btnManaPaper";
            this.btnManaPaper.Size = new System.Drawing.Size(130, 40);
            this.btnManaPaper.TabIndex = 0;
            this.btnManaPaper.Text = "试卷管理";
            this.btnManaPaper.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(25, 61);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 15);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "此处显示欢迎信息";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 453);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnManaPaper);
            this.Controls.Add(this.btnMakePaper);
            this.Controls.Add(this.btnSearchPaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPaper;
        private System.Windows.Forms.Button btnMakePaper;
        private System.Windows.Forms.Button btnManaPaper;
        private System.Windows.Forms.Label lblWelcome;
    }
}