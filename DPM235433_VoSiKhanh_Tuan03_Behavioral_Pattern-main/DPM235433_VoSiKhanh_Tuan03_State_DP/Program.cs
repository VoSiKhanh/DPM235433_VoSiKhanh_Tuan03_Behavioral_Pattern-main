using DPM235433_VoSiKhanh_Tuan03_State_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  STATE PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Quan ly trang thai Don Hang");
Console.WriteLine("==========================================================\n");

Console.WriteLine("=== KICH BAN 1: Don hang thanh cong ===");
var o1 = new OrderContext("DH001", "HTX Tan Chau", "Thuoc tru sau Furadan", 20);
o1.Confirm();
o1.Process();
o1.Cancel();
Console.WriteLine($"  => Trang thai cuoi: [{o1.GetStateName()}]\n");

Console.WriteLine("=== KICH BAN 2: Huy don ngay tu dau ===");
var o2 = new OrderContext("DH002", "Cua hang Minh Duc", "Phan bon NPK", 50);
o2.Cancel();
o2.Confirm();
Console.WriteLine($"  => Trang thai cuoi: [{o2.GetStateName()}]\n");

Console.WriteLine("=== KICH BAN 3: Huy don dang xu ly ===");
var o3 = new OrderContext("DH003", "Nong dan Nguyen Van A", "Hat giong OM18", 100);
o3.Confirm();
o3.Cancel();
o3.Process();
Console.WriteLine($"  => Trang thai cuoi: [{o3.GetStateName()}]");

Console.WriteLine("\nNhan phim bat ky de thoat...");
Console.ReadKey();