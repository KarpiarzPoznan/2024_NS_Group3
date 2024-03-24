using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolerPtaszka : MonoBehaviour
{

    public Vector2 jumpForce;
    public float maxVertivalVelocity = 5;
    public Rigidbody2D rigidbody2D;



    // Start is called before the first frame update
    void Start()
    {
        var value = 10;

        Debug.Log("Hello Wolrd");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(jumpForce, ForceMode2D.Impulse);
        }
        if (rigidbody2D.velocity.y > maxVertivalVelocity)
        { 
            rigidbody2D.velocity = new Vector2(0, maxVertivalVelocity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel("FlappyBird");
    }
}
