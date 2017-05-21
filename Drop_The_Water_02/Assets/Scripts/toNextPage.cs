using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toNextPage : MonoBehaviour {
	
	public int previousScene;

	// go to next scene (except start->ready and setting scene)
	public void GotoNext() {
		previousScene = SceneManager.GetActiveScene().buildIndex;
		int nextScene = previousScene + 1;
		
		if(nextScene<14){
			SceneManager.LoadScene(nextScene);
		}

		Debug.Log("previous :"+previousScene+" && nextScene : "+nextScene);
	}

	// go to ready scene (because of setting page)
	public void GotoReady() {
		previousScene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(2);

		Debug.Log("previous :"+previousScene);
	}

	// go to setting scene
	public void GotoSettings() {
		previousScene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(1);
	}

	// go to previous scene
	public void GoBack() {
		SceneManager.LoadScene(previousScene);
	}
}
