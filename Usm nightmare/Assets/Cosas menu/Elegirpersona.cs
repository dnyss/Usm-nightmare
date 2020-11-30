using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elegirpersona: MonoBehaviour{
    public void ElegirPers (){

        SceneManager.LoadScene("Jugador");
    
    }  

}
public class boton1 : MonoBehaviour{
    public GameObject Chica;
        public void ElegirPers (){
        void OnMouseDown()
        {
            if(Input.GetMouseButtonDown(0)){
                Chica.SetActive (true); 
            }
        }

        SceneManager.LoadScene("Jugador");
    
    }  



}


public class boton2 : MonoBehaviour{
    public GameObject Chico;
        public void ElegirPers (){
        void OnMouseDown()
        {
            if(Input.GetMouseButtonDown(0)){
                Chico.SetActive (true); 
            }
        }

        SceneManager.LoadScene("Jugador");
    
    } 

} 