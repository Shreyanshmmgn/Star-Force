using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpwanningStation_1 : MonoBehaviour
{
    public float health = 10f;
 
    public GameObject explosion2;
    public void Takedamage()
    {
        health -= 1f;
        enemyHealth1.enemyhealth_1 = health;

        // damage-=1f;
        //enemyHealth.health=damage;
        //damage=enemyHealth.health;
        //damage-=1f;

        if (enemyHealth1.enemyhealth_1 == 0)
        {
           
                explosion2.SetActive(true);
           
            InvokeRepeating("die",4f, 0);
        }
    }

    void die()
    {
        Destroy(gameObject);
        Debug.Log("destroy");
    }

}
