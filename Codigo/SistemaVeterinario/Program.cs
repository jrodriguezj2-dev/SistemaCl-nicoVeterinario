using SistemaVeterinario.logica;

namespace SistemaVeterinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClinicaVeterinaria objClinica = new ClinicaVeterinaria();

            int intOpcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine(" SISTEMA DE CONTROL CLINICO VETERINARIO");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Registrar propietario");
                Console.WriteLine("2. Registrar mascota");
                Console.WriteLine("3. Registrar veterinario");
                Console.WriteLine("4. Programar cita");
                Console.WriteLine("5. Consultar mascotas");
                Console.WriteLine("6. Consultar citas");
                Console.WriteLine("0. Salir");
                Console.WriteLine("======================================");

                Console.Write("Seleccione una opcion: ");
                intOpcion = int.Parse(Console.ReadLine());

                switch (intOpcion)
                {
                    case 1:
                        registrarPropietario(objClinica);
                        break;

                    case 2:
                        registrarMascota(objClinica);
                        break;

                    case 3:
                        registrarVeterinario(objClinica);
                        break;

                    case 4:
                        programarCita(objClinica);
                        break;

                    case 5:
                        consultarMascotas(objClinica);
                        break;

                    case 6:
                        consultarCitas(objClinica);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        break;
                }

                if (intOpcion != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (intOpcion != 0);
        }


        static void registrarPropietario(ClinicaVeterinaria objClinica)
        {
            Console.Clear();

            Console.WriteLine("REGISTRAR PROPIETARIO");

            Console.Write("Ingrese codigo: ");
            int intCodigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombre: ");
            string strNombre = Console.ReadLine();

            Console.Write("Ingrese telefono: ");
            string strTelefono = Console.ReadLine();

            Propietario objPropietario = new Propietario(
                intCodigo,
                strNombre,
                strTelefono
            );

            objClinica.agregarPropietario(objPropietario);

            Console.WriteLine("Propietario registrado correctamente.");
        }


        static void registrarMascota(ClinicaVeterinaria objClinica)
        {
            Console.Clear();

            Console.WriteLine("REGISTRAR MASCOTA");

            if (objClinica.lstPropietarios.Count == 0)
            {
                Console.WriteLine("Primero debe registrar un propietario.");
                return;
            }

            Console.Write("Ingrese codigo de mascota: ");
            int intCodigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombre: ");
            string strNombre = Console.ReadLine();

            Console.Write("Ingrese especie: ");
            string strEspecie = Console.ReadLine();

            Console.Write("Ingrese raza: ");
            string strRaza = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            int intEdad = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("PROPIETARIOS DISPONIBLES");

            foreach (Propietario objPropietario in objClinica.lstPropietarios)
            {
                Console.WriteLine(
                    objPropietario.intCodigo + " - " +
                    objPropietario.strNombre
                );
            }

            Console.Write("Ingrese codigo del propietario: ");
            int intCodigoPropietario = int.Parse(Console.ReadLine());

            Propietario objPropietarioSeleccionado =
                objClinica.lstPropietarios.Find(
                    p => p.intCodigo == intCodigoPropietario
                );

            if (objPropietarioSeleccionado == null)
            {
                Console.WriteLine("Propietario no encontrado.");
                return;
            }

            Mascota objMascota = new Mascota(
                intCodigo,
                strNombre,
                strEspecie,
                strRaza,
                intEdad,
                objPropietarioSeleccionado
            );

            objClinica.agregarMascota(objMascota);

            Console.WriteLine("Mascota registrada correctamente.");
        }


        static void registrarVeterinario(ClinicaVeterinaria objClinica)
        {
            Console.Clear();

            Console.WriteLine("REGISTRAR VETERINARIO");

            Console.Write("Ingrese nombre: ");
            string strNombre = Console.ReadLine();

            Console.Write("Ingrese telefono: ");
            string strTelefono = Console.ReadLine();

            Console.Write("Ingrese especialidad: ");
            string strEspecialidad = Console.ReadLine();

            Veterinario objVeterinario = new Veterinario(
                strNombre,
                strTelefono,
                strEspecialidad
            );

            objClinica.agregarVeterinario(objVeterinario);

            Console.WriteLine("Veterinario registrado correctamente.");
        }


        static void programarCita(ClinicaVeterinaria objClinica)
        {
            Console.Clear();

            Console.WriteLine("PROGRAMAR CITA");

            if (objClinica.lstMascotas.Count == 0)
            {
                Console.WriteLine("No hay mascotas registradas.");
                return;
            }

            if (objClinica.lstVeterinarios.Count == 0)
            {
                Console.WriteLine("No hay veterinarios registrados.");
                return;
            }

            Console.Write("Ingrese numero de cita: ");
            int intNumero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("MASCOTAS DISPONIBLES");

            foreach (Mascota objMascota in objClinica.lstMascotas)
            {
                Console.WriteLine(
                    objMascota.intCodigo + " - " +
                    objMascota.strNombre
                );
            }

            Console.Write("Ingrese codigo de mascota: ");
            int intCodigoMascota = int.Parse(Console.ReadLine());

            Mascota objMascotaSeleccionada =
                objClinica.lstMascotas.Find(
                    m => m.intCodigo == intCodigoMascota
                );

            if (objMascotaSeleccionada == null)
            {
                Console.WriteLine("Mascota no encontrada.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("VETERINARIOS DISPONIBLES");

            for (int i = 0; i < objClinica.lstVeterinarios.Count; i++)
            {
                Console.WriteLine(
                    i + " - " +
                    objClinica.lstVeterinarios[i].strNombre
                );
            }

            Console.Write("Seleccione veterinario: ");
            int intPosicion = int.Parse(Console.ReadLine());

            if (intPosicion < 0 ||
                intPosicion >= objClinica.lstVeterinarios.Count)
            {
                Console.WriteLine("Veterinario no encontrado.");
                return;
            }

            Veterinario objVeterinarioSeleccionado =
                objClinica.lstVeterinarios[intPosicion];

            Console.Write("Ingrese fecha: ");
            string strFecha = Console.ReadLine();

            Console.Write("Ingrese motivo: ");
            string strMotivo = Console.ReadLine();

            Cita objCita = new Cita(
                intNumero,
                objMascotaSeleccionada,
                objVeterinarioSeleccionado,
                strFecha,
                strMotivo
            );

            objClinica.agregarCita(objCita);

            Console.WriteLine("Cita programada correctamente.");
        }


        static void consultarMascotas(ClinicaVeterinaria objClinica)
        {
            Console.Clear();

            Console.WriteLine("LISTADO DE MASCOTAS");

            if (objClinica.lstMascotas.Count == 0)
            {
                Console.WriteLine("No hay mascotas registradas.");
                return;
            }

            foreach (Mascota objMascota in objClinica.lstMascotas)
            {
                Console.WriteLine("------------------------------");
                objMascota.mostrarMascota();
            }
        }


        static void consultarCitas(ClinicaVeterinaria objClinica)
        {
            Console.Clear();

            Console.WriteLine("LISTADO DE CITAS");

            if (objClinica.lstCitas.Count == 0)
            {
                Console.WriteLine("No hay citas registradas.");
                return;
            }

            foreach (Cita objCita in objClinica.lstCitas)
            {
                Console.WriteLine("------------------------------");
                objCita.mostrarCita();
            }
        }
    }
}