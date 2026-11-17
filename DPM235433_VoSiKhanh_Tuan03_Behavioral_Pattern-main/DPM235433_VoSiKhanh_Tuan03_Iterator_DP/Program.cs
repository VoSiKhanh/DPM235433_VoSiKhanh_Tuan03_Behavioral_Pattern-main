using DPM235433_VoSiKhanh_Tuan03_Iterator_DP;

Console.WriteLine("==========================================================");
Console.WriteLine("  ITERATOR PATTERN - Nong Duoc An Giang");
Console.WriteLine("  Nghiep vu: Duyet danh sach lo hang theo tieu chi");
Console.WriteLine("==========================================================\n");

var col = new BatchCollection();
col.Add(new Batch { BatchId="LH001", ProductName="Thuoc tru sau Furadan",  Quantity=100, ImportDate=new DateTime(2026,1,15),  ExpiryDate=new DateTime(2027,6,15)  });
col.Add(new Batch { BatchId="LH002", ProductName="Phan bon NPK 16-16-8",  Quantity=200, ImportDate=new DateTime(2026,3,10),  ExpiryDate=new DateTime(2026,9,10)  });
col.Add(new Batch { BatchId="LH003", ProductName="Hat giong lua OM18",     Quantity=150, ImportDate=new DateTime(2025,12,20), ExpiryDate=new DateTime(2026,6,20)  });
col.Add(new Batch { BatchId="LH004", ProductName="Thuoc diet co Sofit",    Quantity=80,  ImportDate=new DateTime(2026,5,1),   ExpiryDate=new DateTime(2028,1,1)   });
col.Add(new Batch { BatchId="LH005", ProductName="Phan vi sinh Komix",     Quantity=120, ImportDate=new DateTime(2026,2,28),  ExpiryDate=new DateTime(2026,8,28)  });

Console.WriteLine(">>> DUYET THEO HAN SU DUNG - FEFO (sap het han truoc):");
Console.WriteLine("------------------------------------------------------");
var expiryIt = col.CreateExpiryIterator();
int i = 1;
while (expiryIt.HasNext())
{
    var batch = expiryIt.Next();
    int days = (batch.ExpiryDate - DateTime.Today).Days;
    string warn = days < 180 ? " <<< SAP HET HAN!" : "";
    Console.WriteLine($"  {i++}. {batch}{warn}");
}

Console.WriteLine();
Console.WriteLine(">>> DUYET THEO NGAY NHAP - LIFO (moi nhat truoc):");
Console.WriteLine("------------------------------------------------------");
var dateIt = col.CreateDateIterator();
i = 1;
while (dateIt.HasNext())
    Console.WriteLine($"  {i++}. {dateIt.Next()}");

Console.WriteLine("\nNhan phim bat ky de thoat...");
Console.ReadKey();