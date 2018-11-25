namespace C_DBProject
{
    partial class T_Register
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
            this.lbTcId = new System.Windows.Forms.Label();
            this.txtTcId = new System.Windows.Forms.TextBox();
            this.txtTcName = new System.Windows.Forms.TextBox();
            this.lbtcName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lbPw = new System.Windows.Forms.Label();
            this.txtPwCheck = new System.Windows.Forms.TextBox();
            this.lbPwCheck = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTcId
            // 
            this.lbTcId.AutoSize = true;
            this.lbTcId.Location = new System.Drawing.Point(194, 64);
            this.lbTcId.Name = "lbTcId";
            this.lbTcId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTcId.Size = new System.Drawing.Size(52, 12);
            this.lbTcId.TabIndex = 0;
            this.lbTcId.Text = "선생님ID";
            // 
            // txtTcId
            // 
            this.txtTcId.Location = new System.Drawing.Point(252, 61);
            this.txtTcId.Name = "txtTcId";
            this.txtTcId.Size = new System.Drawing.Size(100, 21);
            this.txtTcId.TabIndex = 2;
            this.txtTcId.Tag = "";
            // 
            // txtTcName
            // 
            this.txtTcName.Location = new System.Drawing.Point(252, 99);
            this.txtTcName.Name = "txtTcName";
            this.txtTcName.Size = new System.Drawing.Size(100, 21);
            this.txtTcName.TabIndex = 4;
            this.txtTcName.Tag = "";
            // 
            // lbtcName
            // 
            this.lbtcName.AutoSize = true;
            this.lbtcName.Location = new System.Drawing.Point(217, 102);
            this.lbtcName.Name = "lbtcName";
            this.lbtcName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbtcName.Size = new System.Drawing.Size(29, 12);
            this.lbtcName.TabIndex = 3;
            this.lbtcName.Text = "이름";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(252, 137);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 6;
            this.txtId.Tag = "";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(205, 140);
            this.lbId.Name = "lbId";
            this.lbId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbId.Size = new System.Drawing.Size(41, 12);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "아이디";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(252, 175);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(100, 21);
            this.txtPw.TabIndex = 8;
            this.txtPw.Tag = "";
            // 
            // lbPw
            // 
            this.lbPw.AutoSize = true;
            this.lbPw.Location = new System.Drawing.Point(193, 178);
            this.lbPw.Name = "lbPw";
            this.lbPw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPw.Size = new System.Drawing.Size(53, 12);
            this.lbPw.TabIndex = 7;
            this.lbPw.Text = "비밀번호";
            // 
            // txtPwCheck
            // 
            this.txtPwCheck.Location = new System.Drawing.Point(252, 212);
            this.txtPwCheck.Name = "txtPwCheck";
            this.txtPwCheck.PasswordChar = '*';
            this.txtPwCheck.Size = new System.Drawing.Size(100, 21);
            this.txtPwCheck.TabIndex = 10;
            this.txtPwCheck.Tag = "";
            // 
            // lbPwCheck
            // 
            this.lbPwCheck.AutoSize = true;
            this.lbPwCheck.Location = new System.Drawing.Point(165, 215);
            this.lbPwCheck.Name = "lbPwCheck";
            this.lbPwCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPwCheck.Size = new System.Drawing.Size(81, 12);
            this.lbPwCheck.TabIndex = 9;
            this.lbPwCheck.Text = "비밀번호 확인";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(201, 298);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "회원가입";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(358, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "ex.0001";
            // 
            // T_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPwCheck);
            this.Controls.Add(this.lbPwCheck);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.lbPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtTcName);
            this.Controls.Add(this.lbtcName);
            this.Controls.Add(this.txtTcId);
            this.Controls.Add(this.lbTcId);
            this.Name = "T_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T_Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTcId;
        private System.Windows.Forms.TextBox txtTcId;
        private System.Windows.Forms.TextBox txtTcName;
        private System.Windows.Forms.Label lbtcName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lbPw;
        private System.Windows.Forms.TextBox txtPwCheck;
        private System.Windows.Forms.Label lbPwCheck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
    }
}