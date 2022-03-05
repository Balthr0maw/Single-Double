using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Double
{
    class Program
    {
        public static char[] alfabe = { 'a','b','c', 'd','e','f', 'g', 'h', 'i', 'j', 'k',
         'l', 'm', 'n','o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        static void Main(string[] args)
        {


            Console.WriteLine("1- Sifreleme \n2- Sifre Cozme \n Secim : ");
            int secim = Int32.Parse(Console.ReadLine());

            if (secim == 1)
            {
                encryption();
            }
            else if (secim == 2)
            {
                decryption();
            }
            else
            {
                Console.WriteLine("Gecersiz Secim");
            }


        }

        static void encryption()
        {
            Console.Write("Sifrenlenmek istenen metin : ");
            string acikMetin = Console.ReadLine();
            int uzunluk = acikMetin.Length;
            Console.Write("Sifreli Metin : ");
            char temp;

            if (uzunluk % 2 == 0)
            {
                foreach (char c in acikMetin.ToLower())
                {

                    temp = c;
                    for (int i = 0; i < 25; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[(i + 7) % 25];
                        }
                    }
                    Console.Write(temp);

                }
                Console.ReadLine();
            }

            if (uzunluk % 2 == 1)
            {
                foreach (char c in acikMetin.ToLower())
                {

                    temp = c;
                    for (int i = 0; i < 25; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[(i + 5) % 25];
                        }
                    }
                    Console.Write(temp);

                }
                Console.ReadLine();
            }

        }
        static void decryption()
        {
            Console.Write("Cozulmek istenen metin : ");
            string sifreliMetin = Console.ReadLine();
            int uzunluk = sifreliMetin.Length;
            Console.Write("Acık Metin : ");
            char temp;

            if (uzunluk % 2 == 0)
            {
                foreach (char c in sifreliMetin.ToLower())
                {
                    temp = c;
                    for (int i = 0; i < 25; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[((i - 6) + 25) % 25];
                        }
                    }
                    Console.Write(temp);
                }
                Console.ReadLine();
            }

            if (uzunluk % 2 == 1)
            {
                foreach (char c in sifreliMetin.ToLower())
                {
                    temp = c;
                    for (int i = 0; i < 25; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[((i - 5) + 25) % 25];
                        }
                    }
                    Console.Write(temp);
                }
                Console.ReadLine();
            }

        }

    }
}
