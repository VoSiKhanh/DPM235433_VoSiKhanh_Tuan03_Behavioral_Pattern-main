namespace DPM235433_VoSiKhanh_Tuan03_Command_DP;

/// <summary>Receiver: Kho hang thuc su thuc hien cac thao tac nhap/xuat</summary>
public class Inventory
{
    private readonly List<Batch> _batches = new();

    public void AddBatch(Batch batch)
    {
        _batches.Add(batch);
        Console.WriteLine($"  [KHO] Da nhap lo hang: {batch}");
    }

    public bool RemoveBatch(Batch batch)
    {
        bool removed = _batches.Remove(batch);
        if (removed)
            Console.WriteLine($"  [KHO] Da xuat lo hang: {batch}");
        else
            Console.WriteLine($"  [KHO] Khong tim thay lo hang: {batch.BatchId}");
        return removed;
    }

    public void PrintInventory()
    {
        Console.WriteLine("\n  === TON KHO HIEN TAI ===");
        if (_batches.Count == 0) { Console.WriteLine("  (Kho trong!)"); return; }
        foreach (var b in _batches)
            Console.WriteLine($"  - {b}");
        Console.WriteLine($"  Tong so lo: {_batches.Count}");
    }
}