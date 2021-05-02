using FinanceApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinanceAppTests
{
    [TestClass]
    public class ExpensesServicesTests
    {
        private ExpensesService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new ExpensesService();
        }

        [TestMethod]
        public void GetAllExpensesShouldNotBeNull()
        {
            var expenses = _service.GetAllExpenses();
            Assert.IsNotNull(expenses);
        }
    }
}
