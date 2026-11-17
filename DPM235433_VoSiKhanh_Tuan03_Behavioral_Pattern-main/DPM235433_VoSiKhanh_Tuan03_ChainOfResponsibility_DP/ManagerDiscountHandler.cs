namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_DP;

/// <summary>Truong phong kinh doanh: duyet toi da 15%</summary>
public class ManagerDiscountHandler : BaseDiscountHandler
{
    private const double MaxDiscount = 15.0;

    public override string Handle(DiscountRequest request)
    {
        if (request.DiscountPct <= MaxDiscount)
        {
            double saved = request.OrderValue * request.DiscountPct / 100;
            return $"[TRUONG PHONG] Da duyet giam {request.DiscountPct}% cho {request.CustomerName}. Tiet kiem: {saved:N0}d";
        }
        Console.WriteLine($"  --> Truong phong khong du tham quyen duyet {request.DiscountPct}%, chuyen len Giam doc...");
        return base.Handle(request);
    }
}
