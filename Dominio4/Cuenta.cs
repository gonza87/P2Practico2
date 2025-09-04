
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
            
        }

        public decimal SaldoActual { get { return _saldoActual; } set { _saldoActual = value; } }

        public int NumeroCuenta { get { return _numeroCuenta; }  } //solo defino prop get asi no se puede modificar desde afuera el valor una vez instanciado el objeto

        public TipoCuenta CuentaBanco { get { return _cuentaBanco; }  }

        public Moneda MiMoneda { get { return _miMoneda; }  }

        public Cuenta(string titular, decimal saldoActual, int numeroCuenta, TipoCuenta tipoCuenta, Moneda moneda)
        {

            _titular = titular;
            SaldoActual = saldoActual;
            _numeroCuenta = numeroCuenta;
            _cuentaBanco = tipoCuenta;
            _miMoneda = moneda;

        }
        // Se podrá hacer un depósito a la cuenta, se debe controlar que sea de la misma moneda 
        // y que no supere los $ 50000 o u$s 1000. Este método debe indicar si fue posible realizar la operación.


        public bool Deposito(decimal dinero, Moneda monedaEnv)
        {
            bool exito = false;

            if (_miMoneda == monedaEnv)
            {
                if (monedaEnv == Moneda.peso && dinero <= 50000)
                {
                    _saldoActual += dinero;
                    exito = true;

                }
                else if (monedaEnv == Moneda.dolar && dinero <= 1000)
                {
                    _saldoActual += dinero;
                    exito = true;
                }
            }

            return exito;
        }

        //Se podrá hacer un retiro de la cuenta, no se puede retirar más dinero que el que tiene disponible.
        //Este método debe indicar si fue posible realizar la operación.
        public bool RetirarDinero(decimal dineroARetirar)
        {
            bool exito = false;
            if(dineroARetirar <= _saldoActual)
            {
                _saldoActual -= dineroARetirar;
                exito = true;
            }
            else
            {
                throw new Exception("Dinero insuficiente");
                
            }
            return exito;
        }



        public override string ToString()
        {
            return $" {_titular} {_numeroCuenta} {_miMoneda}";
        }


    }
}
