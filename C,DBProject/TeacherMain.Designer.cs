namespace C_DBProject
{
    partial class TeacherMain
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
            this.subMinusPointBtn = new System.Windows.Forms.Button();
            this.addMinusPointBtn = new System.Windows.Forms.Button();
            this.addBonusPointBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subMinusPointBtn
            // 
            this.subMinusPointBtn.Font = new System.Drawing.Font("굴림", 14F);
            this.subMinusPointBtn.Location = new System.Drawing.Point(412, 114);
            this.subMinusPointBtn.Name = "subMinusPointBtn";
            this.subMinusPointBtn.Size = new System.Drawing.Size(165, 220);
            this.subMinusPointBtn.TabIndex = 6;
            this.subMinusPointBtn.Text = "벌점 상쇄";
            this.subMinusPointBtn.UseVisualStyleBackColor = true;
            this.subMinusPointBtn.Click += new System.EventHandler(this.subMinusPointBtn_Click);
            // 
            // addMinusPointBtn
            // 
            this.addMinusPointBtn.Font = new System.Drawing.Font("굴림", 14F);
            this.addMinusPointBtn.Location = new System.Drawing.Point(227, 114);
            this.addMinusPointBtn.Name = "addMinusPointBtn";
            this.addMinusPointBtn.Size = new System.Drawing.Size(165, 220);
            this.addMinusPointBtn.TabIndex = 5;
            this.addMinusPointBtn.Text = "벌점 등록";
            this.addMinusPointBtn.UseVisualStyleBackColor = true;
            this.addMinusPointBtn.Click += new System.EventHandler(this.addMinusPointBtn_Click);
            // 
            // addBonusPointBtn
            // 
            this.addBonusPointBtn.Font = new System.Drawing.Font("굴림", 14F);
            this.addBonusPointBtn.Location = new System.Drawing.Point(36, 114);
            this.addBonusPointBtn.Name = "addBonusPointBtn";
            this.addBonusPointBtn.Size = new System.Drawing.Size(165, 220);
            this.addBonusPointBtn.TabIndex = 4;
            this.addBonusPointBtn.Text = "상점 등록";
            this.addBonusPointBtn.UseVisualStyleBackColor = true;
            this.addBonusPointBtn.Click += new System.EventHandler(this.addBonusPointBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.Font = new System.Drawing.Font("굴림", 14F);
            this.exitBtn.Location = new System.Drawing.Point(595, 114);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(165, 220);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "종료";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // TeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.subMinusPointBtn);
            this.Controls.Add(this.addMinusPointBtn);
            this.Controls.Add(this.addBonusPointBtn);
            this.Name = "TeacherMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subMinusPointBtn;
        private System.Windows.Forms.Button addMinusPointBtn;
        private System.Windows.Forms.Button addBonusPointBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}