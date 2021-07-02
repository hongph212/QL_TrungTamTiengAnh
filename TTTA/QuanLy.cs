using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTA
{
    public partial class QuanLy : Form
    {
        UserControl us;

        public QuanLy()
        {
            InitializeComponent();
        }

        public void doimau()
        {
            foreach (Control item in panel1.Controls)
            {
                ((DevExpress.XtraEditors.SimpleButton)item).ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
                ((DevExpress.XtraEditors.SimpleButton)item).ForeColor = Color.WhiteSmoke;
            }
        }
        private void showUserControls(UserControl user)
        {
            panel_Control.Controls.Add(user);
            user.BringToFront();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            if (Program.kv != 2)
            {
                btn_ThongKe.Enabled = false;
            }
            else
                btn_ThongKe.Enabled = true;
        }


        private void btn_HocVien_Click(object sender, EventArgs e)
        {
            doimau();
            us = new UserControlHocVien();
            showUserControls(us);
            btn_HocVien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            btn_HocVien.ForeColor = Color.Black;
        }


        private void frm_HocVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login.Show();
        }

        private void btn_GiaoVien_Click(object sender, EventArgs e)
        {
            doimau();
            us = new UserControlGiaoVien();
            showUserControls(us);
            btn_GiaoVien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            btn_GiaoVien.ForeColor = Color.Black;
        }

        private void btn_ThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            doimau();
            us = new UserControlThoiKhoaBieu();
            showUserControls(us);
            btn_ThoiKhoaBieu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            btn_ThoiKhoaBieu.ForeColor = Color.Black;
        }

        private void btn_DotThi_Click(object sender, EventArgs e)
        {
            doimau();
            us = new UserControlThiCu();
            showUserControls(us);
            btn_DotThi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            btn_DotThi.ForeColor = Color.Black;
        }

        private void btn_Diem_Click(object sender, EventArgs e)
        {
            doimau();
            us = new UserControlDiem();
            showUserControls(us);
            btn_Diem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            btn_Diem.ForeColor = Color.Black;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            doimau();
            us = new UserControlThongKe();
            showUserControls(us);
            btn_ThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            btn_ThongKe.ForeColor = Color.Black;
        }

    }
}
