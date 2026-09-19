namespace SistemaVeterinario.logica
{
    public class Veterinario : Persona
    {
        public string strEspecialidad { get; set; }

        public Veterinario(string strNombre, string strTelefono, string strEspecialidad)
            : base(strNombre, strTelefono)
        {
            this.strEspecialidad = strEspecialidad;
        }

        public void mostrarVeterinario()
        {
            Console.WriteLine("Nombre: " + strNombre);
            Console.WriteLine("Telefono: " + strTelefono);
            Console.WriteLine("Especialidad: " + strEspecialidad);
        }
    }
}