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
    public partial class UserControlDiem : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy dt = new XuLy();
        string mahv = "";
        public UserControlDiem()
        {
            InitializeComponent();
        }

        private void btn_LoadHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_HoSo.DataSource = dt.HoSo();
            grid_HoSo.AllowUserToAddRows = false;
        }

        private void btn_NewHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_HoSo.AllowUserToAddRows = true;
        }

        private void frm_HocVien_Load(object sender, EventArgs e)
        {
            if (this.grid_HoSo.Rows.Count > 0)
            {
                grid_HoSo.AllowUserToAddRows = false;

            }
        }

        private void grid_HoSo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                mahv = dt.layMaHV(grid_HoSo.CurrentRow.Cells[1].Value.ToString());
                grid_Diem.DataSource = dt.Diem(mahv);
            }
            catch
            {
            }
        }

        private void btn_DeleteHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_HoSo.CurrentRow;
            string mahs = "";
            mahs = row.Cells["MAHOSO"].Value.ToString();
            try
            {
                dt.XoaHS(mahs);
                grid_HoSo.DataSource = dt.HoSo();
            }
            catch
            {

            }
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grid_Diem.CurrentRow;
            string mapc,lan = "";
            mapc = row.Cells["MAPC"].Value.ToString();
            lan = row.Cells["LAN"].Value.ToString();
            try
            {
                dt.XoaDiem(mahv,mapc,lan);
                grid_HoSo.DataSource = dt.HoSo();
            }
            catch
            {

            }
        }

        private void btn_SaveHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mahs,mhv="";
            int row = grid_HoSo.Rows.Count - 2;
            mahs = grid_HoSo.Rows[row].Cells["MAHOSO"].Value.ToString();
            mhv = dt.layMaHV(grid_HoSo.Rows[row].Cells["HOTEN"].Value.ToString());
            try
            {
                dt.ThemHS(mahs,mhv);
                grid_HoSo.DataSource = dt.HoSo();
                grid_HoSo.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mapc,lan,diem = "";
            int row = grid_Diem.Rows.Count - 2;
            mapc = grid_Diem.Rows[row].Cells["MAPC"].Value.ToString();
            lan = grid_Diem.Rows[row].Cells["LAN"].Value.ToString();
            diem = grid_Diem.Rows[row].Cells["DIEM"].Value.ToString();
            try
            {
                dt.ThemDiem(mahv,mapc,lan,diem);
                grid_HoSo.DataSource = dt.HoSo();
                grid_Diem.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void btn_UpdateHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = grid_HoSo.CurrentRow;
            string mahs,mhv ="";
            mahs = row.Cells["MAHOSO"].Value.ToString();
            mhv = dt.layMaHV(row.Cells["HOTEN"].Value.ToString());
            try
            {
                dt.SuaHS(mahs,mhv);
                grid_HoSo.DataSource = dt.HoSo();
            }
            catch
            {

            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grid_Diem.CurrentRow;
            string mapc,lan,diem = "";
            mapc = row.Cells["MAPC"].Value.ToString();
            lan = row.Cells["LAN"].Value.ToString();
            diem = row.Cells["DIEM"].Value.ToString();
            try
            {
                dt.SuaDiem(mahv, mapc, lan, diem);
                grid_HoSo.DataSource = dt.HoSo();
            }
            catch
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_Diem.AllowUserToAddRows = true;
        }

        private void btn_NewHV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grid_HoSo.AllowUserToAddRows = true;
        }

       
    }
}
