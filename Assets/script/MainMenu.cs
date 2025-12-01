using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public UIDocument uiDocument;

    private VisualElement root;
    private Button startButton;

    private void OnEnable()
    {
        root = uiDocument.rootVisualElement;
        startButton = root.Q<Button>("PlayButton");
        
    }

    // Update is called once per frame
    private void Update()
    {
        startButton.RegisterCallback<ClickEvent>(ev =>
        {
            startButton.RegisterCallback<ClickEvent>(ev => onPlayButtonClick());
        });
    }
    private void  onPlayButtonClick()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
