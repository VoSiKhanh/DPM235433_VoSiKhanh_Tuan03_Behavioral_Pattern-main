namespace DPM235433_VoSiKhanh_Tuan03_State_DP;

/// <summary>Concrete State: Don hang da huy</summary>
public class CancelledState : IOrderState
{
    public string StateName => "DA HUY";
    public void Confirm(OrderContext o)  => Console.WriteLine($"  [DH {o.OrderId}] Don da bi huy, khong the khoi phuc!");
    public void Process(OrderContext o)  => Console.WriteLine($"  [DH {o.OrderId}] Don da bi huy!");
    public void Complete(OrderContext o) => Console.WriteLine($"  [DH {o.OrderId}] Don da bi huy!");
    public void Cancel(OrderContext o)   => Console.WriteLine($"  [DH {o.OrderId}] Don da bi huy roi!");
}