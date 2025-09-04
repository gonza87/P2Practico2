
using Dominio4;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Cuenta cuenta1 = new Cuenta("Pepe", 150M,2513,0,0);
            Console.WriteLine(cuenta1.ToString());
            cuenta1.Deposito(1000, Cuenta.Moneda.peso);

            Console.WriteLine(cuenta1.Deposito(1000, Cuenta.Moneda.peso));
            Console.ReadLine();
            
        }
    }
}
