using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Spawner _parameter;
    private int _speed, _distance;
    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
        _parameter = FindObjectOfType<Spawner>();
    }
    
    void Update()
    {
        _speed = _parameter.speed;
        _distance = _parameter.distance;
        transform.Translate(Vector3.right*Time.deltaTime*_speed);
        if (Vector3.Distance(transform.position, _startPos)>=_distance)
            Destroy(this.gameObject);
    }
}
