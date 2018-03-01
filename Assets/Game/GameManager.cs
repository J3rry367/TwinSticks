using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public bool isRecording = true;
    public bool isPaused = false;
    private float initialFixedDeltaTime;

    private void Start()
    {
        initialFixedDeltaTime = Time.fixedDeltaTime;
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

        if (CrossPlatformInputManager.GetButtonDown("Pause") && isPaused)
        {
            UnPauseGame();
        }else if (CrossPlatformInputManager.GetButtonDown("Pause") && !isPaused)
        {
            PauseGame();
        }
	}

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0;
        print("Paused");
        // add graphical indication showing game has been paused.
    }

    void UnPauseGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        Time.fixedDeltaTime = initialFixedDeltaTime;
    }

    private void OnApplicationPause(bool pause)
    {
        isPaused = pause;
    }
}
