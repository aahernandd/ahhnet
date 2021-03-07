using System;
/*Muestra la tabla de multiplicar del número seleccionado
 Aarón Hernández 
*/

    class persona
{
    private int edad = 25;
    private string nombre;

    public int getEdad() { return edad; }
    public string getNombre() { return nombre; }
    public void setEdad(int edd) { edad = edd; } 
    public void setNombre(String nomb) { nombre = nomb; }
    public void impri()
    {
        Console.WriteLine("Esto es una prueba del objeto {0}",nombre);
    }
}
    class Program
    {
    static void Main()
    {
        int a;
        String b;
        persona info = new persona();
        info.setNombre("Matew Henry");
        info.setEdad(24);
        info.impri();
        a = info.getEdad();
        b = info.getNombre();
        Console.WriteLine("La edad de {0} es {1}", b, a);
    }
    }

