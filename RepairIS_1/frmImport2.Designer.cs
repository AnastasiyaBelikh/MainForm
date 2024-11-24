namespace RepairIS_1
{
    partial class frmImport
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnExistingReference = new System.Windows.Forms.RadioButton();
            this.rbtnNewReference = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReferenceName = new System.Windows.Forms.ComboBox();
            this.cmbSheetName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCustomSeparator = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtnDot = new System.Windows.Forms.RadioButton();
            this.rbtnSpace = new System.Windows.Forms.RadioButton();
            this.rbtnComma = new System.Windows.Forms.RadioButton();
            this.rbtnSemicolon = new System.Windows.Forms.RadioButton();
            this.rbtnTab = new System.Windows.Forms.RadioButton();
            this.chkHeaders = new System.Windows.Forms.CheckBox();
            this.chkValidate = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(571, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 35);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(402, 15);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(100, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnExistingReference);
            this.groupBox1.Controls.Add(this.rbtnNewReference);
            this.groupBox1.Location = new System.Drawing.Point(39, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ импорта";
            // 
            // rbtnExistingReference
            // 
            this.rbtnExistingReference.AutoSize = true;
            this.rbtnExistingReference.Location = new System.Drawing.Point(6, 61);
            this.rbtnExistingReference.Name = "rbtnExistingReference";
            this.rbtnExistingReference.Size = new System.Drawing.Size(457, 24);
            this.rbtnExistingReference.TabIndex = 1;
            this.rbtnExistingReference.TabStop = true;
            this.rbtnExistingReference.Text = "Добавить копию данных к существующему справочнику";
            this.rbtnExistingReference.UseVisualStyleBackColor = true;
            this.rbtnExistingReference.CheckedChanged += new System.EventHandler(this.rbtnExistingReference_CheckedChanged);
            // 
            // rbtnNewReference
            // 
            this.rbtnNewReference.AutoSize = true;
            this.rbtnNewReference.Location = new System.Drawing.Point(3, 22);
            this.rbtnNewReference.Name = "rbtnNewReference";
            this.rbtnNewReference.Size = new System.Drawing.Size(373, 24);
            this.rbtnNewReference.TabIndex = 0;
            this.rbtnNewReference.TabStop = true;
            this.rbtnNewReference.Text = "Импортировать данные в новый справочник";
            this.rbtnNewReference.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbReferenceName);
            this.groupBox2.Controls.Add(this.cmbSheetName);
            this.groupBox2.Location = new System.Drawing.Point(39, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 176);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры импорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя листа (откуда импортируем)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "авочника (куда импортируем)";
            // 
            // cmbReferenceName
            // 
            this.cmbReferenceName.FormattingEnabled = true;
            this.cmbReferenceName.Location = new System.Drawing.Point(24, 47);
            this.cmbReferenceName.Name = "cmbReferenceName";
            this.cmbReferenceName.Size = new System.Drawing.Size(121, 28);
            this.cmbReferenceName.TabIndex = 4;
            // 
            // cmbSheetName
            // 
            this.cmbSheetName.FormattingEnabled = true;
            this.cmbSheetName.Location = new System.Drawing.Point(24, 103);
            this.cmbSheetName.Name = "cmbSheetName";
            this.cmbSheetName.Size = new System.Drawing.Size(121, 28);
            this.cmbSheetName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл с данными";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCustomSeparator);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.rbtnDot);
            this.groupBox3.Controls.Add(this.rbtnSpace);
            this.groupBox3.Controls.Add(this.rbtnComma);
            this.groupBox3.Controls.Add(this.rbtnSemicolon);
            this.groupBox3.Controls.Add(this.rbtnTab);
            this.groupBox3.Location = new System.Drawing.Point(451, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 219);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Разделители";
            // 
            // txtCustomSeparator
            // 
            this.txtCustomSeparator.Location = new System.Drawing.Point(143, 187);
            this.txtCustomSeparator.Name = "txtCustomSeparator";
            this.txtCustomSeparator.Size = new System.Drawing.Size(100, 26);
            this.txtCustomSeparator.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 189);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Другой";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtnDot
            // 
            this.rbtnDot.AutoSize = true;
            this.rbtnDot.Location = new System.Drawing.Point(11, 122);
            this.rbtnDot.Name = "rbtnDot";
            this.rbtnDot.Size = new System.Drawing.Size(78, 24);
            this.rbtnDot.TabIndex = 4;
            this.rbtnDot.TabStop = true;
            this.rbtnDot.Text = "Точка";
            this.rbtnDot.UseVisualStyleBackColor = true;
            this.rbtnDot.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbtnSpace
            // 
            this.rbtnSpace.AutoSize = true;
            this.rbtnSpace.Location = new System.Drawing.Point(11, 156);
            this.rbtnSpace.Name = "rbtnSpace";
            this.rbtnSpace.Size = new System.Drawing.Size(92, 24);
            this.rbtnSpace.TabIndex = 3;
            this.rbtnSpace.TabStop = true;
            this.rbtnSpace.Text = "Пробел";
            this.rbtnSpace.UseVisualStyleBackColor = true;
            // 
            // rbtnComma
            // 
            this.rbtnComma.AutoSize = true;
            this.rbtnComma.Location = new System.Drawing.Point(11, 90);
            this.rbtnComma.Name = "rbtnComma";
            this.rbtnComma.Size = new System.Drawing.Size(99, 24);
            this.rbtnComma.TabIndex = 2;
            this.rbtnComma.TabStop = true;
            this.rbtnComma.Text = "Запятая";
            this.rbtnComma.UseVisualStyleBackColor = true;
            // 
            // rbtnSemicolon
            // 
            this.rbtnSemicolon.AutoSize = true;
            this.rbtnSemicolon.Location = new System.Drawing.Point(11, 60);
            this.rbtnSemicolon.Name = "rbtnSemicolon";
            this.rbtnSemicolon.Size = new System.Drawing.Size(156, 24);
            this.rbtnSemicolon.TabIndex = 1;
            this.rbtnSemicolon.TabStop = true;
            this.rbtnSemicolon.Text = "Точка с запятой";
            this.rbtnSemicolon.UseVisualStyleBackColor = true;
            // 
            // rbtnTab
            // 
            this.rbtnTab.AutoSize = true;
            this.rbtnTab.Location = new System.Drawing.Point(11, 30);
            this.rbtnTab.Name = "rbtnTab";
            this.rbtnTab.Size = new System.Drawing.Size(114, 24);
            this.rbtnTab.TabIndex = 0;
            this.rbtnTab.TabStop = true;
            this.rbtnTab.Text = "Табуляция";
            this.rbtnTab.UseVisualStyleBackColor = true;
            // 
            // chkHeaders
            // 
            this.chkHeaders.AutoSize = true;
            this.chkHeaders.Location = new System.Drawing.Point(46, 354);
            this.chkHeaders.Name = "chkHeaders";
            this.chkHeaders.Size = new System.Drawing.Size(385, 24);
            this.chkHeaders.TabIndex = 5;
            this.chkHeaders.Text = "Первая строка содержит заголовки столбцов";
            this.chkHeaders.UseVisualStyleBackColor = true;
            // 
            // chkValidate
            // 
            this.chkValidate.AutoSize = true;
            this.chkValidate.Location = new System.Drawing.Point(45, 385);
            this.chkValidate.Name = "chkValidate";
            this.chkValidate.Size = new System.Drawing.Size(442, 24);
            this.chkValidate.TabIndex = 6;
            this.chkValidate.Text = "Проверять типы данных и структуру перед импортом";
            this.chkValidate.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(147, 415);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Импорт";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(450, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.chkValidate);
            this.Controls.Add(this.chkHeaders);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "frmImport";
            this.Text = "Импорт данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnExistingReference;
        private System.Windows.Forms.RadioButton rbtnNewReference;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReferenceName;
        private System.Windows.Forms.ComboBox cmbSheetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnDot;
        private System.Windows.Forms.RadioButton rbtnSpace;
        private System.Windows.Forms.RadioButton rbtnComma;
        private System.Windows.Forms.RadioButton rbtnSemicolon;
        private System.Windows.Forms.RadioButton rbtnTab;
        private System.Windows.Forms.TextBox txtCustomSeparator;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox chkHeaders;
        private System.Windows.Forms.CheckBox chkValidate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
    }
}