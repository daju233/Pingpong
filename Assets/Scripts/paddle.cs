using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 30.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();//�����ҵ��ĵ�һ���������
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
