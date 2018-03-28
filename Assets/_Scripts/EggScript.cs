using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public GameObject effect;
    AudioSource eggTake;
    
    void Start()
    {
        eggTake = GetComponent<AudioSource>();
    }
    
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Instantiate(effect, other.contacts[0].point, Quaternion.identity);
        eggTake.Play();
        GameManagerScript.IncreaseScore();
        GameManagerScript.IncreaseEggCount();
       
    }
}
