using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{

    FoodData foodData = new FoodData();
    int i = 0;

    void Start()
    {
        Debug.Log("DDDD");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            i = (i + 1) % foodData.list.Count;
            Debug.Log(foodData.list[i].name);
        }
    }

}
