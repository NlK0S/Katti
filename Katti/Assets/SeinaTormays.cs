using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeinaTormays : MonoBehaviour
{
    public float pushForce = 2;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "seina")
        {
            rb.AddForce(Vector2.zero * pushForce, ForceMode2D.Impulse);
        }
    }


}


