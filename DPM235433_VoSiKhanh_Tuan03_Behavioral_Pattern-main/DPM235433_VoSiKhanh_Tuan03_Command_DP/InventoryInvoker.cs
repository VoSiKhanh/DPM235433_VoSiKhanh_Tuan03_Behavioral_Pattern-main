namespace DPM235433_VoSiKhanh_Tuan03_Command_DP;

/// <summary>Invoker: Luu lich su lenh va goi Undo khi can thiet</summary>
public class InventoryInvoker
{
    private readonly Stack<ICommand> _history = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void Undo()
    {
        if (_history.Count == 0)
        {
            Console.WriteLine("  [UNDO] Khong co thao tac nao de hoan tac!");
            return;
        }
        _history.Pop().Undo();
    }
}