public class Consulta
{
    int intNumero;
    String strFecha;
    String strObservaciones;

    public Consulta(int intNumero, String strFecha,
                    String strObservaciones)
    {
        this.intNumero = intNumero;
        this.strFecha = strFecha;
        this.strObservaciones = strObservaciones;
    }

    public void mostrarConsulta()
    {
        System.out.println("Numero de consulta: " + intNumero);
        System.out.println("Fecha: " + strFecha);
        System.out.println("Observaciones: " + strObservaciones);
    }
}