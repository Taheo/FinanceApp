using FinanceApp.Interfaces;
using FinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Repos
{
    public class ExpensesRepo : IExpensesRepo
    {
        public ExpensesRepo()
        {

        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            Expense[] data = { new Expense { Category = new ExpenseCategory { CategoryName="House", SubcategoryName = "Rent" }, InsertDate = DateTime.UtcNow, Total = 20.22M } };

            return data;
        }

        public IEnumerable<Expense> GetExpensesByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expense> GetExpensesBySubcategory(string subcategory)
        {
            throw new NotImplementedException();
        }
    }
}
