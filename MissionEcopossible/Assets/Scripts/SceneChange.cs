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
     	

        if (level.Equals("Levels"))
        {
            LoadingData.sceneToLoad = level;
            SceneManager.LoadScene("Loading");
        }
        else {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(level);
        }

       
 	}
}





