using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	public int fullScreen;

	public void Init()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;	
		Screen.fullScreen = (fullScreen == 1) ? true : false;
	}
}
