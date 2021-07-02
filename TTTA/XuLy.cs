using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TTTA
{
    public class XuLy
    {
        DataSet ds = new DataSet();
        SqlConnection conn = Program.conn;

        public DataTable HocVien()
        {
            DataTable dtb = new DataTable();
            string sql = "select MAHV,HOTEN,NGAYSINH,GIOITINH,DIENTHOAI,DIACHI,TENLOP from HOCVIEN,LOP where HOCVIEN.MALOP = LOP.MALOP";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable PhanCong()
        {
            DataTable dtb = new DataTable();
            string sql = "select MAPC,TENGV,TENLOP,KHOAHOC,MADOTTHI from PHANCONG,GIAOVIEN,LOP where PHANCONG.MALOP = LOP.MALOP and GIAOVIEN.MAGV = PHANCONG.MAGV";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable ThiCu()
        {
            DataTable dtb = new DataTable();
            string sql = "select MADOTTHI,TENLOP,NGAYTHI,GIOTHI from DOTTHI,LOP where DOTTHI.MALOP = LOP.MALOP";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable GiaoVien()
        {
            DataTable dtb = new DataTable();
            string sql = "select MAGV,TENGV,DIENTHOAI from GIAOVIEN";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable HoSo()
        {
            DataTable dtb = new DataTable();
            string sql = "select MAHOSO,HOTEN,TENLOP,TBDIEM,XEPLOAI from HOCVIEN,HOSOHOCVIEN,LOP where HOCVIEN.MAHV = HOSOHOCVIEN.MAHV and LOP.MALOP = HOCVIEN.MALOP";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable Diem(string mahv)
        {
            DataTable dtb = new DataTable();
            string sql = "select MAPC,LAN,DIEM from KIEMTRA where KIEMTRA.MAHV = '"+mahv+"' group by MAPC,LAN,DIEM";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable TKDiem()
        {
            DataTable dtb = new DataTable();
            string sql = "select HOTEN,hs3.TBDIEM as DIEM from CN1.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN hs1,CN2.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN hs2,HOSOHOCVIEN hs3,HOCVIEN where hs1.MAHOSO = hs3.MAHOSO and hs3.MAHV = HOCVIEN.MAHV or hs2.MAHOSO = hs3.MAHOSO and hs3.MAHV = HOCVIEN.MAHV group by HOTEN,hs3.TBDIEM";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable SLHV()
        {
            DataTable dtb = new DataTable();
            string sql = "select TENKV,COUNT(MAHV) as soluong from KHUVUC,HOCVIEN where KHUVUC.MAKV = HOCVIEN.MAKV group by TENKV";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public DataTable TongThu()
        {
            DataTable dtb = new DataTable();
            string sql = "select TENKV,SUM(HOCPHI) as hocphi from KHUVUC,HOCVIEN,LOP where KHUVUC.MAKV = HOCVIEN.MAKV and HOCVIEN.MALOP = LOP.MALOP group by TENKV";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb;
        }

        public bool ThemHV(string mahv, string tenhv, string ngaysinh, string gioitinh, string sdt, string diachi, string malop,string makv)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spInsertHocVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tenhv;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = sdt;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@makv", SqlDbType.VarChar).Value = makv;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaHV(string mahv, string tenhv, string ngaysinh, string gioitinh, string sdt, string diachi, string malop)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spUpdateHocVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tenhv;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = sdt;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHV(string mahv)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spDeleteHocVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemPC(string mapc, string magv,string malop,string khoahoc,string madotthi, string makv)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spInsertPhanCong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapc", SqlDbType.VarChar).Value = mapc;
                cmd.Parameters.Add("@magv", SqlDbType.VarChar).Value = magv;
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@khoahoc", SqlDbType.VarChar).Value = khoahoc;
                cmd.Parameters.Add("@madotthi", SqlDbType.VarChar).Value = madotthi;
                cmd.Parameters.Add("@makv", SqlDbType.VarChar).Value = makv;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaPC(string mapc, string magv, string malop, string khoahoc, string madotthi)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spUpdatePhanCong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapc", SqlDbType.VarChar).Value = mapc;
                cmd.Parameters.Add("@magv", SqlDbType.VarChar).Value = magv;
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@khoahoc", SqlDbType.VarChar).Value = khoahoc;
                cmd.Parameters.Add("@madotthi", SqlDbType.VarChar).Value = madotthi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaPC(string mapc)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spDeletePhanCong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapc", SqlDbType.VarChar).Value = mapc;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemTC(string madotthi, string malop, string ngaythi, string giothi)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spInsertThiCu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@madotthi", SqlDbType.VarChar).Value = madotthi;
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@ngaythi", SqlDbType.Date).Value = ngaythi;
                cmd.Parameters.Add("@giothi", SqlDbType.Time).Value = giothi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTC(string madotthi, string malop, string ngaythi, string giothi)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spUpdateThiCu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@madotthi", SqlDbType.VarChar).Value = madotthi;
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@ngaythi", SqlDbType.Date).Value = ngaythi;
                cmd.Parameters.Add("@giothi", SqlDbType.Time).Value = giothi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaTC(string madotthi)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spDeleteThiCu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@madotthi", SqlDbType.VarChar).Value = madotthi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemGV(string magv, string tengv, string dienthoai)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spInsertGV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@magv", SqlDbType.VarChar).Value = magv;
                cmd.Parameters.Add("@tengv", SqlDbType.NVarChar).Value = tengv;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = dienthoai;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaGV(string magv, string tengv, string dienthoai)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spUpdateGV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@magv", SqlDbType.VarChar).Value = magv;
                cmd.Parameters.Add("@tengv", SqlDbType.NVarChar).Value = tengv;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = dienthoai;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaGV(string magv)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spDeleteGV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@magv", SqlDbType.VarChar).Value = magv;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemHS(string mahs, string mahv)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spInsertHS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahs", SqlDbType.VarChar).Value = mahs;
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaHS(string mahs, string mahv)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spUpdateHS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahs", SqlDbType.VarChar).Value = mahs;
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHS(string mahs)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spDeleteHS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahs", SqlDbType.VarChar).Value = mahs;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemDiem(string mahv,string mapc,string lan,string diem)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spInsertDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.Parameters.Add("@mapc", SqlDbType.VarChar).Value = mapc;
                cmd.Parameters.Add("@lan", SqlDbType.Int).Value = lan;
                cmd.Parameters.Add("@diem", SqlDbType.Float).Value = diem;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDiem(string mahv, string mapc, string lan, string diem)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spUpdateDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.Parameters.Add("@mapc", SqlDbType.VarChar).Value = mapc;
                cmd.Parameters.Add("@lan", SqlDbType.Int).Value = lan;
                cmd.Parameters.Add("@diem", SqlDbType.Float).Value = diem;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaDiem(string mahv, string mapc, string lan)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("spDeleteDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahv", SqlDbType.VarChar).Value = mahv;
                cmd.Parameters.Add("@mapc", SqlDbType.VarChar).Value = mapc;
                cmd.Parameters.Add("@lan", SqlDbType.Int).Value = lan;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string layMaLop(string tenlop)
        {
            DataTable dtb = new DataTable();
            string sql = "select * from LOP where TENLOP = N'"+tenlop+"'";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb.Rows[0][0].ToString();
        }

        public string layMaGV(string tengv)
        {
            DataTable dtb = new DataTable();
            string sql = "select * from GIAOVIEN where TENGV = N'"+tengv+"'";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb.Rows[0][0].ToString();
        }

        public string layMaHV(string tenhv)
        {
            DataTable dtb = new DataTable();
            string sql = "select * from HOCVIEN where HOTEN = N'" + tenhv + "'";
            SqlDataAdapter da_temp = new SqlDataAdapter(sql, conn);
            da_temp.Fill(dtb);
            return dtb.Rows[0][0].ToString();
        }
    }
}
