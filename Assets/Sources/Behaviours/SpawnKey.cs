﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKey : MonoBehaviour
{
    public GameObject key;
    public Transform[] spawnPoints;

    void Start()
    {
        int random = Random.Range(0, spawnPoints.Length - 1);
        Instantiate(key, spawnPoints[random]);
    }

    void OnTriggerEnter(Collider collider)
    {
        IMainCharacter mainCharacter = collider.gameObject.GetComponent<IMainCharacter>();

        if (mainCharacter != null)
        {
            mainCharacter.IHaveTheKey = true;
            Debug.Log(string.Format("Key: {0}", mainCharacter.IHaveTheKey));
        }
    }
}
