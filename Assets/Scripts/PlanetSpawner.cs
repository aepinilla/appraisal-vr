using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public GameObject planetPrefab;

    void FixedUpdate()
    {
        Instantiate(planetPrefab, transform.position, Quaternion.identity);        
    }
}
