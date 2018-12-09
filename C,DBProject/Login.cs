using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace C_DBProject
{    
    public partial class Login : Form
    {
        public delegate void LoginCompletHandler(string Id);
        public event LoginCompletHandler LoginComplet;

        private string strSql = ConfigurationManager.AppSettings["DBconn"];
        HashConvert hc = new HashConvert();

        public Login()
        {
            InitializeComponent();
            SetBasic();
            TxtBoxEmpty();
        }

        public void Login_Load(object sender, EventArgs e)
        {
            var Conn = new MySqlConnection(strSql);
            Conn.Open();
        }

        public void SetBasic()
        {
            this.Text = "Login";
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TxtBoxEmpty()
        {
            this.txtstuId.Text = "";
            this.txtstuPw.Text = "";
        }

        private bool TxtStuCheck()
        {
            if(this.txtstuId.Text == "")
            {
                MessageBox.Show("아이디를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.txtstuPw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var Conn = new MySqlConnection(strSql);
            Conn.Open();

            try
            {
                var Comm = new MySqlCommand("select id, pw, stuId from student where id='" + this.txtstuId.Text + "'", Conn);
                var MyRead = Comm.ExecuteReader();

                while (MyRead.Read())
                {
                    String id = MyRead.GetString(0);
                    String pw = MyRead.GetString(1);
                    String sId = MyRead.GetString(2);

                    if (this.txtstuId.Text == id)
                    {
                        if (hc.ConvertSha256(this.txtstuPw.Text) == pw)
                        {
                            //LoginComplet(txttcId.Text);

                            txtstuId.Text = "";
                            txtstuPw.Text = "";

                            MyRead.Close();
                            Conn.Close();
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("아이디 혹은 비밀번호를 다시 확인해주세요.", "알림");
                    }
                }
                MyRead.Close();
                Conn.Close();

                return false;
            } catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private bool TxtTcCheck()
        {
            if (this.txttcId.Text == "")
            {
                MessageBox.Show("아이디를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.txttcPw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var Conn = new MySqlConnection(strSql);
            Conn.Open();

            try
            {
                var Comm = new MySqlCommand("select id, pw from teacher where id='" + this.txttcId.Text + "'", Conn);
                var MyRead = Comm.ExecuteReader();

                while (MyRead.Read())
                {
                    String id = MyRead.GetString(0);
                    String pw = MyRead.GetString(1);

                    if (this.txttcId.Text == id)
                    {
                        if (hc.ConvertSha256(this.txttcPw.Text) == pw)
                        {
                            MyRead.Close();
                            Conn.Close();

                            txttcId.Text = "";
                            txttcPw.Text = "";
                            return true;
                        }
                    }
                    MessageBox.Show("아이디 혹은 비밀번호를 다시 확인해주세요.", "알림");
                }
                MyRead.Close();
                Conn.Close();

                return false;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void btnstuLogin_Click(object sender, EventArgs e)
        {
            if (TxtStuCheck() == true)
            {
                StudentMain smain = new StudentMain();
                smain.Show();
                return;
            }
        }

        private void btntcLogin_Click(object sender, EventArgs e)
        {
            if (TxtTcCheck() == true)
            {
                TeacherMain tmain = new TeacherMain();
                tmain.Show();
                return;
            }
        }

        private void btnstuRegister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.ShowDialog();
        }

        private void btntcRegister_Click(object sender, EventArgs e)
        {
            T_Register tr = new T_Register();
            tr.ShowDialog();
        }
    }
}
