using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour
{

	public float speed;

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		//float moveHorizontal = Input.GetAxis("Horizontal");
		//float moveVertical = Input.GetAxis("Vertical");

		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddForce(Vector3.forward * speed);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb.AddForce(Vector3.left * speed);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			rb.AddForce(Vector3.back * speed);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			rb.AddForce(Vector3.right * speed);
		}


		//Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		//rb.AddForce(movement * speed);

	}
}
