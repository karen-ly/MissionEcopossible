using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOceanMusic : MonoBehaviour
{
  void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("oceanmusic");
        Destroy(A);
    }
}
