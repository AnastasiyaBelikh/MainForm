namespace RepairIS_1
{
    partial class frmListWorkers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListWorkers));
            this.treeWorkers = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBankDetails = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountExpiry = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassportSeries = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.grpPayments = new System.Windows.Forms.GroupBox();
            this.txtLastPayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPayments = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnToggleBankData = new System.Windows.Forms.Button();
            this.btnTogglePersonalData = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.grpPersonalData.SuspendLayout();
            this.grpBankDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeWorkers
            // 
            this.treeWorkers.HideSelection = false;
            this.treeWorkers.ImageIndex = 0;
            this.treeWorkers.ImageList = this.imageList1;
            this.treeWorkers.Location = new System.Drawing.Point(46, 51);
            this.treeWorkers.Name = "treeWorkers";
            this.treeWorkers.SelectedImageIndex = 0;
            this.treeWorkers.Size = new System.Drawing.Size(121, 333);
            this.treeWorkers.TabIndex = 0;
            this.treeWorkers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeWorkers_AfterSelect_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit.png");
            this.imageList1.Images.SetKeyName(1, "male.png");
            this.imageList1.Images.SetKeyName(2, "female.png");
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.label3);
            this.grpPersonalData.Controls.Add(this.grpBankDetails);
            this.grpPersonalData.Controls.Add(this.label2);
            this.grpPersonalData.Controls.Add(this.label1);
            this.grpPersonalData.Controls.Add(this.txtMiddleName);
            this.grpPersonalData.Controls.Add(this.txtFirstName);
            this.grpPersonalData.Controls.Add(this.txtLastName);
            this.grpPersonalData.Controls.Add(this.groupBox1);
            this.grpPersonalData.Location = new System.Drawing.Point(397, 51);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Size = new System.Drawing.Size(339, 248);
            this.grpPersonalData.TabIndex = 1;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Персональные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // grpBankDetails
            // 
            this.grpBankDetails.Controls.Add(this.label7);
            this.grpBankDetails.Controls.Add(this.label6);
            this.grpBankDetails.Controls.Add(this.txtAccountExpiry);
            this.grpBankDetails.Controls.Add(this.txtAccountNumber);
            this.grpBankDetails.Location = new System.Drawing.Point(6, 248);
            this.grpBankDetails.Name = "grpBankDetails";
            this.grpBankDetails.Size = new System.Drawing.Size(333, 100);
            this.grpBankDetails.TabIndex = 2;
            this.grpBankDetails.TabStop = false;
            this.grpBankDetails.Text = "Банковская карта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Срок действия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Номер счёта";
            // 
            // txtAccountExpiry
            // 
            this.txtAccountExpiry.Location = new System.Drawing.Point(173, 68);
            this.txtAccountExpiry.Name = "txtAccountExpiry";
            this.txtAccountExpiry.Size = new System.Drawing.Size(100, 26);
            this.txtAccountExpiry.TabIndex = 1;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(132, 36);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 26);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(227, 121);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 26);
            this.txtMiddleName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(227, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(227, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassportSeries);
            this.groupBox1.Controls.Add(this.txtPassportNumber);
            this.groupBox1.Location = new System.Drawing.Point(23, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Серия";
            // 
            // txtPassportSeries
            // 
            this.txtPassportSeries.Location = new System.Drawing.Point(23, 21);
            this.txtPassportSeries.Name = "txtPassportSeries";
            this.txtPassportSeries.Size = new System.Drawing.Size(100, 26);
            this.txtPassportSeries.TabIndex = 4;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(204, 21);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 26);
            this.txtPassportNumber.TabIndex = 5;
            // 
            // grpPayments
            // 
            this.grpPayments.Controls.Add(this.txtLastPayment);
            this.grpPayments.Controls.Add(this.label8);
            this.grpPayments.Controls.Add(this.cmbPayments);
            this.grpPayments.Location = new System.Drawing.Point(397, 305);
            this.grpPayments.Name = "grpPayments";
            this.grpPayments.Size = new System.Drawing.Size(346, 115);
            this.grpPayments.TabIndex = 3;
            this.grpPayments.TabStop = false;
            this.grpPayments.Text = "Начислено";
            // 
            // txtLastPayment
            // 
            this.txtLastPayment.Location = new System.Drawing.Point(240, 73);
            this.txtLastPayment.Name = "txtLastPayment";
            this.txtLastPayment.Size = new System.Drawing.Size(100, 26);
            this.txtLastPayment.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Сумма последнего начисления";
            // 
            // cmbPayments
            // 
            this.cmbPayments.FormattingEnabled = true;
            this.cmbPayments.Location = new System.Drawing.Point(78, 19);
            this.cmbPayments.Name = "cmbPayments";
            this.cmbPayments.Size = new System.Drawing.Size(255, 28);
            this.cmbPayments.TabIndex = 0;
            this.cmbPayments.Text = "Все начисления";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(245, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(443, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(589, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnToggleBankData
            // 
            this.btnToggleBankData.Image = global::RepairIS_1.Properties.Resources.image__6_1;
            this.btnToggleBankData.Location = new System.Drawing.Point(297, 263);
            this.btnToggleBankData.Name = "btnToggleBankData";
            this.btnToggleBankData.Size = new System.Drawing.Size(36, 36);
            this.btnToggleBankData.TabIndex = 8;
            this.btnToggleBankData.UseVisualStyleBackColor = true;
            // 
            // btnTogglePersonalData
            // 
            this.btnTogglePersonalData.Image = global::RepairIS_1.Properties.Resources.image__6_1;
            this.btnTogglePersonalData.Location = new System.Drawing.Point(293, 122);
            this.btnTogglePersonalData.Name = "btnTogglePersonalData";
            this.btnTogglePersonalData.Size = new System.Drawing.Size(40, 32);
            this.btnTogglePersonalData.TabIndex = 7;
            this.btnTogglePersonalData.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(63, 454);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(104, 37);
            this.btnAddWorker.TabIndex = 9;
            this.btnAddWorker.Text = "Добавить";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // frmListWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 518);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnToggleBankData);
            this.Controls.Add(this.btnTogglePersonalData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpPayments);
            this.Controls.Add(this.grpPersonalData);
            this.Controls.Add(this.treeWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.frmListWorkers_Load);
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            this.grpBankDetails.ResumeLayout(false);
            this.grpBankDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPayments.ResumeLayout(false);
            this.grpPayments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView treeWorkers;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassportSeries;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBankDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccountExpiry;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.GroupBox grpPayments;
        private System.Windows.Forms.TextBox txtLastPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPayments;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTogglePersonalData;
        private System.Windows.Forms.Button btnToggleBankData;
        private System.Windows.Forms.Button btnAddWorker;
    }
}