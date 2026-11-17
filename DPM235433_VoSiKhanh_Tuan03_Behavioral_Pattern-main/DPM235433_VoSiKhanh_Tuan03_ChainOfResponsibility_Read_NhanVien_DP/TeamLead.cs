using System;
namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_Read_NhanVien_DP;
public class TeamLead : Handler { public override void Handle(string employee, int days) { if (days <= 2) Console.WriteLine("[Truong Nhom] Duyet " + days + " ngay phep cho " + employee + "."); else Next?.Handle(employee, days); } }