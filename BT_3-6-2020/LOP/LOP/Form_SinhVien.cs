using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOP
{
    public partial class Form_SinhVien : Form
    {
        Ket_Noi_CSDL csdl = new Ket_Noi_CSDL();

        public Form_SinhVien()
        {
            InitializeComponent();
            string sql = "select * from TB_LOP";
            cb_MaLop.DataSource = csdl.LayBang(sql);
            cb_MaLop.DisplayMember = "TenLop";
            cb_MaLop.ValueMember = "MaLop";
            hienThiDuLieu();
        }

        public void hienThiDuLieu()
        {
            txt_MaSV.Text = "";
            txt_TenSV.Text = "";
            txt_MaSV.ReadOnly = false;
            DataTable bangLop = new DataTable();
            String sql = "select * from TB_SinhVien";
            bangLop = csdl.LayBang(sql);
            dgv_lop.DataSource = bangLop;
        }
        private void Form_SinhVien_Load(object sender, EventArgs e)
        {

        }

        private void dgv_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txt_MaSV.Text = dgv_lop.Rows[index].Cells[0].Value.ToString();
            txt_TenSV.Text = dgv_lop.Rows[index].Cells[1].Value.ToString();
            txt_MaSV.ReadOnly = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String maLop = txt_MaSV.Text;
            String tenLop = txt_TenSV.Text;

            String sql = "update TB_LOP set TenLop = N'" + tenLop + "' where MaLop = '" + maLop + "'";

            if (csdl.CapnhatCSDL(sql))
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
            hienThiDuLieu();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String maLop = txt_MaSV.Text;


            String sql = "delete TB_LOP where MaLop = '" + maLop + "'";
            if (csdl.CapnhatCSDL(sql))
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            hienThiDuLieu();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            String maLop = txt_MaSV.Text;
            String tenLop = txt_TenSV.Text;

            String sql = "insert into TB_LOP values('" + maLop + "', N'" + tenLop + "')";
            if (csdl.CapnhatCSDL(sql))
            {
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
            hienThiDuLieu();
        }

        private void button(bool them, bool xoa, bool sua, bool thoat, bool luu, bool huy, bool maLop, bool tenLop)
        {
            btn_Them.Enabled = them;
            btn_Xoa.Enabled = xoa;
            btn_Sua.Enabled = sua;
            btn_Thoat.Enabled = thoat;
            btn_Luu.Enabled = luu;
            btn_Huy.Enabled = huy;
            txt_MaSV.Enabled = maLop;
            txt_TenSV.Enabled = tenLop;
        }
    }
}
