namespace DPM235433_VoSiKhanh_Tuan03_Mediator_DP;

/// <summary>Base Component: moi module deu biet ve mediator</summary>
public abstract class BaseComponent
{
    protected IMediator _mediator;
    public string Name { get; }

    protected BaseComponent(IMediator mediator, string name)
    {
        _mediator = mediator;
        Name = name;
    }
}