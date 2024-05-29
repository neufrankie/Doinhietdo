using System;
internal class Program
{
    static void Main()
    {
        
        Console.Write("Nhap vao nhiet do can chuyen doi (°C): ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Nhiet do da duoc chuyen doi la (°F): " + fahrenheit);
    }
}
