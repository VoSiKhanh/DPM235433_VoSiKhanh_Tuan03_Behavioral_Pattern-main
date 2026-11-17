namespace DPM235433_VoSiKhanh_Tuan03_Strategy_DP;

/// <summary>Concrete Strategy: Van chuyen thuong - 15,000d/km + 2,000d/kg</summary>
public class StandardShipping : IShippingStrategy
{
    public string StrategyName => "Van Chuyen Thuong";

    public double Calculate(double distanceKm, double weightKg, double orderValue)
    {
        double fee = distanceKm * 15_000 + weightKg * 2_000;
        Console.WriteLine($"    Cong thuc: {distanceKm}km x 15,000 + {weightKg}kg x 2,000 = {fee:N0}d");
        return fee;
    }
}