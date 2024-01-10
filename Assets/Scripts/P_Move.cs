using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Move : MonoBehaviour
{
    public float speed;
    Vector2 input_Vec;
    Rigidbody2D rgb;
    SpriteRenderer p_sprite;
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>(); 
        p_sprite = GetComponent<SpriteRenderer>();
        speed = 15f;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        input_Vec.x = Input.GetAxisRaw("Horizontal");
        Vector2 a = input_Vec.normalized * Time.deltaTime * speed;
        rgb.MovePosition( rgb.position + a);

        if (input_Vec.x > 0)
            p_sprite.flipX = false;
        else
            p_sprite.flipX = true;
    }
    
}
