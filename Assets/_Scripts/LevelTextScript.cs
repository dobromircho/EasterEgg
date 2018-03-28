using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTextScript : MonoBehaviour
{
     static Animator animator;
    Text text;
    void Start()
    {
        animator = GetComponent<Animator>();
        text = GetComponent<Text>();
    }
    
    void Update()
    {
        text.text = "Level: " + GameManagerScript.level;
    }
    public static void PlayAnimationText()
    {
        
        animator.SetTrigger("playText");
    }
}
