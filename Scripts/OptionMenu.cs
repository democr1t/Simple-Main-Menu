using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] private Button _back;
    [SerializeField] private MainMenu _mainMenu;

    private void OnEnable()
    {
        _back.onClick.AddListener(BackToMain);
    }
    private void BackToMain()
    {
        gameObject.SetActive(false);
        _mainMenu.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        _back.onClick.RemoveListener(BackToMain);
    }
}
