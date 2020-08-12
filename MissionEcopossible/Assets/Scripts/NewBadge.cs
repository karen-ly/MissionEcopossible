using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBadge : MonoBehaviour
{
	public GameObject badge1;
    // Start is called before the first frame update
    void Start()
    {
   		GameObject trigger = GameObject.Find("finalCanvas");
   		// user has finished level 5, so set chapter 1 badge to visible
   		if (trigger.active) {
   			badge1.SetActive(true);
   			trigger.SetActive(false);
   		}
    }
}
