using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

	public UnityEngine.UI.Text text;
	public string name;
	public double cost, upc, ups;
	public GameManager game;
	private bool clicked = false;

	public Color standard;
	public Color affordable;

	void Update(){
		cost = Math.Round(cost * 100D) / 100D;
		ups = Math.Round(ups * 100D) / 100D;
		upc = Math.Round(upc * 100D) / 100D;
		text.text = "Buy " + name + "\n" + "Cost: " + cost + "\nUPC: +" + upc + "\nUPS: " + ups;

		if (game.currentCost >= cost) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standard;
		}
	}

	// Use this for initialization
	public void clickUpdate ()
	{
		if (game.currentCost >= cost) {
			game.currentCost -= cost;
			game.currentRate += ups;
			game.clickAmount += upc;
			clicked = true;
			if (clicked) {
				cost *= 1.5;
				upc *= 1.5;
				ups *= 1.75;
			}
		}
	}
}

