using System;

namespace Book
{
    public class Company
    {
        public int Id { get; set; }                // Уникальный идентификатор
        public string Name { get; set; }           // Название компании
        public string Organization { get; set; }   // Организация
        public string Phone { get; set; }          // Телефон
        public byte[] Logo { get; set; }           // Логотип в виде байтов

        public Company() { }

        public Company(int id ,string name, string organization, string phone, byte[] logo)
        {
            Id = id;
            Name = name;
            Organization = organization;
            Phone = phone;
            Logo = logo;
        }
    }
}
