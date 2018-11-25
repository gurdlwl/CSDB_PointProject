namespace C_DBProject
{
    partial class AddMinusPoint
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
            this.udMP = new System.Windows.Forms.NumericUpDown();
            this.lbMPReason = new System.Windows.Forms.Label();
            this.txtMPReason = new System.Windows.Forms.TextBox();
            this.lbMP = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lbStuName = new System.Windows.Forms.Label();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.lbStuId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udMP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(183, 194);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // udMP
            // 
            this.udMP.Location = new System.Drawing.Point(315, 73);
            this.udMP.Name = "udMP";
            this.udMP.Size = new System.Drawing.Size(106, 21);
            this.udMP.TabIndex = 17;
            // 
            // lbMPReason
            // 
            this.lbMPReason.AutoSize = true;
            this.lbMPReason.Location = new System.Drawing.Point(101, 113);
            this.lbMPReason.Name = "lbMPReason";
            this.lbMPReason.Size = new System.Drawing.Size(29, 12);
            this.lbMPReason.TabIndex = 16;
            this.lbMPReason.Text = "사유";
            // 
            // txtMPReason
            // 
            this.txtMPReason.Location = new System.Drawing.Point(103, 128);
            this.txtMPReason.Multiline = true;
            this.txtMPReason.Name = "txtMPReason";
            this.txtMPReason.Size = new System.Drawing.Size(318, 42);
            this.txtMPReason.TabIndex = 15;
            // 
            // lbMP
            // 
            this.lbMP.AutoSize = true;
            this.lbMP.Location = new System.Drawing.Point(313, 58);
            this.lbMP.Name = "lbMP";
            this.lbMP.Size = new System.Drawing.Size(29, 12);
            this.lbMP.TabIndex = 14;
            this.lbMP.Text = "벌점";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(209, 73);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 13;
            // 
            // lbStuName
            // 
            this.lbStuName.AutoSize = true;
            this.lbStuName.Location = new System.Drawing.Point(207, 58);
            this.lbStuName.Name = "lbStuName";
            this.lbStuName.Size = new System.Drawing.Size(29, 12);
            this.lbStuName.TabIndex = 12;
            this.lbStuName.Text = "이름";
            // 
            // txtStuId
            // 
            this.txtStuId.Location = new System.Drawing.Point(103, 73);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(100, 21);
            this.txtStuId.TabIndex = 11;
            // 
            // lbStuId
            // 
            this.lbStuId.AutoSize = true;
            this.lbStuId.Location = new System.Drawing.Point(101, 58);
            this.lbStuId.Name = "lbStuId";
            this.lbStuId.Size = new System.Drawing.Size(29, 12);
            this.lbStuId.TabIndex = 10;
            this.lbStuId.Text = "학번";
            // 
            // AddMinusPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.udMP);
            this.Controls.Add(this.lbMPReason);
            this.Controls.Add(this.txtMPReason);
            this.Controls.Add(this.lbMP);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.lbStuName);
            this.Controls.Add(this.txtStuId);
            this.Controls.Add(this.lbStuId);
            this.Name = "AddMinusPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMinusPoint";
            ((System.ComponentModel.ISupportInitialize)(this.udMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.NumericUpDown udMP;
        private System.Windows.Forms.Label lbMPReason;
        private System.Windows.Forms.TextBox txtMPReason;
        private System.Windows.Forms.Label lbMP;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lbStuName;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.Label lbStuId;
    }
}