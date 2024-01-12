using UnityEngine;

public class Game : MonoBehaviour
{
	public GameObject _objectToInstantiate;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Debug.Log("111");
			Rat rat = FindObjectOfType<Rat>();
			if (rat != null)
			{
				Destroy(rat.gameObject);
			}
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Instantiate(_objectToInstantiate);
		}
	}
}
