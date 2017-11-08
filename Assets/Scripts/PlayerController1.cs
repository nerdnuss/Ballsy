using UnityEngine;
using System.Collections;

public class PlayerController1 : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
			rb.AddForce(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
			rb.AddForce(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
			rb.AddForce(Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
			rb.AddForce(Vector3.right * speed);
        }

        //Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		//rb.AddForce (movement * speed);

	}
}
