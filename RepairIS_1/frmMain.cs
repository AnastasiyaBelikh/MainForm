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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void панелиИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Все файлы (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Файл открыт: " + openFileDialog.FileName);
                }
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Все файлы (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Файл сохранен: " + saveFileDialog.FileName);
                }
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuFormatFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Выбран шрифт: " + fontDialog.Font.Name);
                }
            }
        }

        private void menuViewStatusBar_Click(object sender, EventArgs e)
        {
            statusBar.Visible = !statusBar.Visible;
            menuViewStatusBar.Checked = statusBar.Visible;
        }

        private void menuFormatColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Выбран цвет: " + colorDialog.Color.ToString());
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            menuFileOpen.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            menuFileSave.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menuFileExit.PerformClick();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открытие настроек...");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочная информация...");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabelUser_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = "Пользователь: " + Environment.UserName;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;  // Обновление каждую секунду
            timer.Tick += Timer1_Tick;
            timer.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

        }

        private void toolStripProgressBar_Click(object sender, EventArgs e)
        {

        }
        private void UpdateProgressBar(int progress)
        {
            toolStripProgressBar.Value = progress;
        }

        private void стандартнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            standardToolbar.Visible = !standardToolbar.Visible;
            menuViewToolbar.Checked = standardToolbar.Visible;
        }
    }
}
