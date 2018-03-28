using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScript : MonoBehaviour
{
    public GameObject eggBroken;
    AudioSource eggDrop;


    void Start()
    {
        eggDrop = GetComponent<AudioSource>();
    }
    
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Instantiate(eggBroken, collision.contacts[0].point, Quaternion.identity);
        eggDrop.Play();
        GameManagerScript.DecreaseLives();
    }
}
