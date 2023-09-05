double jariLingkaran, nilaiPi, luasLingkaran, kelilingLingkaran;

Console.Write("Jari jari lingkaran : ");
jariLingkaran = double.Parse(Console.ReadLine());
Console.WriteLine("Nilai pi : 22/7 atau 3.14");

nilaiPi = 3.14;
luasLingkaran = nilaiPi * jariLingkaran * jariLingkaran;
kelilingLingkaran = 2 * nilaiPi * jariLingkaran;

Console.WriteLine("Luas lingkaran = " + luasLingkaran);
Console.WriteLine("Keliling lingkaran = " + kelilingLingkaran);

