using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_10
{
    //класс угол
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            Console.WriteLine("Задайте угол, градусы целым числом: ");
            angle.Gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте угол, минуты целым числом: ");
            angle.Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте угол, секунды целым числом: ");
            angle.Sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;

        void angle(int gradus, int min, int sec) //конструктор
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public void ToRadians() //метод для перевода угла в радианы
        {
            double radians = gradus * Math.PI / 180 + min * Math.PI / (180 * 60) + sec * Math.PI / (180 * 60 * 60);
            Console.WriteLine("Значение угла {0} {1}' {2}'' - в радианах: {3}", gradus, min, sec, radians);
        }
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360) //угол должен быть от 0 до 360 градусов
                {
                    this. gradus = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение угла в градусах; угол должен быть от 0 до 360");
                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60) // значение минут от 0 до 60
                {
                    this. min = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение угла в минутах, в 1 градусе - 60 минут");
                }
            }
            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60) //значение секунд от 0 до 60
                {
                    this. sec = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение угла в секундах, в 1 минуте - 60 секунд");
                }
            }
            get
            {
                return sec;
            }
        }
    }
}
    
    

