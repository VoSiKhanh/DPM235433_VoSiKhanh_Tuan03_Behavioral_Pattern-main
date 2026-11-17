namespace DPM235433_VoSiKhanh_Tuan03_Mediator_DP;

/// <summary>Concrete Component: Module Kho Hang</summary>
public class WarehouseComponent : BaseComponent
{
    private Dictionary<string, int> _stock = new()
    {
        { "Thuoc tru sau Furadan", 150 },
        { "Phan bon NPK",          300 },
        { "Hat giong lua OM18",    200 },
    };

    public WarehouseComponent(IMediator mediator) : base(mediator, "Kho Hang") { }

    public bool CheckStock(string product, int qty)
    {
        bool ok = _stock.ContainsKey(product) && _stock[product] >= qty;
        int cur = _stock.ContainsKey(product) ? _stock[product] : 0;
        Console.WriteLine($"  [{Name}] Kiem tra '{product}': co {cur}, can {qty} => {(ok ? "DU HANG" : "KHONG DU")}");
        return ok;
    }

    public void ReduceStock(string product, int qty)
    {
        if (!_stock.ContainsKey(product)) return;
        _stock[product] -= qty;
        Console.WriteLine($"  [{Name}] Xuat {qty} '{product}'. Con lai: {_stock[product]}");
        _mediator.Notify(this, "STOCK_CHANGED", (product, _stock[product]));
    }
}