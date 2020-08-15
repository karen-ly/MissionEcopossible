using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private string level;
    public void ButtonMoveScene(string level)
    {
		StartCoroutine(DelaySceneLoad(level));
    }
    
    IEnumerator DelaySceneLoad(string level)
 	{
        yield return new WaitForSeconds(0.5f);

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        //   if ((sceneName == "Levels" || sceneName == "Menu") && (!level.Equals("Settings")))
        //   {
        //       if (!(level.Equals("Resources") || level.Equals("Credits"))) {
        //           LoadingData.sceneToLoad = level;
        //           SceneManager.LoadSceneAsync("Loading");
        //       }
        //       else {
        //           SceneManager.LoadScene(level);
        //        }
        //  }
        //    else if ((level.Equals("Levels") || level.Equals("Menu")) && (!sceneName.Equals("Settings"))) {
        //       
        //       LoadingData.sceneToLoad = level;
        //       SceneManager.LoadSceneAsync("Loading");
        //    }
        //   else
        //   {
        //       SceneManager.LoadScene(level);
        //   }




        if (sceneName == "Menu")
        {
            if (level == "Levels")
            {
                LoadingData.sceneToLoad = level;
                SceneManager.LoadSceneAsync("Loading");
            }
            else
            {
                SceneManager.LoadScene(level);
            }
        }
        else if (sceneName == "Levels")
        {
            LoadingData.sceneToLoad = level;
            SceneManager.LoadSceneAsync("Loading");
        }
        else if (level == "Levels" || level == "Menu")
        {
            if (sceneName != "Resources" && sceneName != "Credits" && sceneName != "Settings")
            {
                LoadingData.sceneToLoad = level;
                SceneManager.LoadSceneAsync("Loading");
            }
            else {
                SceneManager.LoadScene(level);
            }
        }
        else {
            SceneManager.LoadScene(level);
        }
 	}
}





