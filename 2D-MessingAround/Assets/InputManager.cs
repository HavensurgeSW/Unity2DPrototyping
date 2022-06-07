using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject pauseCanvas;
    bool pauseStatus;

    private void Start()
    {
        pauseStatus = false;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            GamePause();
    }

    public void GamePause() {
        if (pauseStatus)
        {
            pauseCanvas.SetActive(false);
            pauseStatus = false;
        }
        else
        {
            pauseCanvas.SetActive(true);
            pauseStatus = true;
        }
    }
}
