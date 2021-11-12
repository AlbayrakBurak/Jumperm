using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Yonetici : MonoBehaviour
{

    public    Text Skor ;
    public static int skorSayisi;
    public AudioClip audi;
    public AudioSource Audio;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        

        if (skorSayisi==100)
        {
            Audio.PlayOneShot(audi);
            skorSayisi++;
        }
        if (skorSayisi == 200)
            
        {
            Audio.PlayOneShot(audi);
            skorSayisi++;
        }
        if (skorSayisi == 300)
        {
            Audio.PlayOneShot(audi);
            skorSayisi++;
        }
        if (skorSayisi == 400)
        {
            Audio.PlayOneShot(audi);
            skorSayisi++;
        }
        if (skorSayisi == 500)
        {
            Audio.PlayOneShot(audi);
            skorSayisi++;
        }
      





        /*if (skorSayisi == 500)
        {
          
                SceneManager.LoadScene("FinalScene");

        }*/
        Skor.text = skorSayisi.ToString();




        /*if (skorSayisi == 31)    GOTTEN YIYENLER BİR ŞEYLERE KARAR VERİYOR
        {
            Skor.text = ("sj");
        }*/
    }

}
