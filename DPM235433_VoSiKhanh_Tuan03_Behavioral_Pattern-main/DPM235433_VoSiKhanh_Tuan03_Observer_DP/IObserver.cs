namespace DPM235433_VoSiKhanh_Tuan03_Observer_DP;

/// <summary>Observer Interface: nhan thong bao khi co su kien</summary>
public interface IObserver
{
    void Update(string product, int remaining);
}