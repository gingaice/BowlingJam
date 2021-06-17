
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Canvas Menuy;
    // Start is called before the first frame update
    void Start()
    {
        Menuy.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Menuy.enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    public void loadResume()
    {
        Menuy.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
}

