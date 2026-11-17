using DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  CHAIN OF RESPONSIBILITY - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Duyet yeu cau giam gia theo cap bac");
Console.WriteLine("==========================================================\n");

// Xay dung chuoi: Nhan vien -> Truong phong -> Giam doc
var staff    = new StaffDiscountHandler();
var manager  = new ManagerDiscountHandler();
var director = new DirectorDiscountHandler();
staff.SetNext(manager).SetNext(director);

var requests = new List<DiscountRequest>
{
    new() { CustomerName = "HTX Nong nghiep Tan Chau",  ProductName = "Thuoc tru sau Furadan", OrderValue = 5_000_000,  DiscountPct = 3  },
    new() { CustomerName = "Cua hang Minh Duc",          ProductName = "Phan bon NPK",          OrderValue = 12_000_000, DiscountPct = 10 },
    new() { CustomerName = "Cong ty TNHH Long Xuyen",    ProductName = "Hat giong lua IR50404", OrderValue = 30_000_000, DiscountPct = 20 },
    new() { CustomerName = "Nong dan Nguyen Van A",       ProductName = "Thuoc diet co",         OrderValue = 2_000_000,  DiscountPct = 35 },
};

foreach (var req in requests)
{
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine($"Yeu cau: {req.CustomerName}");
    Console.WriteLine($"   San pham: {req.ProductName} | Don hang: {req.OrderValue:N0}d | Giam gia: {req.DiscountPct}%");
    string result = staff.Handle(req);
    Console.WriteLine($"   Ket qua: {result}");
    Console.WriteLine();
}

Console.WriteLine("Nhan phim bat ky de thoat...");
Console.ReadKey();
