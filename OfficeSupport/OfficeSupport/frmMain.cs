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
    public partial class frmMain : Form
    {

        frmLogin frmLogin;
        FrmCustomerSearch frmCustomerSearch;
        FrmSetupComapny frmSetupCompany;
        frmServiceTask frmServiceTask;
        frmListContract frmListContract;
        frmAbout frmAbout;
        
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmSetupCompany = new FrmSetupComapny();
            frmSetupCompany.ShowDialog(this);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            //frmLogin = new frmLogin();
            //frmLogin.ShowDialog(this);
            //frmLogin.StartPosition = FormStartPosition.CenterParent;
        }

        private void tsmiFindCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerSearch = new FrmCustomerSearch();
            frmCustomerSearch.ShowDialog(this);
        }

        private void tsmiServiceTask_Click(object sender, EventArgs e)
        {
            frmServiceTask = new frmServiceTask();
            frmServiceTask.ShowDialog(this);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout = new frmAbout();
            frmAbout.ShowDialog(this);
        }

        private void tsmiFindContract_Click(object sender, EventArgs e)
        {
            frmListContract = new frmListContract();
            frmListContract.ShowDialog(this);
        }

    }
}
