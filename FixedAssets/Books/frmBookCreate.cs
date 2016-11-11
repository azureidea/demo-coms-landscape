using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookCreate : Smobiler.Core.MobileForm
    {

        /// <summary>
        /// toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmBookCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(save.Name))
                {
                    
                    if (txtBOOKNAME.Text.Trim().Length <= 0)
                    {
                       throw new Exception ("������ͼ�����ƣ�");
                    }
                    if (nrcQty.Value <= 0)
                    {
                        throw new Exception("��������������0��");
                    }
                    if (txtPRICE.Text.Trim().Length <= 0)
                    {
                        throw new Exception("������ͼ��۸�");
                    }

                    MessageBox.Show("ͼ�����ɹ���", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        ShowResult = Smobiler.Core.ShowResult.Yes;
                        this.Close();
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void frmBookCreate_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }


        private List<string> imglist = new List<string>();
        private void getImg()
        {
            if (imglist.Count > 0 & imglist.Count <= 9)
            {
                ResourceUploader1.MaxSelectCount = 9 - imglist.Count;
                for (int i = 1; i <= imglist.Count; i++)
                {
                    switch (i)
                    {
                        case 1:
                            img1.Visible = true;
                            btndelimg1.Visible = true;
                            img1.ResourceID = imglist[i - 1];
                            img1.Refresh();
                            break;
                        case 2:
                            img2.Visible = true;
                            btndelimg2.Visible = true;
                            img2.ResourceID = imglist[i - 1];
                            img2.Refresh();
                            break;
                        case 3:
                            img3.Visible = true;
                            btndelimg3.Visible = true;
                            img3.ResourceID = imglist[i - 1];
                            img3.Refresh();
                            break;
                        case 4:
                            img4.Visible = true;
                            btndelimg4.Visible = true;
                            img4.ResourceID = imglist[i - 1];
                            img4.Refresh();
                            break;
                        case 5:
                            img5.Visible = true;
                            btndelimg5.Visible = true;
                            img5.ResourceID = imglist[i - 1];
                            img5.Refresh();
                            break;
                        case 6:
                            img6.Visible = true;
                            btndelimg6.Visible = true;
                            img6.ResourceID = imglist[i - 1];
                            img6.Refresh();
                            break;
                        case 7:
                            img7.Visible = true;
                            btndelimg7.Visible = true;
                            img7.ResourceID = imglist[i - 1];
                            img7.Refresh();
                            break;
                        case 8:
                            img8.Visible = true;
                            btndelimg8.Visible = true;
                            img8.ResourceID = imglist[i - 1];
                            img8.Refresh();
                            break;
                        case 9:
                            img9.Visible = true;
                            btndelimg9.Visible = true;
                            img9.ResourceID = imglist[i - 1];
                            img9.Refresh();
                            break;
                    }
                }
            }
        }
      

        /// <summary>
        /// ɾ��ͼƬ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btndelimg_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btndelimg1":
                    imglist.Remove(img1.ResourceID);
                    img1.Visible = false;
                    img1.ResourceID = "";
                    break;
                case "btndelimg2":
                    imglist.Remove(img2.ResourceID);
                    img2.Visible = false;
                    img2.ResourceID = "";
                    break;
                case "btndelimg3":
                    imglist.Remove(img3.ResourceID);
                    img3.Visible = false;
                    img3.ResourceID = "";
                    break;
                case "btndelimg4":
                    imglist.Remove(img4.ResourceID);
                    img4.Visible = false;
                    img4.ResourceID = "";
                    break;
                case "btndelimg5":
                    imglist.Remove(img5.ResourceID);
                    img5.Visible = false;
                    img5.ResourceID = "";
                    break;
                case "btndelimg6":
                    imglist.Remove(img6.ResourceID);
                    img6.Visible = false;
                    img6.ResourceID = "";
                    break;
                case "btndelimg7":
                    imglist.Remove(img7.ResourceID);
                    img7.Visible = false;
                    img7.ResourceID = "";
                    break;
                case "btndelimg8":
                    imglist.Remove(img8.ResourceID);
                    img8.Visible = false;
                    img8.ResourceID = "";
                    break;
                case "btndelimg9":
                    imglist.Remove(img9.ResourceID);
                    img9.Visible = false;
                    img9.ResourceID = "";
                    break;
            }
            ((Button)sender).Visible = false;
            getImg();
            Toast("ͼƬɾ���ɹ���", ToastLength.SHORT);
        }


        private void ResourceUploader1_Uploading(object sender, BinaryData e)
        {
            try
            {
                if (e.IsError == false)
                {
                    e.SaveFile();
                    imglist.Add(e.ResourceID);
                    getImg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
            ResourceUploader1.Show();
        }
    }
}