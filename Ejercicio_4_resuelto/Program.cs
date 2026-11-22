using System;

class Program
{

    // Ejercicio 1
    private delegate int Multiplicar(int x, int y);

    static Multiplicar multiplicar = delegate (int x, int y)
    {
        return x * y;
    };


    // Ejercicio 2
    private delegate bool VerificarPalindromo(string str);

    static VerificarPalindromo verificar = delegate (string str)
    {
        return (new string(str.Reverse().ToArray())) == str;
    };


    // Ejercicio 3
    private delegate double ConvertirTemperatura(double temp);

    static ConvertirTemperatura convertir = delegate (double temp)
    {
        return (temp * 9.0 / 5.0) + 32;
    };


    // Ejercicio 4
    private delegate bool EsMayorQueDiez(int num);

    static EsMayorQueDiez esMayor = delegate (int num)
    {
        return num > 10;
    };


    // Ejercicio 5
    private delegate bool CompararLongitud(string str1, string str2);

    static CompararLongitud comparar = delegate (string str1, string str2)
    {
        return str1.Length == str2.Length;
    };


    // Ejercicio 6
    private delegate int CalcularFactorial(int num);

    static CalcularFactorial calcular = delegate (int num)
    {
        int resultado = 1;

        for (int i = 1; i <= num; i++)
        {
            resultado *= i;
        }

        return resultado;
    };


    // Ejercicio 7
    private delegate int ContarCaracteres(string str);

    static ContarCaracteres contar = delegate (string str)
    {
        return str.Length;
    };


    // Ejercicio 8
    private delegate bool Operacion(int num);

    static void ProcesarNumero(int num, Operacion operacion)
    {

    }


    // Ejercicio 9


    // Ejercicio 10


    // Ejercicio 11


    // Ejercicio 12



    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1: \n");
        Console.WriteLine($"4 * 3 = {multiplicar(4, 3)}");
        Console.WriteLine($"7 * 5 = {multiplicar(7, 5)}");

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 2: \n");
        Console.WriteLine($"'radar' es un palíndromo: {verificar("radar")}");
        Console.WriteLine($"'puerta' es un palíndromo: {verificar("puerta")}");

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 3: \n");
        Console.WriteLine($"0ºC -> {convertir(0)} ºF");
        Console.WriteLine($"0ºC -> {convertir(30)} ºF");

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 4: \n");
        Console.WriteLine($"8 es mayor que 10: {esMayor(8)}:");
        Console.WriteLine($"15 es mayor que 10: {esMayor(10)}:");

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 5: \n");
        Console.WriteLine($"Las palabras 'gato' y 'perro' tienen la misma longitud: {comparar("gato", "perro")}");
        Console.WriteLine();

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 6: \n");
        Console.WriteLine($"Factorial de 4 es {calcular(4)}");
        Console.WriteLine($"Factorial de 6 es {calcular(6)}");

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 7: \n");
        Console.WriteLine($"La palabra 'mundo' tiene {contar("mundo")} caracteres");
        Console.WriteLine($"La palabra 'programa' tiene {contar("programa")} caracteres");

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 8: \n");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 9: \n");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 10: \n");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 11: \n");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Ejercicio 12: \n");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("\n----------------------------------\n");
    }
}
