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
    public partial class frm_SinhVien : Form
    {
        TV_kncsdl conn;
        public frm_SinhVien()
        {
            InitializeComponent();
            conn = new TV_kncsdl();
            if (conn.Moketnoi())
            {
                string sql = "select * from Lop";
                cbb_tenLop.DataSource = conn.LayBang(sql);
                cbb_tenLop.DisplayMember = "ten_lop";
                cbb_tenLop.ValueMember = "ma_lop";

                reloadDGV();
            }
            refresh();
            button(true, false, false, false, false, false, false, false);
        }
        public void button(bool them, bool luu, bool huy, bool sua, bool xoa, bool maSo, bool hoTen, bool lop)
        {
            btn_them.Enabled = them;
            btn_luu.Enabled = luu;
            btn_huy.Enabled = huy;
            btn_sua.Enabled = sua;
            btn_xoa.Enabled = xoa;
            txt_mssv.Enabled = maSo;
            txt_hoTen.Enabled = hoTen;
            cbb_tenLop.Enabled = lop;
        }
        public void refresh()
        {
            txt_mssv.Text = "";
            txt_hoTen.Text = "";
            cbb_tenLop.SelectedIndex = -1;
        }
        public void reloadDGV()
        {
            string sql = "select mssv as MSSV, ho_ten as 'Họ tên', ma_lop as 'Mã lớp' from SinhVien";
            dgv_sinhVien.DataSource = conn.LayBang(sql);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            button(false, true, true, false, false, true, true, true);
            refresh();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mssv.Text.Trim() != "" && txt_hoTen.Text.Trim() != "" && cbb_tenLop.SelectedIndex != -1)
                {
                    string sql = "insert into SinhVien values('" + txt_mssv.Text.Trim()
                        + "',N'" + txt_hoTen.Text.Trim() + "','" 
                        + cbb_tenLop.SelectedValue.ToString() + "')";
                    conn.CapnhatCSDL(sql);
                    reloadDGV();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu", "Thông báo");
                }
            }
            catch
            {
                
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            button(true, false, false, false, false, false, false, false);
            refresh();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_mssv.Text.Trim() != "" && txt_hoTen.Text.Trim() != "" && cbb_tenLop.SelectedIndex != -1)
            {
                string sql = "update SinhVien set ho_ten = N'" + txt_hoTen.Text.Trim()
                    + "', ma_lop = '"+ cbb_tenLop.SelectedValue.ToString() +"' where mssv = '" 
                    + txt_mssv.Text.Trim() + "'";
                conn.CapnhatCSDL(sql);
                reloadDGV();
                refresh();
                button(true, false, false, false, false, false, false, false);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu", "Thông báo");
            }
        }

        private void dgv_sinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button(false, false, true, true, true, false, true, true);
            try
            {
                int index = e.RowIndex;
                txt_mssv.Text = dgv_sinhVien[0, index].Value.ToString();
                txt_hoTen.Text = dgv_sinhVien[1, index].Value.ToString();
                cbb_tenLop.SelectedValue = dgv_sinhVien[2, index].Value.ToString();
            }
            catch
            {

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mssv.Text.Trim() != "")
            {
                string sql = "delete from SinhVien where mssv = '" + txt_mssv.Text.Trim() + "'";
                conn.CapnhatCSDL(sql);
                reloadDGV();
            }
            refresh();
            button(true, false, false, false, false, false, false, false);
        }
    }
}
