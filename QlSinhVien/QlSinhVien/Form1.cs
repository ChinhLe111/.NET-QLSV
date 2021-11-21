using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace QlSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtXl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://husc.hueuni.edu.vn/");
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Thêm(object sender, EventArgs e)
        {
            try
            {
                string masv = txtSV.Text;
                string tensv = txtTenSV.Text;
                DateTime ngays = dtpNs.Value;
                string diachi = txtDC.Text;
                float diem = float.Parse(txtDiem.Text);
                string xeploai = txtXl.Text;
                B_SinhVien sv = new B_SinhVien();
                Class1 sinhvien = new Class1(masv, tensv, ngays, diachi, diem, xeploai);
                B_SinhVien.InsertSinhVien(sinhvien);
                MessageBox.Show(" Thêm thành công " + tensv);
                dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập thông tin cho sinh viên", "Thông Báo!");
            }
        }
        private void Sửa(object sender, EventArgs e)
        {
            try
            {
                string masv = txtSV.Text;
                string tensv = txtTenSV.Text;
                DateTime ngays = dtpNs.Value;
                string diachi = txtDC.Text;
                float diem = float.Parse(txtDiem.Text);
                string xeploai = txtXl.Text;
                B_SinhVien sv = new B_SinhVien();
                Class1 sinhvien = new Class1(masv, tensv, ngays, diachi, diem, xeploai);
                B_SinhVien.UpdateSinhVien(sinhvien);
                MessageBox.Show(" Sửa thành công " + tensv);
                dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập thông tin cho sinh viên", "Thông Báo!");
            }
        }

        private void Xóa(object sender, EventArgs e)
        {
            try
            {
                string masv = txtSV.Text;
                string tensv = txtTenSV.Text;
                DateTime ngays = dtpNs.Value;
                string diachi = txtDC.Text;
                float diem = float.Parse(txtDiem.Text);
                string xeploai = txtXl.Text;
                B_SinhVien sv = new B_SinhVien();
                Class1 sinhvien = new Class1(masv, tensv, ngays, diachi, diem, xeploai);
                B_SinhVien.DeleteSinhVien(masv);
                MessageBox.Show(" Xóa thành công " + tensv);
                dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập thông tin cho sinh viên", "Thông Báo!");
            }
        }

        private void Thoát(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình ?","Thông Báo!", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }

}
       