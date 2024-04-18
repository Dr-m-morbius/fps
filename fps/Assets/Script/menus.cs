using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class menus : MonoBehaviour
{

void Start()
{
       Cursor.lockState = CursorLockMode.None;
}
    public int LevelOne;
    

    public void OnplayButtonPressed()
    {
        SceneManager.LoadScene(LevelOne);
    }

    public void OnQuitButtonPresses()
    {
        Application.Quit();
    }
}
