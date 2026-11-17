using System;
namespace DPM235433_VoSiKhanh_Tuan03_State_Read_NhanVien_DP;
public class FullTimeState : IState { public void Handle(Employee e) { Console.WriteLine("Nhan vien chinh thuc."); } }