using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using DevPF.Class;
using DevPF.Model;
using DevPF.Utils;
using Newtonsoft.Json;

namespace DevPF.Views
{
    public partial class FrmLogin : Form
    {
        private Login _login = null;

        public FrmLogin()
        {
            InitializeComponent();
            _login = new Login();
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.BtnLogin.Enabled = false;
                if (!string.IsNullOrEmpty(this.cbox_YHZH.Text) && !string.IsNullOrEmpty(this.txt_YHMM.Text))
                {
                    this.Bar_Progress.Visible = true;
                    ResultClass<string> userResultClass = CommonMethods.Login(this.cbox_YHZH.Text, this.txt_YHMM.Text);
                    if (userResultClass.Result)
                    {
                        base.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.Bar_Progress.Visible = false;
                        XtraMessageBox.Show("连接数据库失败，请确认用户名和密码是否正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    this.Bar_Progress.Visible = false;
                    XtraMessageBox.Show("用户名和密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.BtnLogin.Enabled = true;
            }
            catch (Exception ex)
            {
                this.Bar_Progress.Visible = false;
                XtraMessageBox.Show("登录失败,原因：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确定要退出吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _login.SetExitWindows(6, 300, this.Handle);
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}
