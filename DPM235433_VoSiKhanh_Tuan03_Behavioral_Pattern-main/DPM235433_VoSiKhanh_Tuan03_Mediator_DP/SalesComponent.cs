namespace DPM235433_VoSiKhanh_Tuan03_Mediator_DP;

/// <summary>Concrete Component: Module Ban Hang</summary>
public class SalesComponent : BaseComponent
{
    public SalesComponent(IMediator mediator) : base(mediator, "Ban Hang") { }

    public void CreateOrder(string product, int qty, string employee)
    {
        Console.WriteLine($"\n  [{Name}] Tao don hang: {qty} '{product}' - NV: {employee}");
        _mediator.Notify(this, "ORDER_CREATED", (product, qty, employee));
    }
}