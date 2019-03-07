using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalk : MonoBehaviour {
	

		public int playerSpeed;
		public static playerWalk instance;
		public GameObject g;
		// Use this for initialization
		void Start () {
			instance = this;
			g.SetActive (false);
		}

		// Update is called once per frame
		void Update () {
			if(Input.GetButton("Fire1")){
				transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
			}

	}
}
