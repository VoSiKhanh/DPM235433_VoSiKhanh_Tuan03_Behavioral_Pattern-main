using System;
using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan03_Iterator_Read_NhanVien_DP;
class Program { static void Main() { Console.WriteLine("--- ITERATOR: Duyet Danh Sach Nhan Vien ---"); var list = new List<Employee> { new Employee{Name="Nguyen Van A", Age=25}, new Employee{Name="Tran Thi B", Age=30} }; var iter = new EmployeeIterator(list); while(iter.HasNext()) { var emp = iter.Next(); Console.WriteLine("- " + emp.Name + " (" + emp.Age + " tuoi)"); } } }