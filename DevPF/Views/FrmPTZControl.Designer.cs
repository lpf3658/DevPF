using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;

namespace DevPF.Views
{
    partial class FrmPTZControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private ComboBoxEdit cmbSpeed;

        private SimpleButton btnDown;

        private SimpleButton btnUp;

        private SimpleButton btnAuto;

        private SimpleButton btnLeft;

        private SimpleButton btnRight;

        private LayoutControlItem layoutControlItem10;

        private LayoutControlItem layoutControlItem4;

        private LayoutControlItem layoutControlItem6;

        private LayoutControlItem layoutControlItem5;

        private LayoutControlItem layoutControlItem2;

        private EmptySpaceItem emptySpaceItem1;

        private EmptySpaceItem emptySpaceItem2;

        private EmptySpaceItem emptySpaceItem3;

        private EmptySpaceItem emptySpaceItem4;

        private EmptySpaceItem emptySpaceItem5;

        private LayoutControlItem layoutControlItem1;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
   	private void InitializeComponent()
		{
			this.layoutControl1 = new LayoutControl();
			this.layoutControlGroup1 = new LayoutControlGroup();
			this.btnRight = new SimpleButton();
			this.layoutControlItem10 = new LayoutControlItem();
			this.btnLeft = new SimpleButton();
			this.layoutControlItem4 = new LayoutControlItem();
			this.btnAuto = new SimpleButton();
			this.layoutControlItem6 = new LayoutControlItem();
			this.btnUp = new SimpleButton();
			this.layoutControlItem5 = new LayoutControlItem();
			this.btnDown = new SimpleButton();
			this.layoutControlItem2 = new LayoutControlItem();
			this.emptySpaceItem1 = new EmptySpaceItem();
			this.emptySpaceItem2 = new EmptySpaceItem();
			this.emptySpaceItem3 = new EmptySpaceItem();
			this.emptySpaceItem4 = new EmptySpaceItem();
			this.emptySpaceItem5 = new EmptySpaceItem();
			this.cmbSpeed = new ComboBoxEdit();
			this.layoutControlItem1 = new LayoutControlItem();
			((ISupportInitialize)this.layoutControl1).BeginInit();
			this.layoutControl1.SuspendLayout();
			((ISupportInitialize)this.layoutControlGroup1).BeginInit();
			((ISupportInitialize)this.layoutControlItem10).BeginInit();
			((ISupportInitialize)this.layoutControlItem4).BeginInit();
			((ISupportInitialize)this.layoutControlItem6).BeginInit();
			((ISupportInitialize)this.layoutControlItem5).BeginInit();
			((ISupportInitialize)this.layoutControlItem2).BeginInit();
			((ISupportInitialize)this.emptySpaceItem1).BeginInit();
			((ISupportInitialize)this.emptySpaceItem2).BeginInit();
			((ISupportInitialize)this.emptySpaceItem3).BeginInit();
			((ISupportInitialize)this.emptySpaceItem4).BeginInit();
			((ISupportInitialize)this.emptySpaceItem5).BeginInit();
			((ISupportInitialize)this.cmbSpeed.Properties).BeginInit();
			((ISupportInitialize)this.layoutControlItem1).BeginInit();
			base.SuspendLayout();
			this.layoutControl1.Controls.Add(this.cmbSpeed);
			this.layoutControl1.Controls.Add(this.btnDown);
			this.layoutControl1.Controls.Add(this.btnUp);
			this.layoutControl1.Controls.Add(this.btnAuto);
			this.layoutControl1.Controls.Add(this.btnLeft);
			this.layoutControl1.Controls.Add(this.btnRight);
			this.layoutControl1.Dock = DockStyle.Fill;
			this.layoutControl1.Location = new Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(929, 201, 650, 636));
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new Size(472, 193);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[]
			{
				this.layoutControlItem10,
				this.layoutControlItem4,
				this.layoutControlItem6,
				this.layoutControlItem5,
				this.layoutControlItem2,
				this.emptySpaceItem1,
				this.emptySpaceItem2,
				this.emptySpaceItem3,
				this.emptySpaceItem4,
				this.emptySpaceItem5,
				this.layoutControlItem1
			});
			this.layoutControlGroup1.Location = new Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
			this.layoutControlGroup1.Size = new Size(472, 193);
			this.layoutControlGroup1.TextVisible = false;
			this.btnRight.Location = new Point(16, 49);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new Size(146, 27);
			this.btnRight.StyleController = this.layoutControl1;
			this.btnRight.TabIndex = 13;
			this.btnRight.Text = "向左";
			this.btnRight.Click += new EventHandler(this.btnRight_Click);
			this.layoutControlItem10.Control = this.btnRight;
			this.layoutControlItem10.Location = new Point(0, 33);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Size = new Size(152, 33);
			this.layoutControlItem10.TextSize = new Size(0, 0);
			this.layoutControlItem10.TextVisible = false;
			this.btnLeft.Location = new Point(311, 49);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new Size(145, 27);
			this.btnLeft.StyleController = this.layoutControl1;
			this.btnLeft.TabIndex = 14;
			this.btnLeft.Text = "向右";
			this.btnLeft.Click += new EventHandler(this.btnLeft_Click);
			this.layoutControlItem4.Control = this.btnLeft;
			this.layoutControlItem4.Location = new Point(295, 33);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new Size(151, 33);
			this.layoutControlItem4.TextSize = new Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			this.btnAuto.Location = new Point(168, 49);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new Size(137, 27);
			this.btnAuto.StyleController = this.layoutControl1;
			this.btnAuto.TabIndex = 15;
			this.btnAuto.Text = "自动";
			this.btnAuto.Click += new EventHandler(this.btnAuto_Click);
			this.layoutControlItem6.Control = this.btnAuto;
			this.layoutControlItem6.Location = new Point(152, 33);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new Size(143, 33);
			this.layoutControlItem6.TextSize = new Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			this.btnUp.Location = new Point(168, 16);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new Size(137, 27);
			this.btnUp.StyleController = this.layoutControl1;
			this.btnUp.TabIndex = 16;
			this.btnUp.Text = "向上";
			this.btnUp.Click += new EventHandler(this.btnUp_Click);
			this.layoutControlItem5.Control = this.btnUp;
			this.layoutControlItem5.Location = new Point(152, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new Size(143, 33);
			this.layoutControlItem5.TextSize = new Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			this.btnDown.Location = new Point(168, 82);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new Size(137, 27);
			this.btnDown.StyleController = this.layoutControl1;
			this.btnDown.TabIndex = 17;
			this.btnDown.Text = "向下";
			this.btnDown.Click += new EventHandler(this.btnDown_Click);
			this.layoutControlItem2.Control = this.btnDown;
			this.layoutControlItem2.Location = new Point(152, 66);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new Size(143, 33);
			this.layoutControlItem2.TextSize = new Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new Point(0, 129);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new Size(446, 38);
			this.emptySpaceItem1.TextSize = new Size(0, 0);
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new Point(295, 66);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new Size(151, 33);
			this.emptySpaceItem2.TextSize = new Size(0, 0);
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new Point(0, 66);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new Size(152, 33);
			this.emptySpaceItem3.TextSize = new Size(0, 0);
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new Point(0, 0);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new Size(152, 33);
			this.emptySpaceItem4.TextSize = new Size(0, 0);
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new Point(295, 0);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new Size(151, 33);
			this.emptySpaceItem5.TextSize = new Size(0, 0);
			this.cmbSpeed.EditValue = "5";
			this.cmbSpeed.Location = new Point(80, 115);
			this.cmbSpeed.Name = "cmbSpeed";
			this.cmbSpeed.Properties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
			this.cmbSpeed.Properties.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9"
			});
			this.cmbSpeed.Size = new Size(376, 24);
			this.cmbSpeed.StyleController = this.layoutControl1;
			this.cmbSpeed.TabIndex = 18;
			this.layoutControlItem1.Control = this.cmbSpeed;
			this.layoutControlItem1.Location = new Point(0, 99);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new Size(446, 30);
			this.layoutControlItem1.Text = "云台速度";
			this.layoutControlItem1.TextSize = new Size(60, 18);
			base.AutoScaleDimensions = new SizeF(8f, 18f);
			base.ClientSize = new Size(472, 193);
			base.Controls.Add(this.layoutControl1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FrmPTZControl";
			this.Text = "云台控制";
			((ISupportInitialize)this.layoutControl1).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((ISupportInitialize)this.layoutControlGroup1).EndInit();
			((ISupportInitialize)this.layoutControlItem10).EndInit();
			((ISupportInitialize)this.layoutControlItem4).EndInit();
			((ISupportInitialize)this.layoutControlItem6).EndInit();
			((ISupportInitialize)this.layoutControlItem5).EndInit();
			((ISupportInitialize)this.layoutControlItem2).EndInit();
			((ISupportInitialize)this.emptySpaceItem1).EndInit();
			((ISupportInitialize)this.emptySpaceItem2).EndInit();
			((ISupportInitialize)this.emptySpaceItem3).EndInit();
			((ISupportInitialize)this.emptySpaceItem4).EndInit();
			((ISupportInitialize)this.emptySpaceItem5).EndInit();
			((ISupportInitialize)this.cmbSpeed.Properties).EndInit();
			((ISupportInitialize)this.layoutControlItem1).EndInit();
			base.ResumeLayout(false);
		}

        #endregion
    }
}