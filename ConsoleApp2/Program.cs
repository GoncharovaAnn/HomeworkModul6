using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MusicInst
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundOf { get; set; }
        public string History { get; set; }
        public MusicInst(string name, string description, string soundOf, string history)
        {
            Name = name;
            Description = description;
            SoundOf = soundOf;
            History = history;
        }
        public void Sound()
        {
            Console.WriteLine($"Звук музыкального инструмента: {SoundOf}");
        }
        public void Show()
        {
            Console.WriteLine($"Название музыкального инструмента: {Name}");
        }
        public void Desc()
        {
            Console.WriteLine($"Описание музыкального инструмента: {Description}");
        }
        public void Hist()
        {
            Console.WriteLine($"История музыкального инструмента: {History}");
        }
    }
    class Violin : MusicInst
    {
        public Violin(string name, string description, string soundOf, string history ) : base(name, description, soundOf, history)
        {

        }
    }
    class Trombone : MusicInst
    {
        public Trombone(string name, string description, string soundOf, string history) : base(name, description, soundOf, history)
        {

        }
    }
    class Ukulele : MusicInst
    {
        public Ukulele(string name, string description, string soundOf, string history) : base(name, description, soundOf, history)
        {

        }
    }
    class Cello : MusicInst
    {
        public Cello(string name, string description, string soundOf, string history) : base(name, description, soundOf, history)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Скрипка", "Смычковый музыкальный инструмент с четырьмя струнами", "Самая высокая регистровая разновидность скрипичного семейства", "Наиболее ранние изображения скрипок близкой к классической формы встречаются в скульптурных композициях начала XVI века. Одно из самых ранних изображений скрипки (трёхструнной, по форме далёкой от классической)  — картина Гауденцио Феррари \"Мадонна апельсиновых деревьев\" (1529)");
            violin.Show();
            violin.Desc();
            violin.Hist();
            violin.Sound();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            Trombone trombone = new Trombone("Тромбон", "Европейский духовой амбушюрный инструмент", "Басово-теноровый регистр", "Появился в XV веке, современный вид приобрёл в середине XIX века. Широко применяется в опере и джазе");
            trombone.Show();
            trombone.Desc();
            trombone.Hist();
            trombone.Sound();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            Ukulele ukulele = new Ukulele("Укулеле", "Гавайская четырёхструнная разновидность гитары, используемая для аккордового сопровождения песен и игры соло", "Высота звучания струн укулеле сопрано, концерт, тенор одинаковая, и образует кварто-терциевый строй", "Укулеле появилась на Гавайских островах во второй половине XIX века, куда её, под названием машети да браса (порт. machete da braça), завезли португальцы с острова Мадейра");
            ukulele.Show();
            ukulele.Desc();
            ukulele.Hist();
            ukulele.Sound();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            Cello cello = new Cello("Виолончель", "смычковый музыкальный инструмент с 4-мя струнами, настроенными по квинтам", "По высоте звучания занимает промежуточное положение между более высоким альтом и низким контрабасом.", "Появление виолончели относится к началу XVI века. Первоначально она применялась как басовый инструмент для сопровождения пения или исполнения на инструменте более высокого регистра");
            cello.Show();
            cello.Desc();
            cello.Hist();
            cello.Sound();
        }
    }
}

