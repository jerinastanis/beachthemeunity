using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMode : MonoBehaviour
{
    public GameObject BoatCam;
    public GameObject Player;


    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x > 0 &&Player.transform.position.x < 10 && Player.transform.position.z < -25 && Player.transform.position.z > -50){
            BoatCam.SetActive(true);
            Player.SetActive(false);
        }
        else{
            BoatCam.SetActive(false);
            Player.SetActive(true);
        }
    }
}
