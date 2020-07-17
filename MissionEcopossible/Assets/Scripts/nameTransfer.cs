using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using TMPro;

/**
  * Manage user's name input
  */
public class nameTransfer : MonoBehaviour
{
    
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName() {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Hi " + theName + "!"; // The welcome sentence
    }

    // IEnumerator Type() {

    //   foreach(char letter in sentences[index])
    // }




}
