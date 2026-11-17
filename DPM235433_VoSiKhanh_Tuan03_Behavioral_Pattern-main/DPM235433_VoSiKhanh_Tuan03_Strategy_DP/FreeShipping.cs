namespace DPM235433_VoSiKhanh_Tuan03_Strategy_DP;

/// <summary>Concrete Strategy: Mien phi van chuyen - danh cho khach hang VIP</summary>
public class FreeShipping : IShippingStrategy
{
    public string StrategyName => "Mien Phi Van Chuyen (VIP)";

    public double Calculate(double distanceKm, double weightKg, double orderValue)
    {
        Console.WriteLine("    Khach hang VIP - MIEN PHI VAN CHUYEN!");
        return 0;
    }
}