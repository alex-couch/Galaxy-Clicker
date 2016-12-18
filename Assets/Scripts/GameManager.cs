using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System;

public class GameManager : MonoBehaviour {

	public UnityEngine.UI.Text starCount;
	public UnityEngine.UI.Text upss, upcs;
	public double currentCost, currentRate, clickAmount;
	public int nextTime = 0;
	public int interval = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentCost = Math.Round(currentCost * 100D) / 100D;
		currentRate = Math.Round(currentRate * 100D) / 100D;
		clickAmount = Math.Round(clickAmount * 100D) / 100D;
		starCount.text = "Star Count: " + currentCost;
		if (Time.time >= nextTime) {
			currentCost += currentRate;

			nextTime += interval;
		}
		upss.text = "Star Per Second: " + currentRate;
		upcs.text = "Star Per Click: " + clickAmount;
	}

	public void updateClick(){
		currentCost += clickAmount;
	}
}
