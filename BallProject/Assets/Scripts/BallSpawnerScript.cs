using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject cameraobject;
    public GameObject prefabball;
   
    // Update is called once per frame
    void Update()
    {
        //spawns ball on tap on screen
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                //ball spawns at the camera position,no change in rotation
                Instantiate(prefabball, cameraobject.transform.position+ (cameraobject.transform.forward), new Quaternion(0, 0, 0, 1));
           
            }
        }
    }
}
