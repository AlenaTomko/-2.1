using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3

{
    public class Calculator
    {
        public int add(int a, int b) // создание класса сложение 
        {
            return a + b; // возвращяет сумму двух переменных  и так далее в других методах 
        }
        public int subtract(int a, int b) // создание класса вычитание
        {
            return a - b;
        }
        public int multiply(int a, int b) // создание класса умножение
        {
            return a * b;
        }
        public int divide(int a, int b) // создание класса деление
        {
            if (a == 0) // если одна из переменных будет равна 0 то выводиться ошибка
            {
                Console.WriteLine("Ошибка на 0 делить нельзя!"); // сообщение об ошибке
            }
            return (a / b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator(); // создание обьекта 
            Console.WriteLine(calculator.add(9, 4)); // вывод метода с класса сложение 
        }
    }
}
