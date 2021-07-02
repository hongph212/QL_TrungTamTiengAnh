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
    public partial class UserControlThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy dt = new XuLy();
        public UserControlThongKe()
        {
            InitializeComponent();
        }

        private void btn_Diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Điểm");
            chart1.DataSource = dt.TKDiem();
            chart1.Series["Điểm"].XValueMember = "HOTEN";
            chart1.Series["Điểm"].YValueMembers = "DIEM";
        }

        private void btn_SoLuongHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Số lượng học viên");
            chart1.DataSource = dt.SLHV();
            chart1.Series["Số lượng học viên"].XValueMember = "TENKV";
            chart1.Series["Số lượng học viên"].YValueMembers = "soluong";
        }

        private void btn_HocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Tổng thu");
            chart1.DataSource = dt.TongThu();
            chart1.Series["Tổng thu"].XValueMember = "TENKV";
            chart1.Series["Tổng thu"].YValueMembers = "hocphi";
        }
    }
}
