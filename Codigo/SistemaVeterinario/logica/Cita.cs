namespace SistemaVeterinario.logica
{
    public class Cita
    {
        public int intNumero { get; set; }
        public Mascota objMascota { get; set; }
        public Veterinario objVeterinario { get; set; }
        public string strFecha { get; set; }
        public string strMotivo { get; set; }
        public string strEstado { get; set; }

        public Cita(int intNumero, Mascota objMascota,
                    Veterinario objVeterinario, string strFecha,
                    string strMotivo)
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
            Console.WriteLine("Numero de cita: " + intNumero);
            Console.WriteLine("Mascota: " + objMascota.strNombre);
            Console.WriteLine("Veterinario: " + objVeterinario.strNombre);
            Console.WriteLine("Fecha: " + strFecha);
            Console.WriteLine("Motivo: " + strMotivo);
            Console.WriteLine("Estado: " + strEstado);
        }
    }
}