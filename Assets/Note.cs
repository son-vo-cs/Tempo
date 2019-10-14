using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 0;
    }
    void Create()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0, -5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setSpeed(float s)
    {
        speed = s;
    }
}
