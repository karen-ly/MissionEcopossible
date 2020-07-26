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
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    private AudioSource source;

    void Start() {

        source = GetComponent<AudioSource>();
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

        } else {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }

}
