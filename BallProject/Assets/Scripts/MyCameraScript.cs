using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraScript : MonoBehaviour
{
    RaycastHit hit;

    int LayerMask = 1 << 8;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LayerMask = ~LayerMask;
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 2f, transform.position.z), Vector3.forward, Color.yellow);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, LayerMask))
        {
            Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 2f, transform.position.z), Vector3.forward, Color.red);
        }
    }
}
