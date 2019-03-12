using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour
{
      public void changeScene(string scene)
    {
        Initiate.Fade(scene, Color.black, 0.5f);
    }


}
