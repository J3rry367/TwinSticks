using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public bool isRecording = true;

    private void Start()
    {
        PlayerPrefsManager.UnlockLevel(2);
        print(PlayerPrefsManager.IsLevelUnlocked(1));
        print(PlayerPrefsManager.IsLevelUnlocked(2));
    }

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
