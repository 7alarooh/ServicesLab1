using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesLab1.Models;
namespace ServicesLab1.Repositories
{
    public class TransactionRepository : IRepository<Transaction>, ITransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _context.Transactions.ToList();
        }

        public Transaction GetById(int id)
        {
            return _context.Transactions.Find(id);
        }

        public void Add(Transaction entity)
        {
            _context.Transactions.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Transaction entity)
        {
            _context.Transactions.Update(entity);
            _context.SaveChanges();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var transaction = _context.Transactions.Find(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
        }
    }
}
