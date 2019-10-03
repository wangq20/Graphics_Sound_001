using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_cream_script : MonoBehaviour
{
    public AudioSource waterDrop;

    // Start is called before the first frame update
    void Start()
    {
        waterDrop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "cone" || col.gameObject.tag == "scream")
        {
            waterDrop.Play();
            Destroy(col.otherRigidbody);
            gameObject.transform.SetParent(col.transform);
        }
        else
        {
            Destroy(gameObject, .9f);
        }
        
        if (col.gameObject.tag == "max")
        {
            Application.LoadLevel(0);
        }

    }
}
