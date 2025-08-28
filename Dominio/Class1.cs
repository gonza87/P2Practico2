namespace Dominio
{
    public class Auto
    {
        private string _marca;
        private string _modelo;
        private bool _exoneraImpuestos;
        private string _matricula;

        public Auto(string marca, string modelo, bool exoneraImpuestos, string matricula)
        {
            _marca = marca;
            _modelo = modelo;
            _exoneraImpuestos = exoneraImpuestos;
            _matricula = matricula;
               
        }
        public void ValidarMatricula()
        {
            // Supongamos que la matrícula debe tener 7 caracteres.
            if (_matricula.Length != 7)
            {
                throw new ArgumentException("La matrícula debe tener 7 caracteres.");
            }

            // Si no hay errores, el método simplemente termina.
            // No devuelve nada.
        }
        public string mostrar()
        {
            return $"Marca: {_marca}  Modelo: {_modelo} ExoneraImpuestos: {_exoneraImpuestos} Matricula: {_matricula}";
        }

       
    }
}
