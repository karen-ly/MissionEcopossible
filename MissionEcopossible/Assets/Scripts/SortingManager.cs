using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingManager : MonoBehaviour
{

    
    public GameObject apple, binHarmful, binRecycle, binLandfill, binCompost; // Garbage and bin items


    Vector2 appleInitialPos, binHarmfulInitialPos, binRecycleInitialPos, binLandfillInitialPos, binCompostInitialPos;
    
    // Start is called before the first frame update
    void Start()
    {
        appleInitialPos = apple.transform.position;
        binHarmfulInitialPos = binHarmful.transform.position;
        binRecycleInitialPos = binRecycle.transform.position;
        binLandfillInitialPos = binLandfill.transform.position;
        binCompostInitialPos = binLandfill.transform.position;
        
    }


    public
    // Update is called once per frame
    void Update()
    {
        
    }
}
