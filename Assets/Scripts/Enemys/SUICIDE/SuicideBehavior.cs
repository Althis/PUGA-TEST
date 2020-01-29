using UnityEngine;
using System.Collections;

public class SuicideBehavior : EnemysBehavior
{
    public EnemyTemplate enemyDB;
    void Start()
    {
        StartStatus(enemyDB);

        shipTransform = GameObject.Find("AllShip").transform;
    }


    void Update()
    {
        UpdateMovimenteSpeed();
        MoveToShip();
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.transform.CompareTag("Ship")) 
        {
            Dead();
        }
    }
}
