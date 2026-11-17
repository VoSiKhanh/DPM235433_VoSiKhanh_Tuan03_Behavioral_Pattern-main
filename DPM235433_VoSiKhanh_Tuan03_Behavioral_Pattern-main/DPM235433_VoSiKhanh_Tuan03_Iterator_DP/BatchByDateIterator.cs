namespace DPM235433_VoSiKhanh_Tuan03_Iterator_DP;

/// <summary>Concrete Iterator: Duyet lo hang theo ngay nhap (moi nhat truoc - LIFO)</summary>
public class BatchByDateIterator : IAgIterator<Batch>
{
    private readonly List<Batch> _sorted;
    private int _index = 0;

    public BatchByDateIterator(List<Batch> batches)
    {
        _sorted = batches.OrderByDescending(b => b.ImportDate).ToList();
    }

    public bool  HasNext() => _index < _sorted.Count;
    public Batch Next()    => _sorted[_index++];
    public void  Reset()   => _index = 0;
}