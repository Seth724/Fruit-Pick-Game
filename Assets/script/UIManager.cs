using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public UIDocument uiDocument;
    public GameManager gameManager;

    private VisualElement root;
    private TextElement scoreText;
    private TextElement lifeCountText  ;

    private VisualElement gameOverlay;

    private Button restartButton;

    private void OnEnable()
    {
        root = uiDocument.rootVisualElement;
        scoreText = root.Q<TextElement>("ScoreText");
        lifeCountText = root.Q<TextElement>("LifeCountText");
        gameOverlay = root.Q<VisualElement>("GameOver");
        restartButton = root.Q<Button>("PlayAgain");
    }
    // Update is called once per frame
    public void Update()
    {
        scoreText.text = $"Score:{gameManager.score}";
        lifeCountText.text = $"Lives:{gameManager.life}";

        if (gameManager.gameOver == true)
        {
            gameOverlay.style.display = DisplayStyle.Flex   ;
            restartButton.RegisterCallback<ClickEvent>(ev =>
            {
                gameManager.RestartGame();
                gameOverlay.style.display = DisplayStyle.None;
            });
        
        
        }
    }
}
