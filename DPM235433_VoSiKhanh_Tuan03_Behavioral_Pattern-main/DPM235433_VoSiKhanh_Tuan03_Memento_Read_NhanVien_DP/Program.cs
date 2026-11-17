using System;
using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan03_Memento_Read_NhanVien_DP;
class Program { static void Main() { Console.WriteLine("--- MEMENTO: Luu/Phuc hoi lich su chuc vu Nhan Vien ---"); var emp = new Employee { Name = "Nguyen Van A", Role = "Thuc Tap Sinh" }; emp.Print(); var history = new Stack<EmployeeMemento>(); history.Push(emp.Save()); emp.Role = "Nhan Vien Chinh Thuc"; emp.Print(); Console.WriteLine("Hoan tac chuc vu..."); emp.Restore(history.Pop()); emp.Print(); } }