
int jumlahBuku, hargaBuku, ongkosKirim, totalBayar;

Console.Write("Jumlah Buku : ");
jumlahBuku = int.Parse(Console.ReadLine());
Console.Write("Harga Buku : ");
hargaBuku = int.Parse(Console.ReadLine());
Console.Write("Ongkos Kirim : ");
ongkosKirim = int.Parse(Console.ReadLine());

totalBayar = jumlahBuku * hargaBuku + ongkosKirim;

Console.WriteLine("Total bayar = " + totalBayar);
