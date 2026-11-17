using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan03_Observer_Read_NhanVien_DP;
public class HRDepartment { private List<IObserver> _observers = new(); public void Subscribe(IObserver o) => _observers.Add(o); public void NotifyAll(string msg) { foreach(var o in _observers) o.Update(msg); } }