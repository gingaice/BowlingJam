
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuMovement : MonoBehaviour
{
    public Canvas Menu;

    public Canvas LoadingScreen;

    public bool LoadScene = false;
    public Image Loading;
    public Image SLoad;
    public Image loadingNow;

    void Start()
    {
        LoadingScreen.enabled = false;
        Loading.enabled = false;
        SLoad.enabled = false;
        loadingNow.enabled = false;
    }

    public void loadGame()
    {
        Menu.enabled = false;
        LoadingScreen.enabled = true;
        StartCoroutine(LoadLevel1());
        LoadScene = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menu.enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1;
    }
    public void loadSettingsMenu()
    {
        SceneManager.LoadScene("Settings");
        Time.timeScale = 1;
    }
    public void loadResume()
    {
        Menu.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
    public void CloseGame()
    {
        Application.Quit();
        Debug.Log("the game has quit");
    }

    IEnumerator LoadLevel1()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Main");
        SLoad.enabled = false;
        Loading.enabled = true;
        loadingNow.enabled = true;
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}