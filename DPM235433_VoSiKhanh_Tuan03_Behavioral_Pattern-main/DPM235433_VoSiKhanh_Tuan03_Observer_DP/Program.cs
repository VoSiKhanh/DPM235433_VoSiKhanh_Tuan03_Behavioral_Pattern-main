using DPM235433_VoSiKhanh_Tuan03_Observer_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  OBSERVER PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Canh bao khi ton kho sap het");
Console.WriteLine("==========================================================\n");

var inv = new InventorySubject();
inv.Subscribe(new LowStockAlert());
inv.Subscribe(new ManagerNotifier("Nguyen Van Thuan - Truong phong"));
var autoPO = new AutoPurchaseOrder();
inv.Subscribe(autoPO);

inv.PrintStock();

Console.WriteLine("\n--- Ban hang ---");
inv.SellProduct("Hat giong lua OM5451",   40);
inv.SellProduct("Thuoc tru sau Furadan",  80);
inv.SellProduct("Phan bon NPK 20-20-15", 260);

Console.WriteLine("\n--- Huy dang ky AutoPurchaseOrder ---");
inv.Unsubscribe(autoPO);

Console.WriteLine("\n--- Ban them ---");
inv.SellProduct("Hat giong lua OM5451", 25);

Console.WriteLine("\nNhan phim bat ky de thoat...");
Console.ReadKey();