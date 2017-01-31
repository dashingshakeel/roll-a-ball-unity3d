using UnityEngine;
using System.Collections;



public class player : MonoBehaviour {
	public Rigidbody rb;
	public int count;
	public GUIText textcount;
	public GUIText wintext;



	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		setcout ();
		wintext.text = " ";
		}


	void FixedUpdate(){
				float movehori = Input.GetAxis ("Horizontal");
				float moveverti = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (movehori, 0.0f, moveverti);

		rb.AddForce (movement *19);

		}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Pick Up")){
			other.gameObject.SetActive(false);
			count++;
			setcout();
		
		}


	}
	void setcout(){
		textcount.text = "Count:" + count.ToString ();
		if (count >= 7) {
			wintext.text= "youn win";
				}
	}

}
