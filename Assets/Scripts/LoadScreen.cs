using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadScreen : MonoBehaviour {
	public Text loadText;

	// Use this for initialization
	void Start () {
		
		InvokeRepeating ("disapear", 0, 1.7f);
		InvokeRepeating ("appear", 0, 1.5f);
		SceneManager.LoadScene ("MainGame");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void disapear()
	{
		loadText.text = "";
	}

	void appear()
	{
		loadText.text = "Loading . . .";
	}

	void move()
	{
		ExecuteAfterTime (2f);
		loadText.gameObject.SetActive (true);
	}

	IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds(time);

		loadText.gameObject.SetActive (false);

	}

}
