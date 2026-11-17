using DPM235433_VoSiKhanh_Tuan03_TemplateMethod_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  TEMPLATE METHOD PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Xuat bao cao thong ke nhieu tieu chi");
Console.WriteLine("==========================================================");

var from = new DateTime(2026, 9, 1);
var to   = new DateTime(2026, 9, 15);

new DailyReportGenerator().GenerateReport(from, to);
new EmployeeReportGenerator().GenerateReport(from, to);
new ProductReportGenerator().GenerateReport(from, to);

Console.WriteLine("Nhan phim bat ky de thoat...");
Console.ReadKey();