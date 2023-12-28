using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bolunenleriBul(10, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void bolunenleriBul(int a, int b)
    {

        string liste = " ";
        string liste2 = " ";
        string liste3 = " ";
        string liste4 = " ";
        string liste5 = " ";

        for(int i = a; i <= b; i++)
        {
            liste += "-" + i;
        }
        print(liste);


        for(int i = a; i <= b; i++) 
        {
            if(i%2 == 0)
            {
                liste2 += "-" + i;  
            }           
        }
        print("ikiye bolunenler: " + liste2);

        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0)
            {
                liste3 += "-" + i;
            }
        }
        print("üçe bolunenler: " + liste3);

        for (int i = a; i <= b; i++)
        {
            if (i % 4 == 0)
            {
                liste4 += "-" + i;
            }
        }
        print("dörde bolunenler: " + liste4);

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                liste5 += "-" + i;
            }
        }
        print("beþe bolunenler: " + liste5);

    }

}
