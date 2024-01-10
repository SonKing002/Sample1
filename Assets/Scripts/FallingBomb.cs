using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBomb : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("Enter");
            Destroy(gameObject,0.5f);
        }
        if (collision.gameObject.tag == "Ground")
        {
            anim.SetTrigger("Enter");
            Ui_TextCtrl.uiText.SetScore(100);
            Destroy(gameObject, 1f);
        }
    }



}
