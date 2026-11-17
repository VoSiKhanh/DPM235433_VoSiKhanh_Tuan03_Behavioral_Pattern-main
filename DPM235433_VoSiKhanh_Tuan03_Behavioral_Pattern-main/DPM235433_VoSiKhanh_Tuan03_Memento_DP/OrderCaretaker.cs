namespace DPM235433_VoSiKhanh_Tuan03_Memento_DP;

/// <summary>Caretaker: Quan ly lich su snapshot (stack Undo)</summary>
public class OrderCaretaker
{
    private readonly Stack<OrderMemento> _history = new();

    public void Backup(OrderOriginator order) =>
        _history.Push(order.Save());

    public void Undo(OrderOriginator order)
    {
        if (_history.Count == 0)
        {
            Console.WriteLine("  [UNDO] Khong co snapshot nao de phuc hoi!");
            return;
        }
        order.Restore(_history.Pop());
    }
}