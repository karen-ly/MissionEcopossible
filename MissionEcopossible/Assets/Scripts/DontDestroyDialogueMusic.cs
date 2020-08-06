using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyDialogueMusic : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("dialoguemusic");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

}