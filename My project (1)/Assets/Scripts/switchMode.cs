using UnityEngine;
using System.Collections;

public class switchMode : MonoBehaviour {

	public GameObject boat;
	public GameObject boatCamera;
	public GameObject player;
	public GameObject playerStartPos;
	public GameObject sky;
	public GameObject SkyDiveCam;
	public KeyCode BoatKey;
	public KeyCode Playerkey;
	public KeyCode skyKey;


	// Use this for initialization
	void Start () {
		sky.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 offset = new Vector3(1,50,1);
		//set to boat mode//
		if(Input.GetKeyUp(BoatKey))
		{
			sky.SetActive(false);
			sky.GetComponent<cube>().enabled = true;
			SkyDiveCam.SetActive(false);


			boat.GetComponent<Rigidbody>().isKinematic = false;
			boat.GetComponent<boat>().enabled = true;
			boatCamera.SetActive(true);
			// boatCamera.transform.position.y += 5;
			boatCamera.transform.position =  new Vector3(boat.transform.position.x,offset.y,boat.transform.position.z);

			player.SetActive(false);
		
		}

		//set to FPS mode//
		if(Input.GetKeyUp(Playerkey))
		{
			boat.GetComponent<Rigidbody>().isKinematic = true;
			boat.GetComponent<boat>().enabled = false;
			// boatCamera.SetActive(false);

			player.SetActive(true);
			// player.transform.position = playerStartPos.transform.position;
		}

		if(Input.GetKeyUp(skyKey))
		{
			// sky.GetComponent<Rigidbody>().isKinematic = true;
			sky.SetActive(true);
			sky.GetComponent<cube>().enabled = false;
			SkyDiveCam.SetActive(true);

			boat.GetComponent<Rigidbody>().isKinematic = true;
			boat.GetComponent<boat>().enabled = false;
			boatCamera.SetActive(false);

			player.SetActive(false);
			// player.transform.position = playerStartPos.transform.position;
			
		}

	}
}
