using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ : MonoBehaviour
{

    public string Product1;
    public string Product2;
    public string Product3;

    public int Price1;
    public int Price2;
    public int Price3;

    public int Cuant1;
    public int Cuant2;
    public int Cuant3;

    void Start()
    {

        int PriceT1 = 0;
        int PriceT2 = 0;
        int PriceT3 = 0;


        if (Cuant1 >= 3)
        {
            Price1 = Price1 - ((20 * Price1) % 100);
            PriceT1 = Price1 * Cuant1;
        }

        if (Cuant2 >= 3)
        {
            Price2 = Price2 - ((20 * Price2) % 100);
            PriceT2 = Price2 * Cuant2;
           
        }

        if (Cuant3 >= 3)
        {
            Price3 = Price3 - ((20 * Price3) % 100);
            PriceT3 = Price2 * Cuant2;            
        }

        if (Price1 <= 0 && Cuant1 <= 0 && Price2 <= 0 && Cuant2 <= 0 && Price3 <= 0 && Cuant3 <= 0 )
        {
            Debug.Log("Usted no ha seleccionado valores validos debido a que no existen productos con un valor igual o menor a cero y tampoco ha seleccionado una cantidad de productos tangible");
        }

        int PriceBT = Price1 + Price2 + Price3;
        Debug.Log("El precio Bruto de su compra es de " + PriceBT);

        int PriceTT = PriceT1 + PriceT2 + PriceT3;
        Debug.Log("El precio Final de su compra es de " + PriceTT);

        int DiscountT = ((20 * Price1) % 100) + ((20 * Price2) % 100) + ((20 * Price3) % 100);
        Debug.Log("En su compra se le ha descontado un total de $" + DiscountT);
    }

    
    void Update()
    {
        
    }
}
