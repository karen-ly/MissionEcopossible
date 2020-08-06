using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// [System.Serializable]
public class Dialogue : MonoBehaviour
{
    // public string name;  // NPC name

    // [TextArea(2,6)] //line scale
    // public string[] sentences;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;  
    private int index = 0;
    public float typingSpeed;
    public GameObject DedeNormal;
    public GameObject CeceNormal;
    public GameObject BebeNormal;
    public GameObject DedeScared;
    public GameObject DedeHappy;
    public GameObject DedeAngry;
    public GameObject DedeSad;
    public GameObject CeceScared;
    public GameObject BebeScared;

    // newly added code
    public string scenename;
    public GameObject finishButton;
    public GameObject finalPanel;
    public GameObject continueButton;
    public AudioSource source;
    public GameObject trashscene;


    void Start() {
        DedeNormal = GameObject.Find("DedeFixed");
        CeceNormal = GameObject.Find("CeceFixed");
        BebeNormal = GameObject.Find("BebeFixed");
        DedeScared = GameObject.Find("DedeScared");
        DedeHappy = GameObject.Find("DedeHappy");
        DedeAngry = GameObject.Find("DedeAngry");
        DedeSad = GameObject.Find("DedeSad");
        CeceScared = GameObject.Find("CeceScared");
        BebeScared = GameObject.Find("BebeScared");

        DisplayCharacter(sentences[index].Substring(0,5));
        StartCoroutine(Type());
    }

    void Update() {
        
        if(textDisplay.text == sentences[index].Substring(1)) {
            continueButton.SetActive(true);
        }
        // check if current text is trash scene
        // level 1 - Dede's house
        if(textDisplay.text == "Dede: We are here! Welcome to my home…") {
            trashscene.SetActive(true);        
        }
        // level 3 - Cece's house
        if(textDisplay.text == "Cece: Let’s go!") {
            trashscene.SetActive(true);
        }
        // level 5 - pile of trash to be sorted
        if(textDisplay.text == "Dede: Now that we collected all the trash, we should sort it.") {
            trashscene.SetActive(true);
        }
        

    }

    public void DisplayCharacter(string name){
        // make sure no other character is displayed
        DedeNormal.SetActive(false);
        CeceNormal.SetActive(false);
        BebeNormal.SetActive(false);
        DedeScared.SetActive(false);
        DedeHappy.SetActive(false);
        DedeAngry.SetActive(false);
        DedeSad.SetActive(false);
        CeceScared.SetActive(false);
        BebeScared.SetActive(false);

        // show correct character
        if(name.Equals("NDede")){
            DedeNormal.SetActive(true);
        }
        else if(name.Equals("SDede")){
            DedeScared.SetActive(true);
        }
        else if(name.Equals("HDede")){
            DedeHappy.SetActive(true);
        }
        else if(name.Equals("ADede")){
            DedeAngry.SetActive(true);
        }
        else if(name.Equals("DDede")){
            DedeSad.SetActive(true);
        }
        else if(name.Equals("NCece")){
            CeceNormal.SetActive(true);
        }
        else if(name.Equals("SCece")){
            CeceScared.SetActive(true);
        }
        else if(name.Equals("NBebe")){
            BebeNormal.SetActive(true);
        }
        else if(name.Equals("SBebe")){
            BebeScared.SetActive(true);
        }
    }



    IEnumerator Type() {
        // ensuring the first letter that contains the character expression isn't typed
        foreach(char letter in sentences[index].Substring(1).ToCharArray()) {
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
            DisplayCharacter(sentences[index].Substring(0,5));
            StartCoroutine(Type());            
        } 

        // reached end of dialogue for scene
        else if (index == sentences.Length - 1) {
            // special case: no submarine game in level 1
            if(scenename == "DialogueL1Ctn") {
                textDisplay.text = "Congrats, you've completed this level!";
                finishButton.SetActive(true);
            }
            // levels 2 - 5 -> pop up panel to submarine game (but sorting game for level 5)
            else
            {
                DisplayCharacter("none");
                continueButton.SetActive(false);
                finalPanel.SetActive(true);
                finishButton.SetActive(true);
            }
        }
    }

}
