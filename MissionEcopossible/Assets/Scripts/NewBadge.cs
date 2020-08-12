using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBadge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   		GameObject trigger = GameObject.Find("finalL5Panel");
   		GameObject badge1 = GameObject.Find("badge1");
   		// user has finished level 5, so set chapter 1 badge to visible
   		if (trigger.active) {
   			badge1.SetActive(true);
   		}
    }
}
