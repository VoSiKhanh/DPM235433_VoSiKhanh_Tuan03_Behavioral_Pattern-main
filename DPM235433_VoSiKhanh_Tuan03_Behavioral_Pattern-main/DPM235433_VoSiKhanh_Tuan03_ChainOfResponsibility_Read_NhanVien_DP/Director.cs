using System;
namespace DPM235433_VoSiKhanh_Tuan03_ChainOfResponsibility_Read_NhanVien_DP;
public class Director : Handler { public override void Handle(string employee, int days) { Console.WriteLine("[Giam Doc] Duyet " + days + " ngay phep cho " + employee + "."); } }