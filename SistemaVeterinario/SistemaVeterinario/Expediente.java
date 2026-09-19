public class Expediente
{
    int intCodigo;
    Mascota objMascota;
    String strFechaCreacion;
    String strObservaciones;

    public Expediente(int intCodigo, Mascota objMascota,
                      String strFechaCreacion,
                      String strObservaciones)
    {
        this.intCodigo = intCodigo;
        this.objMascota = objMascota;
        this.strFechaCreacion = strFechaCreacion;
        this.strObservaciones = strObservaciones;
    }

    public void mostrarExpediente()
    {
        System.out.println("Codigo: " + intCodigo);
        System.out.println("Mascota: " + objMascota.strNombre);
        System.out.println("Fecha: " + strFechaCreacion);
        System.out.println("Observaciones: " + strObservaciones);
    }
}