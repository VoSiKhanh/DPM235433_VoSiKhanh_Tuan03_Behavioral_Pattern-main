using DPM235433_VoSiKhanh_Tuan03_Strategy_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  STRATEGY PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Tinh phi van chuyen theo loai dich vu");
Console.WriteLine("==========================================================\n");

var calc = new ShippingCalculator(new StandardShipping());

Console.WriteLine("--- Don 1: HTX Tan Chau (van chuyen thuong) ---");
calc.SetStrategy(new StandardShipping());
double f1 = calc.CalculateShipping(15, 20, 5_000_000);
Console.WriteLine($"  TONG HOA DON: {5_000_000 + f1:N0}d");

Console.WriteLine("--- Don 2: Cua hang Minh Duc (van chuyen nhanh) ---");
calc.SetStrategy(new ExpressShipping());
double f2 = calc.CalculateShipping(5, 5, 2_000_000);
Console.WriteLine($"  TONG HOA DON: {2_000_000 + f2:N0}d");

Console.WriteLine("--- Don 3: Cong ty TNHH (so luong lon) ---");
calc.SetStrategy(new BulkShipping());
double f3 = calc.CalculateShipping(80, 200, 30_000_000);
Console.WriteLine($"  TONG HOA DON: {30_000_000 + f3:N0}d");

Console.WriteLine("--- Don 4: Khach VIP (mien phi van chuyen) ---");
calc.SetStrategy(new FreeShipping());
double f4 = calc.CalculateShipping(50, 50, 15_000_000);
Console.WriteLine($"  TONG HOA DON: {15_000_000 + f4:N0}d");

Console.WriteLine("Nhan phim bat ky de thoat...");
Console.ReadKey();