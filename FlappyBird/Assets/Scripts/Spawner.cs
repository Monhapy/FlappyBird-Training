using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject pipes;
    public float topHeight, bottomHeight,spawnTime;

    public BirdScript bird;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (!bird.isDead)
        {
            Instantiate(pipes, new Vector3(8f, Random.Range(topHeight, bottomHeight), 0f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        
    }
}
