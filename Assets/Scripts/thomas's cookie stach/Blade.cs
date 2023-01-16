using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public bool isCutting = false;
    public float minSliceValue=.01f;
    Rigidbody2D rb;
    Camera cam;
    Vector2 previousPosition;
    public GameObject bladtrail;
    GameObject currentbladtrail;
    CircleCollider2D circleCollider2D;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        cam=Camera.main;
        circleCollider2D=GetComponent<CircleCollider2D>();
    }
    void Update()
    {
        
        
        
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if(isCutting)
        {
            UpdateBlade();
        }

    }
    void UpdateBlade()
        {
            Vector2 newPosition=cam.ScreenToWorldPoint(Input.mousePosition);
            rb.position = newPosition;
            float velocity = (newPosition - previousPosition).magnitude*Time.deltaTime;
            if (velocity > minSliceValue) 
            {
                circleCollider2D.enabled = true;
                Debug.Log("cutting now");
            }
        else
            { 
                circleCollider2D.enabled = false;   
            }
            previousPosition= newPosition;

        }
    void StartCutting()
    {
        isCutting= true;
        currentbladtrail = Instantiate(bladtrail, transform);
        //previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        circleCollider2D.enabled= false;
    }

    void StopCutting()
    {
        isCutting= false;
        currentbladtrail.transform.SetParent(null);
        Destroy(currentbladtrail);
        circleCollider2D.enabled= false;    

    }

    
}
