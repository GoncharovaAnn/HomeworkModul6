using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundOf { get; set; }
        public Device(string name, string description, string soundOf) 
        {
            Name = name;
            Description = description;
            SoundOf = soundOf;  
        }
        public void Sound()
        {
            Console.WriteLine($"Звук устройства: {SoundOf}");
        }
        public void Show()
        {
            Console.WriteLine($"Название устройства: {Name}");
        }
        public void Desc()
        {
            Console.WriteLine($"Описание устройства: {Description}");
        }
    }
    class Kettle : Device
    {
       public Kettle(string name, string description, string soundOf) : base(name, description, soundOf) 
       { 

       }
    }
    class Microwave : Device
    {
        public Microwave(string name, string description, string soundOf) : base(name, description, soundOf)
        {

        }
    }
    class Automobile : Device 
    {
        public Automobile(string name, string description, string soundOf) : base(name, description, soundOf)
        {

        }
    } 
    class Steamboat : Device 
    {
        public Steamboat(string name, string description, string soundOf) : base(name, description, soundOf)
        {

        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle ("Чайник",  "Полое изделие различной формы с крышкой, ручкой и носиком, предназначенное для кипячения воды и заваривания чая", "Звук кипящей воды \"БульБульБуль\"");
            kettle.Sound();
            kettle.Show();
            kettle.Desc();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            Microwave microwave = new Microwave("Микроволновка", "Электроприбор, позволяющий совершать разогрев водосодержащих веществ благодаря электромагнитному излучению дециметрового диапазона (обычно с частотой 2450 МГц) и предназначенный для быстрого приготовления, подогрева или размораживания пищи", "\"вуввВуВВвуввВуВВвуввВ\" и мерзкое пикащание если не остановить её за секунду до...");
            microwave.Sound();
            microwave.Show();
            microwave.Desc();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            Automobile automobile = new Automobile("Автомобиль", "Моторное безрельсовое дорожное и/или внедорожное, чаще всего автономное, транспортное средство, используемое для перевозки людей и/или грузов, имеющее от четырёх колёс", "Звук мотора \"вввввввВВВВВВВВВВввввввв\"");
            automobile.Sound();
            automobile.Show();
            automobile.Desc();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            Steamboat steamboat = new Steamboat("Пароход", "Судно, оснащённое поршневой паровой машиной или паровой турбиной в качестве тягового двигателя", "Низкий и громкий звук клаксона \"ПппууууУУУУУуууууу\"");
            steamboat.Sound();
            steamboat.Show();
            steamboat.Desc();
        }
    }
}
