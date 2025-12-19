using UnityEngine;
using System.Collections;

public class BootLoader : MonoBehaviour
{
    [SerializeField]    GameObject[] systems;

    IEnumerator Start()
    {
        yield return StartCoroutine(InstantiateSystems());
		GameStateManager.instance.SwitchState(GameStateManager.bootState);
    }

	private IEnumerator InstantiateSystems()
	{
		foreach (GameObject sys in systems)
			yield return Instantiate(sys);
	}
}
