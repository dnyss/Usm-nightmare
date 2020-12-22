using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalNivel : MonoBehaviour
{
    private GameObject gm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jugador"))
        {
            Final();
        }
    }
    public void Final()
    {
        gm = GameObject.FindWithTag("gm");
        Destroy(gm);
        SceneManager.LoadScene("Niveles");
    }
    public void Pausa()
    {
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
