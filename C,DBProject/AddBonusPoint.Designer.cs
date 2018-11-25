namespace C_DBProject
{
    partial class AddBonusPoint
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
            this.lbStuId = new System.Windows.Forms.Label();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lbStuName = new System.Windows.Forms.Label();
            this.txtBPReason = new System.Windows.Forms.TextBox();
            this.lbBP = new System.Windows.Forms.Label();
            this.lbBPReason = new System.Windows.Forms.Label();
            this.udBP = new System.Windows.Forms.NumericUpDown();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udBP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStuId
            // 
            this.lbStuId.AutoSize = true;
            this.lbStuId.Location = new System.Drawing.Point(101, 58);
            this.lbStuId.Name = "lbStuId";
            this.lbStuId.Size = new System.Drawing.Size(29, 12);
            this.lbStuId.TabIndex = 0;
            this.lbStuId.Text = "학번";
            // 
            // txtStuId
            // 
            this.txtStuId.Location = new System.Drawing.Point(103, 73);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(100, 21);
            this.txtStuId.TabIndex = 1;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(209, 73);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 3;
            // 
            // lbStuName
            // 
            this.lbStuName.AutoSize = true;
            this.lbStuName.Location = new System.Drawing.Point(207, 58);
            this.lbStuName.Name = "lbStuName";
            this.lbStuName.Size = new System.Drawing.Size(29, 12);
            this.lbStuName.TabIndex = 2;
            this.lbStuName.Text = "이름";
            // 
            // txtBPReason
            // 
            this.txtBPReason.Location = new System.Drawing.Point(103, 128);
            this.txtBPReason.Multiline = true;
            this.txtBPReason.Name = "txtBPReason";
            this.txtBPReason.Size = new System.Drawing.Size(318, 42);
            this.txtBPReason.TabIndex = 5;
            // 
            // lbBP
            // 
            this.lbBP.AutoSize = true;
            this.lbBP.Location = new System.Drawing.Point(313, 58);
            this.lbBP.Name = "lbBP";
            this.lbBP.Size = new System.Drawing.Size(29, 12);
            this.lbBP.TabIndex = 4;
            this.lbBP.Text = "상점";
            // 
            // lbBPReason
            // 
            this.lbBPReason.AutoSize = true;
            this.lbBPReason.Location = new System.Drawing.Point(101, 113);
            this.lbBPReason.Name = "lbBPReason";
            this.lbBPReason.Size = new System.Drawing.Size(29, 12);
            this.lbBPReason.TabIndex = 6;
            this.lbBPReason.Text = "사유";
            // 
            // udBP
            // 
            this.udBP.Location = new System.Drawing.Point(315, 73);
            this.udBP.Name = "udBP";
            this.udBP.Size = new System.Drawing.Size(106, 21);
            this.udBP.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(183, 194);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddBonusPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.udBP);
            this.Controls.Add(this.lbBPReason);
            this.Controls.Add(this.txtBPReason);
            this.Controls.Add(this.lbBP);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.lbStuName);
            this.Controls.Add(this.txtStuId);
            this.Controls.Add(this.lbStuId);
            this.Name = "AddBonusPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBonusPoint";
            ((System.ComponentModel.ISupportInitialize)(this.udBP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStuId;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lbStuName;
        private System.Windows.Forms.TextBox txtBPReason;
        private System.Windows.Forms.Label lbBP;
        private System.Windows.Forms.Label lbBPReason;
        private System.Windows.Forms.NumericUpDown udBP;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}