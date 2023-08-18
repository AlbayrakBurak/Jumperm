using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public GameObject sesKapat;
    public GameObject sesAc;

    // Start is called before the first frame update
    
    public void sesiKapat()
    {

        sesKapat.SetActive(false);
        sesAc.SetActive(true);
    }

   
    public void sesiAc()
    {

        sesKapat.SetActive(true);
        sesAc.SetActive(false);
    }

}
