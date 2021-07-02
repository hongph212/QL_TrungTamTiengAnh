using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TTTA
{
    public partial class UserControlHocVien : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy dt = new XuLy();

        public UserControlHocVien()
        {
            InitializeComponent();
        }

        private void btn_NewHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_HocVIen.AllowUserToAddRows = true;

        }

        private void frm_HocVien_Load(object sender, EventArgs e)
        {
            if (this.grid_HocVIen.Rows.Count > 0)
            {
                grid_HocVIen.AllowUserToAddRows = false;

            }
        }

        private void btn_DeleteHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_HocVIen.CurrentRow;
            string mahv = "";
            mahv = row.Cells["MAHV"].Value.ToString();
            try
            {
                dt.XoaHV(mahv);
                grid_HocVIen.DataSource = dt.HocVien();
            }
            catch
            {

            }
        }


        private void btn_LoadHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_HocVIen.DataSource = dt.HocVien();
            grid_HocVIen.AllowUserToAddRows = false;
        }

        private void btn_SaveHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mahv, tenhv, ngaysinh, gioitinh, dienthoai, diachi, malop, makv = "";
            int row = grid_HocVIen.Rows.Count - 2;
            mahv = grid_HocVIen.Rows[row].Cells["MAHV"].Value.ToString();
            tenhv = grid_HocVIen.Rows[row].Cells["HOTEN"].Value.ToString();
            ngaysinh = grid_HocVIen.Rows[row].Cells["NGAYSINH"].Value.ToString();
            gioitinh = grid_HocVIen.Rows[row].Cells["GIOITINH"].Value.ToString();
            dienthoai = grid_HocVIen.Rows[row].Cells["SDT"].Value.ToString();
            diachi = grid_HocVIen.Rows[row].Cells["DIACHI"].Value.ToString();
            malop = dt.layMaLop(grid_HocVIen.Rows[row].Cells["LOP"].Value.ToString());
            if (Program.kv == 0)
            {
                makv = "KV001";
            }
            else if (Program.kv == 1)
            {
                makv = "KV002";
            }
            else
            {
                makv = "KV003";
            }
            try
            {
                dt.ThemHV(mahv, tenhv, ngaysinh, gioitinh, dienthoai, diachi, malop, makv);
                grid_HocVIen.DataSource = dt.HocVien();
                grid_HocVIen.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void btn_UpdateHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_HocVIen.CurrentRow;
            string mahv, tenhv, ngaysinh, gioitinh, dienthoai, diachi, malop = "";
            mahv = row.Cells["MAHV"].Value.ToString();
            tenhv = row.Cells["HOTEN"].Value.ToString();
            ngaysinh = row.Cells["NGAYSINH"].Value.ToString();
            gioitinh = row.Cells["GIOITINH"].Value.ToString();
            dienthoai = row.Cells["SDT"].Value.ToString();
            diachi = row.Cells["DIACHI"].Value.ToString();
            malop = dt.layMaLop(row.Cells["LOP"].Value.ToString());
            try
            {
                dt.SuaHV(mahv, tenhv, ngaysinh, gioitinh, dienthoai, diachi, malop);
                grid_HocVIen.DataSource = dt.HocVien();
            }
            catch
            {

            }
        }
    }
}
