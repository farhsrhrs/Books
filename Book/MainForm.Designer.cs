namespace BookCollectionModule
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();

            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.rbAuthor = new System.Windows.Forms.RadioButton();

            this.listBooks = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // 
            // Labels
            // 
            this.lblTitle.Text = "Название:";
            this.lblTitle.Left = 20; this.lblTitle.Top = 23;

            this.lblAuthor.Text = "Автор:";
            this.lblAuthor.Left = 20; this.lblAuthor.Top = 53;

            this.lblYear.Text = "Год:";
            this.lblYear.Left = 20; this.lblYear.Top = 83;

            this.lblSearch.Text = "Поиск:";
            this.lblSearch.Left = 20; this.lblSearch.Top = 323;

            // 
            // TextBoxes
            // 
            this.txtTitle.Left = 100; this.txtTitle.Top = 20; this.txtTitle.Width = 200;
            this.txtAuthor.Left = 100; this.txtAuthor.Top = 50; this.txtAuthor.Width = 200;
            this.txtYear.Left = 100; this.txtYear.Top = 80; this.txtYear.Width = 200;
            this.txtSearch.Left = 100; this.txtSearch.Top = 320; this.txtSearch.Width = 200;

            // 
            // Buttons
            // 
            this.btnAdd.Text = "Добавить"; this.btnAdd.Left = 320; this.btnAdd.Top = 20;
            this.btnRemove.Text = "Удалить"; this.btnRemove.Left = 320; this.btnRemove.Top = 50;
            this.btnFind.Text = "Найти"; this.btnFind.Left = 320; this.btnFind.Top = 350;
            this.btnShowAll.Text = "Все книги"; this.btnShowAll.Left = 440; this.btnShowAll.Top = 350;

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);

            // 
            // RadioButtons
            // 
            this.rbTitle.Text = "По названию"; this.rbTitle.Left = 320; this.rbTitle.Top = 320; this.rbTitle.Checked = true;
            this.rbAuthor.Text = "По автору"; this.rbAuthor.Left = 440; this.rbAuthor.Top = 320;

            // 
            // ListBox
            // 
            this.listBooks.Left = 20; this.listBooks.Top = 120; this.listBooks.Width = 540; this.listBooks.Height = 180;

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Book Manager";

            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.rbTitle);
            this.Controls.Add(this.rbAuthor);
            this.Controls.Add(this.listBooks);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        protected System.Windows.Forms.TextBox txtTitle;
        protected System.Windows.Forms.TextBox txtAuthor;
        protected System.Windows.Forms.TextBox txtYear;
        protected System.Windows.Forms.TextBox txtSearch;

        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Label lblAuthor;
        protected System.Windows.Forms.Label lblYear;
        protected System.Windows.Forms.Label lblSearch;

        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Button btnRemove;
        protected System.Windows.Forms.Button btnFind;
        protected System.Windows.Forms.Button btnShowAll;

        protected System.Windows.Forms.RadioButton rbTitle;
        protected System.Windows.Forms.RadioButton rbAuthor;

        protected System.Windows.Forms.ListBox listBooks;
    }
}
