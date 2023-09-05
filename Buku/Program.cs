int jumlahBuku, hargaBuku, totalBayar;

Console.Write("Jumlah buku : ");
jumlahBuku = int.Parse(Console.ReadLine());
Console.WriteLine("Harga buku : ");
hargaBuku = int.Parse(Console.ReadLine());

totalBayar = jumlahBuku * hargaBuku;

Console.WriteLine("Total bayar = " + totalBayar);
