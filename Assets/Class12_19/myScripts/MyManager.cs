using std;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyManager : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Ȱ��ȭ");
    }
    private void OnDisable()
    {
        Debug.Log("�� Ȱ��ȭ");
    }
    bool isTrue;
    
    public Std std;

    private void Awake()
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
    private void LateUpdate()
    {
        
    }
}
