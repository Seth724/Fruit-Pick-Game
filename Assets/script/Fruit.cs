using UnityEngine;

public class Fruit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float distroyPossition;

    private GameManager gameManager;

    public void Start()
    {
        gameManager=FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < distroyPossition)
        {
            Destroy(gameObject);
            gameManager.life -= 1;
        }
    }
}
