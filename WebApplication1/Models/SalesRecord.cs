using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    public class SalesRecord
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus salesStatus { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus salesStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            this.salesStatus = salesStatus;
            Seller = seller;
        }
    }
}
