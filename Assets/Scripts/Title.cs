using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public void OnClickButton_Play()
    {
        SceneManager.LoadScene("1_Game");
    }
  
}
