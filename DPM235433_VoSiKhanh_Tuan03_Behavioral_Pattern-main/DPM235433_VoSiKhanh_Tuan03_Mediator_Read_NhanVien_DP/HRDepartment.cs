using System;
namespace DPM235433_VoSiKhanh_Tuan03_Mediator_Read_NhanVien_DP;
public class HRDepartment { private IMediator _m; public HRDepartment(IMediator m) => _m = m; public void Hire() { Console.WriteLine("HR: Tuyen dung NV moi."); _m.Notify(this, "Hire"); } }