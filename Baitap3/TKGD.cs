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
    public partial class TKGD : Form
    {
        UserFunction Function = new UserFunction();
        public TKGD()
        {
            InitializeComponent();
        }
        private void LoadGianVien()
        {
            cb_giangvien.DataSource = Function.LoadDSGV();
            cb_giangvien.DisplayMember = "TENGV";
            cb_giangvien.ValueMember = "MAGV";
        }
        private void LoadThongTinCuaGiangVien()
        {
            string magv = cb_giangvien.SelectedValue.ToString();

        }
        private void TKGD_Load(object sender, EventArgs e)
        {
            LoadGianVien();
        }
        private void tinhtongsogio()
        {
            int tongsohlamviec = 0;
            for (int i = 0; i < dataGV_gd.RowCount; i++) 
            {
                tongsohlamviec += Convert.ToInt16(dataGV_gd.Rows[i].Cells["SOTIET"].Value);

            }
            lb_tsg.Text =tongsohlamviec.ToString();
        }
        private void cb_giangvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGV_gd.DataSource = Function.LoadClickThongTinGiangVien(cb_giangvien.SelectedValue.ToString());
            tinhtongsogio();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
