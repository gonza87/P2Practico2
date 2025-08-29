using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            decimal salario = _valorHora * _horasTrabajadas;
            return salario;
        }

       //si tiene una antigüedad menor o igual a 5, le corresponden 20
        //días, si esta entre 5 y 9 le corresponden 21 días, y más de 10 son 25 días.
        public int CalcularLicencia(){
            int licencia = 0;
            if (_antiguedad <= 5) licencia = 20;
            else if (_antiguedad > 5 && _antiguedad <= 9) licencia = 21;
            else licencia = 25;
                return licencia;
        }

        public string mostrar() {
            string texto = "";
            return texto = $"Nombre: {_nombre} Apellidp: {_apellido} \n Fecha Nacimiento: {_fechaNacimiento.Date} \n Valor Hora: s/n {_valorHora}\n Antiguedad: {_antiguedad}\n Horas Trabajadas: {_horasTrabajadas}";
        }
    }
}
