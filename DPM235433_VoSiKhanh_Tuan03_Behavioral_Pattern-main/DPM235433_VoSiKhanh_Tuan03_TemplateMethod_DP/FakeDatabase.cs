namespace DPM235433_VoSiKhanh_Tuan03_TemplateMethod_DP;

/// <summary>Mo phong co so du lieu ban hang</summary>
public static class FakeDatabase
{
    public static readonly List<SaleRecord> Sales = new()
    {
        new("Nguyen Van Thuan", "Thuoc tru sau Furadan", 30, 85_000,  new DateTime(2026,9,1)),
        new("Tran Thi Mai",     "Phan bon NPK",          50, 120_000, new DateTime(2026,9,2)),
        new("Nguyen Van Thuan", "Hat giong lua OM18",    20, 45_000,  new DateTime(2026,9,3)),
        new("Le Van Hung",      "Thuoc diet co Sofit",   15, 200_000, new DateTime(2026,9,5)),
        new("Tran Thi Mai",     "Thuoc tru sau Furadan", 10, 85_000,  new DateTime(2026,9,8)),
        new("Le Van Hung",      "Phan bon NPK",          80, 120_000, new DateTime(2026,9,10)),
        new("Nguyen Van Thuan", "Thuoc diet co Sofit",    5, 200_000, new DateTime(2026,9,12)),
        new("Tran Thi Mai",     "Hat giong lua OM18",    40, 45_000,  new DateTime(2026,9,15)),
    };
}