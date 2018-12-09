 using MySql.Data.MySqlClient;
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
    public partial class AddBonusPoint : Form
    {
        private string strSql = ConfigurationManager.AppSettings["DBconn"];
        HashConvert hc = new HashConvert();

        public AddBonusPoint()
        {
            InitializeComponent();
        }

        private bool TxtCheck()
        {
            String str = "";

            if (this.txtStuId.Text == "")
                str = "학번";
            else if (this.txtStuName.Text == "")
                str = "이름";
            else if (this.udBP.Value.ToString() == "")
                str = "상점";
            else if (this.txtBPReason.Text == "")
                str = "사유";

            if (str == "")
                return true;
            else
            {
                MessageBox.Show(str + "를(을) 입력하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(TxtCheck() == true)
            {
                var Conn = new MySqlConnection(strSql);
                Conn.Open();

                String Sql = "update student set bonusPoint = ";
                Sql += udBP.Value.ToString();
                Sql += " where stuId='" + int.Parse(txtStuId.Text) +"';";

                var Comm = new MySqlCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("정상적으로 값이 입력되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("값 입력에 실패하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소합니다.", "알림");
            this.Close();
        }
    }
}
