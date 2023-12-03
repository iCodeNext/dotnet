namespace WithIn.Domain.Entities;

public class Order : IEntity
{
    public int Id { get; set; }
    public string Code { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
}
