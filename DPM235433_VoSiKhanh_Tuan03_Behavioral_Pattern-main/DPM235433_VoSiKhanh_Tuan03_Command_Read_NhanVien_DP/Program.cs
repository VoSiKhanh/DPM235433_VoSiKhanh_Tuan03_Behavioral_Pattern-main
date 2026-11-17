using System;
using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan03_Command_Read_NhanVien_DP;
class Program { static void Main() { Console.WriteLine("--- COMMAND: Quan Ly Them/Xoa Nhan Vien ---"); var manager = new EmployeeManager(); var history = new Stack<ICommand>(); var cmd = new AddEmployeeCommand(manager, "Nguyen Van A"); cmd.Execute(); history.Push(cmd); var cmd2 = new AddEmployeeCommand(manager, "Tran Thi B"); cmd2.Execute(); history.Push(cmd2); Console.WriteLine("Undo thao tac cuoi..."); history.Pop().Undo(); } }