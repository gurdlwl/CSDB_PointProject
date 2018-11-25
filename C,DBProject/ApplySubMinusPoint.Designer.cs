namespace C_DBProject
{
    partial class ApplySubMinusPoint
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbStuId = new System.Windows.Forms.Label();
            this.lbStuName = new System.Windows.Forms.Label();
            this.lbReason = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(331, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(250, 316);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbStuId
            // 
            this.lbStuId.AutoSize = true;
            this.lbStuId.Location = new System.Drawing.Point(61, 55);
            this.lbStuId.Name = "lbStuId";
            this.lbStuId.Size = new System.Drawing.Size(29, 12);
            this.lbStuId.TabIndex = 22;
            this.lbStuId.Text = "학번";
            // 
            // lbStuName
            // 
            this.lbStuName.AutoSize = true;
            this.lbStuName.Location = new System.Drawing.Point(228, 55);
            this.lbStuName.Name = "lbStuName";
            this.lbStuName.Size = new System.Drawing.Size(29, 12);
            this.lbStuName.TabIndex = 23;
            this.lbStuName.Text = "이름";
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(61, 94);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(29, 12);
            this.lbReason.TabIndex = 24;
            this.lbReason.Text = "사유";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 94);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(478, 183);
            this.textBox3.TabIndex = 27;
            // 
            // ApplySubMinusPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbReason);
            this.Controls.Add(this.lbStuName);
            this.Controls.Add(this.lbStuId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Name = "ApplySubMinusPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplySubMinusPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbStuId;
        private System.Windows.Forms.Label lbStuName;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}