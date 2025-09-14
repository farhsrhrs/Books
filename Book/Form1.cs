namespace BookCollectionModule
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.RadioButton rbAuthor;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;

        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox { PlaceholderText = "Название" };
            this.txtAuthor = new System.Windows.Forms.TextBox { PlaceholderText = "Автор" };
            this.txtYear = new System.Windows.Forms.TextBox { PlaceholderText = "Год" };
            this.btnAdd = new System.Windows.Forms.Button { Text = "Добавить" };
            this.btnRemove = new System.Windows.Forms.Button { Text = "Удалить" };
            this.listBooks = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox { PlaceholderText = "Поиск" };
            this.rbTitle = new System.Windows.Forms.RadioButton { Text = "По названию", Checked = true };
            this.rbAuthor = new System.Windows.Forms.RadioButton { Text = "По автору" };
            this.btnFind = new System.Windows.Forms.Button { Text = "Найти" };
            this.btnShowAll = new System.Windows.Forms.Button { Text = "Показать все" };

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);

            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbTitle);
            this.Controls.Add(this.rbAuthor);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);

            this.Text = "Book Manager";
            this.ClientSize = new System.Drawing.Size(600, 400);
        }
    }
}
