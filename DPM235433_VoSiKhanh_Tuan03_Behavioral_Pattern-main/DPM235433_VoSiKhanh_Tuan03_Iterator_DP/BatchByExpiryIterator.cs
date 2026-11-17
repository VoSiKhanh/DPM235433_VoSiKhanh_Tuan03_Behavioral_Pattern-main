namespace DPM235433_VoSiKhanh_Tuan03_Iterator_DP;

/// <summary>Concrete Iterator: Duyet lo hang theo han su dung (sap het han truoc - FEFO)</summary>
public class BatchByExpiryIterator : IAgIterator<Batch>
{
    private readonly List<Batch> _sorted;
    private int _index = 0;

    public BatchByExpiryIterator(List<Batch> batches)
    {
        _sorted = batches.OrderBy(b => b.ExpiryDate).ToList();
    }

    public bool  HasNext() => _index < _sorted.Count;
    public Batch Next()    => _sorted[_index++];
    public void  Reset()   => _index = 0;
}