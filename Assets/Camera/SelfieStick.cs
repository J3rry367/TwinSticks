﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SelfieStick : MonoBehaviour {

    public float panSpeed = 10f;

    private GameObject player;
    private Vector3 armRotation;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        armRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        // camera movement with gamepad
        armRotation.y += Input.GetAxis("RHoriz") * panSpeed;
        armRotation.x += Input.GetAxis("RVert") * panSpeed;

        //camera movement with mouse
        if (Input.GetButton("Fire2"))
        {
            armRotation.y += Input.GetAxis("Mouse X") * panSpeed;
            armRotation.x += Input.GetAxis("Mouse Y") * panSpeed;
        }

        transform.position = player.transform.position;
        transform.rotation = Quaternion.Euler (armRotation);
	}
}
