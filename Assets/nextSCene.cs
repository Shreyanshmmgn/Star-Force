using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextSCene : MonoBehaviour
{
      public void skip()
    {
        SceneManager.LoadScene("HelloAR");
    }
}
