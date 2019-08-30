using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpwanningStation : MonoBehaviour
{
    public float health = 10f;
  
    public GameObject explosion2;
  
    public void Takedamage()
    {
        health -= 1f;
        enemyHealth.enemyhealth = health;

        // damage-=1f;
        //enemyHealth.health=damage;
        //damage=enemyHealth.health;
        //damage-=1f;
        if (enemyHealth.enemyhealth == 0)
        {
           
                explosion2.SetActive(true);
         
            InvokeRepeating("die", 4f, 0);
        }
    }

    void die()
    {
        Destroy(gameObject);
        Debug.Log("destroy");
    }

}
