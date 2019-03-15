using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerevent1 : MonoBehaviour
{
    string scene;
    void OnCollisionEnter(Collision col) => Initiate.Fade("Scene3", Color.black, 0.5f);
}
