using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GalaxyManager : ButtonManager
{
	public static bool flag = false;
	public UnityEngine.UI.Button buttonToEnable;

	public GalaxyManager(){
		ups = 1;
		upc = 0;
		cost = 300;
	}

	public void UpdateFlag(){
		flag = true;
	}

	void Update(){
		if (flag) {
			buttonToEnable.interactable = true;
		} else {
			buttonToEnable.interactable = false;
		}
	}
}

