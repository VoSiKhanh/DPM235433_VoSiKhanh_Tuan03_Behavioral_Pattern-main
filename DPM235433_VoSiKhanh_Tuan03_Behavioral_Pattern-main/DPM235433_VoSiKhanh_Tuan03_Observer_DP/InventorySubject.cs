namespace DPM235433_VoSiKhanh_Tuan03_Observer_DP;

/// <summary>Concrete Subject: Kho hang phat su kien khi ton kho thay doi</summary>
public class InventorySubject : ISubject
{
    private readonly List<IObserver> _observers = new();
    private readonly Dictionary<string, int> _stock = new()
    {
        { "Thuoc tru sau Furadan", 120 },
        { "Phan bon NPK 20-20-15", 300 },
        { "Hat giong lua OM5451",  80  },
    };
    private const int LOW_THRESHOLD = 50;

    public void Subscribe(IObserver o)
    {
        _observers.Add(o);
        Console.WriteLine($"  [DANG KY] {o.GetType().Name} da dang ky theo doi ton kho.");
    }

    public void Unsubscribe(IObserver o)
    {
        _observers.Remove(o);
        Console.WriteLine($"  [HUY] {o.GetType().Name} da huy theo doi.");
    }

    public void Notify(string product, int remaining)
    {
        Console.WriteLine($"  [SUBJECT] Phat su kien: '{product}' con {remaining}.");
        foreach (var obs in _observers) obs.Update(product, remaining);
    }

    public void SellProduct(string product, int qty)
    {
        if (!_stock.ContainsKey(product)) { Console.WriteLine($"  San pham '{product}' khong ton tai!"); return; }
        _stock[product] = Math.Max(0, _stock[product] - qty);
        Console.WriteLine($"\n  [KHO] Ban {qty} '{product}'. Con lai: {_stock[product]}");
        if (_stock[product] <= LOW_THRESHOLD)
            Notify(product, _stock[product]);
    }

    public void PrintStock()
    {
        Console.WriteLine("\n  === TON KHO ===");
        foreach (var kv in _stock)
            Console.WriteLine($"  - {kv.Key}: {kv.Value} (nguong: {LOW_THRESHOLD})");
    }
}