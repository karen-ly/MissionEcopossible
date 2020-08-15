using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // needed to use Text
using UnityEngine;

public class InstructionsPopUpController : MonoBehaviour
{
    public string[] instructions;
    public GameObject instructionsPopUpUI;
    public Text instructText;
    public Text continueText;
    public int nextDisplayedText = 0;
    public bool isReadyForNext = false;
    public Submarine subControlScript;

    // Start is called before the first frame update
    void Start(){
        subControlScript.PauseClaw();
        instructions = new string[] {"Help Dede and Cece collect trash with the submarine!", "Tap and hold down to extend the submarine claw", "Touch items with the claw to collect them", "Remember the name and category of each item", "Now, to the game!"};
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
                        instructionsPopUpUI.SetActive(false);
                        subControlScript.Continue(); // hides the pop up
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
