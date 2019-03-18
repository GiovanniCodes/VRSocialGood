using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerevent : MonoBehaviour
{
    string scene;
    void OnCollisionEnter(Collision col) => Initiate.Fade("Market", Color.black, 0.5f);
}
