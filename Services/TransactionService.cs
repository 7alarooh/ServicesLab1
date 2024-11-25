using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesLab1.Models;
using ServicesLab1.Repositories;

namespace ServicesLab1.Services
{
    public class TransactionService: ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactionRepository.Add(transaction);
            _transactionRepository.SaveChanges();  // Ensure changes are committed
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _transactionRepository.Update(transaction);
            _transactionRepository.SaveChanges();
        }

        public void DeleteTransaction(int transactionId)
        {
            _transactionRepository.Delete(transactionId);
            _transactionRepository.SaveChanges();
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return _transactionRepository.GetById(transactionId);
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _transactionRepository.GetAll();
        }
    }
}
