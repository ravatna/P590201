namespace OfficeSupport
{
    partial class frmManipulateContract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManipulateContract));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpCurrent = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.dtpStartEffect = new System.Windows.Forms.DateTimePicker();
            this.dtpEndEffect = new System.Windows.Forms.DateTimePicker();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkLocation = new System.Windows.Forms.TextBox();
            this.txtTypeService = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEnableEdit = new System.Windows.Forms.Button();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtContractNo);
            this.groupBox1.Controls.Add(this.txtContractId);
            this.groupBox1.Controls.Add(this.dtpCurrent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustCode);
            this.groupBox1.Controls.Add(this.btnFindCustomer);
            this.groupBox1.Controls.Add(this.dtpStartEffect);
            this.groupBox1.Controls.Add(this.dtpEndEffect);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtWorkLocation);
            this.groupBox1.Controls.Add(this.txtTypeService);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลทั่วไปในสัญญา";
            // 
            // dtpCurrent
            // 
            this.dtpCurrent.Location = new System.Drawing.Point(448, 19);
            this.dtpCurrent.Name = "dtpCurrent";
            this.dtpCurrent.Size = new System.Drawing.Size(200, 20);
            this.dtpCurrent.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ชื่อลูกค้า";
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(319, 53);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(90, 20);
            this.txtCustCode.TabIndex = 20;
            this.txtCustCode.Visible = false;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(319, 19);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(28, 23);
            this.btnFindCustomer.TabIndex = 19;
            this.btnFindCustomer.Text = "....";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // dtpStartEffect
            // 
            this.dtpStartEffect.Location = new System.Drawing.Point(117, 146);
            this.dtpStartEffect.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStartEffect.Name = "dtpStartEffect";
            this.dtpStartEffect.Size = new System.Drawing.Size(200, 20);
            this.dtpStartEffect.TabIndex = 18;
            // 
            // dtpEndEffect
            // 
            this.dtpEndEffect.Location = new System.Drawing.Point(118, 184);
            this.dtpEndEffect.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpEndEffect.Name = "dtpEndEffect";
            this.dtpEndEffect.Size = new System.Drawing.Size(200, 20);
            this.dtpEndEffect.TabIndex = 17;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(319, 233);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(329, 99);
            this.txtComment.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "หมายเหตุ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "สถานที่ปฎิบัติงาน";
            // 
            // txtWorkLocation
            // 
            this.txtWorkLocation.Location = new System.Drawing.Point(117, 113);
            this.txtWorkLocation.Name = "txtWorkLocation";
            this.txtWorkLocation.Size = new System.Drawing.Size(342, 20);
            this.txtWorkLocation.TabIndex = 13;
            // 
            // txtTypeService
            // 
            this.txtTypeService.Location = new System.Drawing.Point(14, 233);
            this.txtTypeService.Multiline = true;
            this.txtTypeService.Name = "txtTypeService";
            this.txtTypeService.Size = new System.Drawing.Size(282, 99);
            this.txtTypeService.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "เงื่อนไขการบริการ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "วันที่ทำรายการ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "วันที่สิ้นสุดสัญญา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "วันที่เริ่มสัญญา";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "บริษัท";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(118, 19);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(192, 20);
            this.txtCompany.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(672, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 65);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(672, 229);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 65);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "พิมพ์";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::OfficeSupport.Properties.Resources._02_Recycle_24x24;
            this.btnDelete.Location = new System.Drawing.Point(672, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 65);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::OfficeSupport.Properties.Resources.recycle_24;
            this.btnRefresh.Location = new System.Drawing.Point(672, 158);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 65);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "คืนค่าข้อมูล";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEnableEdit
            // 
            this.btnEnableEdit.Image = global::OfficeSupport.Properties.Resources.software_24;
            this.btnEnableEdit.Location = new System.Drawing.Point(672, 16);
            this.btnEnableEdit.Name = "btnEnableEdit";
            this.btnEnableEdit.Size = new System.Drawing.Size(105, 65);
            this.btnEnableEdit.TabIndex = 9;
            this.btnEnableEdit.Text = "แก้ไข";
            this.btnEnableEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnableEdit.UseVisualStyleBackColor = true;
            this.btnEnableEdit.Click += new System.EventHandler(this.btnEnableEdit_Click);
            // 
            // txtContractId
            // 
            this.txtContractId.Location = new System.Drawing.Point(426, 53);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Size = new System.Drawing.Size(90, 20);
            this.txtContractId.TabIndex = 23;
            this.txtContractId.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "เลขที่สัญญา";
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(117, 82);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(193, 20);
            this.txtContractNo.TabIndex = 24;
            // 
            // frmManipulateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 374);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEnableEdit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManipulateContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการข้อมูลสัญญา เฉพาะบุคคล";
            this.Load += new System.EventHandler(this.frmManipulateContract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTypeService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkLocation;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpStartEffect;
        private System.Windows.Forms.DateTimePicker dtpEndEffect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEnableEdit;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.DateTimePicker dtpCurrent;
        private System.Windows.Forms.TextBox txtContractId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContractNo;

    }
}