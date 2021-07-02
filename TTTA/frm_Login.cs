using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

using System.Data.SqlClient;


namespace TTTA
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        Form frm;
        public string servername = "";

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == string.Empty || txt_Pass.Text == string.Empty)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được rỗng!");
                return;
            }
            else if(txt_User.Text != string.Empty && txt_Pass.Text != string.Empty)
            {
                string strcon = "Data Source=" + servername + ";Initial Catalog=QL_TRUNGTAMTA;Persist Security Info=True;User ID=" + txt_User.Text + ";Password=" + txt_Pass.Text + "";
                Program.conn.ConnectionString = strcon;
                try
                {
                    Program.conn.Open();
                    //Hiển thị WaitForm
                    splashScreenManager1.ShowWaitForm();

                    //Thời gian chờ
                    Thread.Sleep(1000);

                    //Đóng WaitForm
                    splashScreenManager1.CloseWaitForm();
                    Program.conn.Close();

                    //Hiển thị form cần vào
                    frm = new QuanLy();
                    frm.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Kết nối không thành công, sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_Pass.Clear();
            txt_User.Clear();
            txt_User.Focus();
        }


        private void frm_Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TRUNGTAMTADataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qL_TRUNGTAMTADataSet.V_DS_PHANMANH);
        }

        private void cbbCN_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                servername = cbbCN.SelectedValue.ToString();
                Program.kv = cbbCN.SelectedIndex;
            }
            catch
            {
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DangNhap.PerformClick();
            }
        }

        private void ckDN_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDN.Checked == true)
            {
                servername = "DESKTOP-A12V4HU\\NGOCHAI";//ĐỔI ĐƯỜNG DẪN MÁY CHỦ Ở ĐÂY
                cbbCN.SelectedIndex = -1;
                Program.kv = 2;
                cbbCN.Enabled = false;
            }
            else
            {
                cbbCN.SelectedIndex = 0;
                cbbCN.Enabled = true;
            }
        }
    }
}