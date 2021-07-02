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
    public partial class UserControlGiaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy dt = new XuLy();

        public UserControlGiaoVien()
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
            string maGV = "";
            maGV = row.Cells["MAGV"].Value.ToString();
            try
            {
                dt.XoaGV(maGV);
                grid_GiaoVien.DataSource = dt.GiaoVien();
            }
            catch
            {

            }
        }

        private void btn_LoadGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_GiaoVien.DataSource = dt.GiaoVien();
            grid_GiaoVien.AllowUserToAddRows = false;
        }

        private void btn_SaveGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maGV, tenGV,dienthoai = "";
            int row = grid_GiaoVien.Rows.Count - 2;
            maGV = grid_GiaoVien.Rows[row].Cells["MAGV"].Value.ToString();
            tenGV = grid_GiaoVien.Rows[row].Cells["TENGV"].Value.ToString();
            dienthoai = grid_GiaoVien.Rows[row].Cells["DIENTHOAI"].Value.ToString();
            try
            {
                dt.ThemGV(maGV, tenGV,dienthoai);
                grid_GiaoVien.DataSource = dt.GiaoVien();
                grid_GiaoVien.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void btn_UpdateGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_GiaoVien.CurrentRow;
            string maGV, tenGV, dienthoai = "";
            maGV = row.Cells["MAGV"].Value.ToString();
            tenGV = row.Cells["TENGV"].Value.ToString();
            dienthoai = row.Cells["DIENTHOAI"].Value.ToString();
            
            try
            {
                dt.SuaGV(maGV, tenGV, dienthoai);
                grid_GiaoVien.DataSource = dt.GiaoVien();
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
