using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SceneSwitcher))]
public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _newgameButton;
    
    private SceneSwitcher _sceneSwitcher;

    private void Start()
    {
        _sceneSwitcher = GetComponent<SceneSwitcher>();

        _newgameButton.onClick.AddListener(_sceneSwitcher.LoadMain);
    }
}
