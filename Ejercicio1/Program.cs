using Dominio;
namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            Auto autito = new Auto("toyota", "prius", true, "asd5286");
            autito.ValidarMatricula();
            string datos = autito.mostrar();
            Console.WriteLine(datos);

        }
    }
}
