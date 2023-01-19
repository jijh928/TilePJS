using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    Transform _character;
    float _speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        _character = gameObject.transform;
        transform.Translate((_character.position - transform.position).normalized * Time.deltaTime * _speed);
    }
}
