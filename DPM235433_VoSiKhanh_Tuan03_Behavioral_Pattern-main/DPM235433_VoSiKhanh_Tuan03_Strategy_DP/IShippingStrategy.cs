namespace DPM235433_VoSiKhanh_Tuan03_Strategy_DP;

/// <summary>Strategy Interface: giao dien tinh phi van chuyen</summary>
public interface IShippingStrategy
{
    string StrategyName { get; }
    double Calculate(double distanceKm, double weightKg, double orderValue);
}