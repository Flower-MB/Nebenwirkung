using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ReturnMainMenu ()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void PlayChapterTwo()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void PlayChapterThree()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void PickChapter()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void PickOptions()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
