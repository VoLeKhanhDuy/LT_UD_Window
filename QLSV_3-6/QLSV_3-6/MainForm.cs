using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Lop frmLop = new frm_Lop();
            frmLop.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SinhVien frmSinhVien = new frm_SinhVien();
            frmSinhVien.Show();
        }
    }
}
