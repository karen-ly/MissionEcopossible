using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public Text funFact;
    string[] texts = new string[] { "Text1", "Text2", "Text3", "Text4" };

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
