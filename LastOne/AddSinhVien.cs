using LastOne.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastOne
{
    public partial class AddSinhVien : Form
    {
        public AddSinhVien()
        {
            InitializeComponent();
            cbbChuyenNganh.Items.Add("Văn");
            cbbChuyenNganh.Items.Add("CNTT");
            cbbChuyenNganh.Items.Add("Vật Lý");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String masinhvien = txtmasinhvien.Text;
            String HoTen = txtHoTen.Text;
            SEX gioitinh ;
            if (checkBox1.Checked == true)
            {
                 gioitinh = SEX.Male;
            }
            else
            {
                gioitinh = SEX.Other;
            }
            DateTime ngaysinh = dateTimePicker1.Value;
            ChuyenNganh chuyennganh;
            if (cbbChuyenNganh.SelectedIndex == 1)
            {
                chuyennganh = ChuyenNganh.CNTT;
            }
            else if(cbbChuyenNganh.SelectedIndex == 0)
            {
                chuyennganh = ChuyenNganh.Van;
            }
            else
            {
                chuyennganh = ChuyenNganh.VatLy;
            }
         
                float cn1 = float.Parse(txtcn1.Text);
                float cn2 = float.Parse(txtcn2.Text);
            
            
            SinhVien sv = new SinhVien {
                MaSinhVien = masinhvien,
                HoTen = HoTen,
                GioiTinh = gioitinh,
                NgaySinh = ngaysinh,
                chuyennganh = chuyennganh,
                cn1 = cn1,
                cn2 = cn2
            };
            
            
                if (cn1 <= 10 && cn1 >= 0 && cn2 <= 10 && cn2 >= 0)
                {
                    SinhVien.Add(sv);
                    MessageBox.Show("Đã Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Điểm nhập vào không hợp lệ!");
                }
               
                
            } catch (Exception ex) {
                MessageBox.Show("Thêm thất bại!");
            }
                
                

        }

        private void cbbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChuyenNganh.SelectedIndex == 0)
            {
                cn1.Text = "Văn Học CD:";
                cn2.Text = "Văn Học HD:";
            }
            else if(cbbChuyenNganh.SelectedIndex == 1)
            {
                cn1.Text = "LTHDT:";
                cn2.Text = "CNTT:";
            }
            else
            {
                cn1.Text = "Vật lý 1:";
                cn2.Text = "Vật lý 2:";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
