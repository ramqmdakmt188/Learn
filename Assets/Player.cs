using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public float xInput;
    public float moveSpeed = 10;
    public float jumpForce = 7;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
