using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalNivel : MonoBehaviour
{
    private GameObject gm;

    public GameObject ganaste;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jugador"))
        {
            Time.timeScale = 0f;
            ganaste.SetActive(true);
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
    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
