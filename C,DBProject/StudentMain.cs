using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace C_DBProject
{
    public partial class StudentMain : Form
    {
        private string strSql = ConfigurationManager.AppSettings["DBconn"];
        string stuId = string.Empty;

        public StudentMain()
        {
            InitializeComponent();
        }

        private void viewPointBtn_Click(object sender, EventArgs e)
        {
            ViewPoint vp = new ViewPoint(this.stuId);
            vp.ShowDialog();
        }

        private void LoginComplet()
        {

        }

        private void applySubMinusPointBtn_Click(object sender, EventArgs e)
        {
            ApplySubMinusPoint applysubMP = new ApplySubMinusPoint();
            applysubMP.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("종료합니다.", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                this.Dispose();
        }
    }
}
