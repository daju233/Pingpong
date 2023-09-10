using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    static float speed=300.0f;//这里的参数为什么在private和public中有问题？
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Addingforce();
        //resetPosition();
       
    }

    private void FixedUpdate()
    {
        resetPosition();
    }

    private void Addingforce()
    {
        float x = Random.value < 0.5f?-1.0f:1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f,-0.5f)
                                      :Random.Range(0.5f,1.0f);
        Vector2 direction = new Vector2(x,y);
        _rigidbody2D.AddForce(direction*speed);
    }

    public void Addforce(Vector2 force)
    {
        _rigidbody2D.AddForce(force);
    }


    private void resetPosition()
    {
        if (Input.GetKey(KeyCode.R))
            {
            _rigidbody2D.position = Vector2.zero;
            _rigidbody2D.velocity = Vector2.zero;
            Addingforce();
        }
    }

    public void Reset()
    {
        _rigidbody2D.position = Vector2.zero;
        _rigidbody2D.velocity = Vector2.zero;
        Addingforce();
    }


}

