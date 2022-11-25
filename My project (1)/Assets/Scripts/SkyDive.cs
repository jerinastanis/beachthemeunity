using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyDive : MonoBehaviour
{   
    public Transform Head ;
    public Rigidbody rb;
    public Transform Parachute;

    bool isclose(){
        return Vector3.Distance(transform.position, Parachute.transform.position)<1;
    }
    void Update()
    {
        if(Input.GetKey("e")&& isclose()){
            rb.useGravity = false;
        }
        
    }
}