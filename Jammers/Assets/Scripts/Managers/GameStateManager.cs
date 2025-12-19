using UnityEngine;
using System.Collections;

public class GameStateManager : Singleton<GameStateManager> 
{
	public static BootState bootState = new BootState();
	public static MainMenuState mainMenuState = new MainMenuState();
	public static GameState gameState	= new GameState();

	private GameBaseState currentState = null;

	public void SwitchState(GameBaseState state)
	{
		if (currentState != null)
			StartCoroutine(currentState.QuitState(this));
		currentState = state;
		StartCoroutine(currentState.EnterState(this));
	}

	public void RunCoroutine(IEnumerator routine)
    {
        StartCoroutine(routine);
    }
}
