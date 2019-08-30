using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intantiateMainSHips : MonoBehaviour
{
    public Rigidbody ships;
    int a;
    int r;
    // public Rigidbody ships1;
    // public Rigidbody ships2;
    [SerializeField] Transform[] pos;
    // [SerializeField] Transform[] pos1;
    // [SerializeField] Transform[] pos2;

    void Start()
    {
        
        //    StartCoroutine(DoCheck());
         InvokeRepeating("inst", 3f, 1f); 

        // InvokeRepeating("inst2", 1f, 25f);
        // InvokeRepeating("inst3", 2f, 15f);

    }
    public void inst()
    {
        int r = Random.Range(0, pos.Length);
        print("R-----"+r);
            if (a != r) {
        Vector3 position = pos[r].position;
        Rigidbody clone = Instantiate(ships, position, transform.rotation);
        a = r;
        print("A----"+a);
        }
        

        //-------------------------------------------------------------------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------------------------------------------------------------------



    }
    // void inst2()
    // {
    //     int r1 = Random.Range(0, pos.Length);
    //     Vector3 position1 = pos[r1].position;
    //     Rigidbody clone1 = Instantiate(ships1, position1, transform.rotation);
    // }
    // void inst3()
    // {
    //     int r2 = Random.Range(0, pos.Length);
    //     Vector3 position2 = pos[r2].position;
    //     Rigidbody clone2 = Instantiate(ships2, position2, transform.rotation);
    // }
}
