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
            this.lblCriteria = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.comboCriteria = new System.Windows.Forms.ComboBox();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(100, 50);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 80);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 20);
            this.txtYear.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(100, 320);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Название:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(20, 53);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(100, 23);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Автор:";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(20, 83);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(100, 23);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Год:";
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(20, 323);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Поиск:";
            // 
            // lblCriteria
            // 
            this.lblCriteria.Location = new System.Drawing.Point(317, 320);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(99, 20);
            this.lblCriteria.TabIndex = 8;
            this.lblCriteria.Text = "Критерий поиска:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(320, 50);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(320, 350);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Найти";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(440, 350);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Все книги";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // comboCriteria
            // 
            this.comboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriteria.Items.AddRange(new object[] {
            "Название",
            "Автор",
            "Год"});
            this.comboCriteria.Location = new System.Drawing.Point(422, 320);
            this.comboCriteria.Name = "comboCriteria";
            this.comboCriteria.Size = new System.Drawing.Size(120, 21);
            this.comboCriteria.TabIndex = 13;
            // 
            // listBooks
            // 
            this.listBooks.Location = new System.Drawing.Point(20, 120);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(500, 173);
            this.listBooks.TabIndex = 14;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblCriteria);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.comboCriteria);
            this.Controls.Add(this.listBooks);
            this.Name = "MainForm";
            this.Text = "Book Manager";
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
        protected System.Windows.Forms.Label lblCriteria;

        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Button btnRemove;
        protected System.Windows.Forms.Button btnFind;
        protected System.Windows.Forms.Button btnShowAll;

        protected System.Windows.Forms.ComboBox comboCriteria;

        protected System.Windows.Forms.ListBox listBooks;
    }
}
