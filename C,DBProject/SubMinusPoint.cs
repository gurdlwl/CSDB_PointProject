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
    public partial class SubMinusPoint : Form
    {
        public SubMinusPoint()
        {
            InitializeComponent();
            SetListView();
        }

        //ref. http://cocomo.tistory.com/484
        private void SetListView()
        {
            subMPListView.View = View.Details;
            subMPListView.GridLines = true;
            subMPListView.FullRowSelect = true;

            subMPListView.Columns.Add("학번", 100);
            subMPListView.Columns.Add("이름", 100);
            subMPListView.Columns.Add("사유", 300);
        }

        private void btnsubMP_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소합니다.", "알림");
            this.Close();
        }
    }
}
