using System;
using System.Windows.Forms;

namespace Book
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBookName.Text) && !string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                dataGridViewBooks.Rows.Add(txtBookName.Text, txtAuthor.Text, dtpDate.Value.ToShortDateString());
                toolStripStatusLabel.Text = "Книга добавлена.";
            }
            else
            {
                MessageBox.Show("Введите название и автора книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            dtpDate.Value = DateTime.Today;
            toolStripStatusLabel.Text = "Форма очищена.";
        }

        private void btnLoadBooks_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Обновление списка книг...";
            // Тут можно загрузить данные из БД/файла
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                dataGridViewBooks.Rows.RemoveAt(dataGridViewBooks.SelectedRows[0].Index);
                toolStripStatusLabel.Text = "Книга удалена.";
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
            {
                row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(search)
                           || row.Cells[1].Value.ToString().ToLower().Contains(search);
            }
            toolStripStatusLabel.Text = "Поиск выполнен.";
        }
    }
}
