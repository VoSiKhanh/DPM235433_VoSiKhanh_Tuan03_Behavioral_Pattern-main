namespace DPM235433_VoSiKhanh_Tuan03_Observer_DP;

/// <summary>Concrete Observer: Tu dong tao phieu dat hang khi hang sap het</summary>
public class AutoPurchaseOrder : IObserver
{
    public void Update(string product, int remaining)
    {
        Console.WriteLine($"    [HE THONG] Tu dong tao Phieu Nhap #{DateTime.Now:yyyyMMddHHmm}: dat 200 '{product}'.");
    }
}