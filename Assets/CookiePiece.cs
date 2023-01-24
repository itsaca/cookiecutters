using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookiePiece : MonoBehaviour
{
    public Vector2 direction;
    float force;
    float torque;
    float gravity;

    void Start() {
            force = Random.Range(80, 200);
            torque = Random.Range(10, 50);
            gravity = Random.Range(0.5f, 2);
            direction = new Vector2(0, 1);
            gameObject.GetComponent<Rigidbody2D>().AddForce(direction * force);
            gameObject.GetComponent<Rigidbody2D>().AddTorque(torque);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = gravity;
        }
    }
