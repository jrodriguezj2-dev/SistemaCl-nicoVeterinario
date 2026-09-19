public class Diagnostico
{
    int intCodigo;
    String strDescripcion;
    String strFecha;

    public Diagnostico(int intCodigo,
                       String strDescripcion,
                       String strFecha)
    {
        this.intCodigo = intCodigo;
        this.strDescripcion = strDescripcion;
        this.strFecha = strFecha;
    }

    public void mostrarDiagnostico()
    {
        System.out.println("Codigo: " + intCodigo);
        System.out.println("Descripcion: " + strDescripcion);
        System.out.println("Fecha: " + strFecha);
    }
}