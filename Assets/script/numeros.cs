using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; 

public class numeros : MonoBehaviour
{
    public Text numeroTope; //numero maximo
    public Text numeroTexto;
    int numeroInicio;
    int numeroActual;
    int numeroCabeza; 
    // Start is called before the first frame update
    void Start()
    {
        numeroCabeza = 0; 
           numeroInicio = 0;
        numeroInicio = numeroActual; 
        numeroTexto.text = numeroInicio.ToString();  
    }

    public void next() {
      
        numeroActual++;
        numeroTexto.text = numeroActual.ToString();
        aaa(); 
    }

    public void prev() {
        numeroActual--;
        numeroTexto.text = numeroActual.ToString();

        numeroCabeza = int.Parse(numeroTope.text);
        if (numeroActual == 0)
        {
            numeroActual = numeroCabeza+1;
        }
    }

    void aaa() {

        numeroCabeza = int.Parse(numeroTope.text);
        if (numeroActual == numeroCabeza)
        {
            numeroActual = -1;
        }
    }

    public void reinicio(){
        numeroActual=0 ;
        numeroTexto.text = 0.ToString(); 

    }
}
