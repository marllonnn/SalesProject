using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary {get; set; }

        public Department Department { get; set; }

        public ICollection<SalesRecord> Sr { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
           Sr.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            Sr.Remove(salesRecord);
        }

        public double TotalSales (DateTime initial,DateTime final)
        {
            return Sr.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);

        }


    }
}
