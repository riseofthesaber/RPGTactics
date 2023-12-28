using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
 public float panSpeed=20f;
 public float scrollSpeed=2f;
 public bool LimitPanning = false;
public Vector2 panLimit;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if(Input.GetKey("w")){
            pos.z+=panSpeed*Time.deltaTime;
        }
        if(Input.GetKey("a")){
            pos.x-=panSpeed*Time.deltaTime;
        }
        if(Input.GetKey("s")){
            pos.z-=panSpeed*Time.deltaTime;
        }
        if(Input.GetKey("d")){
            pos.x+=panSpeed*Time.deltaTime;
        }

        Vector3 rot = transform.eulerAngles;
        if(Input.GetKeyDown("q")){
            rot.y+=45;
        }
        if(Input.GetKeyDown("e")){
            rot.y-=45;
        }

    float scroll = Input.GetAxis("Mouse ScrollWheel");

    if(LimitPanning){
    pos.x = Math.Clamp(pos.x, -panLimit.x, panLimit.x);
    pos.y = Math.Clamp(pos.y, -panLimit.y, panLimit.y);}

    transform.position=pos;
    transform.eulerAngles=rot;

    }
}
