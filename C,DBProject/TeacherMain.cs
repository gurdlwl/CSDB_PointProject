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
    public partial class TeacherMain : Form
    {
        public TeacherMain()
        {
            InitializeComponent();
        }

        private void addBonusPointBtn_Click(object sender, EventArgs e)
        {
            AddBonusPoint addBP = new AddBonusPoint();
            addBP.ShowDialog();
        }

        private void addMinusPointBtn_Click(object sender, EventArgs e)
        {
            AddMinusPoint addMP = new AddMinusPoint();
            addMP.ShowDialog();
        }

        private void subMinusPointBtn_Click(object sender, EventArgs e)
        {
            SubMinusPoint subMP = new SubMinusPoint();
            subMP.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료합니다.", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                this.Dispose();
        }
    }
}
