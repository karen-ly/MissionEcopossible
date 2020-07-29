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

    // Start is called before the first frame update
    void Start(){
        instructions = new string[] {"Help Dede and Cece collect trash with the submarine!", "Tap and hold down to extend the submarine claw", "Touch items with the claw to collect them", "Remember the name and category of each item", "Now, to the game!"};
        instructionsPopUpUI = GameObject.Find("InstructionsPanel");
        instructText = GameObject.Find("InstructText").GetComponent<Text>();
        continueText = GameObject.Find("ContinueText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update(){
        
    }
}
