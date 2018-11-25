namespace C_DBProject
{
    partial class Register
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
            this.lbstuId = new System.Windows.Forms.Label();
            this.txtstuId = new System.Windows.Forms.TextBox();
            this.txtstuName = new System.Windows.Forms.TextBox();
            this.lbstuName = new System.Windows.Forms.Label();
            this.lbPw = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtPwCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbstuId
            // 
            this.lbstuId.AutoSize = true;
            this.lbstuId.Location = new System.Drawing.Point(213, 62);
            this.lbstuId.Name = "lbstuId";
            this.lbstuId.Size = new System.Drawing.Size(29, 12);
            this.lbstuId.TabIndex = 0;
            this.lbstuId.Text = "학번";
            // 
            // txtstuId
            // 
            this.txtstuId.Location = new System.Drawing.Point(248, 59);
            this.txtstuId.Name = "txtstuId";
            this.txtstuId.Size = new System.Drawing.Size(100, 21);
            this.txtstuId.TabIndex = 1;
            this.txtstuId.Tag = "";
            // 
            // txtstuName
            // 
            this.txtstuName.Location = new System.Drawing.Point(248, 97);
            this.txtstuName.Name = "txtstuName";
            this.txtstuName.Size = new System.Drawing.Size(100, 21);
            this.txtstuName.TabIndex = 2;
            // 
            // lbstuName
            // 
            this.lbstuName.AutoSize = true;
            this.lbstuName.Location = new System.Drawing.Point(213, 100);
            this.lbstuName.Name = "lbstuName";
            this.lbstuName.Size = new System.Drawing.Size(29, 12);
            this.lbstuName.TabIndex = 3;
            this.lbstuName.Text = "이름";
            // 
            // lbPw
            // 
            this.lbPw.AutoSize = true;
            this.lbPw.Location = new System.Drawing.Point(189, 176);
            this.lbPw.Name = "lbPw";
            this.lbPw.Size = new System.Drawing.Size(53, 12);
            this.lbPw.TabIndex = 4;
            this.lbPw.Text = "비밀번호";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(248, 173);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(100, 21);
            this.txtPw.TabIndex = 5;
            // 
            // txtPwCheck
            // 
            this.txtPwCheck.Location = new System.Drawing.Point(248, 211);
            this.txtPwCheck.Name = "txtPwCheck";
            this.txtPwCheck.PasswordChar = '*';
            this.txtPwCheck.Size = new System.Drawing.Size(100, 21);
            this.txtPwCheck.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "비밀번호 확인";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(200, 287);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "회원가입";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(301, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(201, 138);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(41, 12);
            this.lbId.TabIndex = 11;
            this.lbId.Text = "아이디";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(248, 135);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(354, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "ex.1101";
            // 
            // lbMatch
            // 
            this.lbMatch.AutoSize = true;
            this.lbMatch.Location = new System.Drawing.Point(354, 214);
            this.lbMatch.Name = "lbMatch";
            this.lbMatch.Size = new System.Drawing.Size(9, 12);
            this.lbMatch.TabIndex = 13;
            this.lbMatch.Text = " ";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbMatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPwCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.lbPw);
            this.Controls.Add(this.lbstuName);
            this.Controls.Add(this.txtstuName);
            this.Controls.Add(this.txtstuId);
            this.Controls.Add(this.lbstuId);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbstuId;
        private System.Windows.Forms.TextBox txtstuId;
        private System.Windows.Forms.TextBox txtstuName;
        private System.Windows.Forms.Label lbstuName;
        private System.Windows.Forms.Label lbPw;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtPwCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMatch;
    }
}