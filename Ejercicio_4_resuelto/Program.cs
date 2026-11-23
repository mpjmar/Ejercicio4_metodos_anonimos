using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        if (operacion(num))
        {
            Console.WriteLine($"El número {num} es par.");
        }
        else
        {
            Console.WriteLine($"El número {num} es impar.");
        }
    }


    // Ejercicio 9
    public class Producto
    {
        public string Nombre { get; set; } = string.Empty;
        public int Cantidad { get; set; }
    }

    public delegate bool Filtro(Producto producto);

    public static void MostrarProductosFiltrados(List<Producto> productos, Filtro filtro)
    {
        Console.WriteLine("Productos con cantidad mayor a 5: ");

        foreach (Producto producto in productos)
        {
            if (filtro(producto))
            {
                Console.WriteLine($"- {producto.Nombre} (Cantidad: {producto.Cantidad})");
            }
        }
    }


    // Ejercicio 10
    public class Empleado
    {
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
    }

    public delegate bool FiltroEmpleado(Empleado empleado);

    public static void FiltrarEmpleados(List<Empleado> empleados, FiltroEmpleado filtro)
    {
        Console.WriteLine("Empleados mayores de 30 años: ");
        foreach (Empleado empleado in empleados)
        {
            if (filtro(empleado))
            {
                Console.WriteLine($"- {empleado.Nombre} (Edad: {empleado.Edad})");
            }
        }
    }


    // Ejercicio 11
    public class Libro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
    }

    public delegate bool FiltroLibros (Libro libro);

    public static void MostrarLibrosPorCategoria(List<Libro> libros, FiltroLibros filtro)
    {
        Console.WriteLine("Libros de la categoria 'Ficción':");

        foreach (Libro libro in libros)
        {
            if (filtro(libro))
            {
                Console.WriteLine($"{libro.Titulo}");
            }
        }
    }


    // Ejercicio 12
    public class Vehiculo
    {
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int AnioFabricacion { get; set; }
    }

    public delegate bool FiltroVehiculo (Vehiculo vehiculo);

    public static void MostrarVehiculosAntiguos(List<Vehiculo> vehiculos, FiltroVehiculo filtro)
    {
        Console.WriteLine("Vehículos fabricados antes de 2010:");

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (filtro(vehiculo))
            {
                Console.WriteLine($"- {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.AnioFabricacion})");
            }
        }
    }



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
        Console.WriteLine($"30ºC -> {convertir(30)} ºF");

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
        Operacion comprobar = delegate (int num)
        {
            return num % 2 == 0;
        };
        ProcesarNumero(4, comprobar);
        ProcesarNumero(7, comprobar);

        Console.WriteLine("\n----------------------------------\n");


        Console.WriteLine("Ejercicio 9: \n");
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Televisor", Cantidad = 10 },
            new Producto { Nombre = "Refrigerador", Cantidad = 7 },
            new Producto { Nombre = "Lavadora", Cantidad = 5 },
            new Producto { Nombre = "Microondas", Cantidad = 3 },
            new Producto { Nombre = "Lavavajillas", Cantidad = 8 },
            new Producto { Nombre = "Horno", Cantidad = 2 },
            new Producto { Nombre = "Aspiradora", Cantidad = 6 }
        };

        Filtro filtroProductos = delegate (Producto productos)
        {
            return productos.Cantidad > 5;
        };

        MostrarProductosFiltrados(productos, filtroProductos);

        Console.WriteLine("\n----------------------------------\n");


        Console.WriteLine("Ejercicio 10: \n");
        List<Empleado> empleados = new List<Empleado>
        {
            new Empleado { Nombre = "Ana", Edad = 25 },
            new Empleado { Nombre = "Carlos", Edad = 42 },
            new Empleado { Nombre = "Laura", Edad = 35 },
            new Empleado { Nombre = "Pedro", Edad = 28 },
            new Empleado { Nombre = "Marta", Edad = 50 },
            new Empleado { Nombre = "Javier", Edad = 30 },
            new Empleado { Nombre = "Elena", Edad = 38 },
            new Empleado { Nombre = "David", Edad = 22 }
        };

        FiltroEmpleado filtroEmpleados = delegate (Empleado empleado)
        {
            return empleado.Edad > 30;
        };

        FiltrarEmpleados(empleados, filtroEmpleados);

        Console.WriteLine("\n----------------------------------\n");


        Console.WriteLine("Ejercicio 11: \n");
        List<Libro> libros = new List<Libro>
        {
            new Libro { Titulo = "Cien años de soledad", Categoria = "Ficción" },
            new Libro { Titulo = "El principito", Categoria = "Ficción" },
            new Libro { Titulo = "Breve historia del tiempo", Categoria = "Ciencia" },
            new Libro { Titulo = "Don Quijote de la Mancha", Categoria = "Ficción" },
            new Libro { Titulo = "El universo en una cáscara de nuez", Categoria = "Ciencia" },
            new Libro { Titulo = "La sombra del viento", Categoria = "Ficción" },
            new Libro { Titulo = "Sapiens", Categoria = "Historia" },
            new Libro { Titulo = "El diario de Ana Frank", Categoria = "Biografía" },
            new Libro { Titulo = "1984", Categoria = "Ficción" },
            new Libro { Titulo = "Cosmos", Categoria = "Ciencia" }
        };

        FiltroLibros filtroLibros = delegate (Libro libro)
        {
            return libro.Categoria == "Ficción";
        };

        MostrarLibrosPorCategoria(libros, filtroLibros);

        Console.WriteLine("\n----------------------------------\n");


        Console.WriteLine("Ejercicio 12: \n");
        List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Vehiculo { Marca = "Toyota", Modelo = "Corolla", AnioFabricacion = 2005 },
            new Vehiculo { Marca = "Seat", Modelo = "Ibiza", AnioFabricacion = 2012 },
            new Vehiculo { Marca = "Ford", Modelo = "Focus", AnioFabricacion = 2008 },
            new Vehiculo { Marca = "Volkswagen", Modelo = "Golf", AnioFabricacion = 2003 },
            new Vehiculo { Marca = "Renault", Modelo = "Clio", AnioFabricacion = 2015 },
            new Vehiculo { Marca = "Peugeot", Modelo = "206", AnioFabricacion = 2007 },
            new Vehiculo { Marca = "Opel", Modelo = "Corsa", AnioFabricacion = 2010 },
            new Vehiculo { Marca = "Citroën", Modelo = "C3", AnioFabricacion = 2009 }
        };

        FiltroVehiculo filtroVehiculos = delegate (Vehiculo vehiculo)
        {
            return vehiculo.AnioFabricacion < 2010;
        };

        MostrarVehiculosAntiguos(vehiculos, filtroVehiculos);

        Console.WriteLine("\n----------------------------------\n");
    }
}
