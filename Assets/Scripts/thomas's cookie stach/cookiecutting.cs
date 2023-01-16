using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecutting : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "blade")
        {
            Debug.Log("cookie got cut!");
            Destroy(gameObject);
        }
    }
}
