using DPM235433_VoSiKhanh_Tuan03_Command_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  COMMAND PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Nhap/Xuat lo hang + ho tro Undo");
Console.WriteLine("==========================================================\n");

var inventory = new Inventory();
var invoker   = new InventoryInvoker();

var b1 = new Batch { BatchId="LH001", ProductName="Thuoc tru sau Padan",  Quantity=200, ImportDate=DateTime.Today, ExpiryDate=DateTime.Today.AddMonths(18) };
var b2 = new Batch { BatchId="LH002", ProductName="Phan bon DAP Dinh Vu", Quantity=500, ImportDate=DateTime.Today, ExpiryDate=DateTime.Today.AddMonths(24) };
var b3 = new Batch { BatchId="LH003", ProductName="Hat giong lua OM5451", Quantity=300, ImportDate=DateTime.Today, ExpiryDate=DateTime.Today.AddMonths(12) };

Console.WriteLine("--- Buoc 1: Nhap 3 lo hang vao kho ---");
invoker.ExecuteCommand(new ImportBatchCommand(inventory, b1));
invoker.ExecuteCommand(new ImportBatchCommand(inventory, b2));
invoker.ExecuteCommand(new ImportBatchCommand(inventory, b3));
inventory.PrintInventory();

Console.WriteLine("\n--- Buoc 2: Xuat lo hang LH002 ---");
invoker.ExecuteCommand(new ExportBatchCommand(inventory, b2));
inventory.PrintInventory();

Console.WriteLine("\n--- Buoc 3: Nhan vien nhap nham! UNDO xuat hang ---");
invoker.Undo();
inventory.PrintInventory();

Console.WriteLine("\n--- Buoc 4: UNDO tiep (huy nhap LH003) ---");
invoker.Undo();
inventory.PrintInventory();

Console.WriteLine("\nNhan phim bat ky de thoat...");
Console.ReadKey();