public class Veterinario extends Persona
{
    String strEspecialidad;

    public Veterinario(String strNombre, String strTelefono,
                       String strEspecialidad)
    {
        super(strNombre, strTelefono);
        this.strEspecialidad = strEspecialidad;
    }

    public void mostrarVeterinario()
    {
        System.out.println("Nombre: " + strNombre);
        System.out.println("Telefono: " + strTelefono);
        System.out.println("Especialidad: " + strEspecialidad);
    }
}