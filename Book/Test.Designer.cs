using System;
using System.Drawing;
using System.Windows.Forms;

namespace Book
{
    partial class Test
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblRemoveId = new System.Windows.Forms.Label();
            this.txtRemoveId = new System.Windows.Forms.TextBox();
            this.btnRemoveById = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.comboCriteria = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxNameWarehouse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddWarehouseStock = new System.Windows.Forms.Button();
            this.dgvWarehouses = new System.Windows.Forms.DataGridView();
            this.buttonAddWarehouse = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelNameBook = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.comboNameBook = new System.Windows.Forms.ComboBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddShopping = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.comboWarehouse = new System.Windows.Forms.ComboBox();
            this.comboBook = new System.Windows.Forms.ComboBox();
            this.dgvShopping = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.lableOrganization = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewWarehouseStock = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopping)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouseStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBooks);
            this.tabPage1.Controls.Add(this.lblRemoveId);
            this.tabPage1.Controls.Add(this.txtRemoveId);
            this.tabPage1.Controls.Add(this.btnRemoveById);
            this.tabPage1.Controls.Add(this.btnExport);
            this.tabPage1.Controls.Add(this.panelSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(776, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск книг";
            // 
            // dgvBooks
            // 
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(8, 191);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(760, 309);
            this.dgvBooks.TabIndex = 9;
            // 
            // lblRemoveId
            // 
            this.lblRemoveId.Location = new System.Drawing.Point(552, 138);
            this.lblRemoveId.Name = "lblRemoveId";
            this.lblRemoveId.Size = new System.Drawing.Size(25, 20);
            this.lblRemoveId.TabIndex = 6;
            this.lblRemoveId.Text = "ID:";
            // 
            // txtRemoveId
            // 
            this.txtRemoveId.Location = new System.Drawing.Point(582, 135);
            this.txtRemoveId.Name = "txtRemoveId";
            this.txtRemoveId.Size = new System.Drawing.Size(80, 20);
            this.txtRemoveId.TabIndex = 7;
            // 
            // btnRemoveById
            // 
            this.btnRemoveById.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveById.Location = new System.Drawing.Point(682, 133);
            this.btnRemoveById.Name = "btnRemoveById";
            this.btnRemoveById.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveById.TabIndex = 8;
            this.btnRemoveById.Text = "Удалить";
            this.btnRemoveById.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Khaki;
            this.btnExport.Location = new System.Drawing.Point(607, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 40);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Экспорт в Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.lblCriteria);
            this.panelSearch.Controls.Add(this.comboCriteria);
            this.panelSearch.Controls.Add(this.btnFind);
            this.panelSearch.Controls.Add(this.btnShowAll);
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(350, 129);
            this.panelSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(10, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Поиск:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(70, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblCriteria
            // 
            this.lblCriteria.Location = new System.Drawing.Point(10, 55);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(60, 20);
            this.lblCriteria.TabIndex = 2;
            this.lblCriteria.Text = "Критерий:";
            // 
            // comboCriteria
            // 
            this.comboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriteria.Items.AddRange(new object[] {
            "Название",
            "Автор",
            "Год",
            "Жанр"});
            this.comboCriteria.Location = new System.Drawing.Point(70, 52);
            this.comboCriteria.Name = "comboCriteria";
            this.comboCriteria.Size = new System.Drawing.Size(150, 21);
            this.comboCriteria.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.LightBlue;
            this.btnFind.Location = new System.Drawing.Point(70, 85);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightGray;
            this.btnShowAll.Location = new System.Drawing.Point(170, 85);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Все книги";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxPrice);
            this.tabPage2.Controls.Add(this.lblTitle);
            this.tabPage2.Controls.Add(this.txtTitle);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.lblAuthor);
            this.tabPage2.Controls.Add(this.comboGenre);
            this.tabPage2.Controls.Add(this.txtAuthor);
            this.tabPage2.Controls.Add(this.lblGenre);
            this.tabPage2.Controls.Add(this.lblYear);
            this.tabPage2.Controls.Add(this.txtYear);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(776, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить книгу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(83, 100);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(13, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(83, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(243, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(13, 47);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 20);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Автор:";
            // 
            // comboGenre
            // 
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.Location = new System.Drawing.Point(83, 130);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(150, 21);
            this.comboGenre.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(83, 44);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(13, 131);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(60, 20);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Жанр:";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(13, 77);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 20);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Год:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(83, 74);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(80, 20);
            this.txtYear.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewWarehouseStock);
            this.tabPage3.Controls.Add(this.textBoxNameWarehouse);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.comboBoxWarehouse);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnAddWarehouseStock);
            this.tabPage3.Controls.Add(this.dgvWarehouses);
            this.tabPage3.Controls.Add(this.buttonAddWarehouse);
            this.tabPage3.Controls.Add(this.labelQuantity);
            this.tabPage3.Controls.Add(this.labelNameBook);
            this.tabPage3.Controls.Add(this.labelLocation);
            this.tabPage3.Controls.Add(this.comboNameBook);
            this.tabPage3.Controls.Add(this.textQuantity);
            this.tabPage3.Controls.Add(this.textLocation);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Добавить Склад";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxNameWarehouse
            // 
            this.textBoxNameWarehouse.Location = new System.Drawing.Point(156, 40);
            this.textBoxNameWarehouse.Name = "textBoxNameWarehouse";
            this.textBoxNameWarehouse.Size = new System.Drawing.Size(253, 20);
            this.textBoxNameWarehouse.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Название склада:";
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(471, 100);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(228, 21);
            this.comboBoxWarehouse.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Выбрать расположение склада";
            // 
            // btnAddWarehouseStock
            // 
            this.btnAddWarehouseStock.Location = new System.Drawing.Point(606, 462);
            this.btnAddWarehouseStock.Name = "btnAddWarehouseStock";
            this.btnAddWarehouseStock.Size = new System.Drawing.Size(148, 23);
            this.btnAddWarehouseStock.TabIndex = 8;
            this.btnAddWarehouseStock.Text = "Добавить товар на склад";
            this.btnAddWarehouseStock.UseVisualStyleBackColor = true;
            // 
            // dgvWarehouses
            // 
            this.dgvWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouses.Location = new System.Drawing.Point(11, 76);
            this.dgvWarehouses.Name = "dgvWarehouses";
            this.dgvWarehouses.Size = new System.Drawing.Size(221, 409);
            this.dgvWarehouses.TabIndex = 7;
            // 
            // buttonAddWarehouse
            // 
            this.buttonAddWarehouse.Location = new System.Drawing.Point(415, 40);
            this.buttonAddWarehouse.Name = "buttonAddWarehouse";
            this.buttonAddWarehouse.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWarehouse.TabIndex = 6;
            this.buttonAddWarehouse.Text = "Добавить";
            this.buttonAddWarehouse.UseVisualStyleBackColor = true;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(298, 160);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(63, 13);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Количетво:";
            // 
            // labelNameBook
            // 
            this.labelNameBook.AutoSize = true;
            this.labelNameBook.Location = new System.Drawing.Point(298, 133);
            this.labelNameBook.Name = "labelNameBook";
            this.labelNameBook.Size = new System.Drawing.Size(92, 13);
            this.labelNameBook.TabIndex = 4;
            this.labelNameBook.Text = "Название книги:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(8, 17);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(124, 13);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Расположение склада:";
            // 
            // comboNameBook
            // 
            this.comboNameBook.FormattingEnabled = true;
            this.comboNameBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboNameBook.Location = new System.Drawing.Point(446, 130);
            this.comboNameBook.Name = "comboNameBook";
            this.comboNameBook.Size = new System.Drawing.Size(253, 21);
            this.comboNameBook.TabIndex = 2;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(446, 157);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(253, 20);
            this.textQuantity.TabIndex = 1;
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(156, 14);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(253, 20);
            this.textLocation.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.btnAddShopping);
            this.tabPage5.Controls.Add(this.txtQuantity);
            this.tabPage5.Controls.Add(this.comboCompany);
            this.tabPage5.Controls.Add(this.comboWarehouse);
            this.tabPage5.Controls.Add(this.comboBook);
            this.tabPage5.Controls.Add(this.dgvShopping);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(776, 513);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Создание заказа";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Процент скидки: {{}}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "выбор компании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "выбор склада.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "выбор книги:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество";
            // 
            // btnAddShopping
            // 
            this.btnAddShopping.Location = new System.Drawing.Point(618, 431);
            this.btnAddShopping.Name = "btnAddShopping";
            this.btnAddShopping.Size = new System.Drawing.Size(75, 23);
            this.btnAddShopping.TabIndex = 5;
            this.btnAddShopping.Text = "Добавить";
            this.btnAddShopping.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(173, 89);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // comboCompany
            // 
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(173, 201);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(121, 21);
            this.comboCompany.TabIndex = 3;
            // 
            // comboWarehouse
            // 
            this.comboWarehouse.FormattingEnabled = true;
            this.comboWarehouse.Location = new System.Drawing.Point(173, 158);
            this.comboWarehouse.Name = "comboWarehouse";
            this.comboWarehouse.Size = new System.Drawing.Size(121, 21);
            this.comboWarehouse.TabIndex = 2;
            // 
            // comboBook
            // 
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(173, 118);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(121, 21);
            this.comboBook.TabIndex = 1;
            // 
            // dgvShopping
            // 
            this.dgvShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopping.Location = new System.Drawing.Point(31, 270);
            this.dgvShopping.Name = "dgvShopping";
            this.dgvShopping.Size = new System.Drawing.Size(513, 184);
            this.dgvShopping.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(776, 513);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Список заказов";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvCompanies);
            this.tabPage4.Controls.Add(this.buttonAddCompany);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.labelImage);
            this.tabPage4.Controls.Add(this.labelPhone);
            this.tabPage4.Controls.Add(this.lableOrganization);
            this.tabPage4.Controls.Add(this.labelName);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Добовление компании";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Location = new System.Drawing.Point(31, 236);
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.Size = new System.Drawing.Size(467, 243);
            this.dgvCompanies.TabIndex = 9;
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Location = new System.Drawing.Point(680, 468);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCompany.TabIndex = 8;
            this.buttonAddCompany.Text = "Добавить";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(484, 211);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(52, 13);
            this.labelImage.TabIndex = 4;
            this.labelImage.Text = "Логотип:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(58, 97);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Телефон:";
            // 
            // lableOrganization
            // 
            this.lableOrganization.AutoSize = true;
            this.lableOrganization.Location = new System.Drawing.Point(58, 71);
            this.lableOrganization.Name = "lableOrganization";
            this.lableOrganization.Size = new System.Drawing.Size(77, 13);
            this.lableOrganization.TabIndex = 2;
            this.lableOrganization.Text = "Организация:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(58, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel.Text = "Готово";
            // 
            // dataGridViewWarehouseStock
            // 
            this.dataGridViewWarehouseStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouseStock.Location = new System.Drawing.Point(301, 192);
            this.dataGridViewWarehouseStock.Name = "dataGridViewWarehouseStock";
            this.dataGridViewWarehouseStock.Size = new System.Drawing.Size(410, 251);
            this.dataGridViewWarehouseStock.TabIndex = 13;
            // 
            // Test
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека - Управление книгами";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopping)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouseStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label lblTitle;
        private TextBox txtTitle;
        private Button btnAdd;
        private Label lblAuthor;
        private ComboBox comboGenre;
        private TextBox txtAuthor;
        private Label lblGenre;
        private Label lblYear;
        private TextBox txtYear;
        private Button btnExport;
        private Panel panelSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCriteria;
        private ComboBox comboCriteria;
        private Button btnFind;
        private Button btnShowAll;
        private Label lblRemoveId;
        private TextBox txtRemoveId;
        private Button btnRemoveById;
        private DataGridView dgvBooks;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private PictureBox pictureBox1;
        private Label labelQuantity;
        private Label labelNameBook;
        private Label labelLocation;
        private ComboBox comboNameBook;
        private TextBox textQuantity;
        private TextBox textLocation;
        private Label labelName;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelImage;
        private Label labelPhone;
        private Label lableOrganization;
        private Button buttonAddCompany;
        private Button buttonAddWarehouse;
        private DataGridView dgvWarehouses;
        private DataGridView dgvCompanies;


        //

        //

        private Button btnAddShopping;
        private TextBox txtQuantity;
        private ComboBox comboCompany;
        private ComboBox comboWarehouse;
        private ComboBox comboBook;
        private DataGridView dgvShopping;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox textBoxPrice;
        private Label label7;
        private Button btnAddWarehouseStock;
        private ComboBox comboBoxWarehouse;
        private TextBox textBoxNameWarehouse;
        private Label label8;
        private DataGridView dataGridViewWarehouseStock;
    }
}
