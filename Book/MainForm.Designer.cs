using System.Windows.Forms;

namespace BookCollectionModule
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();

            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboCriteria = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCriteria = new System.Windows.Forms.Label();

            this.dgvBooks = new System.Windows.Forms.DataGridView();

            // 
            // groupAdd
            // 
            this.groupAdd.Text = "Добавить книгу";
            this.groupAdd.Location = new System.Drawing.Point(10, 10);
            this.groupAdd.Size = new System.Drawing.Size(400, 150);
            this.groupAdd.Controls.Add(this.txtTitle);
            this.groupAdd.Controls.Add(this.txtAuthor);
            this.groupAdd.Controls.Add(this.txtYear);
            this.groupAdd.Controls.Add(this.txtGenre);
            this.groupAdd.Controls.Add(this.lblTitle);
            this.groupAdd.Controls.Add(this.lblAuthor);
            this.groupAdd.Controls.Add(this.lblYear);
            this.groupAdd.Controls.Add(this.lblGenre);
            this.groupAdd.Controls.Add(this.btnAdd);

            // 
            // Labels & TextBoxes
            // 
            this.lblTitle.Text = "Название:";
            this.lblTitle.Location = new System.Drawing.Point(10, 25);
            this.txtTitle.Location = new System.Drawing.Point(100, 22);
            this.txtTitle.Width = 200;

            this.lblAuthor.Text = "Автор:";
            this.lblAuthor.Location = new System.Drawing.Point(10, 55);
            this.txtAuthor.Location = new System.Drawing.Point(100, 52);
            this.txtAuthor.Width = 200;

            this.lblYear.Text = "Год:";
            this.lblYear.Location = new System.Drawing.Point(10, 85);
            this.txtYear.Location = new System.Drawing.Point(100, 82);
            this.txtYear.Width = 80;

            this.lblGenre.Text = "Жанр:";
            this.lblGenre.Location = new System.Drawing.Point(10, 115);
            this.txtGenre.Location = new System.Drawing.Point(100, 112);
            this.txtGenre.Width = 150;

            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(260, 110);
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;

            // 
            // panelSearch
            // 
            this.panelSearch.Text = "Поиск";
            this.panelSearch.Location = new System.Drawing.Point(420, 10);
            this.panelSearch.Size = new System.Drawing.Size(350, 150);
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.comboCriteria);
            this.panelSearch.Controls.Add(this.btnFind);
            this.panelSearch.Controls.Add(this.btnShowAll);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.lblCriteria);

            this.lblSearch.Text = "Поиск:";
            this.lblSearch.Location = new System.Drawing.Point(10, 25);
            this.txtSearch.Location = new System.Drawing.Point(80, 22);
            this.txtSearch.Width = 200;

            this.lblCriteria.Text = "Критерий:";
            this.lblCriteria.Location = new System.Drawing.Point(10, 55);
            this.comboCriteria.Location = new System.Drawing.Point(80, 52);
            this.comboCriteria.Width = 150;
            this.comboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriteria.Items.AddRange(new object[] { "Название", "Автор", "Год", "Жанр" });

            this.btnFind.Text = "Найти";
            this.btnFind.Location = new System.Drawing.Point(80, 85);
            this.btnFind.BackColor = System.Drawing.Color.LightBlue;

            this.btnShowAll.Text = "Все книги";
            this.btnShowAll.Location = new System.Drawing.Point(170, 85);
            this.btnShowAll.BackColor = System.Drawing.Color.LightGray;

            // 
            // dgvBooks
            // 
            this.dgvBooks.Location = new System.Drawing.Point(10, 170);
            this.dgvBooks.Size = new System.Drawing.Size(760, 300);
            this.dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.groupAdd);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dgvBooks);
            this.Text = "Book Manager";
        }

        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboCriteria;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCriteria;

        private System.Windows.Forms.DataGridView dgvBooks;
    }
}
