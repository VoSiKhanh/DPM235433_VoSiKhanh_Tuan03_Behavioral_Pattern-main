using DPM235433_VoSiKhanh_Tuan03_Mediator_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  MEDIATOR PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Dieu phoi Kho <-> Ban Hang <-> Nhan Vien");
Console.WriteLine("==========================================================\n");

var mediator  = new SalesMediator();
var warehouse = new WarehouseComponent(mediator);
var sales     = new SalesComponent(mediator);
var staff     = new StaffComponent(mediator);
mediator.Warehouse = warehouse;
mediator.Sales     = sales;
mediator.Staff     = staff;

sales.CreateOrder("Thuoc tru sau Furadan", 30,  "Nguyen Van Thuan");
sales.CreateOrder("Phan bon NPK",          100, "Tran Thi Mai");
sales.CreateOrder("Hat giong lua OM18",    170, "Le Van Hung");
sales.CreateOrder("Phan bon NPK",          130, "Nguyen Van Thuan");

staff.PrintBoard();

Console.WriteLine("\nNhan phim bat ky de thoat...");
Console.ReadKey();