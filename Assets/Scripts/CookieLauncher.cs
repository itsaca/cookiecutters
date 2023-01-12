using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieLauncher : MonoBehaviour
{
    public GameObject cookie;
    public Transform cookieFolder;
    public float lowForce;
    public float highForce;
    public Vector2 direction;

    public void ShootCookie() {
        var force = Random.Range(lowForce,highForce);
        var instance = Instantiate(cookie, transform.position, Quaternion.identity, cookieFolder);
        instance.GetComponent<Rigidbody2D>().AddForce(direction * force);
    }

}
