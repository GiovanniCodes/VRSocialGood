using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSceneChange : MonoBehaviour
{
    public string scene;
    public void OnCollisionEnter(Collision col) => Initiate.Fade(scene, Color.black, 0.5f);
}
