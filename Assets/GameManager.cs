using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public bool isRecording = true;

	void Update () {
        if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            isRecording = false;
            Debug.Log("Playback mode");
        } else
        {
            isRecording = true;
        }
	}
}
