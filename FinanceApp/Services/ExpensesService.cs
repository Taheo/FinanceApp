using FinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public class ExpensesService
    {
        public IEnumerable<Expense> GetAllExpenses()
        {
            Expense[] data = { new Expense { Category="Household", InsertDate=DateTime.UtcNow, Total=20.22M } };

            return data;
        }
    }
}
