namespace DPM235433_VoSiKhanh_Tuan03_State_Read_NhanVien_DP;
public class Employee { public IState State { get; set; } = new ProbationState(); public void Request() => State.Handle(this); }