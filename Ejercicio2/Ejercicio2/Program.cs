namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mayorPerimetro = 0;
            int iteracionMayorPerimetro = 0;
            double sumaSuperficies = 0;
            int conteoParalelogramos = 0;
            int iteracion = 0;

            while (true)
            {
                iteracion++;

                double baseParalelogramo = IngresarValor("Ingrese la base del paralelogramo: ");
                double altura = IngresarValor("Ingrese la altura del paralelogramo: ");
                double lado = IngresarValor("Ingrese el lado del paralelogramo: ");

                double superficie = baseParalelogramo * altura;
                double perimetro = 2 * (baseParalelogramo + lado);

                sumaSuperficies += superficie;
                conteoParalelogramos++;

                Console.WriteLine($"Base: {baseParalelogramo}");
                Console.WriteLine($"Altura: {altura}");
                Console.WriteLine($"Lado: {lado}");
                Console.WriteLine($"Superficie: {superficie}");
                Console.WriteLine($"Perímetro: {perimetro}\n");

                if (perimetro > mayorPerimetro)
                {
                    mayorPerimetro = perimetro;
                    iteracionMayorPerimetro = iteracion;
                }

                Console.Write("¿Desea ingresar otro paralelogramo? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                    break;
            }

            if (conteoParalelogramos > 0)
            {
                double promedioSuperficies = sumaSuperficies / conteoParalelogramos;
                Console.WriteLine("--- RESUMEN FINAL ---");
                Console.WriteLine($"El paralelogramo con mayor perímetro fue ingresado en la iteración {iteracionMayorPerimetro} con un perímetro de {mayorPerimetro}");
                Console.WriteLine($"El promedio de las superficies ingresadas es: {promedioSuperficies}");
            }
            else
            {
                Console.WriteLine("No se ingresaron paralelogramos válidos.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static double IngresarValor(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }
                Console.WriteLine("Error: El valor debe ser un número positivo. Por favor, intente nuevamente.");
            }
        }
    }
}
