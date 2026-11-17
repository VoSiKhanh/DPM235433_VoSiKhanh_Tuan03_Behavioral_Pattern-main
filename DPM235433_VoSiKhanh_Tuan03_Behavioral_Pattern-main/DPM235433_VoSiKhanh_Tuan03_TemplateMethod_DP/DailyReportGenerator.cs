namespace DPM235433_VoSiKhanh_Tuan03_TemplateMethod_DP;

/// <summary>Concrete Template: Bao cao doanh thu theo ngay (ho tro chon tu ngay den ngay)</summary>
public class DailyReportGenerator : ReportGenerator
{
    protected override string GetReportTitle() => "  BAO CAO DOANH THU THEO NGAY";

    protected override List<SaleRecord> CollectData(DateTime from, DateTime to) =>
        FakeDatabase.Sales.Where(s => s.Date >= from && s.Date <= to).ToList();

    protected override Dictionary<string, double> ProcessData(List<SaleRecord> data) =>
        data.GroupBy(s => s.Date.ToString("dd/MM/yyyy"))
            .ToDictionary(g => g.Key, g => g.Sum(s => s.Qty * s.UnitPrice));

    protected override void PrintReport(Dictionary<string, double> data)
    {
        Console.WriteLine("  " + "Ngay".PadRight(15) + "Doanh thu".PadLeft(20));
        Console.WriteLine("  " + new string('-', 35));
        foreach (var kv in data.OrderBy(x => x.Key))
            Console.WriteLine("  " + kv.Key.PadRight(15) + kv.Value.ToString("N0").PadLeft(20) + "d");
    }
}