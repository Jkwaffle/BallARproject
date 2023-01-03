using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallScript : MonoBehaviour
{
   
    public float BallLifetime;
    GameObject cameraobject;
    Rigidbody rigidbodyball;
    // Start is called before the first frame update
    void Start()
    {
        cameraobject = FindObjectOfType<Camera>().gameObject;

        rigidbodyball = this.GetComponent<Rigidbody>();
        rigidbodyball.AddForce(cameraobject.transform.forward * 2, ForceMode.Impulse);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        BallLifetime = BallLifetime - Time.deltaTime;
        if(BallLifetime <=0)
        {
            Destroy(this.gameObject);
        }
    }
}
