﻿using System;
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
    public partial class Form1 : Form
    {
        Ket_Noi_CSDL csdl = new Ket_Noi_CSDL();

        public Form1()
        {
            InitializeComponent();
            hienThiDuLieu();
        }

        public void hienThiDuLieu()
        {
            txt_MaLop.Text = "";
            txt_TenLop.Text = "";
            txt_MaLop.ReadOnly = false;
            DataTable bangLop = new DataTable();
            String sql = "select * from TB_LOP";
            bangLop = csdl.LayBang(sql);
            dgv_lop.DataSource = bangLop;
        }
        

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txt_MaLop.Text = dgv_lop.Rows[index].Cells[0].Value.ToString();
            txt_TenLop.Text = dgv_lop.Rows[index].Cells[1].Value.ToString();
            txt_MaLop.ReadOnly = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
  
            hienThiDuLieu();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String maLop = txt_MaLop.Text;
            String tenLop = txt_TenLop.Text;

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
            String maLop = txt_MaLop.Text;
        

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
            String maLop = txt_MaLop.Text;
            String tenLop = txt_TenLop.Text;

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
            txt_MaLop.Enabled = maLop;
            txt_TenLop.Enabled = tenLop;
        }

        private void txt_TenLop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
