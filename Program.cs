namespace EbobEkok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ebob=1;
            Console.Write("1. sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 < sayi2)
            {
                for(int a =1; a<sayi2; a++)
                {
                    if(sayi2 % a ==0 && sayi1 % a == 0)
                    {
                        ebob = a;
                    }
                }
            }
            else
            {
                for (int a = 1; a < sayi1; a++)
                {
                    if (sayi2 % a == 0 && sayi1 % a == 0)
                    {
                        ebob = a;
                    }
                }
            }
            Console.WriteLine("EBOB {0}", ebob);
            Console.WriteLine("EKOK {0}", (sayi1*sayi2)/ebob);
            Console.ReadKey();
        }
    }
}
