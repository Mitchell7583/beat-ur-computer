﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutRespawn : MonoBehaviour
{
    public GameObject Prefab;
    public int totalDonut = 0;
    private float delay = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;

        //donut respawn
        if (gameObject.name == "Donuts")
        {
            if (totalDonut < 2 && delay <= 0)
            {
                //get transform
                Transform transform = gameObject.GetComponent<Transform>();
                //spawn
                var newDonut = Instantiate(Prefab, transform.position, Quaternion.identity);
                newDonut.transform.parent = gameObject.transform;

                //cooldown
                delay = 5f;

                //donut count
                totalDonut++;
            }
        }
    }

    public void Decrease()
    {
        totalDonut--;
    }

}
