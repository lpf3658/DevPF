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
using DevPF.Model;
using DevPF.Utils;
using WMPLib;

namespace DevPF.Views{
    public partial class ucMainVideo : DevExpress.XtraEditors.XtraUserControl
    {
        private int userid;
        public ucMainVideo()
		{
			this.InitializeComponent();
			this.userid = 0;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			ResultClass<int> resultClass = CommonMethods.VideoLogionInfo(this.txtUserName.Text, this.txtPassWord.Text, this.txtIp.Text, this.txtPort.Text, 1);
			if (resultClass.Result)
			{
				this.userid = resultClass.ResultInfo;
				XtraMessageBox.Show( resultClass.Message,"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
                XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnPrew_Click(object sender, EventArgs e)
		{
			ResultClass<string> resultClass = CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.PREVIEW);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnbmp_Click(object sender, EventArgs e)
		{
			ResultClass<string> resultClass = CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.CAPTUREJPG);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnjpeg_Click(object sender, EventArgs e)
		{
			ResultClass<string> resultClass = CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.CAPTUREJPG);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnclient_Click(object sender, EventArgs e)
		{
			ResultClass<string> resultClass = CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.RECORD);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

        private void btnyun_Click(object sender, EventArgs e)
        {
            FrmPTZControl frmPtzControl = new FrmPTZControl(this.userid);
            frmPtzControl.ShowDialog();
        }

    }
}
