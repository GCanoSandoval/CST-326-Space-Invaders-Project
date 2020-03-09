using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Transform bullet;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * -speed;

        if(bullet.position.y <= -10)
        {
            Destroy(bullet.gameObject);
        }
    }


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        else if(other.tag == "Barrier")
        {
            GameObject playerBarrier = other.gameObject;
            BarrierHealth barrierHealth = playerBarrier.GetComponent<BarrierHealth>();
            barrierHealth.health -= 1;
            Destroy(gameObject);
        }
    }
}
