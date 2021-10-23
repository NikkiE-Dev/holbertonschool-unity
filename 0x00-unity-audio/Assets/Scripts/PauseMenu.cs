using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Creating Pause Menu</summary>
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public Button resumeButton;
    public Button restartButton;
    public Button menuButton;
    public Button optionsButton;

    void Start()
    {
        Button resume = resumeButton.GetComponent<Button>();
        resume.onClick.AddListener(Resume);

        Button restart = restartButton.GetComponent<Button>();
        restart.onClick.AddListener(Restart);

        Button MenuButton = menuButton.GetComponent<Button>();
        MenuButton.onClick.AddListener(MainMenu);

        Button OptionsButton = optionsButton.GetComponent<Button>();
        OptionsButton.onClick.AddListener(Options);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Restart()
    {
        Cursor.lockState = CursorLockMode.Locked;
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }
    public void Options()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        PlayerPrefs.SetInt("lastScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }
}