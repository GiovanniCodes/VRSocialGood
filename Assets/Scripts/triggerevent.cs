﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerevent : MonoBehaviour
{
    string scene;
    void OnCollisionEnter(Collision col) => Initiate.Fade("Scene2", Color.black, 0.5f);
}
