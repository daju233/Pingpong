using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : paddle
{
    private Vector2 _direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up;
            this.speed = 30.0f;
        }
        else if(Input.GetKey(KeyCode.S))
            {
            _direction = Vector2.down;
            this.speed = 30.0f;
        }
        else
        {
            _direction = Vector2.zero;
            this.speed = 0;
        }
    }

    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude!=0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
