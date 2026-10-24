
using System.Data;
using Microsoft.Data.Sqlite;

namespace SistemaVeterinario.Persistencia;

internal sealed class RepositorioVeterinaria
{
    private readonly string _cadenaConexion;

    public RepositorioVeterinaria(string cadenaConexion)
    {
        _cadenaConexion = cadenaConexion;
    }

    // PROPIETARIOS

    public DataTable ObtenerPropietarios() =>
        Consultar("SELECT Id, Codigo, Nombre, Telefono FROM Propietarios ORDER BY Nombre;");

    public int CrearPropietario(string codigo, string nombre, string telefono) =>
        Ejecutar(
            "INSERT INTO Propietarios (Codigo, Nombre, Telefono) VALUES ($codigo, $nombre, $telefono);",
            ("$codigo", codigo), ("$nombre", nombre), ("$telefono", telefono));

    public int ActualizarPropietario(int id, string codigo, string nombre, string telefono) =>
        Ejecutar(
            "UPDATE Propietarios SET Codigo=$codigo, Nombre=$nombre, Telefono=$telefono WHERE Id=$id;",
            ("$codigo", codigo), ("$nombre", nombre),
            ("$telefono", telefono), ("$id", id));

    public int EliminarPropietario(int id) =>
        Ejecutar("DELETE FROM Propietarios WHERE Id=$id;", ("$id", id));

    // VETERINARIOS

    public DataTable ObtenerVeterinarios() =>
        Consultar("SELECT Id, Nombre, Telefono, Especialidad FROM Veterinarios ORDER BY Nombre;");

    public int CrearVeterinario(string nombre, string telefono, string especialidad) =>
        Ejecutar(
            "INSERT INTO Veterinarios (Nombre, Telefono, Especialidad) VALUES ($nombre, $telefono, $especialidad);",
            ("$nombre", nombre), ("$telefono", telefono), ("$especialidad", especialidad));

    public int ActualizarVeterinario(int id, string nombre, string telefono, string especialidad) =>
        Ejecutar(
            "UPDATE Veterinarios SET Nombre=$nombre, Telefono=$telefono, Especialidad=$especialidad WHERE Id=$id;",
            ("$nombre", nombre), ("$telefono", telefono),
            ("$especialidad", especialidad), ("$id", id));

    public int EliminarVeterinario(int id) =>
        Ejecutar("DELETE FROM Veterinarios WHERE Id=$id;", ("$id", id));

    // MASCOTAS

    public DataTable ObtenerMascotas() =>
        Consultar(
            "SELECT m.Id, m.Codigo, m.Nombre, m.Especie, m.Raza, m.Edad, " +
            "m.PropietarioId, p.Nombre AS Propietario " +
            "FROM Mascotas m INNER JOIN Propietarios p ON m.PropietarioId=p.Id " +
            "ORDER BY m.Nombre;");

    public int CrearMascota(string codigo, string nombre, string especie,
        string raza, int edad, int propietarioId) =>
        Ejecutar(
            "INSERT INTO Mascotas (Codigo, Nombre, Especie, Raza, Edad, PropietarioId) " +
            "VALUES ($codigo, $nombre, $especie, $raza, $edad, $propietarioId);",
            ("$codigo", codigo), ("$nombre", nombre), ("$especie", especie),
            ("$raza", raza), ("$edad", edad), ("$propietarioId", propietarioId));

    public int ActualizarMascota(int id, string codigo, string nombre,
        string especie, string raza, int edad, int propietarioId) =>
        Ejecutar(
            "UPDATE Mascotas SET Codigo=$codigo, Nombre=$nombre, Especie=$especie, " +
            "Raza=$raza, Edad=$edad, PropietarioId=$propietarioId WHERE Id=$id;",
            ("$codigo", codigo), ("$nombre", nombre), ("$especie", especie),
            ("$raza", raza), ("$edad", edad),
            ("$propietarioId", propietarioId), ("$id", id));

    public int EliminarMascota(int id) =>
        Ejecutar("DELETE FROM Mascotas WHERE Id=$id;", ("$id", id));

    // CITAS

    public DataTable ObtenerCitas() =>
        Consultar(
            "SELECT c.Id, c.Numero, c.MascotaId, m.Nombre AS Mascota, " +
            "c.VeterinarioId, v.Nombre AS Veterinario, c.Fecha, c.Motivo, c.Estado " +
            "FROM Citas c " +
            "INNER JOIN Mascotas m ON c.MascotaId=m.Id " +
            "INNER JOIN Veterinarios v ON c.VeterinarioId=v.Id " +
            "ORDER BY c.Fecha;");

    public int CrearCita(string numero, int mascotaId, int veterinarioId,
        string fecha, string motivo, string estado) =>
        Ejecutar(
            "INSERT INTO Citas (Numero, MascotaId, VeterinarioId, Fecha, Motivo, Estado) " +
            "VALUES ($numero, $mascotaId, $veterinarioId, $fecha, $motivo, $estado);",
            ("$numero", numero), ("$mascotaId", mascotaId),
            ("$veterinarioId", veterinarioId), ("$fecha", fecha),
            ("$motivo", motivo), ("$estado", estado));

    public int ActualizarCita(int id, string numero, int mascotaId,
        int veterinarioId, string fecha, string motivo, string estado) =>
        Ejecutar(
            "UPDATE Citas SET Numero=$numero, MascotaId=$mascotaId, " +
            "VeterinarioId=$veterinarioId, Fecha=$fecha, Motivo=$motivo, " +
            "Estado=$estado WHERE Id=$id;",
            ("$numero", numero), ("$mascotaId", mascotaId),
            ("$veterinarioId", veterinarioId), ("$fecha", fecha),
            ("$motivo", motivo), ("$estado", estado), ("$id", id));

    public int EliminarCita(int id) =>
        Ejecutar("DELETE FROM Citas WHERE Id=$id;", ("$id", id));

    // MÉTODOS AUXILIARES

    private DataTable Consultar(string sql)
    {
        using var conexion = AbrirConexion();
        using var comando = conexion.CreateCommand();

        comando.CommandText = sql;

        using var lector = comando.ExecuteReader();
        var tabla = new DataTable();
        tabla.Load(lector);

        return tabla;
    }

    private int Ejecutar(string sql, params (string Nombre, object Valor)[] parametros)
    {
        using var conexion = AbrirConexion();
        using var comando = conexion.CreateCommand();

        comando.CommandText = sql;

        foreach (var parametro in parametros)
        {
            comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
        }

        return comando.ExecuteNonQuery();
    }

    private SqliteConnection AbrirConexion()
    {
        var conexion = new SqliteConnection(_cadenaConexion);
        conexion.Open();
        return conexion;
    }
}
