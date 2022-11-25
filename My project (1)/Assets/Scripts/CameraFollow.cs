using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Boat;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Boat.transform.position;
    }
}
