using UnityEngine;

public class Character : MonoBehaviour
{

    public float speed = 10f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    public bool hasInput = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasInput)
            return;

        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    //Checking if the player is touching the ground
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    public void SetHasInput(bool input)
    {
        hasInput = input;
    }


}