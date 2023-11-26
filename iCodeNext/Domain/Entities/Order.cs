namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public string Code { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
}
