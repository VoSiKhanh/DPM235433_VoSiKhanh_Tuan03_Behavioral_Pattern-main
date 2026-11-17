namespace DPM235433_VoSiKhanh_Tuan03_Strategy_DP;

/// <summary>Concrete Strategy: Van chuyen nhanh - 30,000d/km + 5,000d/kg + 20,000d co dinh</summary>
public class ExpressShipping : IShippingStrategy
{
    public string StrategyName => "Van Chuyen Nhanh (Express)";

    public double Calculate(double distanceKm, double weightKg, double orderValue)
    {
        double fee = distanceKm * 30_000 + weightKg * 5_000 + 20_000;
        Console.WriteLine($"    Cong thuc: {distanceKm}km x 30,000 + {weightKg}kg x 5,000 + 20,000 = {fee:N0}d");
        return fee;
    }
}