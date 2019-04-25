using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movespeed;
    public float jumpspeed;
    public GameObject groundCheck;

    private bool grounded;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool jump = Input.GetKeyDown("space");
        float Hin = Input.GetAxisRaw("Horizontal");

        rb.AddForce(new Vector2(Hin * movespeed, 0f),ForceMode2D.Impulse);
        if (jump && grounded) {
            rb.AddForce(new Vector2(0f,jumpspeed), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        grounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision) {
        grounded = false;
    }
}
