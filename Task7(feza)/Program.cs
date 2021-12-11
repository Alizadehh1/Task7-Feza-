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
            l1:
            try
            {
            Console.Write("Konusun Radiusunu daxil edin: ");
            k.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Konusun Hundurluyunu daxil edin: ");
            k.Height = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Konus ucun daxil etdiyiniz deyer duzgun deyiL!");
                goto l1;
            }


            Console.WriteLine($"Konusun Oturacaginin Sahesi: {k.Soturacaq()}");
            Console.WriteLine($"Konusun Hecmi: {k.Hecm()}");

            Silindr s = new Silindr();
            Console.WriteLine("********************SİLİNDR********************");
            l2:
            try
            {
                Console.Write("Silindrin radiusunu daxil edin: ");
                s.Radius = Convert.ToDouble(Console.ReadLine());

                Console.Write("Silindrin Hundurluyunu daxil edin: ");
                s.Height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Silindr ucun daxil etdiyiniz deyer duzgun deyiL!");
                goto l2;

            }

            

            Console.WriteLine($"Silindrin Oturacaginin Sahesi: {s.Soturacaq()}");
            Console.WriteLine($"Silindrin Hecmi: {s.Hecm()}");
            Console.WriteLine($"Silindrin Tam Sethinin Sahesi: {s.Stam()}");

            DuzbucaqliParaleliped dp = new DuzbucaqliParaleliped();
            Console.WriteLine("********************Duzbucaqli Paraleliped********************");
            l3:
            try
            {
                Console.Write("Duzbucaqli Paralelipedin Enini daxil edin: ");
                dp.Width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Duzbucaqli Paralelipedin Uzunlughunu daxil edin: ");
                dp.Length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Duzbucaqli Paralelipedin Hundurluyunu daxil edin: ");
                dp.Height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Duzbucaqli Paraleliped ucun daxil etdiyiniz deyer duzgun deyiL!");
                goto l3;

            }
            

            Console.WriteLine($"Duzbucaqli Paralelipedin Hecmi: {dp.Hecm()}");
            Console.WriteLine($"Duzbucaqli Paralelipedin Tam Sethinin Sahesi: {dp.Stam()}");
            Console.WriteLine("***********************************************************");
        }
    }
}
