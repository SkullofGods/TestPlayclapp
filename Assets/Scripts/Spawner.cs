using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cube;
    public TMP_InputField delayI, speedI, distanceI;
    [HideInInspector] public int speed, distance;
    private int _delay;
    private bool shouldSpawn = true;

    void Start()
    {
        Delay();
        Speed();
        Distance();
    }

    private void Update()
    {
        if (shouldSpawn)
        {
            shouldSpawn = false;
            StartCoroutine(CubeSpawner());
        }
    }

    public void Delay()
    {
        _delay = Int32.Parse(delayI.text);
    }

    public void Speed()
    {
        speed = Int32.Parse(speedI.text);
    }

    public void Distance()
    {
        distance = Int32.Parse(distanceI.text);
    }
    
    IEnumerator CubeSpawner()
    {
        var obj = Instantiate(cube);
        yield return new WaitForSeconds(_delay);
        shouldSpawn = true;
    }
}
