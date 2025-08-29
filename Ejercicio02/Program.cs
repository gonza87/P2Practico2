using Dominio02;
namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Empleado Empleado1 = new Empleado("Roberto", "Rodriguez", new DateTime(1985, 5, 10), 100, 5, 200);
            Console.WriteLine(Empleado1.mostrar());
            Console.WriteLine(Empleado1.CalcularSalario());
            Console.WriteLine(Empleado1.CalcularLicencia());
        }
    }
}
