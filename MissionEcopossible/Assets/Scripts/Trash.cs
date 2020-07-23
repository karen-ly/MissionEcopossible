using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trash : MonoBehaviour
{
    public GameObject claw;
    public GameObject trashItem1;
    public GameObject trashItem2;
    public GameObject trashItem3;
    public GameObject trashItem4;
    public GameObject trashItem5;
    public GameObject trashItem6;
    public GameObject trashItem7;
    public GameObject trashItem8;
    public GameObject trashItem9;
    public GameObject trashItem10;
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
        trashItem4 = GameObject.Find("trashItem4");
        trashItem5 = GameObject.Find("trashItem5");
        trashItem6 = GameObject.Find("trashItem6");
        trashItem7 = GameObject.Find("trashItem7");
        trashItem8 = GameObject.Find("trashItem8");
        trashItem9 = GameObject.Find("trashItem9");
        trashItem10 = GameObject.Find("trashItem10");

        // Array to hold all the trash items
        trashItems = new GameObject[] {trashItem1,trashItem2,trashItem3,trashItem4,trashItem5,trashItem6,trashItem7,trashItem8,trashItem9,trashItem10};

        // Settings based on level
        string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "SubmarineGameL2"){
            // Array to hold start position of each trash item
            trashPositions = new Vector2[] {new Vector2(0, -1), new Vector2(1, -3), new Vector2(-1.5f, 0.5f), new Vector2(0, -2.5f), new Vector2(1, 1), new Vector2(-1.5f, 0.5f), new Vector2(0, 0), new Vector2(1.8f, -1), new Vector2(-0.5f, -2.5f), new Vector2(-1, -1)};
        }
        
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
            if(claw.GetComponent<BoxCollider2D>().bounds.Intersects(trashItems[trashCount].GetComponent<PolygonCollider2D>().bounds)){
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
