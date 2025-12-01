using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Rigidbody2D rbody;
    public float moveSpeed;
    public float minX, maxX;
    public GameManager gameManager;


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rbody.linearVelocity = new Vector2(horizontalInput * moveSpeed, rbody.linearVelocity.y);
        transform.position = new Vector2(Mathf.Clamp(rbody.position.x, minX, maxX), transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fruit"))
        {
            Destroy(collision.gameObject);
            gameManager.score+=1;
        }
    }
}
