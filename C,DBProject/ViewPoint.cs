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
    public partial class ViewPoint : Form
    {
        public ViewPoint()
        {
            InitializeComponent();
            SetListView();
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
    }
}
