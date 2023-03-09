using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_buttons : MonoBehaviour
{
    public string levelToLoad;

    public GameObject creditsWindow;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void OpenCreditsWindow()
    {
        creditsWindow.SetActive(true);
    }

    public void CloseCreditsSWindow()
    {
        creditsWindow.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}