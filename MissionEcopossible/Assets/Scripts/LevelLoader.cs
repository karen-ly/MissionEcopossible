﻿using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public Text funFact;
  
  


    string[] texts = new string[] { "The “working life” of a plastic page is only 15 minutes, yet a single one can kill more than one wildlife. ", "According to National Geographic, there are already more than 5 million pieces of plastic floating in our oceans.", "According to researchers from CSIRO and Imperial College London, plastic ingestion will affect 99% of the world’s seabird population by 2050.", "Did you know that using plastic is illegal in some countries? Kenya, China, France, Italy, and others have implemented fines and even imprisonment for using plastic.", "Did you know that almost every piece of plastic made continues to exist today and probably hundreds of years more?", "90 % of people say they would recycle if it was more fun, so playing Mission Ecopossible is a great start!", "“The earth does not belong to us.We belong to the earth.” -Chief Seattle", "Remember to reduce, reuse and recycle!", "“Recycling is just common sense.Which is probably why most people don't do it.” (Quote from a comic strip from Maxine.com)", "Packaging materials make up the largest market for plastic, and the majority is never recycled.", "The biggest landfill in the world is the Great Pacific Garbage Patch, which is over twice of the size of Texas.", "The energy saved by recycling one aluminum can is enough for you to listen to a full album on iPod.", "Recycling helps to decrease greenhouse gases emission.", "Recycling one ton of plastic can save up to 1,000-2,000 gallons of gasoline.", "Recycling cardboard only takes 75% of the energy needed to make new cardboard.", "Recycling one ton of paper saves 17 trees.", "As much as 80% of the things we throw in the bin could be recycled.", "The biggest landfill in the US is the Puente Hills landfill in Los Angeles.", "It takes 500 years for styrofoam to decompose.", "Eliminating 600,000 pages of printing reports can save $16,000.", "By 2050, ocean plastic will outweigh all of the ocean’s fish.", "27,000 trees are cut down each day so we can have toilet paper." };

    void Update() {
     
        StartCoroutine(LoadYourAsyncScene(4));
    }

    IEnumerator LoadYourAsyncScene(int sceneIndex) {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(LoadingData.sceneToLoad);

        loadingScreen.SetActive(true);

        funFact.text = texts[Random.Range(0, texts.Length)];
        

        while (!asyncLoad.isDone) {
            float progress = Mathf.Clamp01(asyncLoad.progress / .9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;
        }
    }
}
