﻿using WithIn.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace WithIn.Infrastructure.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<User> User { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
}