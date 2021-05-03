using FinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Interfaces
{
    public interface IExpensesRepo
    {
        IEnumerable<Expense> GetAllExpenses();
        IEnumerable<Expense> GetExpensesByCategory(string category);
        IEnumerable<Expense> GetExpensesBySubcategory(string subcategory);
    }
}
