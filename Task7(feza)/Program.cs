using System;
using Task7_feza_.Feza_Fiqurlari;

namespace Task7_feza_
{
    class Program
    {
        static void Main(string[] args)
        {
            Konus k = new Konus();
            Console.WriteLine("*********************KONUS*********************");

            Console.Write("Konusun Radiusunu daxil edin: ");
            k.radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Konusun Hundurluyunu daxil edin: ");
            k.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Konusun Oturacaginin Sahesi: {k.Soturacaq()}");
            Console.WriteLine($"Konusun Hecmi: {k.Hecm()}");

            Silindr s = new Silindr();
            Console.WriteLine("********************SİLİNDR********************");

            Console.Write("Silindrin radiusunu daxil edin: ");
            s.radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Silindrin Hundurluyunu daxil edin: ");
            s.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Silindrin Oturacaginin Sahesi: {s.Soturacaq()}");
            Console.WriteLine($"Silindrin Hecmi: {s.Hecm()}");
            Console.WriteLine($"Silindrin Tam Sethinin Sahesi: {s.Stam()}");

            DuzbucaqliParaleliped dp = new DuzbucaqliParaleliped();
            Console.WriteLine("********************Duzbucaqli Paraleliped********************");

            Console.Write("Duzbucaqli Paralelipedin Enini daxil edin: ");
            dp.width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Duzbucaqli Paralelipedin Uzunlughunu daxil edin: ");
            dp.lenght = Convert.ToDouble(Console.ReadLine());

            Console.Write("Duzbucaqli Paralelipedin Hundurluyunu daxil edin: ");
            dp.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Duzbucaqli Paralelipedin Hecmi: {dp.Hecm()}");
            Console.WriteLine($"Duzbucaqli Paralelipedin Tam Sethinin Sahesi: {dp.Stam()}");
            Console.WriteLine("***********************************************************");
        }
    }
}
