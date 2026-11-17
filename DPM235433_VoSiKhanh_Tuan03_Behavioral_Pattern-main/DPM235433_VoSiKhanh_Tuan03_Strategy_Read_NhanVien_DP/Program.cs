using System;
namespace DPM235433_VoSiKhanh_Tuan03_Strategy_Read_NhanVien_DP;
class Program { static void Main() { Console.WriteLine("--- STRATEGY: Tinh luong theo vai tro Nhan Vien ---"); var dev = new Employee(new DeveloperSalary()); dev.PrintSalary(1000); var mgr = new Employee(new ManagerSalary()); mgr.PrintSalary(1000); } }