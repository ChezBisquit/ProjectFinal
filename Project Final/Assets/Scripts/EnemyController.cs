using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;
    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
   
    // Start is called before the first frame update
     void Start()   
     {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;                                                                                                                                                                                                                                                                                                                                                                                                                                          GetComponent<Animator>();
     }

    void Update()
    {
       
    }

    void FixedUpdate()
    {
       

        Vector2 position = rigidbody2D.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
        }

        rigidbody2D.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();
        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }
}