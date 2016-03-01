using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfficeSupport
{
    public partial class frmManipulateContract : Form
    {

        public static string TYPE_CUST_COMPANY = "c";
        public static string TYPE_CUST_PERSONAL = "p";
        public static string TYPE_CUST_SITE = "s";

        public int MODE_CURRENT = DbManager.MODE_VIEW;

        frmFindCustomer frmFindCustomer;

        public String ContractID;
        public String CustomerCode;

        public frmManipulateContract()
        {
            InitializeComponent();
        }

        private int getNewContractId()
        {

            
            List<String> sql = new List<String>();
            sql.Add("MAX(contract_id) + 1");
            DataSet ds = DbManager.ExcuteQuery(DbManager.getSelectSQL("cust_contract", sql.ToArray()), "cust_contract");
            return int.Parse(ds.Tables["cust_contract"].Rows[0][0].ToString());
        }

       
      

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            frmFindCustomer = new frmFindCustomer();
            frmFindCustomer.ShowDialog(this);
            txtName.Text = frmFindCustomer.m_Name;
            txtCompany.Text = frmFindCustomer.m_Company;
            txtCustCode.Text = frmFindCustomer.m_CustCode;
            frmFindCustomer = null;
        }

        private void frmManipulateContract_Load(object sender, EventArgs e)
        {
            if (MODE_CURRENT == DbManager.MODE_EDIT || MODE_CURRENT == DbManager.MODE_VIEW)
            {
                LockForm(true);
                loadContract(ContractID);
                btnEnableEdit.Enabled = true;
                btnSave.Enabled = false;
            }
            else if (MODE_CURRENT == DbManager.MODE_ADD)
            {
                btnEnableEdit.Enabled = false;

            }

            btnPrint.Enabled = false;
        }

        private void loadContract(string contract_id)
        {
            List<String> sql_customer = new List<String>();
            sql_customer.Add("cust_code"); // 0
            sql_customer.Add("cust_name"); // 0
            sql_customer.Add("cust_surname"); // 0
            sql_customer.Add("company_name"); // 0

            List<String> sql = new List<String>();
            sql.Add("contract_id"); // 0
            sql.Add("contract_no");// 1
            
            sql.Add("cust_code");// 2
            sql.Add("created_date");// 3
            sql.Add("effect_date");// 4
            sql.Add("end_date");// 5
            sql.Add("condition_contract");// 6
            sql.Add("comment");// 7
            sql.Add("work_location");// 8            

            DataSet ds = DbManager.ExcuteQuery(DbManager.getSelectSQL("cust_contract", sql.ToArray(), "contract_id='" + contract_id + "'"), "contract");



            if (ds.Tables["contract"].Rows.Count > 0)
            {
                DataSet ds2 = DbManager.ExcuteQuery(DbManager.getSelectSQL("customer", sql_customer.ToArray(), "rtrim(cust_code)=rtrim('" + ds.Tables["contract"].Rows[0][2].ToString() + "')"), "customer");

                txtCustCode.Text = ds.Tables["contract"].Rows[0][3].ToString();

                txtContractId.Text = ds.Tables["contract"].Rows[0][0].ToString();
                txtContractNo.Text = ds.Tables["contract"].Rows[0][1].ToString();
                txtCompany.Text = ds2.Tables["customer"].Rows[0][3].ToString();
                txtName.Text = ds2.Tables["customer"].Rows[0][1].ToString() + " " + ds2.Tables["customer"].Rows[0][2].ToString();

                dtpCurrent.Text = ds.Tables["contract"].Rows[0][3].ToString();
                dtpStartEffect.Text = ds.Tables["contract"].Rows[0][4].ToString();
                dtpEndEffect.Text = ds.Tables["contract"].Rows[0][5].ToString();

                txtWorkLocation.Text = ds.Tables["contract"].Rows[0][8].ToString();
                txtTypeService.Text = ds.Tables["contract"].Rows[0][6].ToString();
                txtComment.Text = ds.Tables["contract"].Rows[0][7].ToString();

            }
            ds = null;

        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
            this.MODE_CURRENT = DbManager.MODE_EDIT;
            LockForm(false);
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            btnEnableEdit.Enabled = false;
        }

        private void LockForm(Boolean l)
        {
            l = !l;
            btnSave.Enabled = !l;
            btnRefresh.Enabled = !l;


            txtContractNo.Enabled = l;
            txtCustCode.Enabled = l;
            txtContractId.Enabled = l;
            txtCompany.Enabled = l;
            dtpCurrent.Enabled = l;
            dtpStartEffect.Enabled = l;
            dtpEndEffect.Enabled = l;
            txtName.Enabled = l;
            txtWorkLocation.Enabled = l;
            txtTypeService.Enabled = l;
            txtComment.Enabled = l;
           
        }

        /// <summary>
        /// เพิ่มข้อมูลใหม่
        /// </summary>
        /// <returns></returns>
        private Boolean insertContract()
        {

            List<String> sql = new List<String>();
            sql.Add("contract_id"); // 0
            sql.Add("contract_no");// 1

            sql.Add("cust_code");// 2
            sql.Add("created_date");// 3
            sql.Add("effect_date");// 3
            sql.Add("end_date");// 4
            sql.Add("condition_contract");// 5
           
            sql.Add("comment");// 7
            sql.Add("work_location");// 7


            SqlCommand cmd = new SqlCommand(DbManager.getInsertSQL("cust_contract", sql.ToArray()));
            int newId = getNewContractId();
            cmd.Parameters.Add("cust_code", SqlDbType.Char, 15).Value = txtCustCode.Text;
            cmd.Parameters.Add("contract_no", SqlDbType.Char, 15).Value = txtContractNo.Text;
            cmd.Parameters.Add("contract_id", SqlDbType.Int).Value = newId;

            cmd.Parameters.Add("created_date", SqlDbType.DateTime).Value = dtpCurrent.Value;
            cmd.Parameters.Add("effect_date", SqlDbType.DateTime).Value = dtpStartEffect.Value;
            cmd.Parameters.Add("end_date", SqlDbType.DateTime).Value = dtpEndEffect.Value;
            cmd.Parameters.Add("condition_contract", SqlDbType.VarChar, 100).Value = txtTypeService.Text;

            cmd.Parameters.Add("comment", SqlDbType.VarChar, 300).Value = txtComment.Text;

            cmd.Parameters.Add("work_location", SqlDbType.VarChar, 100).Value = txtWorkLocation.Text;
           
            if (DbManager.ExcuteNonQuery(cmd) == 1)
            {
                txtContractId.Text = newId.ToString();
                ContractID = newId.ToString();
                return Global.PROCESS_SUCCESS;
            }
            else
            {
                return Global.PROCESS_FAIL;
            }
        }
        private Boolean updateContract(string contract_id)
        {

            List<String> sql = new List<String>();

            sql.Add("contract_no");// 1

            sql.Add("cust_code");// 2
            sql.Add("created_date");// 3
            sql.Add("effect_date");// 3
            sql.Add("end_date");// 4
            sql.Add("condition_contract");// 5
          
            sql.Add("comment");// 7
            sql.Add("work_location");// 7

            SqlCommand cmd = new SqlCommand(DbManager.getUpdateSQL("cust_contract", sql.ToArray(), "contract_id='" + contract_id + "'"));

            cmd.Parameters.Add("cust_code", SqlDbType.Char, 15).Value = CustomerCode;
            cmd.Parameters.Add("contract_no", SqlDbType.Char, 15).Value = txtContractNo.Text;
        
            cmd.Parameters.Add("created_date", SqlDbType.DateTime).Value = dtpCurrent.Value;
            cmd.Parameters.Add("effect_date", SqlDbType.DateTime).Value = dtpStartEffect.Value;
            cmd.Parameters.Add("end_date", SqlDbType.DateTime).Value = dtpEndEffect.Value;
            cmd.Parameters.Add("condition_contract", SqlDbType.VarChar, 100).Value = txtTypeService.Text;

            cmd.Parameters.Add("comment", SqlDbType.VarChar, 300).Value = txtComment.Text;
            cmd.Parameters.Add("work_location", SqlDbType.VarChar, 100).Value = txtWorkLocation.Text;
         
            if (DbManager.ExcuteNonQuery(cmd) == 1)
            {
                return Global.PROCESS_SUCCESS;
            }
            else
            {
                return Global.PROCESS_FAIL;
            }
        }

        /// <summary>
        /// ตรวจสอบความถูกต้องของข้อมูล
        /// </summary>
        /// <returns></returns>
        private Boolean validForm()
        {

            Boolean b = true;
           

            return b;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean _bResult = Global.PROCESS_FAIL;

            if (validForm())
            {
                if (MODE_CURRENT == DbManager.MODE_ADD)
                {
                    _bResult = insertContract();
                }
                else if (MODE_CURRENT == DbManager.MODE_EDIT)
                {
                    _bResult = updateContract(txtContractId.Text);
                }


                if (_bResult == Global.PROCESS_SUCCESS)
                {
                    MessageBox.Show(Global.STR_UPDATE_SUCCESS);
                }
                else
                {
                    MessageBox.Show(Global.STR_UPDATE_FAIL);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (txtContractId.Text != "")
            {
                loadContract(ContractID);
                LockForm(true);
                btnEnableEdit.Enabled = true;
                btnSave.Enabled = false;
                btnRefresh.Enabled = true;
            }
            else
            {
                clearForm();
                btnEnableEdit.Enabled = false;
                btnSave.Enabled = false;
                btnRefresh.Enabled = true;
            }
            
        }

        private Boolean deleteContract(string contract_id)
        {

            List<String> sql = new List<String>();


            SqlCommand cmd = new SqlCommand(DbManager.getDeleteSQL("cust_contract", "contract_id='" + contract_id + "'"));


            if (DbManager.ExcuteNonQuery(cmd) == 1)
            {
                return Global.PROCESS_SUCCESS;
            }
            else
            {
                return Global.PROCESS_FAIL;
            }
        }

        /// <summary>
        /// ล้างฟอร์ม
        /// </summary>
        private void clearForm()
        {
            txtCustCode.Text = "";
            
            txtCompany.Text = "";
            txtName.Text = "";
            txtContractNo.Text = "";
            dtpCurrent.ResetText();
            dtpStartEffect.ResetText();
            dtpEndEffect.ResetText();
            
            txtWorkLocation.Text = "";
            txtTypeService.Text = "";
            txtComment.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการลบใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (deleteContract(txtContractId.Text))
                {
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ข้อความ");
                    clearForm();
                    MODE_CURRENT = DbManager.MODE_ADD;
                }
                else
                {
                    MessageBox.Show("ไม่สามารถลบข้อมูล", "ข้อความ");
                }
            }
        }
    }
}
