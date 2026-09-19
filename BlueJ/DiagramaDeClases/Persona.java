public class Persona
{
    String strNombre;
    String strTelefono;

    public Persona(String strNombre, String strTelefono)
    {
        this.strNombre = strNombre;
        this.strTelefono = strTelefono;
    }

    public void mostrarInformacion()
    {
        System.out.println("Nombre: " + strNombre);
        System.out.println("Telefono: " + strTelefono);
    }
}