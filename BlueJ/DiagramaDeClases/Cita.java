public class Cita
{
    int intNumero;
    Mascota objMascota;
    Veterinario objVeterinario;
    String strFecha;
    String strMotivo;
    String strEstado;

    public Cita(int intNumero, Mascota objMascota,
                Veterinario objVeterinario,
                String strFecha, String strMotivo)
    {
        this.intNumero = intNumero;
        this.objMascota = objMascota;
        this.objVeterinario = objVeterinario;
        this.strFecha = strFecha;
        this.strMotivo = strMotivo;
        this.strEstado = "Pendiente";
    }

    public void mostrarCita()
    {
        System.out.println("Numero de cita: " + intNumero);
        System.out.println("Mascota: " + objMascota.strNombre);
        System.out.println("Veterinario: " + objVeterinario.strNombre);
        System.out.println("Fecha: " + strFecha);
        System.out.println("Motivo: " + strMotivo);
        System.out.println("Estado: " + strEstado);
    }

    public void cancelarCita()
    {
        strEstado = "Cancelada";
    }
}