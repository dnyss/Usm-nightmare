using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EleccionNiveles : MonoBehaviour
{
    //Para ir al nivel de matemática
    public void NivelMat()
    {
        SceneManager.LoadScene("matematica"); 
    }
    //Para ir al nivel de física
    public void NivelFis()
    {
        SceneManager.LoadScene("fisica"); 
    }
    //Para ir al nivel de programación
    public void NivelProgra()
    {
        SceneManager.LoadScene("progra");
    }
    //Para ir al nivel de química
    public void NivelQuimica()
    {
        SceneManager.LoadScene("quimica");
    }
    //Para ir a la elección de personaje
    public GameObject datos;
    public void retroceder()
    {
        datos = GameObject.FindWithTag("datos");
        Destroy(datos); //eliminar datos anteriores para que se pueda reelegir el personaje
        SceneManager.LoadScene("Personaje");
    }
}
