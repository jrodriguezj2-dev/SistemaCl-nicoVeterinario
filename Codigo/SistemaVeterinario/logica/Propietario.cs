namespace SistemaVeterinario.logica
{
    public class Propietario : Persona
    {
        public int intCodigo { get; set; }

        public Propietario(int intCodigo, string strNombre, string strTelefono)
            : base(strNombre, strTelefono)
        {
            this.intCodigo = intCodigo;
        }

        public void mostrarPropietario()
        {
            Console.WriteLine("Codigo: " + intCodigo);
            Console.WriteLine("Nombre: " + strNombre);
            Console.WriteLine("Telefono: " + strTelefono);
        }
    }
}