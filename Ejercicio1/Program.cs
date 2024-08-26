namespace Recuperatorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular la superficie y perímetro de un paralelogramo");

            try
            {
     
                Console.Write("Ingrese la base del paralelogramo: ");
                double baseParalelogramo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la altura del paralelogramo: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el lado del paralelogramo: ");
                double lado = Convert.ToDouble(Console.ReadLine());

                if (baseParalelogramo <= 0 || altura <= 0 || lado <= 0)
                {
                    Console.WriteLine("Error: Todos los valores deben ser positivos y mayores que cero.");
                    return;
                }

                double superficie = baseParalelogramo * altura;
                double perimetro = 2 * (baseParalelogramo + lado);

               
                Console.WriteLine($"Base del paralelogramo: {baseParalelogramo}");
                Console.WriteLine($"Altura del paralelogramo: {altura}");
                Console.WriteLine($"Lado del paralelogramo: {lado}");
                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar un valor numérico válido.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
