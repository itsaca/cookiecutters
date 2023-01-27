using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieLauncher : MonoBehaviour
{
    public GameObject[] cookies;
    public Transform cookieFolder;
    public float lowForce;
    public float highForce;
    public Vector2 direction;
    GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }
    public void ShootCookie() {
        var force = Random.Range(lowForce,highForce);
        int index = Random.Range(0,cookies.Length);
        var instance = Instantiate(cookies[index], transform.position, Quaternion.identity, cookieFolder);
        instance.GetComponent<Rigidbody2D>().AddForce(direction * force);
        gm.cookiesshot(1);
    }

}
