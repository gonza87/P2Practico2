using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio02
{
    public class Empleado
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private decimal _valorHora;
        private int _antiguedad;
        private int _horasTrabajadas;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, decimal valorHora, int antiguedad, int horasTrabajadas) {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
            _valorHora = valorHora;
            _antiguedad = antiguedad;
            _horasTrabajadas = horasTrabajadas;
        }
        public decimal CalcularSalario(){
            decimal salario = 0;
            return salario;
        }

        public int CalcularLicencia(){
            int licencia = 0;
            return licencia;
        }

        public string mostrar() {
            string texto = "";
            return texto = $"Nombre: {_nombre}";
        }
    }
}
