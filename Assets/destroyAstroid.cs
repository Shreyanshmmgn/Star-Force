using UnityEngine;

public class destroyAstroid : MonoBehaviour
{
    public int health = 1;
    public GameObject efffect;
    public GameObject efffect2;

    public void Takedamage()
    {
        efffect.SetActive(true);
        health -= 1;
        efffect2.SetActive(true);
        print(health);
        if (health == 0)
        {
            InvokeRepeating("die", .2f, 0);
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

    }

    void Update()
    {
    }
}
