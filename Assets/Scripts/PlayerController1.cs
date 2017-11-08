using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class PlayerController1 : MonoBehaviour, PowerUpController
{

	public float speed;
	public Main main;
	public KeyCode left, up, right, down;

	private Rigidbody rb;
	public float powerUpSpeed = 0;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		powerUpSpeed = speed;
		main = new Main ();
		left = KeyCode.A;
		right = KeyCode.D;
		up = KeyCode.W;
		down = KeyCode.S;
	}

	void FixedUpdate()
	{
		//float moveHorizontal = Input.GetAxis("Horizontal");
		//float moveVertical = Input.GetAxis("Vertical");

		if (Input.GetKey(up))
		{
			rb.AddForce(Vector3.forward * speed);
		}

		if (Input.GetKey(left))
		{
			rb.AddForce(Vector3.left * speed);
		}

		if (Input.GetKey(down))
		{
			rb.AddForce(Vector3.back * speed);
		}

		if (Input.GetKey(right))
		{
			rb.AddForce(Vector3.right * speed);
		}


		//Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		//rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			main.selectRandomPowerUp (this);
		}
	}

	public void SpeedUp()
	{
		powerUpSpeed = powerUpSpeed * (float) 1.5;
	}

	public void SlowDown()
	{
		powerUpSpeed = powerUpSpeed * (float) 0.5;
	}

	public void resetSpeed()
	{
		powerUpSpeed = speed;
	}

	public void Inverse()
	{
		left = KeyCode.D;
		right = KeyCode.A;
	}

	public void resetInverse()
	{
		right = KeyCode.D;
		left = KeyCode.A;
	}
}