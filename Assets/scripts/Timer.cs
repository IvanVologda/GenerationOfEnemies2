using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private SpawnSelector _selector;
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
            _selector.SpawnRandom();
        }
    }
}
