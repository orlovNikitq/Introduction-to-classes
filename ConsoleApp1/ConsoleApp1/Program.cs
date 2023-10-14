using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //num 1
            /*
            Console.WriteLine("Введите длину стороны квадрата: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите символ:");
            char symbol = Convert.ToChar(Console.ReadLine());
            DrawSquare(side, symbol);
            */
            //num 2
            /*
            int number = 123; 
            if (IsPalindrome(number))
            {
                Console.WriteLine(number + " является палиндромом.");
            }
            else
            {
                Console.WriteLine(number + " не является палиндромом.");
            }
            */
            //num 3
            /*
            List<int> original = new List<int> { 1, 2, 6, -1, 88, 7, 6 };
            List<int> filter = new List<int> { 6, 88, 7 };
            FilterList(original, filter);
            Console.WriteLine("Результат работы метода:");
            foreach (var el in original)
            {
                Console.Write(el + " ");
            }
            */
            //num 4
            /*
            Website website = new Website();
            website.InputData();
            Console.WriteLine();
            website.Display();

            Console.WriteLine();
            website.URL = "dsfdsf";
            website.Display();
            */
            //num 5
            /*
            Journal journal = new Journal();
            journal.InputData();
            Console.WriteLine();
            journal.Display();

            Console.WriteLine();
            journal.Phone = "dsfdsf";
            journal.Display();
            */
            //num 6
            /*
            Shop shop = new Shop();
            shop.InputData();
            Console.WriteLine();
            shop.Display();

            Console.WriteLine();
            shop.Description = "dsfdsf";
            shop.Display();
            */
        }
        static void DrawSquare(int side, char symbol)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            for (int i = 0; i < numberStr.Length / 2; i++)
            {
                if (numberStr[i] != numberStr[numberStr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void FilterList(List<int> original, List<int> filter)
        {
            original.RemoveAll(item => filter.Contains(item));
        }
    }
    internal class Website
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string URL
        {
            get { return url; }
            set { url = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }

        public void InputData()
        {
            Console.WriteLine("Введите название сайта:");
            name = Console.ReadLine();

            Console.WriteLine("Введите URL сайта:");
            url = Console.ReadLine();

            Console.WriteLine("Введите описание сайта:");
            description = Console.ReadLine();

            Console.WriteLine("Введите IP-адрес сайта:");
            ip = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Название сайта: " + name);
            Console.WriteLine("URL сайта: " + url);
            Console.WriteLine("Описание сайта: " + description);
            Console.WriteLine("IP-адрес сайта: " + ip);
        }
    }
    internal class Journal
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void InputData()
        {
            Console.WriteLine("Введите название журнала:");
            name = Console.ReadLine();

            Console.WriteLine("Введите год основания:");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите описание журнала:");
            description = Console.ReadLine();

            Console.WriteLine("Введите контактный телефон:");
            phone = Console.ReadLine();

            Console.WriteLine("Введите email:");
            email = Console.ReadLine();

        }
        public void Display()
        {
            Console.WriteLine("название журнала: " + name);
            Console.WriteLine("год основания: " + year);
            Console.WriteLine("Описание сайта: " + description);
            Console.WriteLine("контактный телефон: " + phone);
            Console.WriteLine("email: " + email);
        }
    }
    internal class Shop
    {
        private string name;
        private string address;
        private string description;
        private string phone;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void InputData()
        {
            Console.WriteLine("Введите название магазина:");
            name = Console.ReadLine();

            Console.WriteLine("Введите адрес:");
            address = Console.ReadLine();

            Console.WriteLine("Введите описание профиля магазина:");
            description = Console.ReadLine();

            Console.WriteLine("Введите контактный телефон:");
            phone = Console.ReadLine();

            Console.WriteLine("Введите email:");
            email = Console.ReadLine();

        }
        public void Display()
        {
            Console.WriteLine("название магазина: " + name);
            Console.WriteLine("адрес: " + address);
            Console.WriteLine("описание профиля магазина: " + description);
            Console.WriteLine("контактный телефон: " + phone);
            Console.WriteLine("контактный email: " + email);
        }
    }
}