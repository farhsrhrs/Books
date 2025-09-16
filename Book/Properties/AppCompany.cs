using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Book.Services;
using Npgsql;
//using Book.Models;

namespace Book
{
    public class AppCompany
    {
        private readonly CompanyService _companyService;


        private readonly string _connectionString;


        public AppCompany(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _companyService = new CompanyService(_connectionString); // ← ОБЯЗАТЕЛЬНО
        }

        public void EnableDragDrop(PictureBox pictureBox)
        {
            pictureBox.AllowDrop = true;

            pictureBox.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
            };

            pictureBox.DragDrop += (s, e) =>
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                    pictureBox.Image = Image.FromFile(files[0]);
            };
        }
        // Добавление компании через форму
        public void AddCompany(TextBox txtName, TextBox txtOrganization, TextBox txtPhone, PictureBox pictureBox, DataGridView dgvCompanies)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtOrganization.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                byte[] logoBytes = null;
                if (pictureBox.Image != null)
                {
                    using (var ms = new System.IO.MemoryStream())
                    {
                        pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                        logoBytes = ms.ToArray();
                    }
                }

                var company = new Company
                {
                    Name = txtName.Text,
                    Organization = txtOrganization.Text,
                    Phone = txtPhone.Text,
                    Logo = logoBytes
                };

                _companyService.AddCompany(company);

                MessageBox.Show("Компания успешно добавлена!");

                // Обновление DataGridView после добавления
                LoadCompanies(dgvCompanies);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении компании: " + ex.Message);
            }
        }

        // Загрузка компаний в DataGridView
        public void LoadCompanies(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            // Создаём колонки
            dgv.Columns.Add("Id", "ID");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("Phone", "Телефон");
            dgv.Columns.Add("Organization", "Организация");

            // Колонка для логотипа
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Logo";
            imgCol.HeaderText = "Логотип";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv.Columns.Add(imgCol);

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id, name, phone, organization, logo FROM company", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string phone = reader.GetString(2);
                        string org = reader.GetString(3);

                        Image logoImg = null;
                        if (!reader.IsDBNull(4))
                        {
                            byte[] logoBytes = (byte[])reader[4];
                            using (var ms = new MemoryStream(logoBytes))
                            {
                                logoImg = Image.FromStream(ms);
                            }
                        }

                        dgv.Rows.Add(id, name, phone, org, logoImg);
                    }
                }
            }
        }
    }
}
