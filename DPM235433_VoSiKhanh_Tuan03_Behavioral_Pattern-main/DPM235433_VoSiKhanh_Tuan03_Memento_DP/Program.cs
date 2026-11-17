using DPM235433_VoSiKhanh_Tuan03_Memento_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  MEMENTO PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Luu & Khoi phuc Hoa Don ban hang (Undo)");
Console.WriteLine("==========================================================\n");

var order     = new OrderOriginator();
var caretaker = new OrderCaretaker();

Console.WriteLine("--- Buoc 1: Tao hoa don ban dau ---");
order.CustomerName = "HTX Nong nghiep Tan Chau";
order.ProductName  = "Thuoc tru sau Regent 800WG";
order.Quantity = 50; order.UnitPrice = 85_000;
order.Discount = 0;  order.ShippingFee = 0;
caretaker.Backup(order);
order.Print();

Console.WriteLine("\n--- Buoc 2: Them phi van chuyen 150,000d ---");
caretaker.Backup(order);
order.ShippingFee = 150_000;
order.Print();

Console.WriteLine("\n--- Buoc 3: Ap dung giam gia 10% ---");
caretaker.Backup(order);
order.Discount = 10;
order.Print();

Console.WriteLine("\n--- Buoc 4: Nhap nham! UNDO lan 1 ---");
caretaker.Undo(order);
order.Print();

Console.WriteLine("\n--- Buoc 5: UNDO lan 2 (ve ban dau) ---");
caretaker.Undo(order);
order.Print();

Console.WriteLine("\nNhan phim bat ky de thoat...");
Console.ReadKey();