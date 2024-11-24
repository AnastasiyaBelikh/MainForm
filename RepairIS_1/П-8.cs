using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void btnBrowse_Click(object sender, EventArgs e)
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


        private void cmdImport_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Выберите файл для импорта.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    // Логика обработки каждой строки
                }

                MessageBox.Show("Данные успешно импортированы!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при импорте: " + ex.Message);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private string GetSelectedSeparator()
        {
            if (rbtnTab.Checked) return "\t"; // Табуляция
            if (rbtnSemicolon.Checked) return ";"; // Точка с запятой
            if (rbtnComma.Checked) return ","; // Запятая
            if (rbtnDot.Checked) return "."; // Точка
            if (rbtnSpace.Checked) return " "; // Пробел
            return txtCustomSeparator.Text; // Кастомный разделитель
        }
        private void ImportDataToDatabase(string[] lines, string importType, string separator, bool hasHeaders, bool validateStructure)
        {
            // Проверяем, есть ли данные в файле
            if (lines.Length == 0)
            {
                throw new Exception("Файл пуст или некорректен.");
            }

            // Пропускаем заголовок, если нужно
            var data = lines
                .Skip(hasHeaders ? 1 : 0)
                .Select(line => line.Split(new[] { separator }, StringSplitOptions.None))
                .ToList();

            // Если требуется проверка структуры данных
            if (validateStructure)
            {
                ValidateDataStructure(data);
            }

            // Логика импорта
            if (importType == "New")
            {
                // Импорт в новый справочник
                CreateNewReference(data);
            }
            else if (importType == "Existing")
            {
                // Добавление данных в существующий справочник
                AddToExistingReference(data);
            }
        }
        private void CreateNewReference(List<string[]> data)
        {
            string referenceName = cmbReferenceName.Text;

            // Пример SQL-запроса для создания таблицы и вставки данных
            using (var connection = new SqlConnection("your_connection_string"))
            {
                connection.Open();
                var createTableCmd = new SqlCommand($"CREATE TABLE {referenceName} (...)", connection);
                createTableCmd.ExecuteNonQuery();

                foreach (var row in data)
                {
                    var insertCmd = new SqlCommand($"INSERT INTO {referenceName} VALUES (...)", connection);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        private void ValidateDataStructure(List<string[]> data)
        {
            int columnCount = data[0].Length; // Количество колонок по первой строке

            // Проверяем, что каждая строка содержит одинаковое количество колонок
            foreach (var row in data)
            {
                if (row.Length != columnCount)
                {
                    throw new Exception("Несовпадение структуры данных. Проверьте количество колонок.");
                }
            }
        }
        private void AddToExistingReference(List<string[]> data)
        {
            string referenceName = cmbReferenceName.Text;

            using (var connection = new SqlConnection("your_connection_string"))
            {
                connection.Open();

                foreach (var row in data)
                {
                    var insertCmd = new SqlCommand($"INSERT INTO {referenceName} VALUES (...)", connection);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }
        private void BulkInsertData(List<string[]> data, string tableName)
        {
            using (var connection = new SqlConnection("your_connection_string"))
            {
                connection.Open();

                using (var bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = tableName;

                    var dataTable = ConvertToDataTable(data);
                    bulkCopy.WriteToServer(dataTable);
                }
            }
        }

        private DataTable ConvertToDataTable(List<string[]> data)
        {
            var table = new DataTable();

            // Добавляем колонки
            for (int i = 0; i < data[0].Length; i++)
            {
                table.Columns.Add($"Column{i + 1}");
            }

            // Добавляем строки
            foreach (var row in data)
            {
                table.Rows.Add(row);
            }

            return table;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Получаем путь к файлу
            string filePath = txtFilePath.Text;

            // Проверяем, выбран ли файл
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Пожалуйста, выберите корректный файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Определяем параметры импорта
            string importType = rbtnNewReference.Checked ? "New" : "Existing";
            string separator = GetSelectedSeparator();
            bool hasHeaders = chkHeaders.Checked;
            bool validateStructure = chkValidate.Checked;

            try
            {
                // Читаем файл
                var lines = File.ReadAllLines(filePath);

                // Импортируем данные
                ImportDataToDatabase(lines, importType, separator, hasHeaders, validateStructure);

                MessageBox.Show("Импорт данных успешно завершён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

