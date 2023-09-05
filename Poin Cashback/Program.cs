int totalPembelian;
double poinCashback, totalPoinCashback;

Console.Write("Total pembelian : ");
totalPembelian = int.Parse(Console.ReadLine());
Console.WriteLine("Poin cashback : 1% dari total pembelian");

poinCashback = 0.01 * totalPembelian;

Console.WriteLine("Total poin cashback yang dimiliki = " + poinCashback);
