namespace DPM235433_VoSiKhanh_Tuan03_Mediator_DP;

/// <summary>Concrete Mediator: Dieu phoi giua Kho - Ban Hang - Nhan Vien</summary>
public class SalesMediator : IMediator
{
    public WarehouseComponent? Warehouse { get; set; }
    public SalesComponent?     Sales     { get; set; }
    public StaffComponent?     Staff     { get; set; }

    public void Notify(BaseComponent sender, string eventName, object? data = null)
    {
        if (eventName == "ORDER_CREATED")
        {
            var (product, qty, employee) = ((string, int, string))data!;
            Console.WriteLine($"  [MEDIATOR] Nhan ORDER_CREATED tu {sender.Name}. Kiem tra kho...");
            if (Warehouse!.CheckStock(product, qty))
            {
                Warehouse.ReduceStock(product, qty);
                Staff!.RecordSale(employee, qty);
                Console.WriteLine($"  [MEDIATOR] Don hang HOAN TAT!");
            }
            else
            {
                Console.WriteLine($"  [MEDIATOR] Don hang THAT BAI - Khong du hang!");
            }
        }
        else if (eventName == "STOCK_CHANGED")
        {
            var (prod, remaining) = ((string, int))data!;
            if (remaining < 50)
                Console.WriteLine($"  [MEDIATOR] CANH BAO: '{prod}' chi con {remaining}, can nhap them!");
        }
    }
}