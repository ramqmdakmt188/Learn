using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed = 10;
    public float xInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);

    }
}
