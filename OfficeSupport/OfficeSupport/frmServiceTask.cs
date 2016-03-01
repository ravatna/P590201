using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfficeSupport
{
    public partial class frmServiceTask : Form
    {
        frmFindCustomer frmFindCustomer;

        public frmServiceTask()

        {
            InitializeComponent();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            frmFindCustomer = new frmFindCustomer();
            frmFindCustomer.ShowDialog(this);
            txtCustName.Text = frmFindCustomer.m_Name;
            txtCompany.Text = frmFindCustomer.m_Company;
            txtCustCode.Text = frmFindCustomer.m_CustCode;
            frmFindCustomer = null;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ระบบฐานข้อมูลขัดข้องไม่สามารถเพิ่มข้อมูลได้ โปรดลองใหม่");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("เครื่องพิมพ์ขัดข้อง โปรดลองใหม่");
        }
    }
}
