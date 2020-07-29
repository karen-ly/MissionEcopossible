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


    public void DragApple() {

        apple.transform.position = Input.mousePosition;

    }

    // public void DragApple() {

    //     apple.transform.position = Input.mousePosition;

    // }

    // public void DragApple() {

    //     apple.transform.position = Input.mousePosition;

    // }
    
    public void DropApple() {

        float Distance = Vector3.Distance(apple.transform.position, binCompost.transform.position);
        if (Distance < 50) {
            apple.transform.position = binCompost.transform.position;
        }
        else {
            // If sorting is wrong, do something FIXME
            apple.transform.position = appleInitialPos;
        }
    
    }
}
