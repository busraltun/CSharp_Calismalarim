using System;

namespace ToDo_App
{
    class Program
    {
        static void Main(string[] args)
        { 
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("******************************************** ");

                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine ("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak \n");

                int secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("Board listelendi \n");
                }
                   
                else if (secim == 2)
                {
                    Console.WriteLine("Board a kart eklendi \n");

                }
                else if (secim == 3)
                {
                    Console.WriteLine("Board'dan kart silindi \n");

                }
                else if (secim == 4)
                {
                    Console.WriteLine("Kart taşındı \n");

                }

                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız!!! \n");

                }
                // Console.ReadKey();
            }

        }

    }
}
