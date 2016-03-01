using System;
using System.Collections.Generic;
using System.Management;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OfficeSupport
{
    public partial class FrmSetupComapny : Form
    {

        SqlConnection conn;
        String ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString.ToString();        

        public FrmSetupComapny()
        {
            InitializeComponent();
        }

        private void FrmSetupComapny_Load(object sender, EventArgs e)
        {
            InitData();

        }

        


        private void InitData() {
            // New object Sql Connection.
            
   
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = ConnectionString;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                String _sql = "select [company_name] ,[company_number],[tax_number],[addr],[tel],[mobile],[fax],[email] from [company_setting]";
                SqlCommand _cmd = new SqlCommand(_sql, conn);
                SqlDataReader _reader = _cmd.ExecuteReader();

                if (_reader.Read())
                {
                    txtCompanyName.Text = _reader.GetString(0);
                    
                    txtCompanyNumber.Text = _reader.GetString(1);
                    txtTAXNumber.Text = _reader.GetString(2);
                    txtAddr.Text = _reader.GetString(3);           
                    txtTel.Text = _reader.GetString(4);
                    txtMobile.Text = _reader.GetString(5);
                    txtFax.Text = _reader.GetString(6);
                    txtEmail.Text = _reader.GetString(7);
                }
                _reader.Close();
                conn.Close(); // ปิดการเชื่อมต่อฐานข้อมูล
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        
        }

        /**
         * ตรวจสอบสิทธ์การเข้าใช้งานระบบ
         */
        private void updateCompanySetting()
        {
            // New object Sql Connection.
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = ConnectionString;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                String _sql = "select * from COMPANY_SETTING";
                SqlCommand _cmd = new SqlCommand(_sql,conn);
                SqlDataReader _reader = _cmd.ExecuteReader();

                if (_reader.Read())
                {
                    _sql = " UPDATE [company_setting] ";
                    _sql += " SET [company_name] = '" + txtCompanyName.Text + "'";
                  
                    _sql += " ,[company_number] = '" + txtCompanyNumber.Text + "'";
                    _sql += " ,[tax_number] = '" + txtTAXNumber.Text + "'";
                    
                    _sql += " ,[addr] = '" + txtAddr.Text + "'";
                    
                    _sql += " ,[tel] = '" + txtTel.Text + "'";
                    _sql += " ,[mobile] = '" + txtMobile.Text + "'";
                    _sql += " ,[fax] = '" + txtFax.Text + "'";
                    _sql += " ,[email] = '" + txtEmail.Text + "'";
                }
                else {
                    _sql = "INSERT INTO [company_setting]([company_name],[company_number],[tax_number],[addr],[tel],[mobile],[fax],[email]) ";
                    _sql += " VALUES('" + txtCompanyName.Text + "','" + txtCompanyNumber.Text + "','" + txtTAXNumber.Text + "','" + txtAddr.Text + "','" + txtTel.Text + "','" + txtMobile.Text + "','" + txtFax.Text + "','" + txtEmail.Text + "')";
                }
                
                _reader.Close();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                
                SqlCommand _cmd2 = new SqlCommand(_sql, conn);  // สร้างวัตถุ SqlCommand
                
                int result = _cmd2.ExecuteNonQuery();
                if (result == 1) {
                    MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อย");
                }
                _reader.Close();
                conn.Close(); // ปิดการเชื่อมต่อฐานข้อมูล
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateCompanySetting();
        }
    }
}
