using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float _speed;
    GameObject _bullet;
    // Start is called before the first frame update
    void Start()
    {
        _bullet = Resources.Load("Prefabs/Bullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject temp = Instantiate(_bullet);
            temp.transform.position = transform.position;
            temp.name = "Bullet";
            temp.GetComponent<Bullet>().Init();
        }
    }

    public void Move()
    {
        Vector2 v2 = Vector2.zero;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            v2 += Vector2.up * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v2 += Vector2.down * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            v2 += Vector2.left * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v2 += Vector2.right * Time.deltaTime * _speed;
        }
        if (v2 != Vector2.zero)
        {
            transform.Translate(v2);
        }
    }
}
