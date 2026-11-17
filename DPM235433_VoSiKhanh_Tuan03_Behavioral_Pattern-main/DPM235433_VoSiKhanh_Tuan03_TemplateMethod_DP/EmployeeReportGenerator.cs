namespace DPM235433_VoSiKhanh_Tuan03_TemplateMethod_DP;

/// <summary>Concrete Template: Bao cao doanh so theo nhan vien ban hang</summary>
public class EmployeeReportGenerator : ReportGenerator
{
    protected override string GetReportTitle() => "  BAO CAO DOANH SO NHAN VIEN";

    protected override List<SaleRecord> CollectData(DateTime from, DateTime to) =>
        FakeDatabase.Sales.Where(s => s.Date >= from && s.Date <= to).ToList();

    protected override Dictionary<string, double> ProcessData(List<SaleRecord> data) =>
        data.GroupBy(s => s.Employee)
            .ToDictionary(g => g.Key, g => g.Sum(s => s.Qty * s.UnitPrice));

    protected override void PrintReport(Dictionary<string, double> data)
    {
        Console.WriteLine("  " + "Nhan vien".PadRight(25) + "Doanh so".PadLeft(15) + "  Xep hang");
        Console.WriteLine("  " + new string('-', 50));
        int rank = 1;
        foreach (var kv in data.OrderByDescending(x => x.Value))
            Console.WriteLine("  " + kv.Key.PadRight(25) + kv.Value.ToString("N0").PadLeft(15) + "d  #" + rank++);
    }
}