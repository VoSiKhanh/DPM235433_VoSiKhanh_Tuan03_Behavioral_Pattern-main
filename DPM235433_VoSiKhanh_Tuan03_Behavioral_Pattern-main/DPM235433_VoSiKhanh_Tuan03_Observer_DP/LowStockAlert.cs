namespace DPM235433_VoSiKhanh_Tuan03_Observer_DP;

/// <summary>Concrete Observer: Hien thi canh bao khi hang sap het</summary>
public class LowStockAlert : IObserver
{
    public void Update(string product, int remaining)
    {
        Console.WriteLine($"    *** [CANH BAO DO] '{product}' chi con {remaining}! Can nhap them ngay! ***");
    }
}