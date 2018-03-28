using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    
    void Start()
    {
        Time.timeScale = 0;
    }
    
    void Update()
    {

    }

    public void StartGame()
    {
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    }
}
