using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHands : MonoBehaviour
{
    public float speed = 200f;
    public AudioSource audioSource;
    public AudioClip cuckoo;
    public int hours = 1;
    public int lasthours = 0;
    public Boolean chimeStarted = false;
    public Boolean chimeEnded = false;
    public float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 rot = transform.eulerAngles;
      
        rot.z -= speed; //* Time.deltaTime;
        transform.eulerAngles = rot;
        //ot.Normalize();

        if ((Mathf.RoundToInt(rot.z) % 30 == 1) && (chimeStarted == false))
        {
            hours += 1;
            chimeStarted = true;
            //audioSource.PlayOneShot(cuckoo);
            audioSource.Play();
        }

        if (chimeStarted == true)
        {
            t += 1;
            if (t > 3)
            {
                chimeStarted = false;
                chimeEnded = true;
                t = 0;
            }

        }
        //if (lasthours > hours) 
        //{
        //    audioSource.PlayOneShot(cuckoo);
        //    Debug.Log(rot.z.ToString());
        //}
        lasthours += 1;
        // Debug.Log(rot.z.ToString());
    }
}
