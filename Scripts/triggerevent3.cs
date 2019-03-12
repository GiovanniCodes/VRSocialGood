using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerevent3 : MonoBehaviour
{
    string scene;
    void OnCollisionEnter(Collision col) => Initiate.Fade("Endcredits", Color.black, 0.5f);
}
