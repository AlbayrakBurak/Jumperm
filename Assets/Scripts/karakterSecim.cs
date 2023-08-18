using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class karakterSecim : MonoBehaviour
{
    
    public GameObject blue;
    public GameObject pink;
    public GameObject gray;
    public GameObject panel;

    


    void Start()
    {
              

            }

   
    public void maviKarakter(){
        
        blue.SetActive(false);
        pink.SetActive(true);
        gray.SetActive(false);
        SceneManager.LoadScene("Game");
    }


    public void Envanter(){
        panel.SetActive(true);
    }

}
