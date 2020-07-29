using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // needed to use Text
using UnityEngine.SceneManagement;

public class FinishPopUpController : MonoBehaviour
{
    public GameObject finishPopUpUI;
    public Text continueText;
    public static bool isDisplayed = false;
    public Submarine subControlScript; // script for submarine controls
    public bool waitDone;

    // Start is called before the first frame update
    void Start(){
        finishPopUpUI = GameObject.Find("FinishPanel");
        continueText = GameObject.Find("Txt2").GetComponent<Text>();
        finishPopUpUI.SetActive(false); // hides entire pop up at start of game
        isDisplayed = false;
        waitDone = false;
    }

    // Update is called once per frame
    void Update(){
        // If popup is displayed and user taps, then go to levels map
        if(isDisplayed){
            foreach(Touch touch in Input.touches){
                if(touch.phase == TouchPhase.Began){
                    SceneManager.LoadScene("Levels");
                }
            }
        }
    }

    public void Display(){
        subControlScript.Pause();
        finishPopUpUI.SetActive(true);
        StartCoroutine(waiter());
    }

    IEnumerator waiter(){
        yield return new WaitForSeconds(3);

        continueText.text = "Tap to Continue";

        isDisplayed = true;
    }
}

