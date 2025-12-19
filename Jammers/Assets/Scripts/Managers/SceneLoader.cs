using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
	public int currentScene;

	private AsyncOperation LoadScene(int sceneIndex)
	{
		Debug.Log($"SceneLoader => Loading scene {sceneIndex}");
		currentScene = sceneIndex;
		return SceneManager.LoadSceneAsync(sceneIndex);
	}

	public IEnumerator LoadSceneCoRoutine(int sceneIndex)
	{
		AsyncOperation asyncOp = LoadScene(sceneIndex);
		yield return asyncOp;
	}
}
