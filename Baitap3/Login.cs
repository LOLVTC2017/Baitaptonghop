using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Baitap3
{
    public partial class Login : Form
    {
        string tentaikhoan = "admin";
        string matkhau = "123456789";
       
        public bool CheckLogin()
        {
            
            if (txt_tentk.Text == tentaikhoan && txt_mk.Text == matkhau)
            {
                return true;
            }
            else return false;
        
        }
        public Login()
        {
            InitializeComponent();
        }
            
        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (CheckLogin( )== true)
            {
                MessageBox.Show("Dang Nhap Thanh cong");
                this.Hide();
                Main Main = new Main();
                Main.Show();
                Main.nhậpDữLiệuToolStripMenuItem.Enabled = true;
                Main.thốngKêToolStripMenuItem.Enabled = true;

            }
        }
    }
}
