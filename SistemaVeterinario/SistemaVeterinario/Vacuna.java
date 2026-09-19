public class Vacuna
{
    int intCodigo;
    String strNombre;
    String strFecha;
    String strProximaDosis;

    public Vacuna(int intCodigo,
                  String strNombre,
                  String strFecha,
                  String strProximaDosis)
    {
        this.intCodigo = intCodigo;
        this.strNombre = strNombre;
        this.strFecha = strFecha;
        this.strProximaDosis = strProximaDosis;
    }

    public void mostrarVacuna()
    {
        System.out.println("Codigo: " + intCodigo);
        System.out.println("Vacuna: " + strNombre);
        System.out.println("Fecha: " + strFecha);
        System.out.println("Proxima dosis: " + strProximaDosis);
    }
}