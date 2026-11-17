namespace DPM235433_VoSiKhanh_Tuan03_Iterator_DP;

/// <summary>Iterator Interface: cung cap cac phuong thuc duyet tap hop</summary>
public interface IAgIterator<T>
{
    bool HasNext();
    T    Next();
    void Reset();
}