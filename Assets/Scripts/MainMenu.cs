using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string currentPlace;
    //Navigating to certain Unity Scenes
    public void ReturnMainMenu ()
    {
        ValueToKeep.sanityToKeep = 0;
        SceneManager.LoadSceneAsync(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void PickChapter()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void PickOptions()
    {
        SceneManager.LoadSceneAsync(3);
    }
    //Ending the Game
    public void QuitGame()
    {
        Application.Quit();
    }
}
