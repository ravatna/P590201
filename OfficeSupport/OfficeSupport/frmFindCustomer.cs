using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace OfficeSupport
{
    public partial class frmFindCustomer : Form
    {


        frmManipulateCustomer frmCust;
        public string m_Name = "";
        public string m_Company = "";
        public string m_CustCode = "";

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dataReader;


        String ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString.ToString();        

        public frmFindCustomer()
        {
            InitializeComponent();
        }

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {
            cboKeywordCase.SelectedIndex = 1;
            cboTypeCustomer.SelectedIndex = 0;
        }

        private void searchCustomer()
        {

            String _w = "";

            conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;

            switch (cboKeywordCase.SelectedIndex)
            {
                case 0:
                    _w = " cust_code like '" + txtKeyword.Text + "'";
                    break;

                case 1:
                    _w = " company_name like '%" + txtKeyword.Text + "%' OR  cust_name like '%" + txtKeyword.Text + "%'";
                    break;
                case 2:
                    _w = " contact_name like '%" + txtKeyword.Text + "%'";
                    break;
                case 3:
                    _w = " tel like '%" + txtKeyword.Text + "%'";
                    break;


            }

            switch (cboTypeCustomer.SelectedIndex)
            {
                case 0:
                    _w += " and cust_type = 's'";
                    break;
                case 1:
                    _w += " and cust_type = 'c'";
                    break;
                case 2:
                    _w += " and cust_type = 'p'";
                    break;

            }

            String _sql = "SELECT [cust_code],[cust_type],[cust_ref_code],[company_name],[cust_name],[cust_surname],[addr],[village],[city],[province] ";
            _sql += " ,[zipcode],[contact_name],[tel],[mobile],[email],[technic_name],[technic_tel],[technic_mobile]";
            _sql += " FROM [customer] WHERE " + _w;

            // degug
            //MessageBox.Show(_sql);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand _cmd = new SqlCommand(_sql, conn);
            SqlDataReader _rd;

            try
            {
                _rd = _cmd.ExecuteReader();

                if (_rd.HasRows)
                {
                    dgvCustomer.Rows.Clear();

                    while (_rd.Read())
                    {

                        DataGridViewRow dgvRow = (DataGridViewRow)dgvCustomer.Rows[0].Clone();

                        dgvRow.Cells[0].Value = _rd.GetValue(0).ToString();
                        dgvRow.Cells[1].Value = _rd.GetValue(3).ToString();
                        dgvRow.Cells[2].Value = _rd.GetValue(4).ToString() + " " + _rd.GetValue(5).ToString();
                        dgvRow.Cells[3].Value = _rd.GetValue(6).ToString() + " " + _rd.GetValue(7).ToString() + " " + _rd.GetValue(8).ToString() + " " + _rd.GetValue(9).ToString() + " " + _rd.GetValue(10).ToString();
                        dgvRow.Cells[4].Value = _rd.GetValue(12).ToString();


                        dgvCustomer.Rows.Add(dgvRow);
                    }

                }


                _rd.Close();
            }
            catch (SqlException e)
            {

                MessageBox.Show("ไม่สามารถเรียกค้นข้อมูลได้โปรดลองใหม่อีกครั้ง");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            
        }

        private void dgvCustomer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomer.Rows[e.RowIndex].Cells[0].Value != null)
            {
                m_CustCode = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                m_Company = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                m_Name = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.Close();
            }
        }
    }
}
