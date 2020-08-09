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

        if (level.Equals("Levels") || level.Equals("Menu"))
        {
            LoadingData.sceneToLoad = level;
            SceneManager.LoadSceneAsync("Loading");
        }
        else {
            
            SceneManager.LoadScene(level);
        }

       
 	}
}





