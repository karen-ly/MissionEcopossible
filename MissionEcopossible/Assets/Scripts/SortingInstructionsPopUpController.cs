using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // needed to use Text
using UnityEngine;

public class SortingInstructionsPopUpController : MonoBehaviour
{
    public string[] instructions;
    public GameObject instructionsPopUpUI;
    public Text instructText;
    public Text continueText;
    public int nextDisplayedText = 0;
    public bool isReadyForNext = false;

    // Start is called before the first frame update
    void Start(){
        instructions = new string[] {"Help Dede and Cece sort the trash!", "Drag and release each item onto the correct bin", "Have Fun!"};
        instructionsPopUpUI = GameObject.Find("InstructionsPanel");
        instructText = GameObject.Find("InstructText").GetComponent<Text>();
        continueText = GameObject.Find("ContinueText").GetComponent<Text>();

        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update(){
        if(isReadyForNext){
            foreach(Touch touch in Input.touches){
                if(touch.phase == TouchPhase.Began){
                    isReadyForNext = false;
                    if(nextDisplayedText<instructions.Length){
                        StartCoroutine(waiter());
                    }
                    else{
                        instructionsPopUpUI.SetActive(false); // hides the pop up
                        Time.timeScale = 1f;
                    }
                }
            }
        }
    }

    IEnumerator waiter(){
        instructText.text = instructions[nextDisplayedText];
        continueText.text = "";

        yield return new WaitForSecondsRealtime(1f);

        continueText.text = "Tap to Continue";

        isReadyForNext = true;
        nextDisplayedText++;
    }
}
