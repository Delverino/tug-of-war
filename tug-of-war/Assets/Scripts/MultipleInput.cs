﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleInput : MonoBehaviour
{
    [System.Serializable]
    public class Controls
    {
        public KeyCode up;
        public KeyCode down;
        public KeyCode left;
        public KeyCode right;
    }

    public TopDownMovement motor;

    public Controls player_1;
    public Controls player_2;

    // Update is called once per frame
    void Update()
    {
        motor.move(get_direction(player_1) + get_direction(player_2));
    }

    

    Vector2 get_direction(Controls c)
    {
        int x = System.Convert.ToInt32(Input.GetKey(c.right)) - System.Convert.ToInt32(Input.GetKey(c.left));
        int y = System.Convert.ToInt32(Input.GetKey(c.up)) - System.Convert.ToInt32(Input.GetKey(c.down));
        
        return new Vector2(x, y);
    }
}
