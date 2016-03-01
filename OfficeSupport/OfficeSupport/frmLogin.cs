using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace OfficeSupport
{
    public partial class frmLogin : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        
        String ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString.ToString();        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            InitForm();     
        }

        /**
          * เตรียมความพร้อมของหน้าจอ
          */
        private void InitForm()
        {

            this.txtUname.Clear();
            this.txtPword.Clear();
            this.txtUname.Focus();

            txtUname.Text = "admin";
            txtPword.Text = "123456!";
        }

        /**
         * ตรวจสอบสิทธ์การเข้าใช้งานระบบ
         */
        private void checkUserAuthen()
        {
            // New object Sql Connection.
            conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            
            
            try
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                // Insert code to process data.
                String _sql = "select uname, pword, user_level from app_user where uname ='" +  txtUname.Text + "' and pword = '" + txtPword.Text + "';";

                 cmd = new SqlCommand(_sql, conn);  // สร้างวัตถุ SqlCommand
                dataReader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (dataReader.Read())
                {
                    Global.newInstance().UserName = dataReader.GetString(0);
                    Global.newInstance().UserLevel = dataReader.GetString(1);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง");
                    this.txtUname.Focus();
                    this.txtUname.SelectAll();
                    Global.free();
                }

                dataReader.Close(); //  ปิดการอ่านข้อมูล
                //conn.Close(); // ปิดการเชื่อมต่อฐานข้อมูล

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); // ปิดการเชื่อมต่อฐานข้อมูล
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            checkUserAuthen();
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtPword.Focus();
            }
        }

        private void txtPword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                btnLogin.Focus();
            }
        }


    }
}
