using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ScoreBoard : MonoBehaviour
{
    public Text urScore;
    public Text bestScore;
    public static int highScore = 0;
    public GameObject skorTabelasi;
    public GameObject MaxSkor;

    void Start()
    {

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
        { MaxSkor.SetActive(true);}
    }
    void OnDestroy()
    { PlayerPrefs.SetInt("bestScore", highScore);}
}
