using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeCode : MonoBehaviour
{
	private Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
	    {
		    mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = new Vector2(mousePosition.x, -4.8f);
        }


    }
    
}
