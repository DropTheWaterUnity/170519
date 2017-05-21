using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toNextPage : MonoBehaviour {

    public static int previousScene = 0;
	
	// go to next scene (except start->ready and setting scene)
	public void GotoNext() {
		previousScene = SceneManager.GetActiveScene().buildIndex;
		int nextScene = previousScene + 1;
		
		if(nextScene<14){
			SceneManager.LoadScene(nextScene);
		}

		Debug.Log("previous :"+previousScene+" && nextScene : "+nextScene);
	}

	// go to previous scene
	public void GoBack() {
		Debug.Log(previousScene);
		SceneManager.LoadScene(previousScene);
	}
	
	// go to specific scene
	public void GotoScene(int i) {
		previousScene = SceneManager.GetActiveScene().buildIndex;
		Debug.Log(previousScene);
		SceneManager.LoadScene(i);
	}
}
