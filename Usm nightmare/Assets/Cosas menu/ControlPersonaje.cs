using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public GameObject Eleccion_chica;
    public GameObject Girl;
    public GameObject Boy;
    private void Update()
    {
        Eleccion_chica = GameObject.FindWithTag("Eleccion_chica");
        if (Eleccion_chica == true)
        {
            Girl.SetActive(true);
            Boy.SetActive(false);
        }
        else
        {
            Girl.SetActive(false);
            Boy.SetActive(true);
        }
    }
}
