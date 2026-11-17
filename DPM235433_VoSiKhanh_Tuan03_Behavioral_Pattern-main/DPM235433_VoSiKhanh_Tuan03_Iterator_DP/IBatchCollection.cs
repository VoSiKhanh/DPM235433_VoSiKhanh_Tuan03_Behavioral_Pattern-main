namespace DPM235433_VoSiKhanh_Tuan03_Iterator_DP;

/// <summary>Collection Interface: tap hop co the tao ra cac iterator</summary>
public interface IBatchCollection
{
    IAgIterator<Batch> CreateExpiryIterator();
    IAgIterator<Batch> CreateDateIterator();
    void Add(Batch batch);
}