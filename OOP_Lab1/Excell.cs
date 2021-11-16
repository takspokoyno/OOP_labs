using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using OOP_lab1;

namespace OOP_lab1
{
    public partial class Excell : Form
    {
        Table table = new Table();
        public Excell()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            InitializeDataGridView(table.rowCount, table.colCount);
            splitContainer1.IsSplitterFixed = true;
        }


        private void InitializeDataGridView(int rows, int columns)
        {
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.ColumnCount = columns;
            for (int i = 0; i < columns; i++)
            {
                string columnName = NumberConverter.To26System(i);
                dataGridView1.Columns[i].Name = columnName;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Rows.Add("");
                dataGridView1.Rows[i].HeaderCell.Value = (i).ToString();
            }
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            table.setTable(columns, rows);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int col = dataGridView1.SelectedCells[0].ColumnIndex;
            int row = dataGridView1.SelectedCells[0].RowIndex;
            string expression = textBox.Text;
            if (expression == "") return;
            table.ChangeCellWithAllPointers(row, col, expression, dataGridView1);
            dataGridView1[col, row].Value = Table.grid[row][col].value;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = dataGridView1.SelectedCells[0].ColumnIndex;
            int row = dataGridView1.SelectedCells[0].RowIndex;
            string expression = Table.grid[row][col].expression;
            string value = Table.grid[row][col].value;
            textBox.Text = expression;
            textBox.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Ви точно бажаєте закрити таблицю?", "Закрити таблицю?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userAnswer == DialogResult.Yes)
                this.Dispose();
            else if (userAnswer == DialogResult.No)
                e.Cancel = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TableFile|*.txt";
            saveFileDialog.Title = "Save table file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fs);
                table.Save(sw);
                sw.Close();
                fs.Close();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TableFile|*.txt";
            openFileDialog.Title = "Open Table File";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            table.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int row; int column;
            Int32.TryParse(sr.ReadLine(), out row);
            Int32.TryParse(sr.ReadLine(), out column);
            InitializeDataGridView(row, column);
            table.Open(row, column, sr, dataGridView1);
            sr.Close();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вітаємо у додатку Table Editor!\nПрограма надає змогу виконувати обрахунки з використанням операцій:\n +, -,"
                + " /, *, ^\n <=, <, >, >=, =, <>\n X mod Y, X div Y, max(X,Y), min(X,Y).\nУ полі для введеня необхідно вводити числове значення" +
                " (напр., 47) або вираз (обов'язково використовуючи = на початку виразу).\n" +
                "Існує можливість додавати та видаляти колонки та рядки," +
                "\nа також зберігати та читати Вашу таблицю.";
            MessageBox.Show(message);
        }
        
        private void MeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Лабораторна робота 1 варіант 22\nВиконав: Бурлака Владислав К27";
            MessageBox.Show(message);
        }

        private void AddRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new System.Windows.Forms.DataGridViewRow();
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("There are no columns!");
                return;
            }
            dataGridView1.Rows.Add(row);
            dataGridView1.Rows[table.rowCount].HeaderCell.Value = (table.rowCount).ToString();
            table.AddRow(dataGridView1);
        }

        private void AddColToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string name = NumberConverter.To26System(table.colCount);
            dataGridView1.Columns.Add(name, name);
            table.AddColumn(dataGridView1);
        }

        private void DelRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!table.DeleteRow(dataGridView1))
                return;
            dataGridView1.Rows.RemoveAt(table.rowCount);
        }

        private void DelColToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!table.DeleteColumn(dataGridView1))
                return;
            dataGridView1.Columns.RemoveAt(table.colCount);
        }

        private void ExpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpToolStripMenuItem.Checked = true;
            ExpToolStripMenuItem.Enabled = false;
            ValToolStripMenuItem.Checked = false;
            ValToolStripMenuItem.Enabled = true;
            ToggleFormulaView(true);
        }

        private void ValToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValToolStripMenuItem.Checked = true;
            ValToolStripMenuItem.Enabled = false;
            ExpToolStripMenuItem.Checked = false;
            ExpToolStripMenuItem.Enabled = true;
            ToggleFormulaView(false);
        }
        private void ToggleFormulaView(bool a)
        {
            if (a)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell dgvCell in row.Cells)
                    {
                        int r = row.Index;
                        int c = dgvCell.ColumnIndex;
                        Cell cell = Table.grid[r][c];
                        dgvCell.Value = cell.expression;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell dgvCell in row.Cells)
                    {
                        int r = row.Index;
                        int c = dgvCell.ColumnIndex;
                        Cell cell = Table.grid[r][c];
                        dgvCell.Value = cell.value;
                    }
                }
            }

        }
    }
}