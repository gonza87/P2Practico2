using Dominio;
namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            Auto autito = new Auto("toyota", "prius", false, "asd5256", 2014);
            //autito.Validar();
           
            string datos = autito.mostrar();
            Console.WriteLine(datos);
            Console.WriteLine($"patente: {autito.CalcularPatente()}");

        }
    }
}
