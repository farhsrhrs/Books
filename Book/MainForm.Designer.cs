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
            this.btnExport = new Button();

            // ---------------- btnExport ----------------
            this.btnExport.Text = "Экспорт в Excel";
            this.btnExport.Location = new System.Drawing.Point(420, 180);
            this.btnExport.Size = new System.Drawing.Size(150, 40);
            this.btnExport.BackColor = System.Drawing.Color.Khaki;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // Добавляе
            this.Controls.Add(this.btnExport);

            this.groupAdd = new GroupBox();
            this.lblTitle = new Label();
            this.txtTitle = new TextBox();
            this.lblAuthor = new Label();
            this.txtAuthor = new TextBox();
            this.lblYear = new Label();
            this.txtYear = new TextBox();
            this.lblGenre = new Label();
            this.comboGenre = new ComboBox();
            this.btnAdd = new Button();

            this.groupRemove = new GroupBox();
            this.lblRemoveId = new Label();
            this.txtRemoveId = new TextBox();
            this.btnRemoveById = new Button();

            this.panelSearch = new Panel();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();
            this.lblCriteria = new Label();
            this.comboCriteria = new ComboBox();
            this.btnFind = new Button();
            this.btnShowAll = new Button();

            this.dgvBooks = new DataGridView();

            // ---------------- groupAdd ----------------
            this.groupAdd.Text = "Добавить книгу";
            this.groupAdd.Location = new System.Drawing.Point(10, 10);
            this.groupAdd.Size = new System.Drawing.Size(400, 160);
            this.groupAdd.Controls.Add(this.lblTitle);
            this.groupAdd.Controls.Add(this.txtTitle);
            this.groupAdd.Controls.Add(this.lblAuthor);
            this.groupAdd.Controls.Add(this.txtAuthor);
            this.groupAdd.Controls.Add(this.lblYear);
            this.groupAdd.Controls.Add(this.txtYear);
            this.groupAdd.Controls.Add(this.lblGenre);
            this.groupAdd.Controls.Add(this.comboGenre);
            this.groupAdd.Controls.Add(this.btnAdd);

            // Labels и TextBox для добавления
            this.lblTitle.Text = "Название:";
            this.lblTitle.Location = new System.Drawing.Point(10, 25);
            this.lblTitle.Size = new System.Drawing.Size(60, 20);
            this.txtTitle.Location = new System.Drawing.Point(80, 22);
            this.txtTitle.Width = 200;

            this.lblAuthor.Text = "Автор:";
            this.lblAuthor.Location = new System.Drawing.Point(10, 55);
            this.lblAuthor.Size = new System.Drawing.Size(60, 20);
            this.txtAuthor.Location = new System.Drawing.Point(80, 52);
            this.txtAuthor.Width = 200;

            this.lblYear.Text = "Год:";
            this.lblYear.Location = new System.Drawing.Point(10, 85);
            this.lblYear.Size = new System.Drawing.Size(60, 20);
            this.txtYear.Location = new System.Drawing.Point(80, 82);
            this.txtYear.Width = 80;

            this.lblGenre.Text = "Жанр:";
            this.lblGenre.Location = new System.Drawing.Point(10, 115);
            this.lblGenre.Size = new System.Drawing.Size(60, 20);
            this.comboGenre.Location = new System.Drawing.Point(80, 112);
            this.comboGenre.Width = 150;
            this.comboGenre.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(240, 110);
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // ---------------- groupRemove ----------------
            this.groupRemove.Text = "Удалить книгу по ID";
            this.groupRemove.Location = new System.Drawing.Point(10, 180);
            this.groupRemove.Size = new System.Drawing.Size(400, 60);
            this.groupRemove.Controls.Add(this.lblRemoveId);
            this.groupRemove.Controls.Add(this.txtRemoveId);
            this.groupRemove.Controls.Add(this.btnRemoveById);

            this.lblRemoveId.Text = "ID:";
            this.lblRemoveId.Location = new System.Drawing.Point(10, 25);
            this.lblRemoveId.Size = new System.Drawing.Size(25, 20);

            this.txtRemoveId.Location = new System.Drawing.Point(40, 22);
            this.txtRemoveId.Width = 80;

            this.btnRemoveById.Text = "Удалить";
            this.btnRemoveById.Location = new System.Drawing.Point(140, 20);
            this.btnRemoveById.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveById.Click += new System.EventHandler(this.btnRemoveById_Click);

            // ---------------- panelSearch ----------------
            this.panelSearch.Location = new System.Drawing.Point(420, 10);
            this.panelSearch.Size = new System.Drawing.Size(350, 160);
            this.panelSearch.BorderStyle = BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.lblCriteria);
            this.panelSearch.Controls.Add(this.comboCriteria);
            this.panelSearch.Controls.Add(this.btnFind);
            this.panelSearch.Controls.Add(this.btnShowAll);

            this.lblSearch.Text = "Поиск:";
            this.lblSearch.Location = new System.Drawing.Point(10, 25);
            this.lblSearch.Size = new System.Drawing.Size(50, 20);
            this.txtSearch.Location = new System.Drawing.Point(70, 22);
            this.txtSearch.Width = 200;

            this.lblCriteria.Text = "Критерий:";
            this.lblCriteria.Location = new System.Drawing.Point(10, 55);
            this.lblCriteria.Size = new System.Drawing.Size(60, 20);
            this.comboCriteria.Location = new System.Drawing.Point(70, 52);
            this.comboCriteria.Width = 150;
            this.comboCriteria.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnFind.Text = "Найти";
            this.btnFind.Location = new System.Drawing.Point(70, 85);
            this.btnFind.BackColor = System.Drawing.Color.LightBlue;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);

            this.btnShowAll.Text = "Все книги";
            this.btnShowAll.Location = new System.Drawing.Point(170, 85);
            this.btnShowAll.BackColor = System.Drawing.Color.LightGray;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);

            // ---------------- DataGridView ----------------
            this.dgvBooks.Location = new System.Drawing.Point(10, 250);
            this.dgvBooks.Size = new System.Drawing.Size(760, 220);
            this.dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ---------------- MainForm ----------------
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.groupAdd);
            this.Controls.Add(this.groupRemove);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dgvBooks);
            this.Text = "Book Manager";
        }

        private GroupBox groupAdd;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblGenre;
        private ComboBox comboGenre;
        private Button btnAdd;

        private GroupBox groupRemove;
        private Label lblRemoveId;
        private TextBox txtRemoveId;
        private Button btnRemoveById;

        private Panel panelSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCriteria;
        private ComboBox comboCriteria;
        private Button btnFind;
        private Button btnShowAll;

        private DataGridView dgvBooks;
        private Button btnExport;

    }
}
