namespace DPM235433_VoSiKhanh_Tuan03_TemplateMethod_DP;

/// <summary>Abstract Template: dinh nghia bo khung quy trinh xuat bao cao</summary>
public abstract class ReportGenerator
{
    // Template Method - khong override
    public void GenerateReport(DateTime fromDate, DateTime toDate)
    {
        Console.WriteLine("\n" + new string('=', 60));
        Console.WriteLine(GetReportTitle());
        Console.WriteLine("  Tu: " + fromDate.ToString("dd/MM/yyyy") + " - Den: " + toDate.ToString("dd/MM/yyyy"));
        Console.WriteLine(new string('=', 60));
        ValidateParameters(fromDate, toDate);
        var data      = CollectData(fromDate, toDate);
        var processed = ProcessData(data);
        PrintReport(processed);
        PrintSummary(processed);
        Console.WriteLine(new string('=', 60) + "\n");
    }

    protected abstract string GetReportTitle();
    protected abstract List<SaleRecord> CollectData(DateTime from, DateTime to);
    protected abstract Dictionary<string, double> ProcessData(List<SaleRecord> data);
    protected abstract void PrintReport(Dictionary<string, double> data);

    protected virtual void ValidateParameters(DateTime from, DateTime to)
    {
        if (from > to) throw new ArgumentException("Ngay bat dau phai truoc ngay ket thuc!");
        Console.WriteLine("  [OK] Tham so hop le.");
    }

    protected virtual void PrintSummary(Dictionary<string, double> data)
    {
        Console.WriteLine("\n  => TONG CONG: " + data.Values.Sum().ToString("N0") + "d");
    }
}