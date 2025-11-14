using System;
using System.Collections.Generic;

namespace BudgetTracker.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public int Price { get; set; }

    public string Category { get; set; } = null!;

    public string Date { get; set; } = null!;

    public string Description { get; set; } = null!;
}
