public class Mascota
{
    int intCodigo;
    String strNombre;
    String strEspecie;
    String strRaza;
    int intEdad;
    Propietario objPropietario;

    public Mascota(int intCodigo, String strNombre,
                   String strEspecie, String strRaza,
                   int intEdad, Propietario objPropietario)
    {
        this.intCodigo = intCodigo;
        this.strNombre = strNombre;
        this.strEspecie = strEspecie;
        this.strRaza = strRaza;
        this.intEdad = intEdad;
        this.objPropietario = objPropietario;
    }

    public void mostrarMascota()
    {
        System.out.println("Codigo: " + intCodigo);
        System.out.println("Nombre: " + strNombre);
        System.out.println("Especie: " + strEspecie);
        System.out.println("Raza: " + strRaza);
        System.out.println("Edad: " + intEdad);
        System.out.println("Propietario: " + objPropietario.strNombre);
    }
}