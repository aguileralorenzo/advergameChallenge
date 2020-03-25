using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bravo;
    public GameObject goal;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (rb.position.y >= 4f)
        {
            if (rb.position.y >= 0f)
            {
                if (rb.position.x <= 3f) {
                    print("bravo pd" + rb.position);
                    bravo.SetActive(true);
                    goal.SetActive(false);
                    player.SetActive(false);
                }
                
            }
        }   
    }
}
