using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Product[] technika = new Product[6];
            technika[0] = new Product(1, "Toshiba TG01", 0001, "беларусь", 40.05F, 10, "2009, 1, 1");
            technika[1] = new Product(2, "Nokia G20", 0010, "китай", 60.8F, 20, "2016, 2, 2");
            technika[2] = new Product(3, "Samsung Galaxy A32", 0011, "южная корея", 45.2F, 30, "2015, 3, 3");
            technika[3] = new Product(4, "Toshiba Portege", 0100, "китай", 120.05F, 40, "2018, 4, 4");
            technika[4] = new Product(5, "Nokia Purebook X14", 0101, "китай", 200.8F, 50, "2019, 6, 5");
            technika[5] = new Product(6, "Samsung Galaxy Book", 0111, "южная корея", 320F, 60, "2020, 6, 6");

            Tovari[] tovari = new Tovari[6];
            tovari[0] = new Tovari(technika[0], "телефоны");
            tovari[1] = new Tovari(technika[1], "телефоны");
            tovari[2] = new Tovari(technika[2], "телефоны");
            tovari[3] = new Tovari(technika[3], "ноутбуки");
            tovari[4] = new Tovari(technika[4], "ноутбуки");
            tovari[5] = new Tovari(technika[5], "ноутбуки");


            Console.WriteLine("Какую категорию товаров хотите выбрать:(телефоны , ноутбуки)");
            string vvod = Console.ReadLine();

            Product[] lol = new Product[6];
            Tovari vid = new Tovari(lol[0], vvod );
            for (int i = 0; i < 6; i++)
            {
                bool p1 = tovari[i].Equals(vid);
                if (tovari[i].VID == vvod && p1 == true)
                {
                    Console.WriteLine(technika[i]);
                    Console.WriteLine(p1);
                    Console.WriteLine(tovari[i].GetHashCode());

                }
                else
                {
                    Console.WriteLine(technika[i].NAME);
                    Console.WriteLine(p1);
                }
            }

            Console.WriteLine("Какую цену выбираете:");
            float vvod1 = Convert.ToSingle(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                if (technika[i].CENA < vvod1 && tovari[i].VID == vvod)
                {
                    Console.WriteLine(technika[i]);
                }
            }
        }
    }
    public partial class Product
    {

        public int ID { get; set; }
        public string NAME { get; set; }
        public int UPC { get; set; }
        public string IZGOTOVIL { get; set; }
        public float CENA { get; set; }
        public string SROK { get; set; }
        public int KOLVO { get; set; }
        public string VID { get; set; }
        public Product(int id, string name, int upc, string izgotovil, float cena, int kolvo, string srok)
        {
            ID = id;
            NAME = name;
            UPC = upc;
            IZGOTOVIL = izgotovil;
            CENA = cena;
            KOLVO = kolvo;
            SROK = srok;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != KOLVO.GetType()) return false;
            if (obj == null) return false;
            Product person = (Product)obj;
            return (this.KOLVO == person.KOLVO);
        }
        public override int GetHashCode()
        {
            return CENA.GetHashCode();
        }
    }
    public partial class Product
    {
        public override string ToString()
        {
            return "ID: " + ID + "\tНАЗВАНИЕ: " + NAME + "\tUPC: " + UPC + "\tИзготовитель: " + IZGOTOVIL + "\tЦЕНА: " + CENA + "\tКОЛВО: " + KOLVO + "\tСРОК: " + SROK;
        }


    }
    public class Tovari
    {
        public string VID { get; set; }
        private string Value
        {
            get { return VID; }
        }
        public Tovari(Product massiv, string vid)
        {
            VID = vid;
        }
        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object vid)
        {
            if (vid.GetType() != this.GetType()) return false;
            if (vid == null) return false;
            Tovari person = (Tovari)vid;
            return (this.VID == person.VID);
        }
        public override int GetHashCode()
        {
            return VID.GetHashCode();
        }
        
    }
}
