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
        angle angle = new Angle(90,50,30);
        Console.WriteLine(angle.gradus);
        Console.WriteLine(angle.min);
        Console.WriteLine(angle.sec);
       
        Console.ReadKey();
        }
    }
    class angle
    {
        public int gradus { get; set; } // значение угла в градусах
        public int min { get; set; } //угловые минуты
        public int sec { get; set; } // угловые секунды
    }
        public int gradus
    {
        set
        {
            if (value > 0 && value > 360) //угол должен быть от 0 до 360 градусов
            {
               int gradus = value;
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
    public int min
    {
        set
        {
            if (value > 0 && value >60) // значение минут от 0 до 60
            {
                int min = value;
            }
            else
            {
                Console.WriteLine("Некорректное значение угла в минутах, в 1 градус  = 60 минут");
            }
        }
        get
        {
            return min;
        }
    }
    public int sec
    {
        set
        { 
            if (value > 0 && value > 60) //значение секунд от 0 до 60
            {
                int sec = value;
            }
            else
            {
                Console.WriteLine("Некорректное значение угла в секундах, в 1 минуте = 60 секунд");
            }
        }
        get
        {
            return sec;
        }
    }
    public angle(int gradus, int min, int sec) //конструктор
        {
            this. gradus = gradus;
            this. min = min;
            this. sec = sec;
        }
    int radian = 0;

       static void ToRadians(int gradus, int min, int sec) //метод для перевода угла в радианы
        {

        Console.WriteLine("Перевод величины угла {0} из градусов в радианы {1} ", );
        }
     
    }
}
