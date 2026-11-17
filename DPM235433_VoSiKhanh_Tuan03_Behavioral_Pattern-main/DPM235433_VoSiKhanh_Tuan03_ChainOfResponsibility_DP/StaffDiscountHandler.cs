namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_DP;

/// <summary>Nhan vien ban hang: duyet toi da 5%</summary>
public class StaffDiscountHandler : BaseDiscountHandler
{
    private const double MaxDiscount = 5.0;

    public override string Handle(DiscountRequest request)
    {
        if (request.DiscountPct <= MaxDiscount)
        {
            double saved = request.OrderValue * request.DiscountPct / 100;
            return $"[NHAN VIEN] Da duyet giam {request.DiscountPct}% cho {request.CustomerName}. Tiet kiem: {saved:N0}d";
        }
        Console.WriteLine($"  --> Nhan vien khong du tham quyen duyet {request.DiscountPct}%, chuyen len Truong phong...");
        return base.Handle(request);
    }
}
