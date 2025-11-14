using BudgetTracker.Models;

namespace BudgetTracker.Services
{
    public class TransactionService
    {
        private readonly BudgetTrackerContext _context;

        public TransactionService(BudgetTrackerContext context)
        {
            _context = context;
        }

        public List<Transaction> GetAllTransactions()
        {
            return _context.Transactions.ToList();
        }

        public Transaction? GetTransactionById(int id)
        {
            return _context.Transactions.FirstOrDefault(t => t.Id == id);
        }

        public List<Transaction> GetTransactionsByCategory(string category)
        {
            return _context.Transactions
                           .Where(t => t.Category == category)
                           .OrderByDescending(t => t.Date)
                           .ToList();
        }
    }

}
