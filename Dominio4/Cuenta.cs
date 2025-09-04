
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Dominio4
{
    public class Cuenta
    {
        public enum Moneda { peso, dolar };
        public enum TipoCuenta { CC, CA };

        private string _titular;
        private decimal _saldoActual;
        private int _numeroCuenta;
        private TipoCuenta _cuentaBanco;
        private Moneda _miMoneda;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public decimal SaldoActual { get { return _saldoActual; } set { _saldoActual = value; } }

        public int NumeroCuenta { get { return _numeroCuenta; } set { _numeroCuenta = value; } }

        public TipoCuenta CuentaBanco { get { return _cuentaBanco; } set { _cuentaBanco = value; } }

        public Moneda MiMoneda { get { return _miMoneda; } set { _miMoneda = value; } }

        public Cuenta(string titular, decimal saldoActual, int numeroCuenta, TipoCuenta tipoCuenta, Moneda moneda)
        {

            Titular = titular;
            SaldoActual = saldoActual;
            NumeroCuenta = numeroCuenta;
            CuentaBanco = tipoCuenta;
            MiMoneda = moneda;

        }
        // Se podrá hacer un depósito a la cuenta, se debe controlar que sea de la misma moneda 
        // y que no supere los $ 50000 o u$s 1000. Este método debe indicar si fue posible realizar la operación.


        public bool Deposito(decimal dinero, Moneda tipoDeMoneda)
        {
            bool exito = false;

            if ()

                return exito;
        }



        public override string ToString()
        {
            return $"{_numeroCuenta} {_miMoneda}";
        }


    }
}
