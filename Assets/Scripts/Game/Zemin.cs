using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class Zemin : MonoBehaviour
{
    public float ziplamaGücü;
    public bool zemineTemas;
    int doubleJumpihtimali;
    int coinRange;
    Animator anim;


    public void Start()
    {
        anim = GetComponent<Animator>();
        doubleJumpihtimali = Random.Range(1, 21); // DOUBLEJUMP OLASILIĞI İÇİN RANDOM SAYI ÇEKTİK
        
        if (doubleJumpihtimali == 1)
        {
            anim.SetBool("doubleJump", true);
            ziplamaGücü = 22f;
        }
        else
        {
            ziplamaGücü = 11f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        AudioSource a2 = GetComponent<AudioSource>();
        //  AudioSource audi = collision.collider.GetComponent<AudioSource>();
        if (collision.relativeVelocity.y < 0)
        {
            if (rb != null)
            {
                Vector2 ziplamaVelocity = rb.velocity;
                ziplamaVelocity.y = ziplamaGücü;
                rb.velocity = ziplamaVelocity;
                a2.Play();

                if (zemineTemas == false)
                {
                    Yonetici.skorSayisi++;
                    zemineTemas = true;
                    if (zemineTemas == anim.GetBool("doubleJump"))
                    {
                        Yonetici.skorSayisi+=3;
                    }

                }
                anim.SetBool("TemasEdildi", true);
                Destroy(gameObject, 1f);

                if (Yonetici.skorSayisi > 100)
                {
                    if (zemineTemas == false)
                    {
                        zemineTemas = true;
                    }
                    anim.SetBool("TemasEdildi", true);
                    Destroy(gameObject, 0.5f);
                }
           

               
            }
            
        }

         
        
    }
     
    
}












