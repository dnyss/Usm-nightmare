using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opciones : MonoBehaviour
{
    public void PantallaCompleta (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
