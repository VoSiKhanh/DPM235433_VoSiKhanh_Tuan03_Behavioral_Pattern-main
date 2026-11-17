namespace DPM235433_VoSiKhanh_Tuan03_Observer_DP;

/// <summary>Concrete Observer: Gui thong bao email cho quan ly</summary>
public class ManagerNotifier : IObserver
{
    private readonly string _manager;
    public ManagerNotifier(string manager) => _manager = manager;

    public void Update(string product, int remaining)
    {
        Console.WriteLine($"    [EMAIL -> {_manager}] Ton kho thap: '{product}' con {remaining}. Vui long kiem tra!");
    }
}