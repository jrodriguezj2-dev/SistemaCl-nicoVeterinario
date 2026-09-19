public class Tratamiento
{
    int intCodigo;
    String strDescripcion;
    String strMedicamento;
    String strDuracion;

    public Tratamiento(int intCodigo,
                       String strDescripcion,
                       String strMedicamento,
                       String strDuracion)
    {
        this.intCodigo = intCodigo;
        this.strDescripcion = strDescripcion;
        this.strMedicamento = strMedicamento;
        this.strDuracion = strDuracion;
    }

    public void mostrarTratamiento()
    {
        System.out.println("Codigo: " + intCodigo);
        System.out.println("Descripcion: " + strDescripcion);
        System.out.println("Medicamento: " + strMedicamento);
        System.out.println("Duracion: " + strDuracion);
    }
}