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
using DevPF.Model;
using DevPF.Utils;

namespace DevPF.Views
{
    public partial class FrmPTZControl : DevExpress.XtraEditors.XtraForm
    {
        private int userid;
        public FrmPTZControl(int userid)
        {
            this.InitializeComponent();
            this.userid = userid;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            ResultClass<string> resultClass = CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.UP);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            ResultClass<string> resultClass = CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.DOWN);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            ResultClass<string> resultClass = CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.LEFT);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            ResultClass<string> resultClass = CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.RIGHT);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            ResultClass<string> resultClass = CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.AUTO);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}