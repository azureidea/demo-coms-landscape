using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBEdit : Smobiler.Core.MobileForm
    {

        private int State;
        internal string NB_EQNO;
        private object  btnName;
        private string Address = "";
        private string Owner = "";
        /// <summary>
        /// toolbar�¼�
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNBEdit_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "save":

                        //���
                        if (txtNB_SN.Text.Trim().Length <= 0)
                        {
                            throw new Exception("��������ţ�");
                        }

                        //�ͺ�
                        if (txtNB_MODEL.Text.Trim().Length <= 0)
                        {
                            throw new Exception("�������ͺţ�");
                        }
                        //������
                        if (btnNB_OWNER.Text.Trim().Length <= 0)
                        {
                            throw new Exception("�����������ߣ�");
                        }
                        //������
                        if (txtNB_CHECK.Text.Trim().Length <= 0)
                        {
                            throw new Exception("�����������ˣ�");
                        }
                        //״̬
                        if (btnState.Text.Trim().Length <= 0)
                        {
                            throw new Exception("������״̬��");
                        }
                        //����λ��
                        if (btnNB_LOCATION.Text.Trim().Length <= 0)
                        {
                            throw new Exception("����������λ�ã�");
                        }

                        //������
                        if (txtNB_WARRANTYPERIOD.Text.Trim().Length <= 0)
                        {
                            throw new Exception("�����뱣���ڣ�");
                        }
                        //�����嵥
                        if (txtNB_CONFIG.Text.Trim().Length <= 0)
                        {
                            throw new Exception("�����������嵥��");
                        }
                        //�۸�
                        if (txtNB_PRICE.Text.Trim().Length <= 0)
                        {
                            throw new Exception("������۸�");
                        }
                        //ȷ�ϼ۸�
                        if (txtNB_CONFIRMPRICE.Text.Trim().Length <= 0)
                        {
                            throw new Exception("������ȷ�ϼ۸�");
                        }
                        //�۾�����
                        if (txtNB_YEAR.Text.Trim().Length <= 0)
                        {
                            throw new Exception("�������۾����ޣ�");
                        }

                        MessageBox.Show("�ʼǱ����޸ĳɹ���", (Object s, MessageBoxHandlerArgs args) =>
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
                            Bind();
                        });
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ɾ����Ʊ��Ƭ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btndelPhoto_Click(object sender, EventArgs e)
        {
            if (imgNB_INVOCIEIMGID.ResourceID.Length > 0)
            {
                MessageBox.Show("�Ƿ�ȷ��ɾ����Ʊ��Ƭ��", "��Ʊɾ��", MessageBoxButtons.YesNo, (object s, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.ShowResult.Yes)
                    {
                        if (imgNB_INVOCIEIMGID.ResourceID.Trim().Length > 0)
                        {
                            imgNB_INVOCIEIMGID.ResourceID = "";
                            imgNB_INVOCIEIMGID.Enlarged = false;
                        }
                    }
                });
            }
            else
            {
                MessageBox.Show("��û���ϴ���Ʊ��Ƭ������ɾ����");
            }
        }

        /// <summary>
        /// ��Ʊ�ϴ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnupPhoto_Click(object sender, EventArgs e)
        {
            Camera1.GetPhoto();
        }

        /// <summary>
        /// ��ֵ��Ʊ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.ErrorInfo))
                {
                    if (imgNB_INVOCIEIMGID.ResourceID.Length > 0)
                    {
                        e.SaveFile(imgNB_INVOCIEIMGID.ResourceID);
                        imgNB_INVOCIEIMGID.Refresh();
                    }
                    else
                    {
                        e.SaveFile();
                        imgNB_INVOCIEIMGID.ResourceID = e.ResourceID;
                    }
                    imgNB_INVOCIEIMGID.Enlarged = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            try
            {
                btnName = sender;
                PopList1.Groups.Clear();
                PopListGroup poli = new PopListGroup();
                PopList1.Groups.Add(poli);
                COMSSmobilerDemo.common.NBInfo NBInfo = new COMSSmobilerDemo.common.NBInfo();
                switch (((Button)sender).Name)
                {
                    case "btnNB_OWNER":
                    case "btnNB_OWNER2":
                        DataTable table = NBInfo.OwnerData();
                        poli.Text = "������ѡ��";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["NB_OWNER1"].ToString(), rowli["NB_OWNER"].ToString());
                            if (string.IsNullOrWhiteSpace(Owner) == false)
                            {
                                if (Owner.Equals(rowli["NB_OWNER"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnState":
                    case "btnState2":
                        DataTable table1 = NBInfo.StateData();
                        poli.Text = "״̬ѡ��";
                        foreach (DataRow rowli in table1.Rows)
                        {
                            poli.Items.Add(rowli["StateName"].ToString(), rowli["State"].ToString());
                            if (string.IsNullOrWhiteSpace(State.ToString()) == false)
                            {
                                if (State.Equals(rowli["State"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnNB_LOCATION":
                    case "btnNB_LOCATION2":
                        DataTable table2 = NBInfo.AddressData();
                        poli.Text = "����λ��";
                        foreach (DataRow rowli in table2.Rows)
                        {
                            poli.Items.Add(rowli["Address"].ToString(), rowli["ID"].ToString());
                            if (Address.Trim().Length > 0)
                            {
                                if (Address.Equals(rowli["Address"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                }
                PopList1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ״̬��ֵ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void PopList1_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopList1.Selection != null)
                {
                    switch (((Button)btnName).Name)
                    {
                        case "btnNB_OWNER":
                        case "btnNB_OWNER2":
                            Owner = PopList1.Selection.Value;
                            btnNB_OWNER.Text = PopList1.Selection.Text.Trim();
                            if (btnNB_OWNER.Text.Equals(((NBOWNER)NBOWNER.Smobiler).ToString()))
                            {
                                txtNB_CHECK.Text = "Demo";
                                txtNB_CHECK.ReadOnly = true;
                            }
                            else
                            {
                                txtNB_CHECK.ReadOnly = false;
                                txtNB_CHECK.Text = "";
                            }
                            break;
                        case "btnState":
                        case "btnState2":
                            State = int.Parse(PopList1.Selection.Value);
                            btnState.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnNB_LOCATION":
                        case "btnNB_LOCATION2":
                            Address = PopList1.Selection.Text.Trim();
                            btnNB_LOCATION.Text = PopList1.Selection.Text.Trim();
                            break;
                    }
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

        /// <summary>
        /// ��ʼ���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNBEdit_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Bind()
        {
           
                lblNB_EQNO.Text = "NB001";
                txtNB_SN.Text = "L_x0035";
                //�ͺ�
                txtNB_MODEL.Text ="E530";
                btnNB_OWNER.Text = "";
                Owner = NBOWNER.Smobiler.ToString () ;
                txtNB_CHECK.Text = "";
                txtNB_CHECK.ReadOnly = true;
                State = Convert.ToInt32(NBStates.����);
                btnState.Text = "����";
                //����λ��
                Address = ((NBAddress)NBAddress.�Ϻ�).ToString();
                btnNB_LOCATION.Text = "�Ϻ�";
                //����ʱ��
                dpkNB_BUYDATE.CurrentDate = DateTime .Now;
                //������
                txtNB_WARRANTYPERIOD.Text = "2��";
                 //�����嵥
                txtNB_CONFIG.Text ="Ӳ��";
                 //�۸�
                txtNB_PRICE.Text = "5500";
                //ȷ�ϼ۸�
                txtNB_CONFIRMPRICE.Text = "5200";
                //�۾�����
                txtNB_YEAR.Text = "1��";
           
        }

        private void frmNBEdit_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
    }
}