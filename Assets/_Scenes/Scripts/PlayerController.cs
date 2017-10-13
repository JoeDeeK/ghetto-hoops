using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}



	void OnTriggerEnter(Collider other)  //when we touch cubes will deactivate the cubes
	//we are using ontriggerenter instead of oncollision enter so not to destroy cubes
	//remember to check istrigger in prefab pickup -under box collider
	{
		if (other.gameObject.CompareTag ( "Pick Up")) //remember  to set tag in unity
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}



	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12)
		{
			winText.text = "You Win!";
		}
	}
}