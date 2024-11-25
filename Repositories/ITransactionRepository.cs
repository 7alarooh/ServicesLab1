using ServicesLab1.Models;

namespace ServicesLab1.Repositories
{
    public interface ITransactionRepository
    {
        void Add(Transaction entity);
        void Delete(int id);
        IEnumerable<Transaction> GetAll();
        Transaction GetById(int id);
        void Update(Transaction entity);
    }
}