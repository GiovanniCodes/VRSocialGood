using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHand : MonoBehaviour
{
   public Transform onHand1;

void OnMouseDown() {
 GetComponent<Rigidbody>().useGravity = false;
 this.transform.position = onHand1.transform.position;
 this.transform.parent = GameObject.Find("FirstPerson").transform;
}
}
