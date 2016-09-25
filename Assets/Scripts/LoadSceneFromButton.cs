using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadSceneFromButton : MonoBehaviour {

	public string sceneName;

	// Use this for initialization
	void Start () {
		Button b = gameObject.GetComponent<Button> ();
		b.onClick.AddListener(delegate() { LoadScene(sceneName); });
	}

	private void LoadScene(string level)
	{
		SceneManager.LoadScene (level);
		//Application.LoadLevel (level);
	}

}
