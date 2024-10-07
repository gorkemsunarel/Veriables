using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            double number;
            number = 4.85;
            Console.WriteLine(number);



            Console.WriteLine("*****Fiyat Listesi*****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 11.45;
            strawberryPrice = 22.50;
            potatoPrice = 5.40;
            tomatoPrice = 10.50;

            Console.WriteLine("*----Elma Birim Fiyatı: " + applePrice + "Tl");
            Console.WriteLine("*----Portakal Birim Fiyatı: " + orangePrice + "Tl");
            Console.WriteLine("*----Çilek Birim Fiyatı: " + strawberryPrice + "Tl");
            Console.WriteLine("*----Patates Birim Fiyatı: " + potatoPrice + "Tl");
            Console.WriteLine("*----Domates Birim Fiyatı: " + tomatoPrice + "Tl");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.2650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 2.754;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;



            Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyatı: " + applePrice + " -Gramaj :" + appleGram + " Toplam Tutar :" + appleTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün:Portakal - " + "Birim Fiyatı: " + orangePrice + " -Gramaj :" + orangeGram + " Toplam Tutar :" + orangeTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün:Çilek - " + "Birim Fiyatı: " + strawberryPrice + " -Gramaj :" + strawberryGram + " Toplam Tutar :" + strawberryTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün:Patates - " + "Birim Fiyatı: " + potatoPrice + " -Gramaj :" + potatoGram + " Toplam Tutar :" + potatoTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün:Domates - " + "Birim Fiyatı: " + tomatoPrice + " -Gramaj :" + tomatoGram + " Toplam Tutar :" + tomatoTotalPrice + "TL");


            Console.WriteLine("-------------------");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + strawberryTotalPrice + potatoTotalPrice;
            Console.WriteLine("Toplam Tutar:" + shoppingTotalPrice);

            #endregion

            #region Char Değişkenler
            // char değişkenler ' tek tırnakla tanımlanır.

            //char name= 'A';
            //Console.WriteLine(name);

            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("*****C Sharp HavaYolları Yolcu Bilgisi*****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi ");
            passengerCity = Console.ReadLine();

            Console.Write("Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu T.C kimlik numarası: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("------------------");

            Console.WriteLine("Yolcu: " + passengerName + passengerSurname + " " + passengerDistrict + " " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;


            int shoesCount, computerCount, chairCount, tvCount;
            Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz");
            shoesCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz");
            computerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz");
            chairCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz");
            tvCount = int.Parse(Console.ReadLine());



            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            Console.WriteLine();

            Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            double exam1, exam2, exam3, result;

            Console.Write("Lüften 1.Sınav Notunu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lüften 2.Sınav Notunu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lüften 3.Sınav Notunu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());


            result=(exam1+ exam2+exam3)/3;
            Console.WriteLine();

            Console.WriteLine("Sınav Ortalamanız: " + result); 
            #endregion

            #region Klavyeden Karakter Girişleri
            Console.WriteLine("Lüfen Cinsiyet Seçiniz:");

            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion

            Console.Read();
        }
    }
}
