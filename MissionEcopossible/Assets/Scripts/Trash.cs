using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trash : MonoBehaviour
{
    public trashItemPopUpController popUp;
    public SubGameSounds subGameSoundsScript;
    public FinishPopUpController finishPopUp;
    public GameObject claw;
    public GameObject[] trashItems;
    public Vector2[] trashPositions;
    public int trashCount;
    public bool finishPopUpCalled = false;

    // Start is called before the first frame update
    void Start()
    {
        claw = GameObject.Find("claw");

        // Array to hold all the trash items
        trashItems = new GameObject[] {GameObject.Find("trashItem1"),GameObject.Find("trashItem2"),GameObject.Find("trashItem3"),GameObject.Find("trashItem4"),GameObject.Find("trashItem5"),GameObject.Find("trashItem6"),GameObject.Find("trashItem7"),GameObject.Find("trashItem8"),GameObject.Find("trashItem9"),GameObject.Find("trashItem10")};

        // Settings based on level
        string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "SubmarineGameL2"){
            // Array to hold start position of each trash item
            trashPositions = new Vector2[] {new Vector2(0, -1), new Vector2(1, -3), new Vector2(-1.5f, 0.5f), new Vector2(0, -2.5f), new Vector2(1, 1), new Vector2(-1.5f, 0.5f), new Vector2(0, 0), new Vector2(1.8f, 0), new Vector2(-0.5f, -2.5f), new Vector2(-3, -1)};
        }
        
        trashCount = 0;

        // Move first trash item to its starting position
        trashItems[trashCount].transform.position = trashPositions[trashCount];
    }

    // Update is called once per frame
    void Update()
    {
        ClawPickup();
        //finishPopUpCalled is to ensure the below if is only called once
        if(trashCount == trashItems.Length && !finishPopUpCalled && popUp.LastPopUpClosed()){
            finishPopUp.Display();
            finishPopUpCalled = true;
        }
    }

    // Picks up current trash item if collides with claw; shows trash info
    void ClawPickup(){
        if(trashCount < trashItems.Length){
            // Chack if bounds of the claw and trashItam colliders overlap
            if(trashItems[trashCount].GetComponent<ClawCollide>().IsPickedUp()){
                // TODO: add sound effect
                subGameSoundsScript.PlayPickUp();

                // Move trashItem out of frame
                trashItems[trashCount].transform.position = new Vector2(0, -6);

                popUp.Display(trashCount);

                // Add next trashItem to screen
                trashCount++;
                if(trashCount < trashItems.Length){
                    trashItems[trashCount].transform.position = trashPositions[trashCount];
                }
            }
        }
    }
}
