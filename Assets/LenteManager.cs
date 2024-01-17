using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class LenteManager : MonoBehaviour
{
    public Material[] materiales;
    public void SeleccionLentes(int numeroLente)
    {
        GameObject cara = FindObjectOfType<ARFace>().gameObject;

        //Encontar Lentes
        Transform lentesManager = cara.transform.GetChild(1).transform;

        //Desactivariamos todos los lentes
        for(int i = 0; i < lentesManager.childCount;i++)
        {
            //activar el lente seleccionado
            lentesManager.GetChild(i).gameObject.SetActive(i == numeroLente);
        }
    }

    public void CambioColorArmazon(int colorSeleccionado)
    {

    }
}
