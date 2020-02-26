using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInterest : MonoBehaviour
{
    public float x_dist;
    public float y_dist;

    public Vector2 target;
    public Vector2 direction;

    public Rigidbody2D body;
    public TopDownMovement motor;

    // Start is called before the first frame update
    void Start()
    {
        new_target();
    }

    // Update is called once per frame
    void Update()
    {
        if( Vector2.SqrMagnitude(body.position - target) < 0.1f)
        {
            new_target();
        }

        direction = (target - body.position).normalized;

        motor.move(direction);
    }

    void new_target()
    {
        target = (Vector2.up * (Random.Range(-y_dist, y_dist))) + (Vector2.right * (Random.Range(-x_dist, x_dist)));
    }

}
