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
    public partial class UserControlThoiKhoaBieu : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy dt = new XuLy();
        public UserControlThoiKhoaBieu()
        {
            InitializeComponent();
        }
        private void btn_NewGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_GiaoVien.AllowUserToAddRows = true;

        }


        private void btn_DeleteGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_GiaoVien.CurrentRow;
            string maPC = "";
            maPC = row.Cells["MAPC"].Value.ToString();
            try
            {
                dt.XoaPC(maPC);
                grid_GiaoVien.DataSource = dt.PhanCong();
            }
            catch
            {

            }
        }

        private void btn_LoadGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_GiaoVien.DataSource = dt.PhanCong();
            grid_GiaoVien.AllowUserToAddRows = false;
        }

        private void btn_SaveGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maPC, maGV, malop, khoahoc, madotthi, makv = "";
            int row = grid_GiaoVien.Rows.Count - 2;
            maPC = grid_GiaoVien.Rows[row].Cells["MAPC"].Value.ToString();
            maGV = dt.layMaGV(grid_GiaoVien.Rows[row].Cells["TENGV"].Value.ToString());
            khoahoc = grid_GiaoVien.Rows[row].Cells["KHOAHOC"].Value.ToString();
            madotthi = grid_GiaoVien.Rows[row].Cells["MADOTTHI"].Value.ToString();
            malop = dt.layMaLop(grid_GiaoVien.Rows[row].Cells["LOP"].Value.ToString());
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
                dt.ThemPC(maPC, maGV, malop, khoahoc, madotthi, makv);
                grid_GiaoVien.DataSource = dt.PhanCong();
                grid_GiaoVien.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void btn_UpdateGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_GiaoVien.CurrentRow;
            string maPC, maGV, malop, khoahoc, madotthi = "";
            maPC = row.Cells["MAPC"].Value.ToString();
            maGV = dt.layMaGV(row.Cells["TENGV"].Value.ToString());
            malop = dt.layMaLop(row.Cells["LOP"].Value.ToString());
            khoahoc = row.Cells["KHOAHOC"].Value.ToString();
            madotthi = row.Cells["MADOTTHI"].Value.ToString();

            try
            {
                dt.SuaPC(maPC, maGV, malop, khoahoc, madotthi);
                grid_GiaoVien.DataSource = dt.PhanCong();
            }
            catch
            {

            }
        }

        private void UserControlGiaoVien_Load(object sender, EventArgs e)
        {
            if (this.grid_GiaoVien.Rows.Count > 0)
            {
                grid_GiaoVien.AllowUserToAddRows = false;

            }
        }
    }
}
