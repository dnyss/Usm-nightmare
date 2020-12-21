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
            gm = GameObject.FindWithTag("gm");
            Destroy(gm);
            Final();
        }
    }
    void Final()
    {
        SceneManager.LoadScene("Niveles");
    }
}
