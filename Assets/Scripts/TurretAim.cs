using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAim : MonoBehaviour
{
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        if (mouse.y > 0)
        {
            Vector2 direction = mouse - transform.position;

            transform.up = direction;
        }
        else
        {
            Debug.Log("nope".ToString());
        }
        
    }
}
