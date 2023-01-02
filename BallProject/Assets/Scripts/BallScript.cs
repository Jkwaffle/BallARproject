using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallScript : MonoBehaviour
{
    public GameObject cameraobject;
    Vector3 startforce;
    Rigidbody rigidbody1;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 offset = new Vector3(0, 2f, 0);
        rigidbody1 = GetComponent<Rigidbody>();
        this.gameObject.transform.position = cameraobject.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            rigidbody1.constraints = RigidbodyConstraints.None;
            rigidbody1.AddForce(Vector3.forward, ForceMode.Impulse);
        }
    }
}
