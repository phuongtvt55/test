using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveInput;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool isGround;
    public Player player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = new Player("Player1", 10f, 7f);
    }

    // Update is called once per frame
    void Update()
    {       
        moveInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && isGround) {
            rb.velocity = new Vector2(moveInput * player.speed, player.jumpPower);
        }
        rb.velocity = new Vector2(moveInput * player.speed, rb.velocity.y);

        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.02f, groundLayer);
    }
}
