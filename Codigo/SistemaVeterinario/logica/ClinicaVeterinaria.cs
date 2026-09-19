using System.Collections.Generic;

namespace SistemaVeterinario.logica
{
    public class ClinicaVeterinaria
    {
        public List<Propietario> lstPropietarios;
        public List<Mascota> lstMascotas;
        public List<Veterinario> lstVeterinarios;
        public List<Cita> lstCitas;

        public ClinicaVeterinaria()
        {
            lstPropietarios = new List<Propietario>();
            lstMascotas = new List<Mascota>();
            lstVeterinarios = new List<Veterinario>();
            lstCitas = new List<Cita>();
        }

        public void agregarPropietario(Propietario objPropietario)
        {
            lstPropietarios.Add(objPropietario);
        }

        public void agregarMascota(Mascota objMascota)
        {
            lstMascotas.Add(objMascota);
        }

        public void agregarVeterinario(Veterinario objVeterinario)
        {
            lstVeterinarios.Add(objVeterinario);
        }

        public void agregarCita(Cita objCita)
        {
            lstCitas.Add(objCita);
        }
    }
}