using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] string playerName = "Alien";

    [Range(1, 10)]
    [SerializeField] float moveSpeed = 5.5f;
    public float jumpForce = 7.5f;

    int totalCoin = 5;
    int coin;
    bool isGrounded = true;

    Rigidbody2D rb;
    SpriteRenderer sprites;
    Vector2 move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprites = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        move = InputSystem.actions.FindAction("Move").ReadValue<Vector2>();

        if (InputSystem.actions.FindAction("Jump").WasPressedThisFrame() && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        if (move.x > 0.1f)
        {
            sprites.flipX = false;
        }
        else if (move.x < -0.1f)
        {
            sprites.flipX = true;
        }
    }

    // 50Hz Move +1 หรือ -1 //400fps
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(move.x * moveSpeed, rb.linearVelocity.y); // Vector x, y
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coin++;
            Debug.LogWarning($"Coin collected! Total: {coin}");
            Destroy(other.gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.GetContact(0).normal.y > 0.1f)
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

}
