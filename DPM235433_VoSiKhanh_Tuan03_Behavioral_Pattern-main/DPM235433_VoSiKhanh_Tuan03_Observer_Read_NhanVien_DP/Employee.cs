using System;
namespace DPM235433_VoSiKhanh_Tuan03_Observer_Read_NhanVien_DP;
public class Employee : IObserver { public string Name { get; set; } = string.Empty; public void Update(string m) => Console.WriteLine("[" + Name + "] Nhan thong bao: " + m); }