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
    public partial class StudentMain : Form
    {
        private string strSql = ConfigurationManager.AppSettings["DBconn"];

        public StudentMain()
        {
            InitializeComponent();
        }

        private void viewPointBtn_Click(object sender, EventArgs e)
        {
            ViewPoint vp = new ViewPoint();
            vp.ShowDialog();
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
