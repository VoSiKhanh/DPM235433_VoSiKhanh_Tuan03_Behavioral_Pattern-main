namespace DPM235433_VoSiKhanh_Tuan03_State_DP;

/// <summary>Concrete State: Don hang da hoan tat</summary>
public class CompletedState : IOrderState
{
    public string StateName => "HOAN TAT";
    public void Confirm(OrderContext o)  => Console.WriteLine($"  [DH {o.OrderId}] Da hoan tat, khong the thay doi!");
    public void Process(OrderContext o)  => Console.WriteLine($"  [DH {o.OrderId}] Da hoan tat, khong the thay doi!");
    public void Complete(OrderContext o) => Console.WriteLine($"  [DH {o.OrderId}] Da hoan tat roi!");
    public void Cancel(OrderContext o)   => Console.WriteLine($"  [DH {o.OrderId}] Khong the huy don da hoan tat!");
}