﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_DBProject
{
    public partial class T_Register : Form
    {
        private string strSql = ConfigurationManager.AppSettings["DBconn"];
        HashConvert hc = new HashConvert();

        public T_Register()
        {
            InitializeComponent();
            SetBasic();
        }

        public void SetBasic()
        {
            this.Text = "T-Register";
            StartPosition = FormStartPosition.CenterScreen;
        }

        private bool TxtCheck()
        {
            String str = "";

            if (this.txtTcId.Text == "")
                str = "선생님ID";
            else if (this.txtTcName.Text == "")
                str = "이름";
            else if (this.txtId.Text == "")
                str = "아이디";
            else if (this.txtPw.Text == "")
                str = "비밀번호";
            else if (this.txtPwCheck.Text == "")
                str = "비밀번호 확인";

            if (str == "")
                return true;
            else
            {
                MessageBox.Show(str + "를(을) 입력하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckId()
        {
            var Conn = new MySqlConnection(strSql);
            Conn.Open();

            var Comm = new MySqlCommand("select * from teacher where id = '" + this.txtId.Text + "'", Conn);
            var MyRead = Comm.ExecuteReader();

            while (MyRead.Read())
            {
                MessageBox.Show("동일한 아이디가 존재합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtId.Text = "";
                this.txtId.Focus();

                MyRead.Close();
                Conn.Close();
                return false;
            }

            MyRead.Close();
            Conn.Close();

            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            double number = 0;
            if (TxtCheck() == true)
            {
                if (this.txtPw.Text != this.txtPwCheck.Text)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPwCheck.Focus();
                }
                else if (!(Double.TryParse(this.txtTcId.Text, out number)))
                { //txtstuId가 숫자가 아닐 시 실행
                    MessageBox.Show("선생님ID가 숫자가 아닙니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtTcId.Focus();
                }
                else
                {
                    if (CheckId() == true)
                    {
                        var Conn = new MySqlConnection(strSql);
                        Conn.Open();

                        String Sql = "insert into teacher(tcId, tcName, id, pw)";
                        Sql += " values('" + this.txtTcId.Text + "', '" + this.txtTcName.Text + "', '" + this.txtId.Text
                            + "', '" + hc.ConvertSha256(this.txtPw.Text) + "');";

                        var Comm = new MySqlCommand(Sql, Conn);
                        int i = Comm.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("정상적으로 회원가입이 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("회원가입에 실패하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Conn.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("회원가입 취소");
            this.Close();
        }
    }
}
