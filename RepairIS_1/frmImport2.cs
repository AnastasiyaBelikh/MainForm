using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairIS_1
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        private void rbtnExistingReference_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            // Открываем стандартное окно выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Выберите файл для импорта"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Отображаем путь к выбранному файлу в текстовом поле
                txtFilePath.Text = openFileDialog.FileName;
            }
        }
        private string GetSelectedSeparator()
        {
            if (rbtnTab.Checked) return "\t";
            if (rbtnSemicolon.Checked) return ";";
            if (rbtnComma.Checked) return ",";
            if (rbtnDot.Checked) return ".";
            if (rbtnSpace.Checked) return " ";
            return txtCustomSeparator.Text; // Кастомный разделитель
        }
        private void ImportDataToDatabase(string[] lines, string importType, string separator, bool hasHeaders, bool validateStructure)
        {
            if (lines.Length == 0)
            {
                throw new Exception("Файл пуст.");
            }

            // Разделяем строки на колонки
            var data = lines
                .Skip(hasHeaders ? 1 : 0) // Пропуск заголовков, если включено
                .Select(line => line.Split(new[] { separator }, StringSplitOptions.None))
                .ToList();

            if (importType == "New")
            {
                CreateNewReference(data); // Логика для нового справочника
            }
            else if (importType == "Existing")
            {
                AddToExistingReference(data); // Логика для существующего
            }
        }
        private void CreateNewReference(List<string[]> data)
        {
            // Реализация создания нового справочника в базе данных
        }

        private void AddToExistingReference(List<string[]> data)
        {
            // Реализация добавления данных в существующий справочник
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            // Проверка пути к файлу
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Пожалуйста, выберите корректный файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получение параметров
            string importType = rbtnNewReference.Checked ? "New" : "Existing";
            string separator = GetSelectedSeparator();
            bool hasHeaders = chkHeaders.Checked;
            bool validateStructure = chkValidate.Checked;

            try
            {
                // Чтение файла
                var lines = File.ReadAllLines(filePath);

                // Импорт данных
                ImportDataToDatabase(lines, importType, separator, hasHeaders, validateStructure);

                MessageBox.Show("Импорт успешно завершён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка импорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
