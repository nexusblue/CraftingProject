using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public float distance = 5;
    RaycastHit whatIHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distance, Color.magenta);

        if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distance)){

            if (Input.GetMouseButtonDown(0)){
                Debug.Log("I picked up a " + whatIHit.collider.gameObject.name);
                //if (whatIHit.collider.tag == "coin"){

                //}
            }
        }

    }
}
