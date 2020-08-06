using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDialogueMusic : MonoBehaviour
{
  void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("dialoguemusic");
        Destroy(A);
    }
}
