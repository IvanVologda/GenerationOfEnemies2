using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Timer _timer;
    private Vector3 GetDirection()
    {
        float directionX = Random.Range(-1f, 1f);
        float directionZ = Random.Range(-1f, 1f);

        return new Vector3(directionX, 0, directionZ).normalized;
    }

    public void SpawnEnemy()
    {
        Instantiate(_enemy, transform.position, Quaternion.identity).SetDirection(GetDirection());
    }
}
