using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class Expense
    {
        public string Category { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal Total { get; set; }
    }
}
