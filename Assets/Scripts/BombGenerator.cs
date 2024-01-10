using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    GameObject bomb;
    float time;
    void Start()
    {
    }

    void FixedUpdate()
    {
        ReGenTime();
    }

    void ReGenTime()
    {
        time += Time.deltaTime;
        float tempTime = time;
        if (tempTime > 1f)
        { 
            float random = Random.Range(-3.3f, 3.3f);
            time = 0f;
            bomb = Instantiate(Resources.Load<GameObject>("Bomb"));
            bomb.transform.position = new Vector3(random, bomb.transform.position.y);
        }
    }
    //-3.3 ~3.3
}
