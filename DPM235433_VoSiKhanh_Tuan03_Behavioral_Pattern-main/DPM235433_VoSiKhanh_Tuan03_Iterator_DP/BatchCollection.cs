namespace DPM235433_VoSiKhanh_Tuan03_Iterator_DP;

/// <summary>Concrete Collection: danh sach lo hang trong kho</summary>
public class BatchCollection : IBatchCollection
{
    private readonly List<Batch> _batches = new();

    public void Add(Batch batch) => _batches.Add(batch);

    public IAgIterator<Batch> CreateExpiryIterator() =>
        new BatchByExpiryIterator(_batches);

    public IAgIterator<Batch> CreateDateIterator() =>
        new BatchByDateIterator(_batches);
}