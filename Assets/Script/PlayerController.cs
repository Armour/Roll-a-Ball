﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	[Range(0, 100)] public float speed;
	public Text countText;
	public Text winText;
	public Rigidbody bullet;
	public Transform playerPos;

	private int maxScore = 14;
	private Rigidbody rb;
	private int count;

	void Start() {
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
	}

	public float TestSpeed {
		get {
			return speed;
		}
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	}

	void Update() {
		if (Input.GetButtonDown("Fire1")) {
			Shoot();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive(false);
			count++;
			SetCountText();
		}
	}

	void SetCountText() {
		countText.text = "Count: " + count.ToString();
		if (count >= maxScore) {
			winText.text = "You win !!!";
		}
	}

	private void Shoot() {
		Rigidbody bulletInstance;
		bulletInstance = Instantiate(bullet, playerPos.position, playerPos.rotation) as Rigidbody;
		bulletInstance.AddForce(playerPos.forward * 1000);
		Debug.Log(BulletController.bulletCount);
	}
}
