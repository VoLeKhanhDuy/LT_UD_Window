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
    public partial class frm_Lop : Form
    {
        TV_kncsdl conn;
        public frm_Lop()
        {
            InitializeComponent();
            conn = new TV_kncsdl();
            if (conn.Moketnoi())
            {
                reloadDGV();
            }
            refresh();
            button(true, false, false, false, false, false, false);            
        }
        public void refresh()
        {
            txt_tenLop.Text = "";
            txt_maLop.Text = "";
        }
        public void button(bool them, bool luu, bool huy, bool sua, bool xoa, bool maLop, bool tenLop)
        {
            btn_them.Enabled = them;
            btn_luu.Enabled = luu;
            btn_huy.Enabled = huy;
            btn_sua.Enabled = sua;
            btn_xoa.Enabled = xoa;
            txt_maLop.Enabled = maLop;
            txt_tenLop.Enabled = tenLop;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            button(false, true, true, false, false, true, true);
            refresh();
        }

        public void reloadDGV()
        {
            string sql = "select ma_lop as 'Mã lớp', ten_lop as 'Tên lớp' from Lop";
            dgv_lop.DataSource = conn.LayBang(sql);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maLop.Text.Trim() != "" && txt_tenLop.Text.Trim() != "")
                {
                    string sql = "insert into Lop values('" + txt_maLop.Text.Trim()
                        + "',N'" + txt_tenLop.Text.Trim() + "')";
                    conn.CapnhatCSDL(sql);
                    reloadDGV();
                    refresh();
                }
                else
                {
                    if (txt_maLop.Text.Trim() == "" && txt_tenLop.Text.Trim() == "")
                        MessageBox.Show("Vui lòng nhập dữ liệu vào ô Mã Lớp và ô Tên Lớp", "Thông báo");
                    else
                    {
                        if (txt_maLop.Text.Trim() == "")
                            MessageBox.Show("Vui lòng nhập dữ liệu vào ô Mã Lớp", "Thông báo");
                        if (txt_tenLop.Text.Trim() == "")
                            MessageBox.Show("Vui lòng nhập dữ liệu vào ô Tên Lớp", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            button(true, false, false, false, false, false, false);          
            refresh();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maLop.Text.Trim() != "")
            {
                string sql = "delete from Lop where ma_lop = '" + txt_maLop.Text.Trim() + "'";
                conn.CapnhatCSDL(sql);
                reloadDGV();
            }
            refresh();
            button(true, false, false, false, false, false, false);
        }

        private void dgv_sinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button(false, false, true, true, true, false, true);
            try
            {
                int index = e.RowIndex;
                txt_maLop.Text = dgv_lop[0, index].Value.ToString();
                txt_tenLop.Text = dgv_lop[1, index].Value.ToString();
            }
            catch
            {

            }
           
        }

        private void dgv_sinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_maLop.Text.Trim() != "" && txt_tenLop.Text.Trim() != "")
            {
                string sql = "update Lop set ten_lop = '" + txt_tenLop.Text.Trim() 
                    + "' where ma_lop = '"+ txt_maLop.Text.Trim() + "'";
                conn.CapnhatCSDL(sql);
                reloadDGV();
                refresh();
                button(true, false, false, false, false, false, false);
            }
            else
            {
                if (txt_tenLop.Text.Trim() == "")
                    MessageBox.Show("Vui lòng nhập dữ liệu vào ô Tên Lớp", "Thông báo");
            }
            
        }
    }
}
