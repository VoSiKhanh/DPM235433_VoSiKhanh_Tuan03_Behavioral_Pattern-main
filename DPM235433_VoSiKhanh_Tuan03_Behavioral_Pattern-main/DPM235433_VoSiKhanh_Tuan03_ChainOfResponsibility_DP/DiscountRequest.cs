namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_DP;

/// <summary>Model: Yeu cau giam gia tu khach hang</summary>
public class DiscountRequest
{
    public string CustomerName { get; set; } = "";
    public string ProductName  { get; set; } = "";
    public double OrderValue   { get; set; }
    public double DiscountPct  { get; set; }
}
