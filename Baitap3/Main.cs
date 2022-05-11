using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhậpDanhSáchGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSGV dSGV = new DSGV();
            dSGV.Show();
       
        }

        private void nhậpDanhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void giáoViênTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THTK tHTK = new THTK();
            tHTK.Show();
            
        }

        private void thốngKêGiờDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKGD tKGD = new TKGD();
            tKGD.Show();

        }
    }
}
