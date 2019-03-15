using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk1 : MonoBehaviour
{
    public int PlayerSpeed = 5;
    public Transform vrCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*PlayerSpeed);
        }
    }
}
