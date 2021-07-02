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
    public partial class UserControlThiCu : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy dt = new XuLy();
        public UserControlThiCu()
        {
            InitializeComponent();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_ThiCu.AllowUserToAddRows = true;

        }


        private void btn_DeleteTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_ThiCu.CurrentRow;
            string maDT = "";
            maDT = row.Cells["MADOTTHI"].Value.ToString();
            try
            {
                dt.XoaTC(maDT);
                grid_ThiCu.DataSource = dt.ThiCu();
            }
            catch
            {

            }
        }

        private void btn_LoadTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_ThiCu.DataSource = dt.ThiCu();
            grid_ThiCu.AllowUserToAddRows = false;
        }

        private void btn_SaveTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maDT, malop,ngaythi,giothi = "";
            int row = grid_ThiCu.Rows.Count - 2;
            maDT = grid_ThiCu.Rows[row].Cells["MADOTTHI"].Value.ToString();
            malop = dt.layMaLop(grid_ThiCu.Rows[row].Cells["LOP"].Value.ToString());
            ngaythi = grid_ThiCu.Rows[row].Cells["NGAYTHI"].Value.ToString();
            giothi = grid_ThiCu.Rows[row].Cells["GIOTHI"].Value.ToString();
            
            try
            {
                dt.ThemTC(maDT, malop, ngaythi, giothi);
                grid_ThiCu.DataSource = dt.ThiCu();
                grid_ThiCu.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void btn_UpdateTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_ThiCu.CurrentRow;
            string maDT, malop, ngaythi, giothi = "";
            maDT = row.Cells["MADOTTHI"].Value.ToString();
            malop = dt.layMaLop(row.Cells["LOP"].Value.ToString());
            ngaythi = row.Cells["NGAYTHI"].Value.ToString();
            giothi = row.Cells["GIOTHI"].Value.ToString();
            
            try
            {
                dt.SuaTC(maDT, malop, ngaythi, giothi);
                grid_ThiCu.DataSource = dt.ThiCu();
            }
            catch
            {

            }
        }

        private void UserControlThiCu_Load(object sender, EventArgs e)
        {
            if (this.grid_ThiCu.Rows.Count > 0)
            {
                grid_ThiCu.AllowUserToAddRows = false;

            }
        }
    }
}
