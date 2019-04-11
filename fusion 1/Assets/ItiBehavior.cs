using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItiBehavior : MonoBehaviour
{
	public Rigidbody2D m_rb2D;
	public float m_vitesse = 1000f;

	public GameObject m_gauche;
	public GameObject m_droite;
	public GameObject m_center;

	public bool isLeft = false;
	public bool isRight = false;

	public bool mustWaitForControl = false;
	public AudioClip Sound;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetAxis("Horizontal") == 0f) {
			mustWaitForControl = false;
		}

		if (mustWaitForControl == true) {
			return;
		}

		if (Input.GetAxis("Horizontal") < 0f) {
		 	if (isLeft == false) {
		 		if (isRight == true) {
	 			transform.position = m_center.transform.position;
	 		 	isRight = false;
		 		}
		 		else {
		 		 transform.position = m_gauche.transform.position;
		 		 isLeft = true;
		 		}
		 	}	
		 	mustWaitForControl = true;
		 }

		 if (Input.GetAxis("Horizontal") > 0f) {
		 	if (isRight == false) {
		 		if (isLeft == true) {
	 			transform.position = m_center.transform.position;
	 		 	isLeft = false;
		 		}
		 		else {
		 		 transform.position = m_droite.transform.position;
		 		 isRight = true;
		 		}
		 	}	
		 	mustWaitForControl = true;
		 }
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
	 Destroy(gameObject);

	}


}
