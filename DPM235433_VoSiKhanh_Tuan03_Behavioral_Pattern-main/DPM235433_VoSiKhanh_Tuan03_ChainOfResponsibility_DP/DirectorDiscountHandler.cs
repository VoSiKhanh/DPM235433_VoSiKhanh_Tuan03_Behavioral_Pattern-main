namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_DP;

/// <summary>Giam doc: duyet toi da 30%</summary>
public class DirectorDiscountHandler : BaseDiscountHandler
{
    private const double MaxDiscount = 30.0;

    public override string Handle(DiscountRequest request)
    {
        if (request.DiscountPct <= MaxDiscount)
        {
            double saved = request.OrderValue * request.DiscountPct / 100;
            return $"[GIAM DOC] Da duyet giam {request.DiscountPct}% cho {request.CustomerName}. Tiet kiem: {saved:N0}d";
        }
        Console.WriteLine($"  --> Giam doc khong du tham quyen duyet {request.DiscountPct}%.");
        return base.Handle(request);
    }
}
