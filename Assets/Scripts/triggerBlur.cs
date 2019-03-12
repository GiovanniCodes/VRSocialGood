using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerBlur : MonoBehaviour
{
    private int counter;
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if(Physics.Raycast(transform.position, (forward), out hit) && hit.transform.tag == "high" && Input.GetButton("Fire1"))
        {
            counter++;
            hit.collider.gameObject.SetActive(false);
        }
        if (counter > 100)
        {
            img.gameObject.SetActive(true);
        }
    }
}
