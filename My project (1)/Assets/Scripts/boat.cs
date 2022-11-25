using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class boat : MonoBehaviour {

	public float turnSpeed = 1000f;
	public float accellerateSpeed = 1000f;

	private Rigidbody rbody;

	// Use this for initialization
	void Start () 
	{
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		// rbody.AddTorque(0f,0f,v*turnSpeed*Time.deltaTime);
		rbody.AddForce(transform.right*-1*v*accellerateSpeed*Time.deltaTime);
		rbody.AddForce(transform.forward*h*accellerateSpeed*Time.deltaTime);

		if(Input.GetKey("r")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

	}

}
