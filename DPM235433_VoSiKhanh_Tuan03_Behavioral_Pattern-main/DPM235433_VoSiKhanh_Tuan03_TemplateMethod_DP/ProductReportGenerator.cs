namespace DPM235433_VoSiKhanh_Tuan03_TemplateMethod_DP;

/// <summary>Concrete Template: Bao cao hang hoa ban chay nhat</summary>
public class ProductReportGenerator : ReportGenerator
{
    protected override string GetReportTitle() => "  BAO CAO HANG HOA BAN CHAY";

    protected override List<SaleRecord> CollectData(DateTime from, DateTime to) =>
        FakeDatabase.Sales.Where(s => s.Date >= from && s.Date <= to).ToList();

    protected override Dictionary<string, double> ProcessData(List<SaleRecord> data) =>
        data.GroupBy(s => s.Product)
            .ToDictionary(g => g.Key, g => g.Sum(s => (double)s.Qty));

    protected override void PrintReport(Dictionary<string, double> data)
    {
        Console.WriteLine("  " + "San pham".PadRight(30) + "So luong".PadLeft(12));
        Console.WriteLine("  " + new string('-', 42));
        foreach (var kv in data.OrderByDescending(x => x.Value))
            Console.WriteLine("  " + kv.Key.PadRight(30) + kv.Value.ToString("N0").PadLeft(12) + " sp");
    }

    protected override void PrintSummary(Dictionary<string, double> data)
    {
        Console.WriteLine("\n  => TONG SAN PHAM BAN DUOC: " + data.Values.Sum().ToString("N0"));
    }
}