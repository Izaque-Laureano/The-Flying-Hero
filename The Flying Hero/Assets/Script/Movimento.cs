using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movimento : MonoBehaviour
{
    Rigidbody2D RB;
    public float MaxSpeed, CurrentSpeed;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        MaxSpeed = Random.Range(150, 300);
        CurrentSpeed = MaxSpeed;
    }


    private void FixedUpdate()
    {
        RB.velocity = Vector2.left * CurrentSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);

        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}