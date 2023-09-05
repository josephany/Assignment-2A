int jumlahMakanan, jumlahMinuman, jumlahPembelanjaan, hargaMakanan, hargaMinuman, totalBayar;
double pajak, ongkosLayanan;

Console.Write("Jumlah makanan : ");
jumlahMakanan = int.Parse(Console.ReadLine());
Console.WriteLine("Jumlah minuman : ");
jumlahMinuman = int.Parse(Console.ReadLine());
Console.Write("Harga makanan : ");
hargaMakanan = int.Parse((string)Console.ReadLine());
Console.Write("Harga minuman : ");
hargaMinuman = int.Parse((string)Console.ReadLine());

jumlahPembelanjaan = (jumlahMakanan * hargaMakanan) + (jumlahMinuman * hargaMinuman);
pajak = 0.1 * jumlahPembelanjaan;
ongkosLayanan = 0.05 * jumlahPembelanjaan;
totalBayar = (int)(jumlahPembelanjaan + pajak + ongkosLayanan);

Console.WriteLine ("Total bayar = " + totalBayar);


