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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            try {
                List<SinhVien> list = SinhVien.getSinhVienListFromDB();
                if (list == null)
                {
                    throw new Exception("Khong co Sinh Viên nao");
                }
                else
                {

                    for (int i = 0; i < list.Count(); i++)
                    {
                        if (list[i].GioiTinh==SEX.Male) { 
                            
                            listSinhVien.Items.Add("Anh "+list[i].HoTen);
                        }
                        else
                        {
                            listSinhVien.Items.Add("Chị " + list[i].HoTen);
                        }

                    }
                    ckGioiTinh.Checked = list[0].GioiTinh == SEX.Male;
                    txtHoTen.Text = list[0].HoTen;
                    dtpNgaySinh.Value = list[0].NgaySinh;
                    tabPage1.Text = "Văn";
                    tabPage2.Text = "Vật Lý";
                    tabPage3.Text = "CNTT";
                    if (list[0].chuyennganh == ChuyenNganh.CNTT)
                    {
                        tabControl1.SelectTab("tabPage3");
                        txtLthdt.Text = list[0].cn1.ToString();
                        txtcntt.Text = list[0].cn2.ToString();
                        label3.Text = ((list[0].cn1 + list[0].cn2) / 2).ToString();
                    }
                    else if (list[0].chuyennganh == ChuyenNganh.Van)
                    {
                        tabControl1.SelectTab("tabPage1");
                        txtcd.Text = list[0].cn1.ToString();
                        txtHD.Text = list[0].cn2.ToString();
                        label3.Text = ((list[0].cn1 + list[0].cn2) / 2).ToString();
                    }
                    else
                    {
                        tabControl1.SelectTab("tabPage2");
                        txtvl1.Text = list[0].cn1.ToString();
                        txtvl2.Text = list[0].cn2.ToString();
                        label3.Text = ((list[0].cn1 + list[0].cn2) / 2).ToString();
                    }


                    label3.Text = ((list[0].cn1 + list[0].cn2) / 2).ToString();


                }
            } 
            
            
            catch (Exception ex) {
                txtHoTen.Text = "";

            }

        }
        
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public new void Load()
        {
            try
            {


                for (int i = listSinhVien.Items.Count - 1; i > -1; i--)
                {
                    listSinhVien.Items.RemoveAt(i);

                }
                List<SinhVien> list = SinhVien.getSinhVienListFromDB();
                if (list == null)
                {
                    throw new Exception("Khong co Sinh Viên nao");
                }
                else
                {

                    for (int i = 0; i < list.Count(); i++)
                    {
                        if (list[i].GioiTinh == SEX.Male)
                        {

                            listSinhVien.Items.Add("Anh " + list[i].HoTen);
                        }
                        else
                        {
                            listSinhVien.Items.Add("Chị " + list[i].HoTen);
                        }

                    }
                }

            }
            catch (Exception ex) { }

        }

        private void listSinhVien_Click(object sender, EventArgs e)
        {
            try {
                List<SinhVien> list = SinhVien.getSinhVienListFromDB();
                int row = listSinhVien.SelectedIndex;
                if (listSinhVien!=null) { 
            txtHoTen.Text = list.ElementAt(row).HoTen;
            if (list[row].GioiTinh == SEX.Male)
                ckGioiTinh.Checked = list[row].GioiTinh == SEX.Male;
            else
                ckGioiTinh.Checked = false;
            dtpNgaySinh.Value = list[row].NgaySinh;
            tabPage1.Text = "Văn";
            tabPage2.Text = "Vật Lý";
            tabPage3.Text = "CNTT";
            if (list[row].chuyennganh == ChuyenNganh.CNTT) { 
                tabControl1.SelectTab("tabPage3");
                txtLthdt.Text = list[row].cn1.ToString();
                txtcntt.Text = list[row].cn2.ToString();
                txtcd.Text = "";
                txtHD.Text = "";
                txtvl1.Text = "";
                txtvl2.Text = "";
                label3.Text = ((list[row].cn1 + list[row].cn2) / 2).ToString();
            }
            else if(list[row].chuyennganh == ChuyenNganh.Van) { 
                tabControl1.SelectTab("tabPage1");
                txtcd.Text = list[row].cn1.ToString();
                txtHD.Text = list[row].cn2.ToString();
                txtvl1.Text = "";
                txtvl2.Text = "";
                txtLthdt.Text ="";
                txtcntt.Text = "";
                label3.Text = ((list[row].cn1 + list[row].cn2) / 2).ToString();
            }
            else { 
                tabControl1.SelectTab("tabPage2");
                txtvl1.Text = list[row].cn1.ToString();
                txtvl2.Text = list[row].cn2.ToString();
                txtLthdt.Text = "";
                txtcntt.Text = "";
                txtcd.Text = "";
                txtHD.Text = "";
                label3.Text = ((list[row].cn1 + list[row].cn2) / 2).ToString();
            }
                }
                else
                {
                    txtHoTen.Text = "";
                }
            } 
            
            catch (Exception ex) {

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {

                
                DialogResult dlr = MessageBox.Show("Bạn có muốn xóa Sinh Viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {
                    List<SinhVien> list = SinhVien.getSinhVienListFromDB();
                    int row = listSinhVien.SelectedIndex;
                    SinhVien sv = list[row];
                    SinhVien.Remove(sv);
                    Load();



                }
                else
                {

                }


            } catch (Exception ex)
            {

            }
           
            
        }

        private void BoSung_Click(object sender, EventArgs e)
        {
            AddSinhVien f = new AddSinhVien();
            f.ShowDialog();
            Load();
           
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try {
                List<SinhVien> list = SinhVien.getSinhVienListFromDB();
                int row = listSinhVien.SelectedIndex;
                string HoTen = txtHoTen.Text;
                SEX gioitinh;
                if (ckGioiTinh.Checked == true)
                {
                    gioitinh = SEX.Male;
                }
                else
                {
                    gioitinh = SEX.Other;
                }
                DateTime ngaysinh = dtpNgaySinh.Value;
                ChuyenNganh chuyennganh;
                float cn1;
                float cn2;
                if (tabControl1.SelectedIndex == 0)
                {
                    chuyennganh = ChuyenNganh.Van;
                    cn1 = float.Parse(txtcd.Text);
                    cn2 = float.Parse(txtHD.Text);
                }
                else if(tabControl1.SelectedIndex == 1)
                {
                    chuyennganh = ChuyenNganh.VatLy;
                    cn1 = float.Parse(txtvl1.Text);
                    cn2 = float.Parse(txtvl2.Text);
                }
                else
                {
                    chuyennganh = ChuyenNganh.CNTT;
                    cn1 = float.Parse(txtLthdt.Text);
                    cn2 = float.Parse(txtcntt.Text);
                }
                 


                SinhVien sv = new SinhVien
                {
                    MaSinhVien = list[row].MaSinhVien,
                    HoTen = HoTen,
                    GioiTinh = gioitinh,
                    NgaySinh = ngaysinh,
                    chuyennganh = chuyennganh,
                    cn1 = cn1,
                    cn2 = cn2
                };

                if (cn1 <= 10 && cn1 >= 0 && cn2 <= 10 && cn2 >= 0)
                {
                    SinhVien.Edit(sv);
                    MessageBox.Show("Đã Cập nhật thành công");
                    Load();
                }
                else
                {
                    MessageBox.Show("Điểm nhập vào không hợp lệ!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
    }
}
