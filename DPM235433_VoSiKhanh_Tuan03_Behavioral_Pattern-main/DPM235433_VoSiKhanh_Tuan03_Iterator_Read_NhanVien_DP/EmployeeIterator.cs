using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan03_Iterator_Read_NhanVien_DP;
public class EmployeeIterator : IIterator { private List<Employee> _list; private int _index = 0; public EmployeeIterator(List<Employee> list) => _list = list; public bool HasNext() => _index < _list.Count; public Employee Next() => _list[_index++]; }