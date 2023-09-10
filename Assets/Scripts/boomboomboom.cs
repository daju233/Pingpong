using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class boomboomboom : MonoBehaviour
{
    private float boom=10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ball ball = collision.gameObject.GetComponent<ball>();//什么意思
        if(ball!=null)
        {
            Vector2 normal = collision.GetContact(0).normal;//看不懂
            ball.Addforce(-normal * this.boom);
        }
    }
        
    }

