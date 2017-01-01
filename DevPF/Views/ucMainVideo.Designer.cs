using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevPF.Views
{
    partial class ucMainVideo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private SimpleButton btnLogin;

        private TextEdit txtIp;

        private TextEdit txtPort;

        private TextEdit txtUserName;

        private TextEdit txtPassWord;

        private LayoutControlItem layoutControlItem1;

        private LayoutControlItem layoutControlItem2;

        private LayoutControlItem layoutControlItem4;

        private LayoutControlItem layoutControlItem5;

        private LayoutControlItem layoutControlItem7;

        private PanelControl panelControl1;

        private TextEdit txtZT;

        private LayoutControlItem layoutControlItem3;

        private LayoutControlItem layoutControlItem6;

        private SimpleButton btnbmp;

        private SimpleButton btnPrew;

        private SimpleButton btnyun;

        private SimpleButton btnclient;

        private SimpleButton btnjpeg;

        private LayoutControlItem layoutControlItem13;

        private LayoutControlItem layoutControlItem14;

        private LayoutControlItem layoutControlItem15;

        private LayoutControlItem layoutControlItem10;

        private LayoutControlItem layoutControlItem11;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new LayoutControl();
            this.btnbmp = new SimpleButton();
            this.btnPrew = new SimpleButton();
            this.btnyun = new SimpleButton();
            this.btnclient = new SimpleButton();
            this.btnjpeg = new SimpleButton();
            this.panelControl1 = new PanelControl();
            this.btnLogin = new SimpleButton();
            this.txtIp = new TextEdit();
            this.txtPort = new TextEdit();
            this.txtUserName = new TextEdit();
            this.txtPassWord = new TextEdit();
            this.txtZT = new TextEdit();
            this.layoutControlGroup1 = new LayoutControlGroup();
            this.layoutControlItem1 = new LayoutControlItem();
            this.layoutControlItem2 = new LayoutControlItem();
            this.layoutControlItem4 = new LayoutControlItem();
            this.layoutControlItem5 = new LayoutControlItem();
            this.layoutControlItem7 = new LayoutControlItem();
            this.layoutControlItem3 = new LayoutControlItem();
            this.layoutControlItem6 = new LayoutControlItem();
            this.layoutControlItem13 = new LayoutControlItem();
            this.layoutControlItem14 = new LayoutControlItem();
            this.layoutControlItem15 = new LayoutControlItem();
            this.layoutControlItem10 = new LayoutControlItem();
            this.layoutControlItem11 = new LayoutControlItem();
            ((ISupportInitialize)this.layoutControl1).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((ISupportInitialize)this.panelControl1).BeginInit();
            ((ISupportInitialize)this.txtIp.Properties).BeginInit();
            ((ISupportInitialize)this.txtPort.Properties).BeginInit();
            ((ISupportInitialize)this.txtUserName.Properties).BeginInit();
            ((ISupportInitialize)this.txtPassWord.Properties).BeginInit();
            ((ISupportInitialize)this.txtZT.Properties).BeginInit();
            ((ISupportInitialize)this.layoutControlGroup1).BeginInit();
            ((ISupportInitialize)this.layoutControlItem1).BeginInit();
            ((ISupportInitialize)this.layoutControlItem2).BeginInit();
            ((ISupportInitialize)this.layoutControlItem4).BeginInit();
            ((ISupportInitialize)this.layoutControlItem5).BeginInit();
            ((ISupportInitialize)this.layoutControlItem7).BeginInit();
            ((ISupportInitialize)this.layoutControlItem3).BeginInit();
            ((ISupportInitialize)this.layoutControlItem6).BeginInit();
            ((ISupportInitialize)this.layoutControlItem13).BeginInit();
            ((ISupportInitialize)this.layoutControlItem14).BeginInit();
            ((ISupportInitialize)this.layoutControlItem15).BeginInit();
            ((ISupportInitialize)this.layoutControlItem10).BeginInit();
            ((ISupportInitialize)this.layoutControlItem11).BeginInit();
            base.SuspendLayout();
            this.layoutControl1.Controls.Add(this.btnbmp);
            this.layoutControl1.Controls.Add(this.btnPrew);
            this.layoutControl1.Controls.Add(this.btnyun);
            this.layoutControl1.Controls.Add(this.btnclient);
            this.layoutControl1.Controls.Add(this.btnjpeg);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.btnLogin);
            this.layoutControl1.Controls.Add(this.txtIp);
            this.layoutControl1.Controls.Add(this.txtPort);
            this.layoutControl1.Controls.Add(this.txtUserName);
            this.layoutControl1.Controls.Add(this.txtPassWord);
            this.layoutControl1.Controls.Add(this.txtZT);
            this.layoutControl1.Dock = DockStyle.Fill;
            this.layoutControl1.Location = new Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1092, 264, 534, 437));
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new Size(828, 606);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            this.btnbmp.Location = new Point(535, 530);
            this.btnbmp.Name = "btnbmp";
            this.btnbmp.Size = new Size(277, 27);
            this.btnbmp.StyleController = this.layoutControl1;
            this.btnbmp.TabIndex = 16;
            this.btnbmp.Text = "BMP抓图";
            this.btnbmp.Click += new EventHandler(this.btnbmp_Click);
            this.btnPrew.Location = new Point(244, 530);
            this.btnPrew.Name = "btnPrew";
            this.btnPrew.Size = new Size(285, 27);
            this.btnPrew.StyleController = this.layoutControl1;
            this.btnPrew.TabIndex = 15;
            this.btnPrew.Text = "预览";
            this.btnPrew.Click += new EventHandler(this.btnPrew_Click);
            this.btnyun.Location = new Point(535, 563);
            this.btnyun.Name = "btnyun";
            this.btnyun.Size = new Size(277, 27);
            this.btnyun.StyleController = this.layoutControl1;
            this.btnyun.TabIndex = 14;
            this.btnyun.Text = "云台控制";
            this.btnyun.Click += new EventHandler(this.btnyun_Click);
            this.btnclient.Location = new Point(244, 563);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new Size(285, 27);
            this.btnclient.StyleController = this.layoutControl1;
            this.btnclient.TabIndex = 13;
            this.btnclient.Text = "客户端录像";
            this.btnclient.Click += new EventHandler(this.btnclient_Click);
            this.btnjpeg.Location = new Point(16, 558);
            this.btnjpeg.Name = "btnjpeg";
            this.btnjpeg.Size = new Size(222, 27);
            this.btnjpeg.StyleController = this.layoutControl1;
            this.btnjpeg.TabIndex = 12;
            this.btnjpeg.Text = "JPEG抓图";
            this.btnjpeg.Click += new EventHandler(this.btnjpeg_Click);
            this.panelControl1.Location = new Point(16, 72);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new Size(796, 452);
            this.panelControl1.TabIndex = 11;
            this.btnLogin.Location = new Point(646, 16);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(166, 27);
            this.btnLogin.StyleController = this.layoutControl1;
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            this.txtIp.Location = new Point(115, 15);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new Size(222, 24);
            this.txtIp.StyleController = this.layoutControl1;
            this.txtIp.TabIndex = 4;
            this.txtPort.Location = new Point(441, 15);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new Size(200, 24);
            this.txtPort.StyleController = this.layoutControl1;
            this.txtPort.TabIndex = 5;
            this.txtUserName.Location = new Point(115, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new Size(222, 24);
            this.txtUserName.StyleController = this.layoutControl1;
            this.txtUserName.TabIndex = 7;
            this.txtPassWord.Location = new Point(441, 43);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new Size(200, 24);
            this.txtPassWord.StyleController = this.layoutControl1;
            this.txtPassWord.TabIndex = 8;
            this.txtZT.Location = new Point(115, 529);
            this.txtZT.Name = "txtZT";
            this.txtZT.Size = new Size(124, 24);
            this.txtZT.StyleController = this.layoutControl1;
            this.txtZT.TabIndex = 4;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem4,
				this.layoutControlItem5,
				this.layoutControlItem7,
				this.layoutControlItem3,
				this.layoutControlItem6,
				this.layoutControlItem13,
				this.layoutControlItem14,
				this.layoutControlItem15,
				this.layoutControlItem10,
				this.layoutControlItem11
			});
            this.layoutControlGroup1.Location = new Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new Size(828, 606);
            this.layoutControlGroup1.TextVisible = false;
            this.layoutControlItem1.Control = this.txtIp;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem1.Size = new Size(326, 28);
            this.layoutControlItem1.Text = "设备Ip";
            this.layoutControlItem1.TextLocation = Locations.Left;
            this.layoutControlItem1.TextSize = new Size(96, 18);
            this.layoutControlItem2.Control = this.txtPort;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new Point(326, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem2.Size = new Size(304, 28);
            this.layoutControlItem2.Text = "设备端口号";
            this.layoutControlItem2.TextLocation = Locations.Left;
            this.layoutControlItem2.TextSize = new Size(96, 18);
            this.layoutControlItem4.Control = this.txtUserName;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem4.Size = new Size(326, 28);
            this.layoutControlItem4.Text = "用户名";
            this.layoutControlItem4.TextLocation = Locations.Left;
            this.layoutControlItem4.TextSize = new Size(96, 18);
            this.layoutControlItem5.Control = this.txtPassWord;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new Point(326, 28);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem5.Size = new Size(304, 28);
            this.layoutControlItem5.Text = "密码";
            this.layoutControlItem5.TextLocation = Locations.Left;
            this.layoutControlItem5.TextSize = new Size(96, 18);
            this.layoutControlItem7.Control = this.btnLogin;
            this.layoutControlItem7.Location = new Point(630, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new Size(172, 56);
            this.layoutControlItem7.TextSize = new Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            this.layoutControlItem3.Control = this.panelControl1;
            this.layoutControlItem3.Location = new Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new Size(802, 458);
            this.layoutControlItem3.TextSize = new Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem6.Control = this.txtZT;
            this.layoutControlItem6.Location = new Point(0, 514);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem6.Size = new Size(228, 28);
            this.layoutControlItem6.Text = "远程/抓图通道";
            this.layoutControlItem6.TextLocation = Locations.Left;
            this.layoutControlItem6.TextSize = new Size(96, 18);
            this.layoutControlItem13.Control = this.btnjpeg;
            this.layoutControlItem13.Location = new Point(0, 542);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new Size(228, 38);
            this.layoutControlItem13.TextSize = new Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            this.layoutControlItem14.Control = this.btnclient;
            this.layoutControlItem14.Location = new Point(228, 547);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new Size(291, 33);
            this.layoutControlItem14.TextSize = new Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            this.layoutControlItem15.Control = this.btnyun;
            this.layoutControlItem15.Location = new Point(519, 547);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new Size(283, 33);
            this.layoutControlItem15.TextSize = new Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            this.layoutControlItem10.Control = this.btnPrew;
            this.layoutControlItem10.Location = new Point(228, 514);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new Size(291, 33);
            this.layoutControlItem10.TextSize = new Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            this.layoutControlItem11.Control = this.btnbmp;
            this.layoutControlItem11.Location = new Point(519, 514);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new Size(283, 33);
            this.layoutControlItem11.TextSize = new Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            base.AutoScaleDimensions = new SizeF(8f, 18f);
            base.Controls.Add(this.layoutControl1);
            base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            base.Name = "ucMainVideo";
            base.Size = new Size(828, 606);
            ((ISupportInitialize)this.layoutControl1).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((ISupportInitialize)this.panelControl1).EndInit();
            ((ISupportInitialize)this.txtIp.Properties).EndInit();
            ((ISupportInitialize)this.txtPort.Properties).EndInit();
            ((ISupportInitialize)this.txtUserName.Properties).EndInit();
            ((ISupportInitialize)this.txtPassWord.Properties).EndInit();
            ((ISupportInitialize)this.txtZT.Properties).EndInit();
            ((ISupportInitialize)this.layoutControlGroup1).EndInit();
            ((ISupportInitialize)this.layoutControlItem1).EndInit();
            ((ISupportInitialize)this.layoutControlItem2).EndInit();
            ((ISupportInitialize)this.layoutControlItem4).EndInit();
            ((ISupportInitialize)this.layoutControlItem5).EndInit();
            ((ISupportInitialize)this.layoutControlItem7).EndInit();
            ((ISupportInitialize)this.layoutControlItem3).EndInit();
            ((ISupportInitialize)this.layoutControlItem6).EndInit();
            ((ISupportInitialize)this.layoutControlItem13).EndInit();
            ((ISupportInitialize)this.layoutControlItem14).EndInit();
            ((ISupportInitialize)this.layoutControlItem15).EndInit();
            ((ISupportInitialize)this.layoutControlItem10).EndInit();
            ((ISupportInitialize)this.layoutControlItem11).EndInit();
            base.ResumeLayout(false);
        }
    }

}
