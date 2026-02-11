using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    private Target _target;
    private Vector3 _direction;

    private void Update()
    {
        _direction = (_target.transform.position - transform.position).normalized;
        transform.Translate(_direction * _moveSpeed * Time.deltaTime);
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}
