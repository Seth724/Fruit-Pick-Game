using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float score =0;
    public int life = 5;

    public bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            GameOver();
        }
    }
    private void GameOver()
    {
        Time.timeScale = 0;
        gameOver = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        gameOver = false;
        score=0;
        life=5;
    }
}
