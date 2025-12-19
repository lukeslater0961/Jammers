using UnityEngine;
using System;
using System.Collections;

public class GameState : GameBaseState
{
	public override IEnumerator EnterState(GameStateManager manager)
	{
		Debug.Log("Entered Game state");
		yield break;
	}

	public override IEnumerator QuitState(GameStateManager manager)
	{
		Debug.Log("Quitting Game state");
		yield break;
	}
}
