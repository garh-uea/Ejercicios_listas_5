public class Vector
{
    private List<int> elementos;

    public Vector()
    {
        elementos = new List<int>();
    }

    public void AgregarElemento(int valor)
    {
        elementos.Add(valor);
    }

    public int ObtenerElemento(int posicion)
    {
        return elementos[posicion];
    }

    public int Longitud()
    {
        return elementos.Count;
    }

    // Producto escalar entre dos vectores
    public int ProductoEscalar(Vector otro)
    {
        int resultado = 0;

        for (int i = 0; i < elementos.Count; i++)
        {
            resultado += elementos[i] * otro.ObtenerElemento(i);
        }

        return resultado;
    }
}

class ProgramaVector
{
    static void Main()
    {
        // Crear dos vectores
        Vector vector1 = new Vector();
        Vector vector2 = new Vector();

        // Agregar elementos al primer vector (1, 2, 3)
        vector1.AgregarElemento(1);
        vector1.AgregarElemento(2);
        vector1.AgregarElemento(3);

        // Agregar elementos al segundo vector (-1, 0, 2)
        vector2.AgregarElemento(-1);
        vector2.AgregarElemento(0);
        vector2.AgregarElemento(2);

        // Realiza el cálculo producto escalar
        int producto = vector1.ProductoEscalar(vector2);

        // Muestra el resultado
        Console.WriteLine("El producto escalar de los vectores (1,2,3) y (-1,0,2) es: " + producto);
    }
}

