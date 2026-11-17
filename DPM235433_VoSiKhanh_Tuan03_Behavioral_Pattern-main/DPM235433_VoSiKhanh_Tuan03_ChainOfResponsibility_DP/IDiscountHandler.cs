namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_DP;

/// <summary>Handler interface: moi handler co the set handler ke tiep va xu ly yeu cau</summary>
public interface IDiscountHandler
{
    IDiscountHandler SetNext(IDiscountHandler next);
    string Handle(DiscountRequest request);
}
