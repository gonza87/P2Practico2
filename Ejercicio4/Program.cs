
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
            cuenta1.Deposito(2000M, Cuenta.Moneda.peso);
            //cuenta1.Titular = "Jose";
            Console.WriteLine(cuenta1.ToString());

            Console.WriteLine(cuenta1.Deposito(1000M, Cuenta.Moneda.peso));
            Console.WriteLine(cuenta1.SaldoActual);
            Console.WriteLine(cuenta1.RetirarDinero(1000M));
            Console.WriteLine(cuenta1.SaldoActual);
            Console.ReadLine();
            
        }
    }
}
