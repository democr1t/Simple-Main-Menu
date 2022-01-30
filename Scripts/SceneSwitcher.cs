using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private const string _mainScene = "MainScene";
    private const string _mainMenu = "MainMenu";

    public void LoadMain()
    {
        SceneManager.LoadScene(_mainScene);
        Debug.Log("Loaded Main Scene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(_mainMenu);
        Debug.Log("Loaded Main Menu");
    }
}
