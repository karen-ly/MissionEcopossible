using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashItemPopUpController : MonoBehaviour
{
    public static bool isDisplayed;

    public GameObject itemPopUpUI;

    // Start is called before the first frame update
    void Start()
    {
        itemPopUpUI = GameObject.Find("Panel");
        itemPopUpUI.SetActive(false);
        isDisplayed = false;
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

    public void Display(){
        itemPopUpUI.SetActive(true);
        Time.timeScale = 0f; // Freezes game
        isDisplayed = true;
    }

    void Close(){
        itemPopUpUI.SetActive(false);
        Time.timeScale = 1f; // Unfreezes game
        isDisplayed = false;
    }
}
