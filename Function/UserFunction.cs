using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Function
{
    public class UserFunction
    {
        DataBase data = new DataBase();
        public DataTable LoadDSGV()
        {
            string sql = "SELECT * FROM GIANGVIEN";
            SqlDataAdapter adapter = data.Query(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable LoadMaKhoa()
        {
            string sql = "SELECT * FROM KHOA";
            SqlDataAdapter adapter = data.Query(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool SaveThongTinGiaoVien(string magv, string hodem, string tengiaovien, string ngaysinh, string hocvi, string dienthoai, float hsl, int sgc, string makhoa)
        {
            string sql = "LuuThongTinGiangVien @magv,@hodem,@tengiaovien,@ngaysinh,@hocvi,@dienthoai,@hsl,@sgc,@makhoa";
            SqlCommand cmd = new SqlCommand(sql,data.Connect());
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@hodem", hodem);
            cmd.Parameters.AddWithValue("@tengiaovien", tengiaovien);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@hocvi", hocvi);
            cmd.Parameters.AddWithValue("@dienthoai", dienthoai);
            cmd.Parameters.AddWithValue("@hsl", hsl);
            cmd.Parameters.AddWithValue("@sgc", sgc);
            cmd.Parameters.AddWithValue("@makhoa", makhoa);
            cmd.Connection.Open();
            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }
        public DataTable LoadGiangVienBangMaKhoa(string makhoa)
        {
            string sql = String.Format("LoadGiangVienBangMaKhoa '{0}'", makhoa);
            SqlDataAdapter adapter = data.Query(sql);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable LoadClickThongTinGiangVien(string magv)
        {
            string sql = string.Format("GetThongKeHday '{0}'", magv);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = data.Query(sql);
            adapter.Fill(table);    
            return table;
        }
       
    }
}