using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float jumpForce = 4f;
        void OnCollisionEnter2D(Collision2D collision){
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if(rb!=null){
            Vector2 velocity = rb.velocity;
            velocity.y =jumpForce;
            rb.velocity = velocity;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
