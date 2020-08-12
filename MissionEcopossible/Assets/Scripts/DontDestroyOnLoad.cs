using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public static GameObject trigger;
    // Start is called before the first frame update
    void Awake()
    {   
       // see if badge for chapter 1 gameoject from sorting game 5 is set active
        trigger = GameObject.Find("finalL5Panel");
        DontDestroyChildOnLoad(trigger);
    }
    public static void DontDestroyChildOnLoad( GameObject child )
    {
         Transform parentTransform = child.transform;
 
         // If this object doesn't have a parent then its the root transform.
         while ( parentTransform.parent != null )
         {
             // Keep going up the chain.
             parentTransform = parentTransform.parent;
         }
         GameObject.DontDestroyOnLoad(parentTransform.gameObject);
    }

}
