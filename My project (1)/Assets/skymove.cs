using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skymove : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnSpeed = 1000f;
	public float accellerateSpeed = 1000f;

	private Rigidbody rbody;
    void Start()
    {
        rbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		// rbody.AddTorque(0f,0f,v*turnSpeed*Time.deltaTime);
		rbody.AddForce(transform.right*h*accellerateSpeed*Time.deltaTime);
		rbody.AddForce(transform.forward*v*accellerateSpeed*Time.deltaTime);

        if(Input.GetKey("r")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

	}
}
