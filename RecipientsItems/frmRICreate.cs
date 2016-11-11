using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.RecipientsItems
{
    partial class frmRICreate : Smobiler.Core.MobileForm
    {

        private void imgbtnSignature_Click(object sender, EventArgs e)
        {
            Signature1.GetSignature();
        }

        private void Signature1_SignatureCompleted(object sender, BinaryData e)
        {
            if (string.IsNullOrEmpty(e.ErrorInfo))
            {
                string itemSname = "ItemS" + e.ResourceID;
                e.SaveFile(itemSname);
                imgbtnSignature.ResourceID = itemSname;
            }

        }

        private DateTime taosttime;
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }
        private void HandleToast()
        {
            if ( taosttime.AddSeconds(3) >= DateTime.Now)
            {
                this.Close();
            }
            else
            {
                taosttime = DateTime.Now;
                this.Toast("�ٰ�һ���˳�����", ToastLength.SHORT);
            }
        }

        private void frmRICreate_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }

        private void frmRICreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "save"  :
                        if (btnCU2.Text.Trim().Length <= 0)
                        {
                            throw new Exception("��������Ʒ���ƣ�");
                        }
                        if (txtITEM_QTY.Text.Trim().Length <= 0)
                        {
                            throw new Exception("����������!");
                        }
                        if (txtITEM_USER.Text.Trim().Length <= 0)
                        {
                            throw new Exception("������������!");
                        }
                
                        if (imgbtnSignature.ResourceID.Trim().Length <= 0)
                        {
                            throw new Exception("��ǩ��!");
                        }


                        MessageBox.Show("��Ʒ���ü�¼�Ѵ����ɹ���", (Object s, MessageBoxHandlerArgs args) =>
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
                            this.Close();
                        });

                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnpop_Click(object sender, EventArgs e)
        {
            pickerView1.Visible = true;
        }

        private void pickerView1_Picked(object sender, PickerViewPickedEventArgs e)
        {
            btnCU2.Text = e.Item.Text;
            pickerView1.Visible = false;
        }
    }
}