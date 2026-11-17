namespace DPM235433_VoSiKhanh_Tuan03_Mediator_DP;

/// <summary>Mediator Interface: trung gian dieu phoi giua cac component</summary>
public interface IMediator
{
    void Notify(BaseComponent sender, string eventName, object? data = null);
}