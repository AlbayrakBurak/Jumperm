using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class singleton : MonoBehaviour
{
    public static singleton obje = null;

     void Awake()
    {
        if (obje == null)
        {
            obje = this;
            DontDestroyOnLoad(this);


        }
        else if (this != obje)
        {
            Destroy(gameObject);
        }

    }

}


