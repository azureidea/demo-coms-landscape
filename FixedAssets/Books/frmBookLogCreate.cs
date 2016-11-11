using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookLogCreate : Smobiler.Core.MobileForm
    {

        private object  btnName;
        private int state;
        /// <summary>
        /// Toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmBookLogCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(save.Name))
                {
                    
                    if (txtBOOKSNID.Text.Trim().Length <= 0)
                    {
                       throw new Exception ("������ͼ����ţ�");
                    }

                    if (txtBORROWER.Text.Trim().Length <= 0)
                    {
                        throw new Exception("������ͼ����ţ�");
                    }

                    MessageBox.Show("ͼ����ļ�¼¼��ɹ���", (Object s, MessageBoxHandlerArgs args) =>
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
        private bool handleExit = false;
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            if (handleExit == true && taosttime.AddSeconds(3) >= DateTime.Now)
            {
                handleExit = false;
                this.Close();
            }
            else
            {
                handleExit = true;
                taosttime = DateTime.Now;
                this.Toast("�ٰ�һ���˳�����", ToastLength.SHORT);
            }
        }

        private void frmBookLogCreate_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }

        /// <summary>
        /// ɨ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnBOOKSN_BarcodeScanned(object sender, BarcodeData e)
        {
            if (string.IsNullOrEmpty(e.ErrorInfo))
            {
                if (e.Barcode.Length > 0)
                {
                    txtBOOKSNID.Text = e.Barcode;
                }
            }
        }
        /// <summary>
        /// ����ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnpop_Click(object sender, EventArgs e)
        {
            try
            {
                btnName = sender;
                PopList1.Groups.Clear();
                PopListGroup poli = new PopListGroup();
                PopList1.Groups.Add(poli);
                COMSSmobilerDemo.common.BookLogInfo BookLogInfo = new COMSSmobilerDemo.common.BookLogInfo();
                COMSSmobilerDemo.common.BookSNInfo BookSNInfo = new COMSSmobilerDemo.common.BookSNInfo();
                DataTable table = new DataTable();
                switch (((Button)btnName).Name)
                {
                    case "btnBOOKSN2":
                        table = BookSNInfo.GetBookSNbyBookID();
                        poli.Text = "ͼ�����ѡ��";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["BOOKSNID"].ToString (), rowli["BOOKSNID"].ToString ());
                            if (txtBOOKSNID.Text.Trim().Length > 0)
                            {
                                if (txtBOOKSNID.Text.Trim().Equals(rowli["BOOKSNID"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnState":
                    case "btnState2":
                        table = BookLogInfo.StateData();
                        poli.Text = "״̬ѡ��";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["StateName"].ToString (), rowli["State"].ToString());
                            if (state.ToString().Length >0)
                            {
                                if (state.Equals(rowli["State"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnBORROWER2":
                        table = BookLogInfo.GetUserData();
                        poli.Text = "�û�ѡ��";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["USER_NAME"].ToString(), rowli["USER_ID"].ToString());
                            if (string.IsNullOrWhiteSpace(txtBORROWER.Text) == false)
                            {
                                if (txtBORROWER.Text.Trim().ToUpper() == rowli["USER_ID"].ToString().Trim().ToUpper())
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                }
                switch (((Button)btnName).Name)
                {
                    case "btnState":
                    case "btnState2":
                        PopList1.ShowDialog();
                        break;
                    default:
                        PopList1.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopList1_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopList1.Selection != null)
                {
                    switch (((Button )btnName).Name)
                    {
                        case "btnBOOKSN2":
                            txtBOOKSNID.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnState":
                        case "btnState2":
                            state = Convert.ToInt32 (PopList1.Selection.Value);
                            btnState.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnBORROWER2":
                            txtBORROWER.Text = PopList1.Selection.Text.Trim();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBookLogCreate_Load(object sender, EventArgs e)
        {

            state = Convert.ToInt32 (BooksNSState.���);
            btnState.Text = ((BooksNSState)state).ToString();
        }
    }
}