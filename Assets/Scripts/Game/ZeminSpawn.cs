using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawn : MonoBehaviour
{
    public GameObject zemin;
    private Transform tran;
    public int zeminSayisi;
    public float zeminGenisligi;
    public float miny, maxy;
    //public GameObject zeminEkle;

    private void Start()
    {
        Yonetici.skorSayisi = 0;

        tran = zemin.GetComponent<Transform>();
        Vector3 spawnkonumu = new Vector3();
        Vector2 yeniScale = new Vector2();




        
        
            for (int i = 0; i < zeminSayisi; i++)
            {
                yeniScale.x = Random.Range(0.5f, 1.1f);
                yeniScale.y = Random.Range(0.9f, 1.1f);
                tran.localScale = yeniScale;

                spawnkonumu.y += Random.Range(miny, maxy);
                spawnkonumu.x = Random.Range(-zeminGenisligi, zeminGenisligi);

                Instantiate(zemin, spawnkonumu, Quaternion.identity);
                
           // Debug.Log("Nesne Sayisi" + i);
        }

       

        
    }
}
