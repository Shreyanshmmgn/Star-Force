using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour
{

    //  public float speed;
    // public bool moveright;
    //   void OnTriggerEnter(Collider turn)
    // {   print("########################");
    //     if(turn.gameObject.tag == "turn")
    //     {print("-------------------------------  Move right");
    //         moveright = false;
    //     }


    //     else if(turn.gameObject.tag == "turn1")
    //     {   print("99999999999999999999999999999   move false");

    //             moveright = true;


    //     }
    // }



    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void FixedUpdate()
    // {
    //     if(moveright)
    //     {
    //         transform.Translate(0,1*Time.deltaTime*speed,0);
    //         // transform.localScale = new Vector3(1.5f,1.5f,1.5f);
    //     }
    //     else
    //     {
    //         transform.Translate(0 , -1*Time.deltaTime*speed,0);
    //         // transform.localScale = new Vector3(1.5f,-1.5f,1.5f);
    //     }
    // }


    Transform tr_Player;
    float f_RotSpeed = 3.0f, f_MoveSpeed = 3.0f;

    // Use this for initialization
    void Start()
    {

        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        /* Look at Player*/
        transform.rotation = Quaternion.Slerp(transform.rotation
                                              , Quaternion.LookRotation(tr_Player.position - transform.position)
                                              , f_RotSpeed * Time.deltaTime);

        /* Move at Player*/
        transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
    }
}
