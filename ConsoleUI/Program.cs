using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç: " + car.Description);
                Console.WriteLine("Günlük Kiralama Bedeli: " + car.DailyPrice + " TL");
                Console.WriteLine("---------");
            }
        }
    }
}
/*
            // Category Business (Abstract ve Concrete) eklenecek
            // Brand tamamı eklenecek
            // Color tamamı eklenecek

            // Kategori bilgisi yazdırma eklenecek.

            ID Kategoriler

            1  Sedan
            2  Coupe
            3  Hatchback
            4  Van
            5  Pick-up
            6  Station Wagon
            7  Cabrio
            8  SUV

            ID Markalar

            1  BMW
            2  Dacia
            3  Fiat
            4  Ford
            5  Mercedes-Benz
            6  Mitsubishi
            7  Nissan
            8  Peugeot
            9  Range Rover
            10 Renault
            11 Toyota
            12 Volkswagen

            ID Renkler
            1  siyah
            2  beyaz
            3  kırmızı
            4  sarı
            5  mavi
            6  bordo
            7  krem
            8  yeşil
*/
