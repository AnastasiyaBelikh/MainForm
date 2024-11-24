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
    public partial class frmListWorkers : Form
    {
        public frmListWorkers()
        {
            InitializeComponent();
        }
        public TreeView TreeWorkers => treeWorkers;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeWorkers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1) // Уровень сотрудника
            {
                txtLastName.Text = "Иванов"; // Данные сотрудника
                txtFirstName.Text = "Иван";
                txtMiddleName.Text = "Иванович";
                txtPassportSeries.Text = "2222";
                txtPassportNumber.Text = "666666";
                txtAccountNumber.Text = "4040404040404040";
                txtAccountExpiry.Text = "1310";
            }
        }


        private void frmListWorkers_Load(object sender, EventArgs e)
        {
            // Иконки для TreeView
            ImageList imageList = new ImageList();
            imageList.Images.Add("male", Properties.Resources.male_icon); // Иконка для мужчин
            imageList.Images.Add("female", Properties.Resources.female_icon); // Иконка для женщин
            imageList.Images.Add("edit", Properties.Resources.edit_icon); // Иконка редактирования

            // Привязка ImageList к TreeView
            treeWorkers.ImageList = imageList;

            // Добавление корневого узла
            TreeNode rootNode = new TreeNode("Западный филиал РАНХиГС");
            treeWorkers.Nodes.Add(rootNode);

            // Добавление подузлов (сотрудников)
            rootNode.Nodes.Add(new TreeNode("Анфриев Иван Иванович") { ImageKey = "male" });
            rootNode.Nodes.Add(new TreeNode("Анисимова Валентина Григорьевна") { ImageKey = "female" });

            // Разворачивание корневого узла
            rootNode.Expand();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("Новый сотрудник") { ImageKey = "male" };
            treeWorkers.SelectedNode.Nodes.Add(newNode);
            treeWorkers.SelectedNode.Expand();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeWorkers.SelectedNode != null && treeWorkers.SelectedNode.Level == 1)
            {
                treeWorkers.Nodes.Remove(treeWorkers.SelectedNode);
                MessageBox.Show("Сотрудник удалён.");
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сохранены успешно.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка для блокировки/разблокировки ввода в "Персональные данные"
        private void btnTogglePersonalData_Click(object sender, EventArgs e)
        {
            // Переключаем доступ к элементам управления внутри группы
            foreach (Control control in grpPersonalData.Controls)
            {
                control.Enabled = !control.Enabled; // Меняем состояние Enabled
            }

            // Меняем текст кнопки в зависимости от текущего состояния
            btnTogglePersonalData.Text = grpPersonalData.Controls[0].Enabled
                ? "Блокировать данные"
                : "Разблокировать данные";
        }

        // Кнопка для блокировки/разблокировки ввода в "Банковская карта"
        private void btnToggleBankData_Click(object sender, EventArgs e)
        {
            // Переключаем доступ к элементам управления внутри группы
            foreach (Control control in grpBankDetails.Controls)
            {
                control.Enabled = !control.Enabled; // Меняем состояние Enabled
            }

            // Меняем текст кнопки в зависимости от текущего состояния
            btnToggleBankData.Text = grpBankDetails.Controls[0].Enabled
                ? "Блокировать данные"
                : "Разблокировать данные";
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        public void treeWorkers_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            // Создаём экземпляр формы frmWorker
            frmWorker workerForm = new frmWorker();

            // Открываем форму и ждем результат
            if (workerForm.ShowDialog() == DialogResult.OK)
            {
                // Получаем данные сотрудника из свойств формы workerForm
                string fullName = workerForm.FullName;
                string accountNumber = workerForm.AccountNumber;

                // Добавляем нового сотрудника в TreeView
                TreeNode newNode = new TreeNode(fullName) { ImageKey = "male" }; // Пример: мужская иконка
                treeWorkers.Nodes[0].Nodes.Add(newNode);

                // Показываем сообщение об успешном добавлении
                MessageBox.Show("Сотрудник добавлен успешно.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Проверяем, выбран ли узел
            if (treeWorkers.SelectedNode == null)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем имя сотрудника
            string selectedWorker = treeWorkers.SelectedNode.Text;

            // Подтверждение удаления
            var result = MessageBox.Show(
                $"Вы действительно хотите удалить {selectedWorker} из числа сотрудников?",
                "Удаление сотрудника",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Если пользователь подтвердил удаление
            if (result == DialogResult.Yes)
            {
                // Удаляем узел
                treeWorkers.Nodes.Remove(treeWorkers.SelectedNode);
                MessageBox.Show("Сотрудник успешно удален.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

