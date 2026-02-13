using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _point;
    [SerializeField] private float _spawnDelay;

    private void Start()
    {
        StartCoroutine(CountTime());
    }

    private IEnumerator CountTime()
    {
        var wait = new WaitForSeconds(_spawnDelay);

        while (true)
        {
            yield return wait;
            SpawnEnemy();
        }
    }

    public void SpawnEnemy()
    {
        Instantiate(_enemy, transform.position, Quaternion.identity).SetPoint(_point);
    }
}
