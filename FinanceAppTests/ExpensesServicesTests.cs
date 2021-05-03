using FinanceApp.Interfaces;
using FinanceApp.Repos;
using FinanceApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinanceAppTests
{
    [TestClass]
    public class ExpensesServicesTests
    {
        private readonly ExpensesService _service;
        private readonly ExpensesRepo _repo;

        public ExpensesServicesTests(ExpensesRepo repo, ExpensesService service)
        {
            _repo = repo;
            _service = new ExpensesService(_repo);
        }

        //[TestInitialize]
        //public void Setup(IExpensesRepo repo, ExpensesService service)
        //{
        //    _repo = repo;
        //    _service = new ExpensesService(_repo);
        //}

        [TestMethod]
        public void GetAllExpensesShouldNotBeNull()
        {
            var expenses = _service.GetAllExpenses();
            Assert.IsNotNull(expenses);
        }
    }
}
