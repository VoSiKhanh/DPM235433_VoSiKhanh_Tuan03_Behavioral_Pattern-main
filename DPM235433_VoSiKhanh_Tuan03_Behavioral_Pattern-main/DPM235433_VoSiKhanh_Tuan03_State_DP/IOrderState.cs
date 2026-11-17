namespace DPM235433_VoSiKhanh_Tuan03_State_DP;

/// <summary>State Interface: dinh nghia hanh dong trong moi trang thai don hang</summary>
public interface IOrderState
{
    string StateName { get; }
    void Confirm(OrderContext order);
    void Process(OrderContext order);
    void Complete(OrderContext order);
    void Cancel(OrderContext order);
}