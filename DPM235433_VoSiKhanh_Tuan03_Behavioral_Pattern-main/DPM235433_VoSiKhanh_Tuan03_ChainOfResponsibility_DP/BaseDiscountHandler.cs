namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_DP;

/// <summary>Base Handler: cai dat chuoi lien ket, chuyen yeu cau len cap tren neu vuot tham quyen</summary>
public abstract class BaseDiscountHandler : IDiscountHandler
{
    private IDiscountHandler? _next;

    public IDiscountHandler SetNext(IDiscountHandler next)
    {
        _next = next;
        return next;
    }

    public virtual string Handle(DiscountRequest request)
    {
        if (_next != null)
            return _next.Handle(request);
        return $"[TU CHOI] Khong co cap nao du tham quyen duyet {request.DiscountPct}% cho {request.CustomerName}.";
    }
}
