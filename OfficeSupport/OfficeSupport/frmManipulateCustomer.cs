using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OfficeSupport
{
    public partial class frmManipulateCustomer : Form
    {
        public static string TYPE_CUST_COMPANY = "c";
        public static string TYPE_CUST_PERSONAL = "p";
        public static string TYPE_CUST_SITE = "s";

        public int MODE_CURRENT = DbManager.MODE_VIEW;



        public String CustomerCode;
      
        public frmManipulateCustomer()
        {
            InitializeComponent();
        }

        private String getNewCustomerCode(){
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void frmManipulateCustomer_Load(object sender, EventArgs e)
        {

          

            if (MODE_CURRENT == DbManager.MODE_EDIT || MODE_CURRENT== DbManager.MODE_VIEW) {
                LockForm(true);
                loadCustomer(CustomerCode);
                btnEnableEdit.Enabled = true;
                btnSave.Enabled = false;
            }
            else if (MODE_CURRENT == DbManager.MODE_ADD) {
                btnEnableEdit.Enabled = false;
                
            }

            btnPrint.Enabled = false;


        }



        /// <summary>
        /// เพิ่มข้อมูลใหม่
        /// </summary>
        /// <returns></returns>
        private Boolean insertCustomer()
        {
            
            List<String> sql = new List<String>();
            sql.Add("cust_code");
            sql.Add("cust_type");
            sql.Add("cust_ref_code");
            sql.Add("company_name");
            sql.Add("cust_name");
            sql.Add("cust_surname");
            sql.Add("addr");
            sql.Add("village");
            sql.Add("city");
            sql.Add("province");
            sql.Add("zipcode");
            sql.Add("tel");
            sql.Add("fax");
            sql.Add("email");

            sql.Add("contact_name");
            sql.Add("contact_tel");
            sql.Add("contact_mobile");
            sql.Add("contact_position");
            
            sql.Add("technic_name");
            sql.Add("technic_tel");
            sql.Add("technic_mobile");
            sql.Add("technic_position");

            sql.Add("pm_pe_name");
            sql.Add("pm_pe_tel");
            sql.Add("pm_pe_mobile");
            sql.Add("pm_pe_position");

            String custType = "";
            if (rdoSite.Checked == true)
            {
                custType = "s";
            }else if(rdoTypeCompany.Checked == true){
                custType = "c";
            }
            else if(rdoTypePersonal.Checked==true){
                custType = "p";
            }


            SqlCommand cmd = new SqlCommand(DbManager.getInsertSQL("customer", sql.ToArray()));
            String newCode = getNewCustomerCode();
            cmd.Parameters.Add("cust_code", SqlDbType.Char, 15).Value = newCode;
            cmd.Parameters.Add("cust_type", SqlDbType.Char, 1).Value = custType;

            cmd.Parameters.Add("cust_ref_code", SqlDbType.VarChar,15).Value="";
            cmd.Parameters.Add("company_name", SqlDbType.VarChar,100).Value = txtCompany.Text;

            cmd.Parameters.Add("cust_name", SqlDbType.VarChar, 30).Value = txtName.Text;
            cmd.Parameters.Add("cust_surname", SqlDbType.VarChar, 30).Value = txtSurname.Text;
            cmd.Parameters.Add("addr", SqlDbType.VarChar, 100).Value = txtAddr.Text;
            cmd.Parameters.Add("village", SqlDbType.VarChar, 30).Value = txtVillage.Text;
            cmd.Parameters.Add("city", SqlDbType.VarChar, 30).Value = txtCity.Text;
            cmd.Parameters.Add("province", SqlDbType.VarChar, 30).Value = txtProvince.Text;
            cmd.Parameters.Add("zipcode", SqlDbType.VarChar, 5).Value = txtZipcode.Text;
            cmd.Parameters.Add("contact_name", SqlDbType.VarChar, 60).Value = txtContactName.Text;
            cmd.Parameters.Add("contact_tel", SqlDbType.VarChar, 15).Value = txtContactTel.Text;
            cmd.Parameters.Add("contact_mobile", SqlDbType.VarChar, 15).Value = txtContactMobile.Text;
            cmd.Parameters.Add("contact_position", SqlDbType.VarChar, 30).Value = txtContactPosition.Text;
            cmd.Parameters.Add("tel", SqlDbType.VarChar, 15).Value = txtTel.Text;
            cmd.Parameters.Add("fax", SqlDbType.VarChar, 15).Value = txtFax.Text;
            cmd.Parameters.Add("email", SqlDbType.VarChar, 30).Value = txtEmail.Text;
            cmd.Parameters.Add("technic_name", SqlDbType.VarChar, 60).Value = txtTechnicName.Text;
            cmd.Parameters.Add("technic_tel", SqlDbType.VarChar, 15).Value = txtTechnicTel.Text;
            cmd.Parameters.Add("technic_mobile", SqlDbType.VarChar, 15).Value = txtTechnicMobile.Text;
            cmd.Parameters.Add("technic_position", SqlDbType.VarChar, 30).Value = txtTechnicPosition.Text;
            cmd.Parameters.Add("pm_pe_name", SqlDbType.VarChar, 60).Value = txtPmName.Text;
            cmd.Parameters.Add("pm_pe_tel", SqlDbType.VarChar, 15).Value = txtPmTel.Text;
            cmd.Parameters.Add("pm_pe_mobile", SqlDbType.VarChar, 15).Value = txtPmMobile.Text;
            cmd.Parameters.Add("pm_pe_position", SqlDbType.VarChar, 30).Value = txtPmPosition.Text;
         

            if (DbManager.ExcuteNonQuery(cmd) == 1)
            {
                txtCustCode.Text = newCode;
                CustomerCode = newCode;
                return Global.PROCESS_SUCCESS;
            }
            else {
                return Global.PROCESS_FAIL;
            }
        }

        private Boolean deleteCustomer(string custCode)
        {

            List<String> sql = new List<String>();

           
            SqlCommand cmd = new SqlCommand(DbManager.getDeleteSQL("customer", "cust_code='" + custCode + "'"));

           
            if (DbManager.ExcuteNonQuery(cmd) == 1)
            {
                return Global.PROCESS_SUCCESS;
            }
            else
            {
                return Global.PROCESS_FAIL;
            }
        }

        private Boolean updateCustomer(string custCode)
        {

            List<String> sql = new List<String>();

            sql.Add("cust_type");
            sql.Add("cust_ref_code");
            sql.Add("company_name");
            sql.Add("cust_name");
            sql.Add("cust_surname");
            sql.Add("addr");
            sql.Add("village");
            sql.Add("city");
            sql.Add("province");
            sql.Add("zipcode");
            sql.Add("tel");
            sql.Add("fax");
            sql.Add("email");

            sql.Add("contact_name");
            sql.Add("contact_tel");
            sql.Add("contact_mobile");
            sql.Add("contact_position");

            sql.Add("technic_name");
            sql.Add("technic_tel");
            sql.Add("technic_mobile");
            sql.Add("technic_position");

            sql.Add("pm_pe_name");
            sql.Add("pm_pe_tel");
            sql.Add("pm_pe_mobile");
            sql.Add("pm_pe_position");

            String custType = "";
            if (rdoSite.Checked == true)
            {
                custType = "s";
            }
            else if (rdoTypeCompany.Checked == true)
            {
                custType = "c";
            }
            else if (rdoTypePersonal.Checked == true)
            {
                custType = "p";
            }


            SqlCommand cmd = new SqlCommand(DbManager.getUpdateSQL("customer", sql.ToArray(), "cust_code='" + custCode + "'"));

            cmd.Parameters.Add("cust_type", SqlDbType.Char, 1).Value = custType;

            cmd.Parameters.Add("cust_ref_code", SqlDbType.VarChar, 15).Value = "";
            cmd.Parameters.Add("company_name", SqlDbType.VarChar, 100).Value = txtCompany.Text;

            cmd.Parameters.Add("cust_name", SqlDbType.VarChar, 30).Value = txtName.Text;
            cmd.Parameters.Add("cust_surname", SqlDbType.VarChar, 30).Value = txtSurname.Text;
            cmd.Parameters.Add("addr", SqlDbType.VarChar, 100).Value = txtAddr.Text;
            cmd.Parameters.Add("village", SqlDbType.VarChar, 30).Value = txtVillage.Text;
            cmd.Parameters.Add("city", SqlDbType.VarChar, 30).Value = txtCity.Text;
            cmd.Parameters.Add("province", SqlDbType.VarChar, 30).Value = txtProvince.Text;
            cmd.Parameters.Add("zipcode", SqlDbType.VarChar, 5).Value = txtZipcode.Text;
            cmd.Parameters.Add("contact_name", SqlDbType.VarChar, 60).Value = txtContactName.Text;
            cmd.Parameters.Add("contact_tel", SqlDbType.VarChar, 15).Value = txtContactTel.Text;
            cmd.Parameters.Add("contact_mobile", SqlDbType.VarChar, 15).Value = txtContactMobile.Text;
            cmd.Parameters.Add("contact_position", SqlDbType.VarChar, 30).Value = txtContactPosition.Text;
            cmd.Parameters.Add("tel", SqlDbType.VarChar, 15).Value = txtTel.Text;
            cmd.Parameters.Add("fax", SqlDbType.VarChar, 15).Value = txtFax.Text;
            cmd.Parameters.Add("email", SqlDbType.VarChar, 30).Value = txtEmail.Text;
            cmd.Parameters.Add("technic_name", SqlDbType.VarChar, 60).Value = txtTechnicName.Text;
            cmd.Parameters.Add("technic_tel", SqlDbType.VarChar, 15).Value = txtTechnicTel.Text;
            cmd.Parameters.Add("technic_mobile", SqlDbType.VarChar, 15).Value = txtTechnicMobile.Text;
            cmd.Parameters.Add("technic_position", SqlDbType.VarChar, 30).Value = txtTechnicPosition.Text;
            cmd.Parameters.Add("pm_pe_name", SqlDbType.VarChar, 60).Value = txtPmName.Text;
            cmd.Parameters.Add("pm_pe_tel", SqlDbType.VarChar, 15).Value = txtPmTel.Text;
            cmd.Parameters.Add("pm_pe_mobile", SqlDbType.VarChar, 15).Value = txtPmMobile.Text;
            cmd.Parameters.Add("pm_pe_position", SqlDbType.VarChar, 30).Value = txtPmPosition.Text;
         
            if (DbManager.ExcuteNonQuery(cmd) == 1)
            {
                return Global.PROCESS_SUCCESS;
            }
            else
            {
                return Global.PROCESS_FAIL;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean _bResult = Global.PROCESS_FAIL;

            if (validForm()) {
                if (MODE_CURRENT == DbManager.MODE_ADD)
                {
                    _bResult = insertCustomer();
                }
                else if (MODE_CURRENT == DbManager.MODE_EDIT)
                {
                    _bResult = updateCustomer(txtCustCode.Text);
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


        /// <summary>
        /// ล้างฟอร์ม
        /// </summary>
        private  void clearForm() {
            txtCustCode.Text = "";
            rdoTypeCompany.Checked=false;
            rdoTypePersonal.Checked =false;
            txtCompany.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtVillage.Text = "";
            txtAddr.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtZipcode.Text = "";
            txtTel.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";

            txtContactName.Text = "";
            txtContactTel.Text="";
            txtContactMobile.Text="";
            txtContactPosition.Text="";

            txtTechnicName.Text = "";
            txtTechnicTel.Text="";
            txtTechnicMobile.Text="";
            txtTechnicPosition.Text="";

            txtPmName.Text = "";
            txtPmTel.Text="";
            txtPmMobile.Text="";
            txtPmPosition.Text="";
        }

        private void LockForm(Boolean l) {
            l = !l;
            btnSave.Enabled = !l;
            btnRefresh.Enabled = !l;



            txtCustCode.Enabled = l;
            rdoTypeCompany.Enabled = l;
            rdoTypePersonal.Enabled = l;
            txtCompany.Enabled = l;
            txtName.Enabled = l;
            txtSurname.Enabled = l;
            txtVillage.Enabled = l;
            txtAddr.Enabled = l;
            txtCity.Enabled = l;
            txtProvince.Enabled = l;
            txtZipcode.Enabled = l;
            txtTel.Enabled = l;
            txtFax.Enabled = l;
            txtEmail.Enabled = l;

            txtContactName.Enabled = l;
            txtContactTel.Enabled = l;
            txtContactMobile.Enabled = l;
            txtContactPosition.Enabled = l;

            txtTechnicName.Enabled = l;
            txtTechnicTel.Enabled = l;
            txtTechnicMobile.Enabled = l;
            txtTechnicPosition.Enabled = l;

            txtPmName.Enabled = l;
            txtPmTel.Enabled = l;
            txtPmMobile.Enabled = l;
            txtPmPosition.Enabled = l;
        }


        private void loadCustomer(string custCode)
        {
            List<String> sql = new List<String>();
            sql.Add("cust_code");
            sql.Add("cust_type");
            sql.Add("cust_ref_code");
            sql.Add("company_name");
            sql.Add("cust_name");
            sql.Add("cust_surname");
            sql.Add("addr");
            sql.Add("village");
            sql.Add("city");
            sql.Add("province");
            sql.Add("zipcode");
            sql.Add("tel");
            sql.Add("fax");
            sql.Add("email");

            sql.Add("contact_name");
            sql.Add("contact_tel");
            sql.Add("contact_mobile");
            sql.Add("contact_position");

            sql.Add("technic_name");
            sql.Add("technic_tel");
            sql.Add("technic_mobile");
            sql.Add("technic_position");

            sql.Add("pm_pe_name");
            sql.Add("pm_pe_tel");
            sql.Add("pm_pe_mobile");
            sql.Add("pm_pe_position");

           DataSet ds=  DbManager.ExcuteQuery(DbManager.getSelectSQL("customer", sql.ToArray(), "cust_code='" + custCode + "'"),"customer");

           if (ds.Tables["customer"].Rows.Count > 0)
           {

               txtCustCode.Text = ds.Tables["customer"].Rows[0][0].ToString();
               if (ds.Tables["customer"].Rows[0][1].ToString().Equals("c"))
               {
                   rdoTypeCompany.Checked = true;
               }
               else
               {
                   rdoTypePersonal.Checked = true;
               }

               txtCompany.Text = ds.Tables["customer"].Rows[0][3].ToString();
               txtName.Text = ds.Tables["customer"].Rows[0][4].ToString();
               txtSurname.Text = ds.Tables["customer"].Rows[0][5].ToString();
               txtVillage.Text = ds.Tables["customer"].Rows[0][6].ToString();
               txtAddr.Text = ds.Tables["customer"].Rows[0][7].ToString();
               txtCity.Text = ds.Tables["customer"].Rows[0][8].ToString();
               txtProvince.Text = ds.Tables["customer"].Rows[0][9].ToString();
               txtZipcode.Text = ds.Tables["customer"].Rows[0][10].ToString();
               txtTel.Text = ds.Tables["customer"].Rows[0][11].ToString();
               txtFax.Text = ds.Tables["customer"].Rows[0][12].ToString();
               txtEmail.Text = ds.Tables["customer"].Rows[0][13].ToString();

               txtContactName.Text = ds.Tables["customer"].Rows[0][14].ToString();
               txtContactTel.Text = ds.Tables["customer"].Rows[0][15].ToString();
               txtContactMobile.Text = ds.Tables["customer"].Rows[0][16].ToString();
               txtContactPosition.Text = ds.Tables["customer"].Rows[0][17].ToString();

               txtTechnicName.Text = ds.Tables["customer"].Rows[0][18].ToString();
               txtTechnicTel.Text = ds.Tables["customer"].Rows[0][19].ToString();
               txtTechnicMobile.Text = ds.Tables["customer"].Rows[0][20].ToString();
               txtTechnicPosition.Text = ds.Tables["customer"].Rows[0][21].ToString();

               txtPmName.Text = ds.Tables["customer"].Rows[0][22].ToString();
               txtPmTel.Text = ds.Tables["customer"].Rows[0][23].ToString();
               txtPmMobile.Text = ds.Tables["customer"].Rows[0][24].ToString();
               txtPmPosition.Text = ds.Tables["customer"].Rows[0][25].ToString();

           }
           ds = null;

        }

        private void txtCompany_KeyPress(object sender, KeyPressEventArgs e)
        {

            Utility.FocusTo(e, rdoTypeCompany);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtSurname);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtVillage);
        }

        private void txtVillage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtAddr);
        }

        private void txtAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtCity);
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtProvince);
        }

        private void txtProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtZipcode);
        }

        private void txtZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtTel);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtFax);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtEmail);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtContactName);
        }

        private void txtContactName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtContactTel);
        }

        private void txtContactTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtContactMobile);
        }

        private void txtContactMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtContactPosition);
        }

        private void txtContactPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtPmName);
        }

        private void txtPmName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtPmTel);
        }

        private void txtPmTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtPmMobile);
        }

        private void txtPmMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtPmPosition);
        }

        private void txtPmPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtTechnicName);
        }

        private void txtTechnicName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtTechnicTel);
        }

        private void txtTechnicTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtTechnicMobile);
        }

        private void txtTechnicMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtTechnicPosition);
        }

        private void rdoTypeCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, rdoTypePersonal);
        }

        private void rdoTypePersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, txtName);
        }

        private void txtTechnicPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FocusTo(e, btnSave);
        }


        /// <summary>
        /// ตรวจสอบความถูกต้องของข้อมูล
        /// </summary>
        /// <returns></returns>
        private Boolean validForm() {

            Boolean b = true;
            if (txtName.Text =="" && txtCompany.Text=="") {
                b = false;
                if (txtName.Text == "") {
                    txtName.Focus();
                }else{
                    txtCompany.Focus();
                }

                MessageBox.Show("โปรดระบุ ชื่อลูกค้า หรือ ชื่อบริษัท");
                
            }else if (txtTel.Text == "") {
                b = false;
                txtTel.Focus();
                MessageBox.Show("โปรดระบุ หมายเลขโทรศัพท์");
            }

            return b;
        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
            this.MODE_CURRENT = DbManager.MODE_EDIT;
            LockForm(false);
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            btnEnableEdit.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (txtCustCode.Text != "")
            {
                loadCustomer(CustomerCode);
                LockForm(true);
                btnEnableEdit.Enabled = true;
                btnSave.Enabled = false;
                btnRefresh.Enabled = false;
            }
            else {
                clearForm();
                btnEnableEdit.Enabled = false;
                btnSave.Enabled = true;
                btnRefresh.Enabled = true;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult =  MessageBox.Show("ต้องการลบใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (dialogResult == DialogResult.Yes) {
               if (deleteCustomer(txtCustCode.Text))
               {
                   MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ข้อความ");
                   clearForm();
                   MODE_CURRENT = DbManager.MODE_ADD;
               }
               else {
                   MessageBox.Show("ไม่สามารถลบข้อมูล", "ข้อความ");
               }
           }
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        
    }
}
