using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSelector : MonoBehaviour
{
    [SerializeField] private Spawner _spawnerA;
    [SerializeField] private Spawner _spawnerB;
    [SerializeField] private Spawner _spawnerC;
    [SerializeField] private Spawner _spawnerD;

    public void SpawnRandom()
    {
        const int spawnerA = 0;
        const int spawnerB = 1;
        const int spawnerC = 2;

        int numberSpawner = Random.Range(0, 4);

        switch (numberSpawner)
        {
            case spawnerA:
                _spawnerA.SpawnEnemy();
                break;

            case spawnerB:
                _spawnerB.SpawnEnemy();
                break;

            case spawnerC:
                _spawnerC.SpawnEnemy();
                break;

            default:
                _spawnerD.SpawnEnemy();
                break;
        }
    }
}
