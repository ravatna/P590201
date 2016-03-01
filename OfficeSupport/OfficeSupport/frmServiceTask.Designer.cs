namespace OfficeSupport
{
    partial class frmServiceTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceTask));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.chkClosedWork = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkLocation = new System.Windows.Forms.TextBox();
            this.dtpWaranty = new System.Windows.Forms.DateTimePicker();
            this.dtpCreated = new System.Windows.Forms.DateTimePicker();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.dtpWorkJobDate = new System.Windows.Forms.DateTimePicker();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlantNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlokNo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDrill = new System.Windows.Forms.CheckBox();
            this.chkSpray = new System.Windows.Forms.CheckBox();
            this.chkInjection = new System.Windows.Forms.CheckBox();
            this.chkHammer = new System.Windows.Forms.CheckBox();
            this.chkRecoverPipe = new System.Windows.Forms.CheckBox();
            this.chkCompress = new System.Windows.Forms.CheckBox();
            this.chkPipeLine = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkFly = new System.Windows.Forms.CheckBox();
            this.chkMosquito = new System.Windows.Forms.CheckBox();
            this.chkRat = new System.Windows.Forms.CheckBox();
            this.chkCockrach = new System.Windows.Forms.CheckBox();
            this.chkAnt = new System.Windows.Forms.CheckBox();
            this.chkTermite = new System.Windows.Forms.CheckBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaskId);
            this.groupBox1.Controls.Add(this.txtCustCode);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.chkClosedWork);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWorkLocation);
            this.groupBox1.Controls.Add(this.dtpWaranty);
            this.groupBox1.Controls.Add(this.dtpCreated);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.dtpWorkJobDate);
            this.groupBox1.Controls.Add(this.btnFindCustomer);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPlantNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBlokNo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายละเอียดการสั่งงาน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "บริษัท";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "ชื่อ";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(115, 42);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(217, 20);
            this.txtCustName.TabIndex = 50;
            // 
            // chkClosedWork
            // 
            this.chkClosedWork.AutoSize = true;
            this.chkClosedWork.Location = new System.Drawing.Point(585, 220);
            this.chkClosedWork.Name = "chkClosedWork";
            this.chkClosedWork.Size = new System.Drawing.Size(78, 17);
            this.chkClosedWork.TabIndex = 49;
            this.chkClosedWork.Text = "ปิดงานแล้ว";
            this.chkClosedWork.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "ครั้งที่";
            // 
            // txtWorkLocation
            // 
            this.txtWorkLocation.Location = new System.Drawing.Point(115, 106);
            this.txtWorkLocation.Name = "txtWorkLocation";
            this.txtWorkLocation.Size = new System.Drawing.Size(179, 20);
            this.txtWorkLocation.TabIndex = 47;
            // 
            // dtpWaranty
            // 
            this.dtpWaranty.Location = new System.Drawing.Point(629, 72);
            this.dtpWaranty.Name = "dtpWaranty";
            this.dtpWaranty.Size = new System.Drawing.Size(181, 20);
            this.dtpWaranty.TabIndex = 46;
            // 
            // dtpCreated
            // 
            this.dtpCreated.Location = new System.Drawing.Point(632, 15);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(181, 20);
            this.dtpCreated.TabIndex = 45;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(115, 16);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(217, 20);
            this.txtCompany.TabIndex = 44;
            // 
            // dtpWorkJobDate
            // 
            this.dtpWorkJobDate.Location = new System.Drawing.Point(115, 73);
            this.dtpWorkJobDate.Name = "dtpWorkJobDate";
            this.dtpWorkJobDate.Size = new System.Drawing.Size(183, 20);
            this.dtpWorkJobDate.TabIndex = 43;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(340, 14);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(28, 23);
            this.btnFindCustomer.TabIndex = 42;
            this.btnFindCustomer.Text = "....";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ไม่มีรับประกัน",
            "1 ปี",
            "2 ปี",
            "3 ปี"});
            this.comboBox2.Location = new System.Drawing.Point(374, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "รับประกันถึงวันที่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "เลขแปลง";
            // 
            // txtPlantNo
            // 
            this.txtPlantNo.Location = new System.Drawing.Point(550, 108);
            this.txtPlantNo.Name = "txtPlantNo";
            this.txtPlantNo.Size = new System.Drawing.Size(113, 20);
            this.txtPlantNo.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Block NO";
            // 
            // txtBlokNo
            // 
            this.txtBlokNo.Location = new System.Drawing.Point(374, 107);
            this.txtBlokNo.Name = "txtBlokNo";
            this.txtBlokNo.Size = new System.Drawing.Size(113, 20);
            this.txtBlokNo.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDrill);
            this.groupBox3.Controls.Add(this.chkSpray);
            this.groupBox3.Controls.Add(this.chkInjection);
            this.groupBox3.Controls.Add(this.chkHammer);
            this.groupBox3.Controls.Add(this.chkRecoverPipe);
            this.groupBox3.Controls.Add(this.chkCompress);
            this.groupBox3.Controls.Add(this.chkPipeLine);
            this.groupBox3.Location = new System.Drawing.Point(34, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 49);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // chkDrill
            // 
            this.chkDrill.AutoSize = true;
            this.chkDrill.Location = new System.Drawing.Point(433, 19);
            this.chkDrill.Name = "chkDrill";
            this.chkDrill.Size = new System.Drawing.Size(47, 17);
            this.chkDrill.TabIndex = 31;
            this.chkDrill.Text = "เจาะ";
            this.chkDrill.UseVisualStyleBackColor = true;
            // 
            // chkSpray
            // 
            this.chkSpray.AutoSize = true;
            this.chkSpray.Location = new System.Drawing.Point(370, 19);
            this.chkSpray.Name = "chkSpray";
            this.chkSpray.Size = new System.Drawing.Size(57, 17);
            this.chkSpray.TabIndex = 29;
            this.chkSpray.Text = "สเปรย์";
            this.chkSpray.UseVisualStyleBackColor = true;
            // 
            // chkInjection
            // 
            this.chkInjection.AutoSize = true;
            this.chkInjection.Location = new System.Drawing.Point(278, 19);
            this.chkInjection.Name = "chkInjection";
            this.chkInjection.Size = new System.Drawing.Size(86, 17);
            this.chkInjection.TabIndex = 28;
            this.chkInjection.Text = "ฉีด-พ่นแปลง";
            this.chkInjection.UseVisualStyleBackColor = true;
            // 
            // chkHammer
            // 
            this.chkHammer.AutoSize = true;
            this.chkHammer.Location = new System.Drawing.Point(225, 19);
            this.chkHammer.Name = "chkHammer";
            this.chkHammer.Size = new System.Drawing.Size(47, 17);
            this.chkHammer.TabIndex = 27;
            this.chkHammer.Text = "ตีกิ๊บ";
            this.chkHammer.UseVisualStyleBackColor = true;
            // 
            // chkRecoverPipe
            // 
            this.chkRecoverPipe.AutoSize = true;
            this.chkRecoverPipe.Location = new System.Drawing.Point(148, 19);
            this.chkRecoverPipe.Name = "chkRecoverPipe";
            this.chkRecoverPipe.Size = new System.Drawing.Size(71, 17);
            this.chkRecoverPipe.TabIndex = 26;
            this.chkRecoverPipe.Text = "เก็บหัวท่อ";
            this.chkRecoverPipe.UseVisualStyleBackColor = true;
            // 
            // chkCompress
            // 
            this.chkCompress.AutoSize = true;
            this.chkCompress.Location = new System.Drawing.Point(78, 19);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.Size = new System.Drawing.Size(64, 17);
            this.chkCompress.TabIndex = 25;
            this.chkCompress.Text = "อัดน้ำยา";
            this.chkCompress.UseVisualStyleBackColor = true;
            // 
            // chkPipeLine
            // 
            this.chkPipeLine.AutoSize = true;
            this.chkPipeLine.Location = new System.Drawing.Point(17, 19);
            this.chkPipeLine.Name = "chkPipeLine";
            this.chkPipeLine.Size = new System.Drawing.Size(55, 17);
            this.chkPipeLine.TabIndex = 24;
            this.chkPipeLine.Text = "วางท่อ";
            this.chkPipeLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOther);
            this.groupBox2.Controls.Add(this.chkOther);
            this.groupBox2.Controls.Add(this.chkFly);
            this.groupBox2.Controls.Add(this.chkMosquito);
            this.groupBox2.Controls.Add(this.chkRat);
            this.groupBox2.Controls.Add(this.chkCockrach);
            this.groupBox2.Controls.Add(this.chkAnt);
            this.groupBox2.Controls.Add(this.chkTermite);
            this.groupBox2.Location = new System.Drawing.Point(34, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 52);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "เป้าหมาย";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(444, 19);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(179, 20);
            this.txtOther.TabIndex = 49;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(370, 19);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(72, 17);
            this.chkOther.TabIndex = 37;
            this.chkOther.Text = "แมลงอื่นๆ";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // chkFly
            // 
            this.chkFly.AutoSize = true;
            this.chkFly.Location = new System.Drawing.Point(291, 19);
            this.chkFly.Name = "chkFly";
            this.chkFly.Size = new System.Drawing.Size(66, 17);
            this.chkFly.TabIndex = 36;
            this.chkFly.Text = "แมลงวัน";
            this.chkFly.UseVisualStyleBackColor = true;
            // 
            // chkMosquito
            // 
            this.chkMosquito.AutoSize = true;
            this.chkMosquito.Location = new System.Drawing.Point(200, 19);
            this.chkMosquito.Name = "chkMosquito";
            this.chkMosquito.Size = new System.Drawing.Size(38, 17);
            this.chkMosquito.TabIndex = 35;
            this.chkMosquito.Text = "ยุง";
            this.chkMosquito.UseVisualStyleBackColor = true;
            // 
            // chkRat
            // 
            this.chkRat.AutoSize = true;
            this.chkRat.Location = new System.Drawing.Point(244, 19);
            this.chkRat.Name = "chkRat";
            this.chkRat.Size = new System.Drawing.Size(41, 17);
            this.chkRat.TabIndex = 34;
            this.chkRat.Text = "หนู";
            this.chkRat.UseVisualStyleBackColor = true;
            // 
            // chkCockrach
            // 
            this.chkCockrach.AutoSize = true;
            this.chkCockrach.Location = new System.Drawing.Point(124, 19);
            this.chkCockrach.Name = "chkCockrach";
            this.chkCockrach.Size = new System.Drawing.Size(70, 17);
            this.chkCockrach.TabIndex = 33;
            this.chkCockrach.Text = "แมลงสาบ";
            this.chkCockrach.UseVisualStyleBackColor = true;
            // 
            // chkAnt
            // 
            this.chkAnt.AutoSize = true;
            this.chkAnt.Location = new System.Drawing.Point(78, 19);
            this.chkAnt.Name = "chkAnt";
            this.chkAnt.Size = new System.Drawing.Size(40, 17);
            this.chkAnt.TabIndex = 32;
            this.chkAnt.Text = "มด";
            this.chkAnt.UseVisualStyleBackColor = true;
            // 
            // chkTermite
            // 
            this.chkTermite.AutoSize = true;
            this.chkTermite.Location = new System.Drawing.Point(17, 19);
            this.chkTermite.Name = "chkTermite";
            this.chkTermite.Size = new System.Drawing.Size(52, 17);
            this.chkTermite.TabIndex = 31;
            this.chkTermite.Text = "ปลวก";
            this.chkTermite.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddItem.Location = new System.Drawing.Point(705, 202);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(105, 50);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "เพิ่มรายการ";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "สถานที่ปฎิบัติงาน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "วันที่ทำรายการ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "วันที่จ่ายงาน";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvCustomer.Location = new System.Drawing.Point(12, 284);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(731, 195);
            this.dgvCustomer.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "รหัสลูกค้า";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ชื่อลูกค้า";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "วันที่จ่ายงาน";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "สถานที่ปฎิบัติงาน";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "รายละเอียดงาน";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(749, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 65);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "พิมพ์";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(749, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 65);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ลบรายการ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(340, 43);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(86, 20);
            this.txtCustCode.TabIndex = 53;
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(432, 42);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(86, 20);
            this.txtTaskId.TabIndex = 54;
            // 
            // frmServiceTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 491);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmServiceTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการ ข้อมูลจ่ายงาน";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSpray;
        private System.Windows.Forms.CheckBox chkInjection;
        private System.Windows.Forms.CheckBox chkHammer;
        private System.Windows.Forms.CheckBox chkRecoverPipe;
        private System.Windows.Forms.CheckBox chkCompress;
        private System.Windows.Forms.CheckBox chkPipeLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkFly;
        private System.Windows.Forms.CheckBox chkMosquito;
        private System.Windows.Forms.CheckBox chkRat;
        private System.Windows.Forms.CheckBox chkCockrach;
        private System.Windows.Forms.CheckBox chkAnt;
        private System.Windows.Forms.CheckBox chkTermite;
        private System.Windows.Forms.CheckBox chkDrill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlantNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBlokNo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.DateTimePicker dtpWorkJobDate;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.DateTimePicker dtpWaranty;
        private System.Windows.Forms.DateTimePicker dtpCreated;
        private System.Windows.Forms.TextBox txtWorkLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkClosedWork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.TextBox txtTaskId;
    }
}