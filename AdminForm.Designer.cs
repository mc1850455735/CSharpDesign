namespace CSharpDesign
{
    partial class AdminForm
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
            this.btnManaUser = new System.Windows.Forms.Button();
            this.btnManaSub = new System.Windows.Forms.Button();
            this.btnManaKno = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManaUser
            // 
            this.btnManaUser.Location = new System.Drawing.Point(115, 123);
            this.btnManaUser.Name = "btnManaUser";
            this.btnManaUser.Size = new System.Drawing.Size(130, 40);
            this.btnManaUser.TabIndex = 0;
            this.btnManaUser.Text = "用户管理";
            this.btnManaUser.UseVisualStyleBackColor = true;
            this.btnManaUser.Click += new System.EventHandler(this.btnManaUser_Click);
            // 
            // btnManaSub
            // 
            this.btnManaSub.Location = new System.Drawing.Point(115, 187);
            this.btnManaSub.Name = "btnManaSub";
            this.btnManaSub.Size = new System.Drawing.Size(130, 40);
            this.btnManaSub.TabIndex = 1;
            this.btnManaSub.Text = "考试科目管理";
            this.btnManaSub.UseVisualStyleBackColor = true;
            // 
            // btnManaKno
            // 
            this.btnManaKno.Location = new System.Drawing.Point(115, 251);
            this.btnManaKno.Name = "btnManaKno";
            this.btnManaKno.Size = new System.Drawing.Size(130, 40);
            this.btnManaKno.TabIndex = 2;
            this.btnManaKno.Text = "知识点管理";
            this.btnManaKno.UseVisualStyleBackColor = true;
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(115, 315);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(130, 40);
            this.btnTitle.TabIndex = 3;
            this.btnTitle.Text = "题目管理";
            this.btnTitle.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(18, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 15);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "此处显示欢迎信息";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 453);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnManaKno);
            this.Controls.Add(this.btnManaSub);
            this.Controls.Add(this.btnManaUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManaUser;
        private System.Windows.Forms.Button btnManaSub;
        private System.Windows.Forms.Button btnManaKno;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Label lblWelcome;
    }
}