namespace C_DBProject
{
    partial class StudentMain
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.viewPointBtn = new System.Windows.Forms.Button();
            this.applySubMinusPointBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.Font = new System.Drawing.Font("굴림", 14F);
            this.exitBtn.Location = new System.Drawing.Point(521, 113);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(188, 220);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "종료";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // viewPointBtn
            // 
            this.viewPointBtn.Font = new System.Drawing.Font("굴림", 14F);
            this.viewPointBtn.Location = new System.Drawing.Point(101, 113);
            this.viewPointBtn.Name = "viewPointBtn";
            this.viewPointBtn.Size = new System.Drawing.Size(188, 220);
            this.viewPointBtn.TabIndex = 4;
            this.viewPointBtn.Text = "상벌점 조회";
            this.viewPointBtn.UseVisualStyleBackColor = true;
            this.viewPointBtn.Click += new System.EventHandler(this.viewPointBtn_Click);
            // 
            // applySubMinusPointBtn
            // 
            this.applySubMinusPointBtn.Font = new System.Drawing.Font("굴림", 14F);
            this.applySubMinusPointBtn.Location = new System.Drawing.Point(309, 113);
            this.applySubMinusPointBtn.Name = "applySubMinusPointBtn";
            this.applySubMinusPointBtn.Size = new System.Drawing.Size(188, 220);
            this.applySubMinusPointBtn.TabIndex = 5;
            this.applySubMinusPointBtn.Text = "벌점 상쇄 신청";
            this.applySubMinusPointBtn.UseVisualStyleBackColor = true;
            this.applySubMinusPointBtn.Click += new System.EventHandler(this.applySubMinusPointBtn_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applySubMinusPointBtn);
            this.Controls.Add(this.viewPointBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button viewPointBtn;
        private System.Windows.Forms.Button applySubMinusPointBtn;
    }
}