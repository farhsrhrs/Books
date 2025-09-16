using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;
//using Book.Models;

namespace Book
{
    public class CompanyService
    {
        private readonly string _connectionString;

        public CompanyService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Добавление новой компании
        public Company GetCompanyById(int id)
        {
            return GetAllCompanies().FirstOrDefault(c => c.Id == id);
        }

        public void AddCompany(string name, string organization, string phone, byte[] logo)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO companies (name, organization, phone, logo) VALUES (@name, @org, @phone, @logo)", conn))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("org", organization);
                    cmd.Parameters.AddWithValue("phone", phone);
                    cmd.Parameters.AddWithValue("logo", logo ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddCompany(Company company)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO company (name, organization, phone, logo)
                        VALUES (@name, @organization, @phone, @logo)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("name", company.Name);
                        cmd.Parameters.AddWithValue("organization", company.Organization ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("phone", company.Phone ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("logo", company.Logo ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении компании: " + ex.Message);
            }
        }

        // Получение всех компаний
        public List<Company> GetAllCompanies()
        {
            var companies = new List<Company>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "SELECT id, name, organization, phone, logo FROM company";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            companies.Add(new Company
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Organization = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Logo = reader.IsDBNull(4) ? null : (byte[])reader[4]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при загрузке компаний: " + ex.Message);
            }

            return companies;
        }
    }
}
