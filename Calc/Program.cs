using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            do
            {

                try
                {
                    Console.Write("Введите первое значение:");
                    float value1 = float.Parse(Console.ReadLine());

                    Console.Write("Введите необходимую операцию:");
                    char operation = char.Parse(Console.ReadLine());

                    Console.Write("Введите второе значение:");
                    float value2 = float.Parse(Console.ReadLine());

                    if (operation == '/' & value2 == 0)
                    {
                        throw new Exception("На ноль делить нельзя.");
                    }

                    float result = GetResult(operation, value1, value2);

                    Console.WriteLine("Результат = {0}", result.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: {0}", ex.Message);
                }

                Console.Write("Желаете выполнить еще одну операцию (y/n)?");
                inputString = Console.ReadLine();

            } while (inputString == "y");
        }

        static float GetResult(char operation, float value1, float value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '/':
                    return value1 / value2;
                case '*':
                    return value1 * value2;
                default:
                    throw new Exception("Данный оператор не поддерживается.");
            }
        }
    }
}
