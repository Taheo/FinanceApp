using FinanceApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly ExpensesService _expensesService;
        public ExpensesController(ExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        [HttpGet]
        [Route("getAllExpenses")]
        public IActionResult GetAllExpenses()
        {
            var result = _expensesService.GetAllExpenses();

            return Ok(result);
        }
    }
}
