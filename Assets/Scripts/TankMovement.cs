using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //REPLACE THIS CODE LATER WITH ACTUAL CODE
        //THIS IS JUST COPY PASTED TO MAKE SURE ALL ELEMENTS MOVE TOGETHER PROPERLY

        //things to note: Tank only switches directions when CENTER of tank hits edge of screen. 
        //See how that could be taken into account with code
        //Speed should be at least 1 from the get go
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
