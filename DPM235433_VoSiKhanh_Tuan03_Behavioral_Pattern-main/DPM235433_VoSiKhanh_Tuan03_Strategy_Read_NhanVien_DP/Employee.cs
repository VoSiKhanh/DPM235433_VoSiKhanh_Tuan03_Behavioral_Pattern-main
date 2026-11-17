using System;
namespace DPM235433_VoSiKhanh_Tuan03_Strategy_Read_NhanVien_DP;
public class Employee { private ISalaryStrategy _strategy; public Employee(ISalaryStrategy s) => _strategy = s; public void PrintSalary(double baseSal) => Console.WriteLine("Luong nhan vien: " + _strategy.Calculate(baseSal) + ""); }