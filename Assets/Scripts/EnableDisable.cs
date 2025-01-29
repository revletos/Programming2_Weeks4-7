using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //sr.enabled = false;  // hides the sprite
            //script.enabled = false; //removes scrip
            go.SetActive(false); //disables game object 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true; //shows the sprite
            //script.enabled = true; //turns on script
            go.SetActive(true); // ennable game object (can be used to spawn without using prefabs if you want a limited amount of assets)
        }
    }
}
