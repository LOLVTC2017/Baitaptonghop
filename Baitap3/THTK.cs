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
    public partial class THTK : Form
    {
        public THTK()
        {
            InitializeComponent();
        }
        UserFunction Function = new UserFunction();
        BindingSource customersBindingSource = new BindingSource();
        private void LoadDataGrid1()
        {
            dataGV_khoa.DataSource = Function.LoadMaKhoa();
        }

        private void LoadDataGrid2WhenClick()
        {
            string makhoa = dataGV_khoa.CurrentRow.Cells["MAKHOA"].Value.ToString();
            DataTable table = Function.LoadGiangVienBangMaKhoa(makhoa);
            dataGV_gv.DataSource = table;
            customersBindingSource.DataSource = table;
            bindingNav.BindingSource = customersBindingSource;
        }
        private void THTK_Load(object sender, EventArgs e)
        {
            LoadDataGrid1();
          
        }

        private void dataGV_khoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadDataGrid2WhenClick();
        }

        private void bindingNav_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
