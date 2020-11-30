using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sig : MonoBehaviour {

    public GameObject Chica;
    public GameObject Chico;
    public GameObject elec1;
    public GameObject elec2;

    void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            if(Chica.activeSelf){
                Chica.SetActive (false);
                Chico.SetActive (true);

                elec1.SetActive (false);
                elec2.SetActive (true);

            }else if(Chico.activeSelf){
                Chica.SetActive (true);
                Chico.SetActive (false);

                elec1.SetActive (true);
                elec2.SetActive (false);

            }

        }
    }

        

}
