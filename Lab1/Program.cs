﻿namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            Blue blue = new Blue();
            Console.WriteLine(blue.Task1(1.2));
            Console.WriteLine(blue.Task2(2));
            Console.WriteLine(blue.Task3(2, 1));
            //Console.WriteLine(white.Task4(-2.5, 1.89));
            //Console.WriteLine(white.Task5(0.5));
            //Console.WriteLine(white.Task6(2.5, 1.89, 3));
            Console.WriteLine(blue.Task7(2));
        }
    }
}
