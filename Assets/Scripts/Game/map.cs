using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    public CharacterMove controller;
    public GameObject mapOne, mapTwo;
    public void mapTasi(bool type)
    {
       
        StartCoroutine(gecikme(type));

    }
    IEnumerator gecikme (bool type) {  
        //MAP TAŞIMA OLAYI 2 MAPI COLLİDERA GİRDİĞİ ANDA 2.3 SANİYE DELAYLI +23 Y KORDİNATINA TAŞIYOR
        yield return new WaitForSeconds(1.7f);
        if (!type)
        {
            mapOne.transform.position = new Vector3(-2f, mapOne.transform.position.y + 23f, 0f);

        }
        else
        {
            mapTwo.transform.position = new Vector3(-2f, mapTwo.transform.position.y + 23f, 0f);
        }
        controller.TasimaEngel = false;
    }
  
}
