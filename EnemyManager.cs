using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<Enemy> enemyList;

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            foreach (var enemy in enemyList)
            {
                enemy.transform.Translate(Vector3.right * 5);
            }
        }
    }
}