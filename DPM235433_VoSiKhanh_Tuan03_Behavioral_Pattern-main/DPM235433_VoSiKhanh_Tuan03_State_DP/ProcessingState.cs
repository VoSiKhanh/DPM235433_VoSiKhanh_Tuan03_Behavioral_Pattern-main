namespace DPM235433_VoSiKhanh_Tuan03_State_DP;

/// <summary>Concrete State: Don hang dang xu ly</summary>
public class ProcessingState : IOrderState
{
    public string StateName => "DANG XU LY";
    public void Confirm(OrderContext o)  => Console.WriteLine($"  [DH {o.OrderId}] Da xac nhan roi!");
    public void Process(OrderContext o)  { Console.WriteLine($"  [DH {o.OrderId}] Chuan bi hang va giao hang..."); o.SetState(new CompletedState()); }
    public void Complete(OrderContext o) => Console.WriteLine($"  [DH {o.OrderId}] Loi: Chua hoan tat xu ly!");
    public void Cancel(OrderContext o)   { Console.WriteLine($"  [DH {o.OrderId}] Huy don dang xu ly."); o.SetState(new CancelledState()); }
}