using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UiManager : MonoBehaviour {

	bool notgameover;
	public Button [] buttons;
	bool pause=false;
	private int pointerID;
	float volume;
	float sound;
	bool saved=false;
	public Text Savedtext;
	public Slider[] sliders;





	// Use this for initialization



	public void StartGame()
	{
		SceneManager.LoadScene ("Loading");
	}

	public void Credits()
	{
		SceneManager.LoadScene ("Credits");
	}



	public void goOptions(){
		SceneManager.LoadScene ("Options");
	}

	public bool getPaused()
	{
		return pause;
	}




	public void adjustVolume(Slider slider)
	{
		volume = slider.value;
	//	Debug.Log (slider.value);
	}

	public void adjustSound(Slider slider)
	{
		sound = slider.value;
	//	Debug.Log (slider.value);
	}

	public void saveOptions()
	{
		PlayerPrefs.SetFloat ("Volume", volume);
		PlayerPrefs.SetFloat ("Sound", sound);
	//	Debug.Log (PlayerPrefs.GetFloat ("Volume"));

		Savedtext.text = "SAVED";
		saved = true;
	}

	public void backToMain(){
		SceneManager.LoadScene ("MenuScene");
	}

	public void ToTheTree(){
		SceneManager.LoadScene ("TreeScene");
	}

}
