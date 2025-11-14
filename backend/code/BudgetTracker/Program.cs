using BudgetTracker.Models;
using BudgetTracker.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<BudgetTrackerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BudgetTracker")));

// Add your service
builder.Services.AddScoped<TransactionService>();

var app = builder.Build();

// Example endpoint to get all transactions
app.MapGet("/transactions", (TransactionService service) =>
{
    return service.GetAllTransactions();
});

app.Run();
