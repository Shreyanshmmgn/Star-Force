using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpwanningStation_2 : MonoBehaviour
{
    public float health = 10f;
    public GameObject explosion;
  
    public void Takedamage()
    {
        health -= 1f;
        enemyHealth2.enemyhealth_2 = health;

        // damage-=1f;
        //enemyHealth.health=damage;
        //damage=enemyHealth.health;
        //damage-=1f;

        if (enemyHealth2.enemyhealth_2 == 0)
        {

            explosion.SetActive(true);


            InvokeRepeating("die", 4f, 0);
        }
    }

    void die()
    {
        Destroy(gameObject);
        Debug.Log("destroy");
    }

}
