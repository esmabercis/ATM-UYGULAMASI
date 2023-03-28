// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System;
using System.Reflection.PortableExecutable;




    string pW = "1234";
    int Balance = 1000;



for (int i = 2 ; i >  0 ; i--)
{
    Console.WriteLine("Lütfen şifrenizi giriniz.");
    string pWCheck = Console.ReadLine();

    if (pW != pWCheck)
    {

        Console.WriteLine("Yanlış şifre. Sadece" + " " + i + " " + "hakkın kaldı:");
        Console.ReadLine();
        if (i == 1)
        {
            Console.WriteLine("Hakkın bitti.");
            Console.ReadLine();

        }



    }
    else if (pW == pWCheck)
    {

        

        Console.WriteLine("Hoşgeldiniz... ");

        Console.WriteLine("Lütfen bir işlem seçiniz:");

        Console.WriteLine("1-Para Çekme");

        Console.WriteLine("2-Para Yatırma");

        Console.WriteLine("3-Bakiye Sorgulama");

        Console.WriteLine("4-Kart İade");

        string choose = Console.ReadLine();

        switch (choose)
        {
            case "1":
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz.");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar > Balance)
                {
                    Console.WriteLine("Bakiyeniz yetersiz.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Kalan Bakiyeniz:" + (Balance - cekilecek_tutar));
                    Console.ReadLine();

                }

                break;

            case "2":
                Console.WriteLine("Para Yatırmak İstediğiniz Tutarı Giriniz:");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Balance = yatirilacak_tutar + Balance;
                Console.WriteLine("Yeni Bakiyeniz:" + (Balance));
                Console.ReadLine();
                break;

            case "3":
                Console.WriteLine("Bakiyeniz:" + Balance);
                Console.ReadLine();
                break;

            case "4":
                Console.WriteLine("Hesabınızdan Çıkış Yapılıyor.Hoşçakal..");
                Console.ReadLine();

                break;

            default:
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz.");
                Console.ReadLine();
                break;




        }
    }

}