
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
public partial class frmRBRightLayout : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmRBRightLayout()
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
            this.STATE = new Smobiler.Core.Controls.Button();
            this.AMOUNT = new Smobiler.Core.Controls.Button();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.ImageButton1 = new Smobiler.Core.Controls.ImageButton();
            // 
            // STATE
            // 
            this.STATE.BorderColor = System.Drawing.Color.Silver;
            this.STATE.DataMember = "RB_STATE";
            this.STATE.DisplayMember = "STATENAMECOUNT";
            this.STATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.STATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.STATE.HoverBackColor = System.Drawing.Color.LightCyan;
            this.STATE.HoverForeColor = System.Drawing.Color.White;
            this.STATE.Location = new System.Drawing.Point(30, 0);
            this.STATE.Name = "STATE";
            this.STATE.Padding = new Smobiler.Core.Padding(3F, 0F, 2F, 0F);
            this.STATE.Size = new System.Drawing.Size(370, 35);
            this.STATE.TabIndex = 5;
            this.STATE.ZIndex = 2;
            // 
            // AMOUNT
            // 
            this.AMOUNT.BorderColor = System.Drawing.Color.Silver;
            this.AMOUNT.DataMember = "AMOUNT";
            this.AMOUNT.DisplayMember = "AMOUNTFIELD";
            this.AMOUNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AMOUNT.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.AMOUNT.HoverBackColor = System.Drawing.Color.LightCyan;
            this.AMOUNT.HoverForeColor = System.Drawing.Color.White;
            this.AMOUNT.Location = new System.Drawing.Point(400, 3);
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Size = new System.Drawing.Size(100, 35);
            this.AMOUNT.TabIndex = 7;
            this.AMOUNT.Text = "��12.5";
            this.AMOUNT.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 35);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(500, 3);
            this.Line1.TabIndex = 8;
            this.Line1.ZIndex = 4;
            // 
            // ImageButton1
            // 
            this.ImageButton1.DataMember = "STATENAME";
            this.ImageButton1.DisplayMember = "STATENAME";
            this.ImageButton1.FontSize = 10F;
            this.ImageButton1.Name = "ImageButton1";
            this.ImageButton1.Size = new System.Drawing.Size(30, 35);
            this.ImageButton1.TabIndex = 9;
            this.ImageButton1.ZIndex = 1;
            // 
            // frmRBRightLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ImageButton1,
            this.STATE,
            this.AMOUNT,
            this.Line1});
            this.Size = new System.Drawing.Size(500, 35);
            this.Name = "frmRBRightLayout";

    }
    internal Smobiler.Core.Controls.Button STATE;
    internal Smobiler.Core.Controls.Button AMOUNT;
    internal Smobiler.Core.Controls.Line Line1;
    internal Smobiler.Core.Controls.ImageButton ImageButton1;
    #endregion

}
