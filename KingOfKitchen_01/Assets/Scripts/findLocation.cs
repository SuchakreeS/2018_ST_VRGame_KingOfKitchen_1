﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findLocation : MonoBehaviour {
    public GameObject locationSet;
    public GameObject foodSet;
	void Start () {
        
        Transform[] locationList = locationSet.GetComponentsInChildren<Transform>();
        Transform[] foodList = foodSet.GetComponentsInChildren<Transform>();
        int locationNum = locationList.Length;
        int foodNum = foodList.Length;

        print("" + foodNum);
        //show all transform
        foreach (Transform t in locationList)
        {
            if (t == locationList[0])
            {
                continue;
            }

            int randomNum = Random.Range(1, foodNum);
            Transform temp = Instantiate(foodList[randomNum].transform, t.position, Quaternion.identity);
            Food food = temp.GetComponent<Food>();
            //food.DestroyGameObjectDelay(3);


        }
        
	}
	
}
