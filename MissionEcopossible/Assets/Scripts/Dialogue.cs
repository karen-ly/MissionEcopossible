using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// [System.Serializable]
public class Dialogue : MonoBehaviour
{
    // public string name;  // NPC name

    // [TextArea(2,6)] //line scale
    // public string[] sentences;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;  //Own class, object contains sentences and characters
    private int index;
    public float typingSpeed;

    // newly added code
    public string scenename;
    public GameObject finishButton;

    public GameObject continueButton;
    public AudioSource source;


    void Start() {

        StartCoroutine(Type());

    }

    void Update() {
        
        if(textDisplay.text == sentences[index]) {
            continueButton.SetActive(true);
        }
    }


    IEnumerator Type() {

        foreach(char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

    }

    public void NextSentence() {
        source.Play();
        continueButton.SetActive(false);

        if (index < sentences.Length - 1) {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            // Object: sentence string + face type
            
        } 

        // reached end of dialogue for scene
        else if (index == sentences.Length - 1) {
            // special case: no submarine game in level 1
            if(scenename == "DialogueL1Ctn") {
                textDisplay.text = "Congrats, you've completed this level!";
                finishButton.SetActive(true);
            }
            // special case: level 5 (end of chapter 1) -> show message about future levels
            continueButton.SetActive(false);
        }
    }

}
