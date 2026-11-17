namespace DPM235433_VoSiKhanh_Tuan03_State_DP;

/// <summary>Concrete State: Don hang moi tao</summary>
public class NewOrderState : IOrderState
{
    public string StateName => "MOI TAO";
    public void Confirm(OrderContext o)  { Console.WriteLine($"  [DH {o.OrderId}] Xac nhan don hang."); o.SetState(new ProcessingState()); }
    public void Process(OrderContext o)  => Console.WriteLine($"  [DH {o.OrderId}] Loi: Phai XAC NHAN truoc!");
    public void Complete(OrderContext o) => Console.WriteLine($"  [DH {o.OrderId}] Loi: Don chua xu ly!");
    public void Cancel(OrderContext o)   { Console.WriteLine($"  [DH {o.OrderId}] Huy don hang moi."); o.SetState(new CancelledState()); }
}