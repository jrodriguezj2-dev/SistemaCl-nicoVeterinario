namespace SistemaVeterinario.logica
{
    public class Mascota
    {
        public int intCodigo { get; set; }
        public string strNombre { get; set; }
        public string strEspecie { get; set; }
        public string strRaza { get; set; }
        public int intEdad { get; set; }
        public Propietario objPropietario { get; set; }

        public Mascota(int intCodigo, string strNombre, string strEspecie,
                       string strRaza, int intEdad, Propietario objPropietario)
        {
            this.intCodigo = intCodigo;
            this.strNombre = strNombre;
            this.strEspecie = strEspecie;
            this.strRaza = strRaza;
            this.intEdad = intEdad;
            this.objPropietario = objPropietario;
        }

        public void mostrarMascota()
        {
            Console.WriteLine("Codigo: " + intCodigo);
            Console.WriteLine("Nombre: " + strNombre);
            Console.WriteLine("Especie: " + strEspecie);
            Console.WriteLine("Raza: " + strRaza);
            Console.WriteLine("Edad: " + intEdad);
            Console.WriteLine("Propietario: " + objPropietario.strNombre);
        }
    }
}