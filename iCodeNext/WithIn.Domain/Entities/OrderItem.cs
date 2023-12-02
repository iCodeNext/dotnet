namespace WithIn.Domain.Entities;

public class OrderItem : IEntity
{
    public int Id { get; set; }

    public int OderId { get; set; }
    public Order Order { get; set; }

    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}
