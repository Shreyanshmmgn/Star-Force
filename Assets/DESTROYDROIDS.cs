using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYDROIDS : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Astroid")
        {
            Destroy(col.gameObject);
        }
    }
}
