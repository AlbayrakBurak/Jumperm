using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using GoogleMobileAds;
using System;

public class ScoreBoard : MonoBehaviour
{
   
    public Text urScore;
    public Text bestScore;
    public static int highScore = 0;
    public GameObject skorTabelasi;
    public GameObject MaxSkor;

    private InterstitialAd gecis;
    // Start is called before the first frame update
    void Start()
    {
        if (UnityEngine.Random.Range(0, 3) == 1)
        {
            gecis = new InterstitialAd("ca-app-pub-3940256099942544/1033173712");
            AdRequest reklamistegi = new AdRequest.Builder().Build();
            gecis.LoadAd(reklamistegi);
            gecis.Show();

        }
        

            highScore = PlayerPrefs.GetInt("bestScore");
        urScore.text = Yonetici.skorSayisi.ToString();

        if (Yonetici.skorSayisi >= highScore)
        {
            highScore = Yonetici.skorSayisi;
            bestScore.text = highScore.ToString();
            skorTabelasi.SetActive(true);
            
        }

        else
        {
            highScore = PlayerPrefs.GetInt("bestScore");
            bestScore.text = highScore.ToString();
            skorTabelasi.SetActive(false);
        }


        if (Yonetici.skorSayisi >= 500)
        {
            MaxSkor.SetActive(true);
        }



    }

   
  void OnDestroy()
    {
        PlayerPrefs.SetInt("bestScore", highScore);
    }
 
    
    // Update is called once per frame
    void Update()
    {
       

    }
}
