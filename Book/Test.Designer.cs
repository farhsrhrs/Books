using System;
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
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
            this.btnAdd.Location = new System.Drawing.Point(243, 102);
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
            this.comboGenre.Location = new System.Drawing.Point(83, 104);
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
            this.lblGenre.Location = new System.Drawing.Point(13, 107);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Добавить Склад";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Добавить Компанию";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(776, 513);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Создание заказа";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.tabPage4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}
