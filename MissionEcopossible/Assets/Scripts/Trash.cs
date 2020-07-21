using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public GameObject claw;
    public GameObject trashItem1;
    public GameObject trashItem2;
    public GameObject trashItem3;
    public GameObject[] trashItems;
    public Vector2[] trashPositions;
    public int trashCount;

    // Start is called before the first frame update
    void Start()
    {
        claw = GameObject.Find("claw");
        trashItem1 = GameObject.Find("trashItem1");
        trashItem2 = GameObject.Find("trashItem2");
        trashItem3 = GameObject.Find("trashItem3");

        // Array to hold all the trash items
        trashItems = new GameObject[] {trashItem1,trashItem2,trashItem3};

        // Array to hold start position of each trash item
        trashPositions = new Vector2[] {new Vector2(0, -1), new Vector2(1, -3), new Vector2(-1.5f, 0.5f)};

        trashCount = 0;

        // Move first trash item to its starting position
        trashItems[trashCount].transform.position = trashPositions[trashCount];
    }

    // Update is called once per frame
    void Update()
    {
        ClawPickup();
    }

    // Picks up current trash item if collides with claw; shows trash info
    void ClawPickup(){
        if(trashCount < trashItems.Length){
            // Chack if bounds of the claw and trashItam colliders overlap
            if(claw.GetComponent<BoxCollider2D>().bounds.Intersects(trashItems[trashCount].GetComponent<CircleCollider2D>().bounds)){
                // TODO: add sound effect

                // Move trashItam out of frame
                trashItems[trashCount].transform.position = new Vector2(0, -6);
                trashCount++;

                // Add next trashItem to screen
                if(trashCount < trashItems.Length){
                    trashItems[trashCount].transform.position = trashPositions[trashCount];
                }
            }
        }
    }

    // TODO: popup method that freezes game and returns once user clicks x; call in ClawPickup after collision
    // TODO: text when you finish game
    // TODO: instructions for submarine game before it starts
}
