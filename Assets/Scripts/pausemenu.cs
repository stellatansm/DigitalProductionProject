using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public GameObject PauseMenu; //ref to pause menu 

    public bool isPaused;

    void Start()
    {
        PauseMenu.SetActive(false); //menu is not active by default
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //if user presses P
        {
            if (isPaused)
            {
                ResumeGame(); 
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(true); //menu is active when button is pressed
        Time.timeScale = 0f;
        isPaused = true;
    }
    
    public void ResumeGame()
    {
        PauseMenu.SetActive(false); //menu is active when button is pressed
        Time.timeScale = 1.0f;
        isPaused = false;
    }
}
