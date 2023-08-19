using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");
            byte b = 5;   // 1 byte
            sbyte c = 5;  // 1 byte
            short s = 5;  // 2 byte 

            ushort us = 5;   // 2byte

            Int16 i16 = 2;  // 2 byte 
            int i = 2;    // 4byte
            int i32 = 2;  // 4byte
            int i64 = 2;  //8byte

            uint u = 2;   //4byte
            long l = 2;   //8byte
            ulong ul = 4; // 8byte

            //Reel sayılar
            float f = 5;  //4byte
            double d = 5; //8byte
            decimal de = 5;  //16 byte

            char ch = '2';  // 2byte

            string str = "Biltekin";// sınırsız

            bool b1 = true;
            bool b2 = false;


            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);


            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler 

            string str1 = string.Empty;

            str1 = "Biltekin Kurtuluş";
            string ad = "Biltekin";
            string soyad = "Kurtuluş";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;


            //boolen

            bool bool1 = 10 > 2;

            //Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);//çıktı2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);//çıktı 40

            int int22 = int20 + int.Parse(str20);  // çıktısı 40


            // dateTime

            string dateTime2 = DateTime.Now.ToString("dd.MM.yyy");
            Console.WriteLine(dateTime2);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");

            int degisken = 5;
            
            Console.WriteLine(degisken);

            Console.ReadLine();
        }
        
    }
}
