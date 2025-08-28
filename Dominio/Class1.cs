namespace Dominio
{
    public class Auto
    {
        private string _marca;
        private string _modelo;
        private bool _exoneraImpuestos;
        private string _matricula;
        private int _anio;

        public Auto(string marca, string modelo, bool exoneraImpuestos, string matricula, int anio)
        {
            _marca = marca;
            _modelo = modelo;
            _exoneraImpuestos = exoneraImpuestos;
            _matricula = matricula;
            _anio = anio;   
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
        public void ValidarMarca()
        {
            if (_marca.Length < 3)
            {
                throw new ArgumentException("La marca debe tener mas de tres caracteres");
            }
        }
        public string mostrar()
        {
            return $"Marca: {_marca}  Modelo: {_modelo} ExoneraImpuestos: {_exoneraImpuestos} Matricula: {_matricula} Año: {_anio}";
        }

        //Los autos anteriores a 2015 si exoneran impuestos pagan
        //$10.000, sino pagan $12.000. Y los posteriores a 2015 pagan $17.000

        public decimal CalcularPatente()
        {
            decimal patente = 0;
            if(_anio < 2015)
            {
                if (_exoneraImpuestos) patente = 10.000M;
                else patente = 12.000M;
            }
            else
            {
                patente = 17.000M;
            }
                return patente;

        }

       
    }
}
