using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    [Header("Stats Enemy")]
    public int health = 100;
    public int damage;
    public float moveSpeed = 5;

    private bool Attack = false;
    private Vector3 moveDirection;
    private GameObject player;
  





    void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    void Update()
    {
        if (!Attack)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);

            moveDirection = (player.transform.position - transform.position).normalized;

        }


        if (health <= 0)
        {
            Destroy(gameObject);

            

        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerStats>().health -= damage;
        }
    }

}
