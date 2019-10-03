using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenGroundSound : MonoBehaviour
{
    public AudioSource bounce;

    // Start is called before the first frame update
    void Start()
    {
        bounce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        bounce.Play(); 
    }
}
