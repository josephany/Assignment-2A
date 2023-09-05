double nilaiTengahSemester, nilaiAkhirSemester, nilaiAkhir;

Console.Write("Nilai Tengah Semester : ");
nilaiTengahSemester = double.Parse(Console.ReadLine());
Console.Write("Nilai Akhir Semester : ");
nilaiAkhirSemester = double.Parse(Console.ReadLine());
Console.WriteLine("Nilai Akhir = 40% NTS + 60% NAS");

nilaiAkhir = (0.4 * nilaiTengahSemester) + (0.6 * nilaiAkhirSemester);

Console.WriteLine("Nilai Akhir = " +  nilaiAkhir);

