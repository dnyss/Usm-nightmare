using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    //Para el botón de jugar
    public void GoTomenu()
    {
        SceneManager.LoadScene("Menu"); //Se cargará la escena del menu
    }
}
