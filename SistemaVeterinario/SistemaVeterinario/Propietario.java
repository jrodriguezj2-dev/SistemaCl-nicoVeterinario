public class Propietario extends Persona
{
    int intCodigo;

    public Propietario(int intCodigo, String strNombre, String strTelefono)
    {
        super(strNombre, strTelefono);
        this.intCodigo = intCodigo;
    }

    public void mostrarPropietario()
    {
        System.out.println("Codigo: " + intCodigo);
        System.out.println("Nombre: " + strNombre);
        System.out.println("Telefono: " + strTelefono);
    }
}