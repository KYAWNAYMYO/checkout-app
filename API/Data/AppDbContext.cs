using System;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Transaction> Transactions { get; set; }

    public DbSet<CustomerCard> CustomerCards { get; set; }
}
