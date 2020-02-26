using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    public Vector2 target;
    public float response = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        body.velocity = Vector2.Lerp(body.velocity, target, response);
    }

    public void move(Vector2 direction)
    {
        target = direction * speed;
    }
}
