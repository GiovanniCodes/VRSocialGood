using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerevent2 : MonoBehaviour
{
    string scene;
    void OnCollisionEnter(Collision col) => Initiate.Fade("Scene1", Color.black, 0.5f);
}
