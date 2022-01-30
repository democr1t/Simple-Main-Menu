using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SceneSwitcher))]
public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _newgame;
    [SerializeField] private Button _options;
    [SerializeField] private Button _exit;
    [SerializeField] private OptionMenu _optionsMenu;

    private SceneSwitcher _sceneSwitcher;

    private void Start()
    {
        _sceneSwitcher = GetComponent<SceneSwitcher>();

        _newgame.onClick.AddListener(_sceneSwitcher.LoadMain);
        _options.onClick.AddListener(OpenOptions);
        _exit.onClick.AddListener(Exit);
    }

    private void Exit()
    {       
        Application.Quit();
        Debug.Log("Application closed");
    }

    private void OpenOptions()
    {
        gameObject.SetActive(false);
        _optionsMenu.gameObject.SetActive(true);
    }
}
