using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashItemPopUpController : MonoBehaviour
{
    public static bool isDisplayed;
    public int displayedItemIndex;
    public GameObject itemPopUpUI;
    public GameObject trashItem1Image;
    public GameObject trashItem2Image;
    public GameObject trashItem3Image;
    public GameObject trashItem4Image;
    public GameObject trashItem5Image;
    public GameObject trashItem6Image;
    public GameObject trashItem7Image;
    public GameObject trashItem8Image;
    public GameObject trashItem9Image;
    public GameObject trashItem10Image;
    public GameObject[] trashItemImages;

    // Start is called before the first frame update
    void Start()
    {
        trashItem1Image = GameObject.Find("trashItem1Image");
        trashItem2Image = GameObject.Find("trashItem2Image");
        trashItem3Image = GameObject.Find("trashItem3Image");
        trashItem4Image = GameObject.Find("trashItem4Image");
        trashItem5Image = GameObject.Find("trashItem5Image");
        trashItem6Image = GameObject.Find("trashItem6Image");
        trashItem7Image = GameObject.Find("trashItem7Image");
        trashItem8Image = GameObject.Find("trashItem8Image");
        trashItem9Image = GameObject.Find("trashItem9Image");
        trashItem10Image = GameObject.Find("trashItem10Image");

        trashItemImages = new GameObject[] {trashItem1Image,trashItem2Image,trashItem3Image,trashItem4Image,trashItem5Image,trashItem6Image,trashItem7Image,trashItem8Image,trashItem9Image,trashItem10Image};
    
        for(int i=0; i<trashItemImages.Length; i++){
            trashItemImages[i].SetActive(false);
        }

        itemPopUpUI = GameObject.Find("Panel");
        itemPopUpUI.SetActive(false);
        isDisplayed = false;
        displayedItemIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // If popup is displayed and user taps, then close
        if(isDisplayed){
            foreach(Touch touch in Input.touches){
                if(touch.phase == TouchPhase.Began){
                    Close();
                }
            }
        }
    }

    public void Display(int itemIndex){
        itemPopUpUI.SetActive(true);
        trashItemImages[itemIndex].SetActive(true);
        displayedItemIndex = itemIndex;
        Time.timeScale = 0f; // Freezes game
        isDisplayed = true;
    }

    void Close(){
        itemPopUpUI.SetActive(false);
        trashItemImages[displayedItemIndex].SetActive(false);
        Time.timeScale = 1f; // Unfreezes game
        isDisplayed = false;
    }
}
