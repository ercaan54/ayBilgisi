namespace ayBilgisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("lütfen 1 ile 12 arasında bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("ocak");
                    break;
                    case 2:
                    Console.WriteLine("subat");
                    break;  
                    case 3:
                    Console.WriteLine("mart");
                    break;
                    case 4:
                    Console.WriteLine("nisan");
                    break;
                    case 5:
                    Console.WriteLine("mayıs");
                    break;
                    case 6:
                    Console.WriteLine("haziran");
                    break;
                    case 7:
                    Console.WriteLine("temmuz");
                    break;
                    case 8:
                    Console.WriteLine("ağustos");
                    break;
                    case 9:
                    Console.WriteLine("eylül");
                    break;
                    case 10:
                    Console.WriteLine("ekim");
                    break;  
                    case 11:
                    Console.WriteLine("kasım");
                    break;  
                    case 12:
                    Console.WriteLine("aralık");
                    break;
            */


            Console.WriteLine("lutfen 1 ile 12 arasında bir sayı giriniz");
            int ay = Convert.ToInt32(Console.ReadLine());

            if (ay == 12 || ay == 1 || ay == 2)
            {
                Console.WriteLine("kış");
            }
            else if (ay == 3 || ay == 4 || ay == 5)
            {

                Console.WriteLine("ilkbahar");

            }
            else if (ay == 6 || ay == 7 || ay == 8)
            {
                Console.WriteLine("yaz");
            }
            else if(ay == 9 || ay == 10 || ay == 11)
            {
                Console.WriteLine("sonbahar");
            }
            else
            {
                Console.WriteLine("gecersiz bir sayı girdiniz lütfen tekrardan 1 ile 12 arasında bir sayı giriniz");
            }

















            }
        }
    }

