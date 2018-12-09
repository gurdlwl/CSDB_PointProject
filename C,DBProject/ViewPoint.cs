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
    public partial class ViewPoint : Form
    {
        private string strSql = ConfigurationManager.AppSettings["DBconn"];
        string stuId = string.Empty;

        public ViewPoint(string stuID)
        {
            this.stuId = stuID;

            InitializeComponent();
            SetListView();
            UpdateListView();
        }

        private void SetListView()
        {
            PointListView.View = View.Details;
            PointListView.GridLines = true;
            PointListView.FullRowSelect = true;

            PointListView.Columns.Add("이름", 100);
            PointListView.Columns.Add("상점", 70);
            PointListView.Columns.Add("벌점", 70);
            PointListView.Columns.Add("사유", 300);
        }

        private void UpdateListView()
        {
            string[] point = new string[4];

            var Conn = new MySqlConnection(strSql);
            Conn.Open();

            String Sql = "select * from student where stuId='" + stuId + "';";

            var Comm = new MySqlCommand(Sql, Conn);
            int i = Comm.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("정상적으로 값을 불러왔습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("값 불러오기에 실패하였습니다." + i +".", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conn.Close();
        }
    }
}
