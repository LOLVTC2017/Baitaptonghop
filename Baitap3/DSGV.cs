using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Function;

namespace Baitap3
{
    public partial class DSGV : Form
    {
        CurrencyManager manager;

        public DSGV()
        {
            InitializeComponent();
        }
        UserFunction Function = new UserFunction();
       
        private void btn_themmt_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox || ctr is DateTimePicker)
                {
                    ctr.Text = "";
                    ctr.DataBindings.Clear();
                }
            }
            txt_makhoa.Visible = false;
            cb_makhoa.Visible = true;
            btn_capnhat.Enabled = false;
            btn_luu.Enabled = true;
            txt_magv.Enabled = true;
            btn_themmt.Enabled = false;
            btn_vephai.Enabled = false;
            btn_trai.Enabled = false;
            btn_phai.Enabled = false;
            btn_vetrai.Enabled = false;
            btn_luu.Enabled = true;
        }
        private void LoadThongTinGiaoVien()
        {
            DataTable data =  Function.LoadDSGV();
            DataTable data2 = Function.LoadMaKhoa();
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox || ctr is DateTimePicker)
                {
                    ctr.Text = "";
                    ctr.DataBindings.Clear();
                }
            }
            txt_magv.DataBindings.Add("text", data, "MAGV");
            txt_hodem.DataBindings.Add("text", data, "HODEM");
            dtp_ngaysinh.DataBindings.Add("text", data, "NGAYSINH");
            txt_dienthoai.DataBindings.Add("text", data, "DIENTHOAI");
            txt_sogiochuan.DataBindings.Add("text", data, "SOGIOCHUAN");
            txt_tengv.DataBindings.Add("text", data, "TENGV");
            txt_hocvi.DataBindings.Add("text", data, "HOCVI");
            txt_hsluong.DataBindings.Add("text", data, "HSLUONG");
            cb_makhoa.DataSource = data2;
            cb_makhoa.DisplayMember = "MAKHOA";
            cb_makhoa.ValueMember = "MAKHOA";
            manager = (CurrencyManager)this.BindingContext[data];
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);

        }
       
        private void SaveInfor()
        {
            string magv = txt_magv.Text;
            string hodem = txt_hodem.Text;
            string tengv = txt_tengv.Text;
            string ngaysinh = dtp_ngaysinh.Value.ToString();
            string hocvi = txt_hocvi.Text;
            string dienthoai = txt_dienthoai.Text;
            string mk = cb_makhoa.SelectedValue.ToString();
            float hsl = float.Parse(txt_hsluong.Text);
            int sgc = Convert.ToInt16(txt_sogiochuan.Text);
            if (Function.SaveThongTinGiaoVien(magv, hodem, tengv, ngaysinh, hocvi, dienthoai, hsl, sgc, mk) == true) MessageBox.Show("Luu Thanh Cong");
            else MessageBox.Show("Luu That Bai");
            
           




        }


        private void DSGV_Load(object sender, EventArgs e)
        {
            LoadThongTinGiaoVien();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_phai_Click(object sender, EventArgs e)
        {

            manager.Position++;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_trai_Click(object sender, EventArgs e)
        {
            manager.Position--;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_vetrai_Click(object sender, EventArgs e)
        {
            manager.Position = 0;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_vephai_Click(object sender, EventArgs e)
        {
            manager.Position = manager.Count;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try { SaveInfor(); }
            catch (Exception ex) { MessageBox.Show("khong duoc de trong "); }
            btn_themmt.Enabled = true;
            btn_capnhat.Enabled = true;
            btn_vephai.Enabled = true;
            btn_trai.Enabled = true;
            btn_phai.Enabled = true;
            btn_vetrai.Enabled = true;
            btn_luu.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            btn_themmt.Enabled=false;
            btn_vephai.Enabled=false;
            btn_trai.Enabled=false;
            btn_phai.Enabled = false;
            btn_vetrai.Enabled=false;
            btn_luu.Enabled = true;
        }
    }
}
