using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minY;
    public float maxY;
    public float x;
    public float interval;

    private void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }


    private void Spawn()
    {
        GameObject Instance = Instantiate(pipePrefab);
        Instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
        Instance.transform.SetParent(transform);
    }
}
