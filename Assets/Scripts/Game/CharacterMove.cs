using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class CharacterMove : MonoBehaviour
{
    public float hareketHizi;
    private float yatayHareket;
    public map mapGecis;
    public bool TasimaEngel;
    Rigidbody2D rb;
    public GameObject final;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hareketHizi = 200;
    }
    private void OnCollisionEnter2D(Collision2D final) 
        //SKOR'DA BULUNAN COLLİSİONA ÇARPTIGINDA OYUN BİTMESİ
    {
        if (final.gameObject.CompareTag("final")) 
            //çarpıtıgı objenin tagi "final" ise ;
        { SceneManager.LoadScene("FinalScene"); }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!TasimaEngel)  
            //COLLİDERA ÇARPTIGINDA MAP TAŞIMA (BULUTLAR)
        {
            if (other.tag == "Trigger 1")
            {
                mapGecis.mapTasi(false);
                TasimaEngel = true;
            }
            if (other.tag == "Trigger 2")
            {
                mapGecis.mapTasi(true);
                TasimaEngel = true;
            }
        }
    }


    void Update()
    {
        yatayHareket = SimpleInput.GetAxis("Horizontal");
        //UNİTY OTOMATİK TUŞ ATAMALARI a,d-sağ,sol
        rb.velocity = new Vector2(yatayHareket * hareketHizi * Time.deltaTime, rb.velocity.y);
        Vector2 yeniScale = transform.localScale;
        if (yatayHareket > 0)
        { yeniScale.x = 0.25f; }

        if (yatayHareket < 0)
        {  yeniScale.x = -0.25f; }
        transform.localScale = yeniScale;
        if (transform.position.x >= 2.73)   
            //SOLDAN SAĞA GEÇERKEN SOLA ATAMASI İÇİN
        {
            GetComponent<TrailRenderer>().enabled = false;
            transform.position = new Vector3(-2.76f, transform.position.y, transform.position.z);
            //if içinde delay dene 
            GetComponent<TrailRenderer>().enabled = true;
        }
        if (transform.position.x <= -2.77f) 
            //SAĞDAN SOLA GEÇERKEN SAĞA ATAMASI İÇİN
        {
            GetComponent<TrailRenderer>().enabled = false;
            transform.position = new Vector3(2.72f, transform.position.y, transform.position.z);
            GetComponent<TrailRenderer>().enabled = true;
        }
        //BOŞ OBJE İÇİNE KUYRUK EKLEDİKTEN SONRA GERİDE BAŞLAT 
    }
}
