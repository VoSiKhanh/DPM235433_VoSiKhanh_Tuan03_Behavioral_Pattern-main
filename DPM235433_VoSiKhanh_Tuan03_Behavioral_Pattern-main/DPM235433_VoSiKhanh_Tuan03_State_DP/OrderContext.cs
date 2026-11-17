namespace DPM235433_VoSiKhanh_Tuan03_State_DP;

/// <summary>Context: Don hang - giu trang thai hien tai va uy quyen cho State</summary>
public class OrderContext
{
    private IOrderState _state;
    public string OrderId      { get; }
    public string CustomerName { get; }
    public string ProductName  { get; }
    public int    Quantity     { get; }

    public OrderContext(string id, string customer, string product, int qty)
    {
        OrderId = id; CustomerName = customer; ProductName = product; Quantity = qty;
        _state = new NewOrderState();
        Console.WriteLine($"  [DH {OrderId}] Tao don hang moi. Trang thai: [{_state.StateName}]");
    }

    public void SetState(IOrderState state)
    {
        _state = state;
        Console.WriteLine($"  [DH {OrderId}] Chuyen sang trang thai: [{_state.StateName}]");
    }

    public string GetStateName() => _state.StateName;

    public void Confirm()  => _state.Confirm(this);
    public void Process()  => _state.Process(this);
    public void Complete() => _state.Complete(this);
    public void Cancel()   => _state.Cancel(this);
}