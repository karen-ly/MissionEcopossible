using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // needed to use Text
using UnityEngine.SceneManagement;

public class FinishPopUpController : MonoBehaviour
{
    public GameObject finishPopUpUI;
    public static bool isDisplayed = false;
    public Submarine subControlScript; // script for submarine controls
    public bool waitDone;
    public SubGameSounds subGameSoundsScript;

    // Start is called before the first frame update
    void Start(){
        finishPopUpUI = GameObject.Find("FinishPanel");
        finishPopUpUI.SetActive(false); // hides entire pop up at start of game
        isDisplayed = false;
        waitDone = false;
    }

    // Update is called once per frame
    void Update(){

    }

    public void Display(){
        subControlScript.Pause();
        finishPopUpUI.SetActive(true);
        subGameSoundsScript.PlayLevelDone();
    }
}

