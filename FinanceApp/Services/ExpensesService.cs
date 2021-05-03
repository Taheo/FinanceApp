using FinanceApp.Models;
using FinanceApp.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public class ExpensesService
    {
        private readonly ExpensesRepo _expensesRepo;
        public ExpensesService(ExpensesRepo expensesRepo)
        {
            _expensesRepo = expensesRepo;
        }
        public IEnumerable<Expense> GetAllExpenses() => _expensesRepo.GetAllExpenses();
    }
}
