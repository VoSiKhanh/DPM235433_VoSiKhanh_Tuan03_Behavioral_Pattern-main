using System;
namespace DPM235433_VoSiKhanh_Tuan03_Observer_Read_NhanVien_DP;
class Program { static void Main() { Console.WriteLine("--- OBSERVER: Thong bao chinh sach cho Nhan Vien ---"); var hr = new HRDepartment(); hr.Subscribe(new Employee { Name = "Nguyen Van A" }); hr.Subscribe(new Employee { Name = "Tran Thi B" }); hr.NotifyAll("Cong ty se to chuc kham suc khoe vao tuan sau."); } }