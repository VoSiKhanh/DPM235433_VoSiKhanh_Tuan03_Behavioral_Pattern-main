namespace DPM235433_VoSiKhanh_Tuan03_Memento_DP;

/// <summary>Originator: Hoa don goc - co the luu va phuc hoi trang thai</summary>
public class OrderOriginator
{
    public string CustomerName { get; set; } = "";
    public string ProductName  { get; set; } = "";
    public int    Quantity     { get; set; }
    public double UnitPrice    { get; set; }
    public double Discount     { get; set; }
    public double ShippingFee  { get; set; }

    public double TotalAmount =>
        UnitPrice * Quantity * (1 - Discount / 100) + ShippingFee;

    public OrderMemento Save()
    {
        Console.WriteLine("  [SAVE] Luu snapshot hoa don...");
        return new OrderMemento(CustomerName, ProductName, Quantity,
                                UnitPrice, Discount, ShippingFee);
    }

    public void Restore(OrderMemento m)
    {
        CustomerName = m.CustomerName; ProductName = m.ProductName;
        Quantity = m.Quantity; UnitPrice = m.UnitPrice;
        Discount = m.Discount; ShippingFee = m.ShippingFee;
        Console.WriteLine($"  [RESTORE] Khoi phuc hoa don tu snapshot luc {m.SavedAt:HH:mm:ss}");
    }

    public void Print()
    {
        Console.WriteLine($"  Khach hang : {CustomerName}");
        Console.WriteLine($"  San pham   : {ProductName} x {Quantity}");
        Console.WriteLine($"  Don gia    : {UnitPrice:N0}d");
        Console.WriteLine($"  Giam gia   : {Discount}%");
        Console.WriteLine($"  Van chuyen : {ShippingFee:N0}d");
        Console.WriteLine($"  TONG CONG  : {TotalAmount:N0}d");
    }
}