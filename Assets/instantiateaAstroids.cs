using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateaAstroids : MonoBehaviour
{
    public Rigidbody astroids;
    [SerializeField] Transform[] pos;

    void Start()
    {
        //    StartCoroutine(DoCheck());
        InvokeRepeating("inst", 2f, 3.5f);
    }
    public void inst()
    {
        Vector3 speed = new Vector3(1, 0, 0);
        int r = Random.Range(0, pos.Length);
        Vector3 position = pos[r].position;
        Rigidbody clone = Instantiate(astroids, position, transform.rotation);
        clone.velocity = new Vector3(0,0,10);
    }
}
