using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeOver : MonoBehaviour
{
    public Transform cameraPosition;
    public Transform thirdBoid;

    void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = transform;

            cameraPosition.position = thirdBoid.position;

            // cameraPosition.rotation = Quaternion.Slerp(cameraPosition.position, thirdBoid.position, 2f);)
        }
    }
    void OnTriggerExit (Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}