using UnityEngine;
using System.Collections;

public class rockGenerator : MonoBehaviour
{
    public GameObject rockPrefab;

    void Start()
    {
        InvokeRepeating("Generaterock", 1, 1);
        InvokeRepeating("Generaterock", 1, 1);
        InvokeRepeating("Generaterock", 1, 1);
    }

    void Generaterock()
    {
        Instantiate(rockPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }
}
