using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // needed to use Text
using UnityEngine.SceneManagement;

public class trashItemPopUpController : MonoBehaviour
{
    public Text itemName;
    public Text itemCategory;
    public string[] itemNames;
    public string[] itemCategories;
    public GameObject[] trashItemImages;
    public GameObject itemPopUpUI;
    public static bool isDisplayed;
    public int displayedItemIndex;

    // Start is called before the first frame update
    void Start()
    {
        itemName = GameObject.Find("ItemName").GetComponent<Text>();
        itemCategory = GameObject.Find("ItemCategory").GetComponent<Text>();

        // Creating two string arrays hoding the text to be displayed for each item based on the Scene
        string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "SubmarineGameL2"){
            itemNames = new string[] {"Apple Core", "Plastic Bottle", "Newspaper", "Pizza Box", "Fish Bone", "Styrofoam", "Cardboard", "Leaf", "Battery", "Glass"};
            itemCategories = new string[] {"Compost", "Recycling", "Recycling", "Landfill", "Compost", "Landfill", "Recycling", "Compost", "Harmful", "Landfill"};
        }

        // Creating an array of all the trashItemImages
        trashItemImages = new GameObject[] {GameObject.Find("trashItem1Image"),GameObject.Find("trashItem2Image"),GameObject.Find("trashItem3Image"),GameObject.Find("trashItem4Image"),GameObject.Find("trashItem5Image"),GameObject.Find("trashItem6Image"),GameObject.Find("trashItem7Image"),GameObject.Find("trashItem8Image"),GameObject.Find("trashItem9Image"),GameObject.Find("trashItem10Image")};
    
        for(int i=0; i<trashItemImages.Length; i++){
            trashItemImages[i].SetActive(false);
        }

        itemPopUpUI = GameObject.Find("Panel");
        itemPopUpUI.SetActive(false); // hides entire pop up at start of game
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

        // Change display text color based on category
        if(itemCategories[itemIndex]=="Recycling"){
            itemName.color = Color.blue;
            itemCategory.color = Color.blue;
        }
        else if(itemCategories[itemIndex]=="Compost"){
            itemName.color = new Color32(16, 140, 36, 255);
            itemCategory.color = new Color32(16, 140, 36, 255);
        }
        else if(itemCategories[itemIndex]=="Landfill"){
            itemName.color = Color.gray;
            itemCategory.color = Color.gray;
        }
        else{
            itemName.color = Color.red;
            itemCategory.color = Color.red;
        }

        itemName.text = itemNames[itemIndex];
        itemCategory.text = itemCategories[itemIndex];
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
