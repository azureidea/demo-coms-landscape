using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDocumentCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDocumentCreate()
            : base()
        {

            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]

        private void InitializeComponent()
        {
            this.btnCC = new Smobiler.Core.Controls.Button();
            this.btnChoice = new Smobiler.Core.Controls.Button();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.btntype = new Smobiler.Core.Controls.Button();
            this.btntype2 = new Smobiler.Core.Controls.Button();
            this.lblworkday = new Smobiler.Core.Controls.Label();
            this.txtworkday = new Smobiler.Core.Controls.TextBox();
            this.txtworkday1 = new Smobiler.Core.Controls.TextBox();
            this.lblCDNO = new Smobiler.Core.Controls.Label();
            this.txtCDNO = new Smobiler.Core.Controls.TextBox();
            this.TxtNote = new Smobiler.Core.Controls.TextBox();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            // 
            // btnCC
            // 
            this.btnCC.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnCC.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnCC.Location = new System.Drawing.Point(88, 43);
            this.btnCC.Name = "btnCC";
            this.btnCC.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnCC.Size = new System.Drawing.Size(387, 35);
            this.btnCC.TabIndex = 3;
            this.btnCC.Text = "ѡ�񣨱��";
            this.btnCC.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChoice_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnChoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnChoice.FontSize = 20F;
            this.btnChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnChoice.Location = new System.Drawing.Point(475, 43);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(25, 35);
            this.btnChoice.TabIndex = 4;
            this.btnChoice.Text = ">";
            this.btnChoice.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChoice_Click);
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88, 35);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "��������";
            // 
            // btntype
            // 
            this.btntype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntype.HoverBackColor = System.Drawing.Color.White;
            this.btntype.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype.Location = new System.Drawing.Point(88, 0);
            this.btntype.Name = "btntype";
            this.btntype.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btntype.Size = new System.Drawing.Size(387, 35);
            this.btntype.TabIndex = 6;
            this.btntype.Text = "ѡ�񣨱��";
            this.btntype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btntype2
            // 
            this.btntype2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype2.FontSize = 20F;
            this.btntype2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype2.Location = new System.Drawing.Point(475, 0);
            this.btntype2.Name = "btntype2";
            this.btntype2.Size = new System.Drawing.Size(25, 35);
            this.btntype2.TabIndex = 7;
            this.btntype2.Text = ">";
            this.btntype2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // lblworkday
            // 
            this.lblworkday.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblworkday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblworkday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblworkday.Location = new System.Drawing.Point(0, 85);
            this.lblworkday.Name = "lblworkday";
            this.lblworkday.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblworkday.Size = new System.Drawing.Size(88, 35);
            this.lblworkday.TabIndex = 8;
            this.lblworkday.Text = "����ҵ������";
            // 
            // txtworkday
            // 
            this.txtworkday.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtworkday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtworkday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtworkday.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtworkday.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtworkday.Location = new System.Drawing.Point(88, 85);
            this.txtworkday.Name = "txtworkday";
            this.txtworkday.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.txtworkday.Size = new System.Drawing.Size(367, 35);
            this.txtworkday.TabIndex = 9;
            this.txtworkday.WaterMarkText = "0.00";
            // 
            // txtworkday1
            // 
            this.txtworkday1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtworkday1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtworkday1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtworkday1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtworkday1.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtworkday1.Location = new System.Drawing.Point(88, 85);
            this.txtworkday1.Name = "txtworkday1";
            this.txtworkday1.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.txtworkday1.Size = new System.Drawing.Size(367, 35);
            this.txtworkday1.TabIndex = 10;
            this.txtworkday1.Visible = false;
            this.txtworkday1.WaterMarkText = "0.00";
            // 
            // lblCDNO
            // 
            this.lblCDNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCDNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCDNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCDNO.Location = new System.Drawing.Point(0, 120);
            this.lblCDNO.Name = "lblCDNO";
            this.lblCDNO.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCDNO.Size = new System.Drawing.Size(88, 35);
            this.lblCDNO.TabIndex = 11;
            this.lblCDNO.Text = "Эͬ�����";
            // 
            // txtCDNO
            // 
            this.txtCDNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCDNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtCDNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtCDNO.Location = new System.Drawing.Point(88, 120);
            this.txtCDNO.Name = "txtCDNO";
            this.txtCDNO.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtCDNO.Size = new System.Drawing.Size(412, 35);
            this.txtCDNO.TabIndex = 12;
            this.txtCDNO.Visible = false;
            this.txtCDNO.WaterMarkText = "��ѡ�";
            // 
            // TxtNote
            // 
            this.TxtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.TxtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TxtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.TxtNote.Location = new System.Drawing.Point(88, 163);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.TxtNote.Size = new System.Drawing.Size(412, 100);
            this.TxtNote.TabIndex = 13;
            this.TxtNote.WaterMarkText = "��ѡ�";
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.SelectIconID = "!\\ue161043146223";
            this.save.Text = "����";
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblNote.Location = new System.Drawing.Point(0, 163);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.Size(88, 100);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "��������";
            this.lblNote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 43);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "�ɱ�����";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label3.Location = new System.Drawing.Point(455, 85);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.Label3.Size = new System.Drawing.Size(45, 35);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "��";
            // 
            // frmWorkDocumentCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCC,
            this.btnChoice,
            this.Label1,
            this.btntype,
            this.btntype2,
            this.lblworkday,
            this.txtworkday,
            this.txtworkday1,
            this.lblCDNO,
            this.txtCDNO,
            this.TxtNote,
            this.lblNote,
            this.Label2,
            this.Label3});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 300);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "��������";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmWorkDocumentCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmWorkDocumentCreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmWorkDocumentCreate";

        }
        internal Smobiler.Core.Controls.Button btnCC;
        internal Smobiler.Core.Controls.Button btnChoice;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button btntype;
        internal Smobiler.Core.Controls.Button btntype2;
        internal Smobiler.Core.Controls.Label lblworkday;
        internal Smobiler.Core.Controls.TextBox txtworkday;
        internal Smobiler.Core.Controls.TextBox txtworkday1;
        internal Smobiler.Core.Controls.Label lblCDNO;
        internal Smobiler.Core.Controls.TextBox txtCDNO;
        internal Smobiler.Core.Controls.TextBox TxtNote;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        #endregion

    }
}
