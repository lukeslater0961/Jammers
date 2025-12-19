using UnityEngine;
using System;
using System.Collections;

public class MainMenuState : GameBaseState
{
	public override IEnumerator EnterState(GameStateManager manager)
	{
		Debug.Log("Entered Main Menu state");
		yield break;
	}

	public override IEnumerator QuitState(GameStateManager manager)
	{
		Debug.Log("Quitting Main menu state");
		yield break;
	}
}
