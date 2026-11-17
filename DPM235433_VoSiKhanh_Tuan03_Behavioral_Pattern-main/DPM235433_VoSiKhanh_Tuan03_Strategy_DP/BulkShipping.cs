namespace DPM235433_VoSiKhanh_Tuan03_Strategy_DP;

/// <summary>Concrete Strategy: Van chuyen so luong lon - 8,000d/km, giam 5% neu don tren 10 trieu</summary>
public class BulkShipping : IShippingStrategy
{
    public string StrategyName => "Van Chuyen So Luong Lon (Bulk)";

    public double Calculate(double distanceKm, double weightKg, double orderValue)
    {
        double fee = distanceKm * 8_000 + weightKg * 1_000;
        if (orderValue >= 10_000_000)
        {
            fee *= 0.95;
            Console.WriteLine("    Don hang tren 10tr: giam them 5% phi van chuyen!");
        }
        Console.WriteLine($"    Cong thuc: {distanceKm}km x 8,000 + {weightKg}kg x 1,000 = {fee:N0}d");
        return fee;
    }
}