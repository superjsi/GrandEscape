﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraBehaviour : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("HumanFighter");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
