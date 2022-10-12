using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;
        }
        Debug.Log(Vector2.left);
        if (Input.GetKey(KeyCode.A))
            rb.velocity = Vector2.left * velocity + new Vector2(0.0f, -0.6f);
        if (Input.GetKey(KeyCode.D))
            rb.velocity = Vector2.right * velocity + new Vector2(0.0f, -0.6f);
    }
}
