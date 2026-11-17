namespace DPM235433_VoSiKhanh_Tuan03_Command_DP;

/// <summary>Concrete Command: Lenh xuat lo hang ra khoi kho</summary>
public class ExportBatchCommand : ICommand
{
    private readonly Inventory _inventory;
    private readonly Batch     _batch;

    public ExportBatchCommand(Inventory inventory, Batch batch)
    {
        _inventory = inventory;
        _batch     = batch;
    }

    public void Execute() => _inventory.RemoveBatch(_batch);

    public void Undo()
    {
        Console.WriteLine($"  [UNDO] Hoan lai lo hang da xuat: {_batch.BatchId}");
        _inventory.AddBatch(_batch);
    }
}