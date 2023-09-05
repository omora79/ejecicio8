// Construir un programa que pida un número y luego diga si este número es par o no.

// 1 clase y metodo

public class Ejercicio8
{
    static void Main(string[] args)
    {
        // 2 declaracion de variables

        double num;

        // 3 pedir datos por pantalla

        Console.WriteLine("Escriba un numero: ");
        num = Convert.ToDouble(Console.ReadLine());

        if ((num % 2) == 0)
        {
            Console.WriteLine($"El numero {num} es par");

        }
        else
        {
            Console.WriteLine($"el numero {num} es impar");
        }
    }
}
