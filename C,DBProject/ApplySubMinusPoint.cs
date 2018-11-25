using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_DBProject
{
    public partial class ApplySubMinusPoint : Form
    {
        public ApplySubMinusPoint()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소합니다.", "알림");
            this.Close();
        }
    }
}
