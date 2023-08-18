using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class Yonetici : MonoBehaviour
{
    public Text Skor ;
    public static int skorSayisi;
    public AudioClip audi;
    public AudioSource Audio;

   
   

   
    void Update()
    {
    

        if (skorSayisi==100)
        {Audio.PlayOneShot(audi); skorSayisi++;}
        if (skorSayisi == 200)
        { Audio.PlayOneShot(audi); skorSayisi++; }
        if (skorSayisi == 300)
        { Audio.PlayOneShot(audi); skorSayisi++;}
        if (skorSayisi == 400)
        {Audio.PlayOneShot(audi); skorSayisi++; }
        if (skorSayisi == 500) 
        { Audio.PlayOneShot(audi); skorSayisi++;}
        Skor.text = skorSayisi.ToString();
    }
}
