using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Vector3 _direction;

    void Update()
    {
        transform.position += _direction * _moveSpeed * Time.deltaTime;
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}
