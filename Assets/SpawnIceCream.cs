using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIceCream : MonoBehaviour
{
    public float spawnTime = 1.5f;
    public Transform CookieDough;
    public Transform Raspberry;
    public Transform Blueberry;
    public Transform CookiesnCream;
    public Transform FrenchVanilla;
    public Transform MintChocoChip;
    public Transform Strawberry;
    public Transform StrawberryCheeseCake;

    int layerOrder = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateIceCream", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateIceCream()
    {
        int which = Mathf.FloorToInt(Random.Range(0f, 8f));
        Transform go = null;
        if (which == 0) {
           go = Instantiate(CookieDough, new Vector3(Random.Range(-6.0f, 6.0f), 4f, 0f), Quaternion.identity);
        } else if (which == 1)
        { 
           go = Instantiate(Raspberry, new Vector3(Random.Range(-6.0f, 6.0f), 4f, 0f), Quaternion.identity);
        } else if (which == 2)
        {
            go = Instantiate(Blueberry, new Vector3(Random.Range(-6.0f, 6.0f),4f, 0f), Quaternion.identity);
        } else if (which == 3)
        {
            go = Instantiate(CookiesnCream, new Vector3(Random.Range(-6.0f, 6.0f), 4f, 0f), Quaternion.identity);
        } else if (which == 4)
        {
            go = Instantiate(FrenchVanilla, new Vector3(Random.Range(-6.0f, 6.0f), 4f, 0f), Quaternion.identity);
        } else if (which == 5)
        {
            go = Instantiate(MintChocoChip, new Vector3(Random.Range(-6.0f, 6.0f), 4f, 0f), Quaternion.identity);
        } else if (which == 6)
        {
            go = Instantiate(Strawberry, new Vector3(Random.Range(-6.0f, 6.0f), 4.2f, 0f), Quaternion.identity);
        } else if (which == 7)
        {
            go = Instantiate(StrawberryCheeseCake, new Vector3(Random.Range(-6.0f, 6.0f), 4f, 0f), Quaternion.identity);
        } 

        if (go != null)
        {
            go.gameObject.GetComponent<SpriteRenderer>().sortingOrder = layerOrder;
            layerOrder += 1;
        }



    }
}
