using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject[] spawner;
    int index;

    public void SpawnCookie(int i) {
        spawner[i].GetComponent<CookieLauncher>().ShootCookie();
    }
}
