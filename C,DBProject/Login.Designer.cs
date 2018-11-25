namespace C_DBProject
{
    partial class Login
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
            this.txtstuId = new System.Windows.Forms.TextBox();
            this.txtstuPw = new System.Windows.Forms.TextBox();
            this.lbstuID = new System.Windows.Forms.Label();
            this.lbstuPW = new System.Windows.Forms.Label();
            this.btnstuLogin = new System.Windows.Forms.Button();
            this.btnstuRegister = new System.Windows.Forms.Button();
            this.lbtcPw = new System.Windows.Forms.Label();
            this.lbtcId = new System.Windows.Forms.Label();
            this.txttcPw = new System.Windows.Forms.TextBox();
            this.txttcId = new System.Windows.Forms.TextBox();
            this.btntcRegister = new System.Windows.Forms.Button();
            this.btntcLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtstuId
            // 
            this.txtstuId.Font = new System.Drawing.Font("굴림", 14F);
            this.txtstuId.Location = new System.Drawing.Point(105, 240);
            this.txtstuId.Name = "txtstuId";
            this.txtstuId.Size = new System.Drawing.Size(140, 29);
            this.txtstuId.TabIndex = 0;
            // 
            // txtstuPw
            // 
            this.txtstuPw.Font = new System.Drawing.Font("굴림", 14F);
            this.txtstuPw.Location = new System.Drawing.Point(105, 275);
            this.txtstuPw.Name = "txtstuPw";
            this.txtstuPw.PasswordChar = '*';
            this.txtstuPw.Size = new System.Drawing.Size(140, 29);
            this.txtstuPw.TabIndex = 1;
            // 
            // lbstuID
            // 
            this.lbstuID.AutoSize = true;
            this.lbstuID.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbstuID.Location = new System.Drawing.Point(58, 243);
            this.lbstuID.Name = "lbstuID";
            this.lbstuID.Size = new System.Drawing.Size(23, 19);
            this.lbstuID.TabIndex = 2;
            this.lbstuID.Text = "ID";
            // 
            // lbstuPW
            // 
            this.lbstuPW.AutoSize = true;
            this.lbstuPW.Font = new System.Drawing.Font("굴림", 14F);
            this.lbstuPW.Location = new System.Drawing.Point(58, 278);
            this.lbstuPW.Name = "lbstuPW";
            this.lbstuPW.Size = new System.Drawing.Size(35, 19);
            this.lbstuPW.TabIndex = 3;
            this.lbstuPW.Text = "PW";
            // 
            // btnstuLogin
            // 
            this.btnstuLogin.Location = new System.Drawing.Point(251, 239);
            this.btnstuLogin.Name = "btnstuLogin";
            this.btnstuLogin.Size = new System.Drawing.Size(108, 32);
            this.btnstuLogin.TabIndex = 4;
            this.btnstuLogin.Text = "Login";
            this.btnstuLogin.UseVisualStyleBackColor = true;
            this.btnstuLogin.Click += new System.EventHandler(this.btnstuLogin_Click);
            // 
            // btnstuRegister
            // 
            this.btnstuRegister.Location = new System.Drawing.Point(251, 275);
            this.btnstuRegister.Name = "btnstuRegister";
            this.btnstuRegister.Size = new System.Drawing.Size(108, 32);
            this.btnstuRegister.TabIndex = 5;
            this.btnstuRegister.Text = "Register";
            this.btnstuRegister.UseVisualStyleBackColor = true;
            this.btnstuRegister.Click += new System.EventHandler(this.btnstuRegister_Click);
            // 
            // lbtcPw
            // 
            this.lbtcPw.AutoSize = true;
            this.lbtcPw.Font = new System.Drawing.Font("굴림", 14F);
            this.lbtcPw.Location = new System.Drawing.Point(431, 278);
            this.lbtcPw.Name = "lbtcPw";
            this.lbtcPw.Size = new System.Drawing.Size(35, 19);
            this.lbtcPw.TabIndex = 10;
            this.lbtcPw.Text = "PW";
            // 
            // lbtcId
            // 
            this.lbtcId.AutoSize = true;
            this.lbtcId.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbtcId.Location = new System.Drawing.Point(431, 243);
            this.lbtcId.Name = "lbtcId";
            this.lbtcId.Size = new System.Drawing.Size(23, 19);
            this.lbtcId.TabIndex = 9;
            this.lbtcId.Text = "ID";
            // 
            // txttcPw
            // 
            this.txttcPw.Font = new System.Drawing.Font("굴림", 14F);
            this.txttcPw.Location = new System.Drawing.Point(478, 275);
            this.txttcPw.Name = "txttcPw";
            this.txttcPw.PasswordChar = '*';
            this.txttcPw.Size = new System.Drawing.Size(140, 29);
            this.txttcPw.TabIndex = 8;
            // 
            // txttcId
            // 
            this.txttcId.Font = new System.Drawing.Font("굴림", 14F);
            this.txttcId.Location = new System.Drawing.Point(478, 240);
            this.txttcId.Name = "txttcId";
            this.txttcId.Size = new System.Drawing.Size(140, 29);
            this.txttcId.TabIndex = 7;
            // 
            // btntcRegister
            // 
            this.btntcRegister.Location = new System.Drawing.Point(624, 275);
            this.btntcRegister.Name = "btntcRegister";
            this.btntcRegister.Size = new System.Drawing.Size(108, 32);
            this.btntcRegister.TabIndex = 12;
            this.btntcRegister.Text = "Register";
            this.btntcRegister.UseVisualStyleBackColor = true;
            this.btntcRegister.Click += new System.EventHandler(this.btntcRegister_Click);
            // 
            // btntcLogin
            // 
            this.btntcLogin.Location = new System.Drawing.Point(624, 240);
            this.btntcLogin.Name = "btntcLogin";
            this.btntcLogin.Size = new System.Drawing.Size(108, 32);
            this.btntcLogin.TabIndex = 11;
            this.btntcLogin.Text = "Login";
            this.btntcLogin.UseVisualStyleBackColor = true;
            this.btntcLogin.Click += new System.EventHandler(this.btntcLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(169, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "학생용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F);
            this.label2.Location = new System.Drawing.Point(520, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "선생님용";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntcRegister);
            this.Controls.Add(this.btntcLogin);
            this.Controls.Add(this.lbtcPw);
            this.Controls.Add(this.lbtcId);
            this.Controls.Add(this.txttcPw);
            this.Controls.Add(this.txttcId);
            this.Controls.Add(this.btnstuRegister);
            this.Controls.Add(this.btnstuLogin);
            this.Controls.Add(this.lbstuPW);
            this.Controls.Add(this.lbstuID);
            this.Controls.Add(this.txtstuPw);
            this.Controls.Add(this.txtstuId);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstuId;
        private System.Windows.Forms.TextBox txtstuPw;
        private System.Windows.Forms.Label lbstuID;
        private System.Windows.Forms.Label lbstuPW;
        private System.Windows.Forms.Button btnstuLogin;
        private System.Windows.Forms.Button btnstuRegister;
        private System.Windows.Forms.Label lbtcPw;
        private System.Windows.Forms.Label lbtcId;
        private System.Windows.Forms.TextBox txttcPw;
        private System.Windows.Forms.TextBox txttcId;
        private System.Windows.Forms.Button btntcRegister;
        private System.Windows.Forms.Button btntcLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

