using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public int prod1;
    public int prod2;
    public int prod3;
    public int monto;

    void Start()
    {
        int suma;
        suma = prod1 + prod2 + prod3;
        if (suma > monto)
        {
            Debug.Log("La suma de los 3 productos supera el dinero disponible");
            int resto;
            resto = suma - monto;
            Debug.Log("Lo que falta es " + resto);
        }
        else
        {
            Debug.Log("La suma de los 3 productos no supera el dinero dispnible");
            int sobra;
            sobra = monto - suma;
            Debug.Log("Lo que sobra es " + sobra);
        }


    }

    void Update()
    {
        
    }
}
