namespace DPM235433_VoSiKhanh_Tuan03_Memento_DP;

/// <summary>Memento: Snapshot bat bien cua trang thai hoa don</summary>
public class OrderMemento
{
    public string   CustomerName { get; }
    public string   ProductName  { get; }
    public int      Quantity     { get; }
    public double   UnitPrice    { get; }
    public double   Discount     { get; }
    public double   ShippingFee  { get; }
    public DateTime SavedAt      { get; }

    public OrderMemento(string customer, string product, int qty,
                        double price, double discount, double shipping)
    {
        CustomerName = customer; ProductName = product; Quantity = qty;
        UnitPrice = price; Discount = discount; ShippingFee = shipping;
        SavedAt = DateTime.Now;
    }

    public override string ToString() =>
        $"[{SavedAt:HH:mm:ss}] {CustomerName} - {ProductName} x{Quantity} | " +
        $"Gia:{UnitPrice:N0} | Giam:{Discount}% | Ship:{ShippingFee:N0}d";
}