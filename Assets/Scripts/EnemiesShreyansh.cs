﻿using UnityEngine;

public class EnemiesShreyansh : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retratDistance;
    private float TimeBtwShots;
    public float startTimeBtwShots;
    public GameObject projectile;
    private Transform player;
    public Transform Player;
    public int health = 1;
    public GameObject efffect;
    public GameObject sound;

    public void Takedamage(int damage)
    {
        efffect.SetActive(true);
        sound.SetActive(true);
        health -= damage;
        print(health);
        if (health == 0)
        {
            InvokeRepeating("die", .3f, 0);
        }
    }

    void die()
    {
        Destroy(gameObject);

    }

    // void movingPath()
    // {
    //     enemies.AddForce(new Vector3(1f, 1f, 0f), ForceMode.Impulse);
    // }
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        TimeBtwShots = startTimeBtwShots;
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation
                                              , Quaternion.LookRotation(Player.position - transform.position)
                                              , speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, Player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
            // Vector3 direction =Player.position - this.transform.position;
            // transform.Translate(direction.normalized*speed*Time.deltaTime);

        }
        else if (Vector3.Distance(transform.position, Player.position) == stoppingDistance && Vector3.Distance(transform.position, Player.position) > retratDistance)
        {
            transform.position = this.transform.position;

        }
        else if (Vector3.Distance(transform.position, Player.position) < retratDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.position, -speed * Time.deltaTime);

        }

        if (TimeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            TimeBtwShots = startTimeBtwShots;
        }
        else
        {
            TimeBtwShots -= Time.deltaTime;
        }
    }
}
