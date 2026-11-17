using System;
namespace DPM235433_VoSiKhanh_Tuan03_Mediator_Read_NhanVien_DP;
class Program { static void Main() { Console.WriteLine("--- MEDIATOR: Phoi hop cac phong ban khi tuyen NV ---"); var mediator = new CompanyMediator(); mediator.HR = new HRDepartment(mediator); mediator.IT = new ITDepartment(); mediator.HR.Hire(); } }