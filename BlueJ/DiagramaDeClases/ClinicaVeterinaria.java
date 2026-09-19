public class ClinicaVeterinaria
{
    String strNombre;
    String strDireccion;
    String strTelefono;

    public ClinicaVeterinaria(String strNombre,
                              String strDireccion,
                              String strTelefono)
    {
        this.strNombre = strNombre;
        this.strDireccion = strDireccion;
        this.strTelefono = strTelefono;
    }

    public void mostrarClinica()
    {
        System.out.println("Clinica: " + strNombre);
        System.out.println("Direccion: " + strDireccion);
        System.out.println("Telefono: " + strTelefono);
    }
}