using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public Animator flashButton;
   public void Start() {
    flashButton = GetComponent<Animator>();
    Destroy(gameObject, 1f);
   }

}
