using UnityEngine;
using System.Collections;

public class perheb : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
