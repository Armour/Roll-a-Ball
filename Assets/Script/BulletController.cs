using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public static int bulletCount = 1;

	// Use this for initialization
	void Start () {
		bulletCount++;
	}

	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 2.0f);
	}

	void OnDestroy() {
		bulletCount--;
	}
}
