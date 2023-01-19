using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    float _speed = 5.0f;
    Vector2 _dir;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StrBullet();
    }
    void StrBullet()
    {
        transform.Translate(_dir * Time.deltaTime * _speed);
    }
    public void Init()
    {
        _dir = Vector2.up;
    }
}
