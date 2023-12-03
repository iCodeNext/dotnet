﻿namespace WithIn.Domain.Entities;

public class User : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }

    public ICollection<Order> Orders { get; set; }
}
