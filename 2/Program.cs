using System;

namespace homework1

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                double Number_one = Convert.ToDouble(Console.ReadLine());
                double Number_two = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберете действие");
                Console.WriteLine('+');
                Console.WriteLine('-');
                Console.WriteLine('*');
                Console.WriteLine('/');
                double Exit_Number = Convert.ToDouble(Console.ReadLine());
                switch (Exit_Number)
                {
                    case 1:
                        Console.WriteLine(Number_one + Number_two);
                        break;
                    case 2:
                        Console.WriteLine(Number_one - Number_two);
                        break;
                    case 3:
                        Console.WriteLine(Number_one * Number_two);
                        break;
                    case 4:
                        if (Number_two == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine(Number_one / Number_two);
                        }
                        break;
                    default:
                        Console.WriteLine("Выберете из доступного");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка. Используйте только цифры");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

        }
    }
}
