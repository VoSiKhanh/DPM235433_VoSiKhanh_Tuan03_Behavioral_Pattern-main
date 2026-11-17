namespace DPM235433_VoSiKhanh_Tuan03_Command_DP;

/// <summary>Model: Lo hang nhap/xuat theo lo</summary>
public class Batch
{
    public string   BatchId      { get; set; } = "";
    public string   ProductName  { get; set; } = "";
    public int      Quantity     { get; set; }
    public DateTime ImportDate   { get; set; }
    public DateTime ExpiryDate   { get; set; }

    public override string ToString() =>
        $"[{BatchId}] {ProductName} | SL:{Quantity} | Nhap:{ImportDate:dd/MM/yyyy} | HSD:{ExpiryDate:dd/MM/yyyy}";
}