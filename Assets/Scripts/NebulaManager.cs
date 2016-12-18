using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NebulaManager : ButtonManager
{
	public static bool flag = false;
	public UnityEngine.UI.Button buttonToEnable;

	public void Update(){
		this.ups = 0;
		this.upc = 0.5;
		this.cost = 50;

		if (flag) {
			buttonToEnable.interactable = true;
		} else {
			buttonToEnable.interactable = false;
		}
	}

	public void UpdateFlag(){
		flag = true;
	}
}

