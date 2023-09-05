int jumlahBuku, hargaBuku;
double diskonBuku, totalBayar;

Console.Write("Jumlah buku : ");
jumlahBuku = int.Parse (Console.ReadLine());
Console.Write("Harga buku : ");
hargaBuku = int.Parse (Console.ReadLine());
Console.WriteLine("Diskon buku : 10%");

diskonBuku = 0.1 * hargaBuku * jumlahBuku;
totalBayar = hargaBuku * jumlahBuku - diskonBuku;

Console.WriteLine ("Total bayar = " + totalBayar);