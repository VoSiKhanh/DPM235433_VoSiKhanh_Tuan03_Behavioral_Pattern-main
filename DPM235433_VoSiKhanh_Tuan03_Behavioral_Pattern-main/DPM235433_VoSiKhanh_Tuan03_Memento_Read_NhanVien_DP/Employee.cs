using System;
namespace DPM235433_VoSiKhanh_Tuan03_Memento_Read_NhanVien_DP;
public class Employee { public string Name { get; set; } = string.Empty; public string Role { get; set; } = string.Empty; public EmployeeMemento Save() => new EmployeeMemento(Role); public void Restore(EmployeeMemento m) => Role = m.Role; public void Print() => Console.WriteLine("NV " + Name + " - Chuc vu: " + Role); }