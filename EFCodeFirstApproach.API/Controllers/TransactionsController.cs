using EFCodeFirstApproach.Service.Interfaces;
using EFCodeFirstApproach.Utils.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCodeFirstApproach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        // GET: api/<TransactionsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionDTO>>> GetTransactions()
        {
            return Ok(await _transactionService.GetAll());
        }

        // POST api/<TransactionsController>
        [HttpPost]
        public async Task<ActionResult<TransactionDTO>> AddTransaction(TransactionDTO transactionDTO)
        {
            await _transactionService.Add(transactionDTO);
            return Ok(transactionDTO);
        }
    }
}
