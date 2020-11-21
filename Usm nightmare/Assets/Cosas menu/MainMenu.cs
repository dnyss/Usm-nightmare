using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Para el botón de jugar
    public void EleccionPersonaje()
    {
        SceneManager.LoadScene("Personaje"); //Se cargará la escena de eleccion de personaje
    }
    //Para el botón de salir
    public void CerrarJuego()
    {
        Application.Quit();
    }
    //Para el botón de controles y opciones estan en la función onClick de cada botón
}
