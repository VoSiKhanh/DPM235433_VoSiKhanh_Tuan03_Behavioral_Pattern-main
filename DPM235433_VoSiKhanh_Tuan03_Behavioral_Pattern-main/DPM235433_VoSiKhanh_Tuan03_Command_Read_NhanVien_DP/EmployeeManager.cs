using System;
using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan03_Command_Read_NhanVien_DP;
public class EmployeeManager { public List<string> Employees { get; } = new List<string>(); public void Add(string name) { Employees.Add(name); Console.WriteLine("Them NV: " + name); } public void Remove(string name) { Employees.Remove(name); Console.WriteLine("Xoa NV: " + name); } }