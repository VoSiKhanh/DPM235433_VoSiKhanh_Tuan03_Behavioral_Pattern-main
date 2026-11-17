namespace DPM235433_VoSiKhanh_Tuan03_Command_DP;

/// <summary>Concrete Command: Lenh nhap lo hang vao kho</summary>
public class ImportBatchCommand : ICommand
{
    private readonly Inventory _inventory;
    private readonly Batch     _batch;

    public ImportBatchCommand(Inventory inventory, Batch batch)
    {
        _inventory = inventory;
        _batch     = batch;
    }

    public void Execute() => _inventory.AddBatch(_batch);

    public void Undo()
    {
        Console.WriteLine($"  [UNDO] Huy nhap lo hang: {_batch.BatchId}");
        _inventory.RemoveBatch(_batch);
    }
}