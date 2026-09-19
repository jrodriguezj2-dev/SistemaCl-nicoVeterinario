public class Pago
{
    int intCodigo;
    Cita objCita;
    double dblMonto;
    String strFecha;
    String strMetodo;

    public Pago(int intCodigo, Cita objCita,
                double dblMonto, String strFecha,
                String strMetodo)
    {
        this.intCodigo = intCodigo;
        this.objCita = objCita;
        this.dblMonto = dblMonto;
        this.strFecha = strFecha;
        this.strMetodo = strMetodo;
    }

    public void mostrarPago()
    {
        System.out.println("Codigo de pago: " + intCodigo);
        System.out.println("Cita: " + objCita.intNumero);
        System.out.println("Monto: Q" + dblMonto);
        System.out.println("Fecha: " + strFecha);
        System.out.println("Metodo: " + strMetodo);
    }
}