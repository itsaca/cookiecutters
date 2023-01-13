using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject[] spawner;
    int index;

    public void SpawnCookie() {
        index = Random.Range(0, 6);
        spawner[index].GetComponent<CookieLauncher>().ShootCookie();
    }
}
