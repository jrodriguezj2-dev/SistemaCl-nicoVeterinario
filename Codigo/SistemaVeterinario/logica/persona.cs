namespace SistemaVeterinario.logica
{
    public class Persona
    {
        public string strNombre { get; set; }
        public string strTelefono { get; set; }

        public Persona(string strNombre, string strTelefono)
        {
            this.strNombre = strNombre;
            this.strTelefono = strTelefono;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("Nombre: " + strNombre);
            Console.WriteLine("Telefono: " + strTelefono);
        }
    }
}