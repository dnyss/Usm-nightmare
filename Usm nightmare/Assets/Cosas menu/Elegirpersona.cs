using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Elegirpersona : MonoBehaviour
{
    public GameObject Eleccion_chica;
    //si se elige a la chica esta funcion se activa
    public void ElegirPers1()
    {
        Eleccion_chica.SetActive(true);    //la eleccion chica es verdadero
        SceneManager.LoadScene("Niveles"); //se carga la escena del juego
    }

    public GameObject Eleccion_chico;
    public void ElegirPers2()
    {
        Eleccion_chico.SetActive(true);
        SceneManager.LoadScene("Niveles");
    }
}


