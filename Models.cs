namespace QuestPdfDemo;

public class InvoiceModel
{
    public int InvoiceNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }

    public Address SellerAddress { get; set; } = new();
    public Address CustomerAddress { get; set; } = new();

    public List<OrderItem> Items { get; set; } = [];
    public string Comments { get; set; } = string.Empty;
}

public class OrderItem
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class Address
{
    public string CompanyName { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public object Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}
