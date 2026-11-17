namespace DPM235433_VoSiKhanh_Tuan03_Mediator_DP;

/// <summary>Concrete Component: Module Quan ly Nhan Vien</summary>
public class StaffComponent : BaseComponent
{
    private Dictionary<string, int> _sales = new();

    public StaffComponent(IMediator mediator) : base(mediator, "Nhan Vien") { }

    public void RecordSale(string employee, int qty)
    {
        if (!_sales.ContainsKey(employee)) _sales[employee] = 0;
        _sales[employee] += qty;
        Console.WriteLine($"  [{Name}] Ghi nhan: {employee} ban them {qty}. Tong: {_sales[employee]}");
    }

    public void PrintBoard()
    {
        Console.WriteLine("\n  === BANG DOANH SO ===");
        foreach (var kv in _sales.OrderByDescending(x => x.Value))
            Console.WriteLine($"  - {kv.Key}: {kv.Value} san pham");
    }
}