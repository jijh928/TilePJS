using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRemove : MonoBehaviour
{
    float _lifeTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _lifeTimer += Time.deltaTime;
        if (_lifeTimer > 4)
        {
            Remove();
        }
    }
    public void Remove()
    {
        Destroy(gameObject);
    }
}
