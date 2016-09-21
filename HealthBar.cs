using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	float healthBarValue;

	float healthBarUpperlimit;
	bool gameLose;


	HealthBar(float healthBarValue)
	{
		this.healthBarValue = healthBarValue;
	}

	// Use this for initialization
	void Start (float healthBarValue) {
		if (HealthbarCheck == true) {
			HealthBar (healthBarValue);
		}
	}
	
	// Update is called once per frame
	void Update (float attackPower) {
		healthBarValue = healthBarValue - attackPower;

		if (healthBarValue < 0.0f) {
			gameLose = true;
		}
	}

	bool HealthbarCheck()
	{
		if (healthBarValue > healthBarUpperlimit) {
			return false;
		}
	}



}
