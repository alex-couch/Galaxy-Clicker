using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;
using UnityEngine.SceneManagement;

[System.Serializable]
public class NewGameButton : MonoBehaviour {
	public void LoadScene(){
		SceneManager.LoadScene ("Galaxy Clicker");
	}
}
