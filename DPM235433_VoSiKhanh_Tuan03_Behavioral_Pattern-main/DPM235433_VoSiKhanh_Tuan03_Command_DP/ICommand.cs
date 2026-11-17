namespace DPM235433_VoSiKhanh_Tuan03_Command_DP;

/// <summary>Command Interface: moi lenh phai co Execute va Undo</summary>
public interface ICommand
{
    void Execute();
    void Undo();
}