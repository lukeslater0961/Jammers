using UnityEngine;

public class SaveManager : Singleton<SaveManager> 
{
	public void InitSave()
	{
		PlayerPrefs.DeleteAll();
		if (!PlayerPrefs.HasKey("InputType"))
			InitSettings();
		else
			LoadSettings();
	}

	public void InitSettings()
	{
		Debug.Log("SaveManager => Initializing Settings");
		PlayerPrefs.SetInt("Fullscreen", 1);
		LoadSettings();
	}

	private void LoadSettings()
	{
		//set default settings
		GameManager.instance.fullScreen = PlayerPrefs.GetInt("Fullscreen");
	}
	
	public void ClearSave()
	{
		Debug.Log("SaveManager => Clearing save ...");
		PlayerPrefs.DeleteAll();
		InitSettings();
	}
}
