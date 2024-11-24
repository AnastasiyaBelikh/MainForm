using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairIS_1
{
    public partial class frmWorker : Form
    {
        public frmWorker()
        {
            InitializeComponent();
        }
        public string FullName
        {
            get { return $"{txtLastName.Text} {txtFirstName.Text} {txtMiddleName.Text}"; }
            set
            {
                // Разделяем строку ФИО на части
                string[] parts = value?.Split(' ');
                if (parts != null && parts.Length == 3)
                {
                    txtLastName.Text = parts[0];  // Устанавливаем фамилию
                    txtFirstName.Text = parts[1]; // Устанавливаем имя
                    txtMiddleName.Text = parts[2]; // Устанавливаем отчество
                }
            }
        }


        public string AccountNumber
        {
            get { return txtAccountNumber.Text; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрыть форму без сохранения
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Устанавливаем результат формы
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



    }
}
