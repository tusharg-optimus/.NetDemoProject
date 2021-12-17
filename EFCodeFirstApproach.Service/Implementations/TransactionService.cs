using EFCodeFirstApproach.DataAccess.Entity;
using EFCodeFirstApproach.Repository.Interfaces;
using EFCodeFirstApproach.Service.Interfaces;
using EFCodeFirstApproach.Utils.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Service.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
                _transactionRepository = transactionRepository;
        }
        public async Task<TransactionDTO> Add(TransactionDTO obj)
        {
            //Mapping TransactionDTO to Transaction
            var transaction = new Transaction
            {
                Id = obj.Id,
                TransactionType = obj.TransactionType,
                TransactionAmount = obj.TransactionAmount
            };
            var result = await _transactionRepository.Add(transaction);

            //Mapping from Transaction to TransactionDTO
            var transactionDTO = new TransactionDTO
            {
                Id = result.Id,
                TransactionType = result.TransactionType,
                TransactionAmount = result.TransactionAmount
            };
            return transactionDTO;
        }

        public async Task<IEnumerable<TransactionDTO>> GetAll()
        {
            List<TransactionDTO> lisTransactionDTOs = new List<TransactionDTO>();
            var result = await _transactionRepository.GetAll();
            foreach (var item in result)
            {
                var transactionDto = new TransactionDTO
                {
                    Id = item.Id,
                    TransactionAmount = item.TransactionAmount,
                    TransactionType = item.TransactionType
                };
                lisTransactionDTOs.Add(transactionDto);
            }
            return lisTransactionDTOs;
        }
    }
}
