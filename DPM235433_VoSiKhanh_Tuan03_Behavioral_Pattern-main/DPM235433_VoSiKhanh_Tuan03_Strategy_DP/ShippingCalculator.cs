namespace DPM235433_VoSiKhanh_Tuan03_Strategy_DP;

/// <summary>Context: Su dung Strategy de tinh phi van chuyen, co the doi Strategy luc runtime</summary>
public class ShippingCalculator
{
    private IShippingStrategy _strategy;

    public ShippingCalculator(IShippingStrategy strategy) => _strategy = strategy;

    public void SetStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
        Console.WriteLine($"  [STRATEGY] Chuyen sang: {_strategy.StrategyName}");
    }

    public double CalculateShipping(double distanceKm, double weightKg, double orderValue)
    {
        Console.WriteLine($"  Chien luoc: [{_strategy.StrategyName}]");
        double fee = _strategy.Calculate(distanceKm, weightKg, orderValue);
        Console.WriteLine($"  => Phi van chuyen: {fee:N0}d\n");
        return fee;
    }
}