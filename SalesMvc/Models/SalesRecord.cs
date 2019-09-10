﻿using System;
using SalesMvc.Models.Enums;

namespace SalesMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Selller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller selller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Selller = selller;
        }
    }
}
