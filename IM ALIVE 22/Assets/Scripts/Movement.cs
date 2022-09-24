using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour { 
    Rigidbody2D body;
    float horizontal;
    float vertical;

    [SerializeField] public float speed;
    public float dashDistance = 15f;
    bool isDashing;
     
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {

        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}