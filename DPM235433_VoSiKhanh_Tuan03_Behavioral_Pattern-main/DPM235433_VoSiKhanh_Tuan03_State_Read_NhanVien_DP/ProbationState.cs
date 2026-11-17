using System;
namespace DPM235433_VoSiKhanh_Tuan03_State_Read_NhanVien_DP;
public class ProbationState : IState { public void Handle(Employee e) { Console.WriteLine("Dang thu viec. Cap nhat sang Chinh thuc."); e.State = new FullTimeState(); } }