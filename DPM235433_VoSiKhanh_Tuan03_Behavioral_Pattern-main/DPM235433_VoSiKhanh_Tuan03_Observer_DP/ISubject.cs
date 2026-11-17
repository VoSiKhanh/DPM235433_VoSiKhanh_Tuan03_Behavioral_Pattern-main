namespace DPM235433_VoSiKhanh_Tuan03_Observer_DP;

/// <summary>Subject Interface: phat su kien cho cac observer da dang ky</summary>
public interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string product, int remaining);
}