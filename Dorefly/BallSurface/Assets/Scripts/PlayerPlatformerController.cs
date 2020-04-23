using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : MonoBehaviour
{
    public float speed = 8.0f;

    private Rigidbody2D body;

    private Vector2 currentVelocity;

    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        currentVelocity = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        Move();
    }

    // Use this for initialization
    private void Move()
    {
        float velocityY = Input.GetAxis("Vertical") * speed;

        // Horizontal Movement
        body.velocity = Vector2.SmoothDamp(body.velocity, new Vector2(body.velocity.x, velocityY), ref currentVelocity, 0.02f);
    }

    public void makeDeadplayer()
    {
        Destroy(gameObject);
    }
}
