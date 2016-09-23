using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour {

	public int currentMonies;

    public Text moniesText;

    //Initial amount of money on startup of the game.
    void Start () {
        currentMonies = 1000;
        moniesText.text = "Money: " + currentMonies;
        UpdatePanel();
        Debug.Log(currentMonies);
    }

	//Checks whether the tower/upgrade can be bought.
	bool CheckCost(int cost){
		if (cost <= -1) {
			return false;
		}

		if (cost > currentMonies) {
			return false;
		} else {
			return true;	
		}
	}

	//Checks whether the profit is legitimate .
	bool CheckEarned(int earned){
		if (earned <= -1) {
			return false;
		} else {
			return true;	
		}
	}

    //Updates the ingame panels text to match money value
    void UpdatePanel() {
        moniesText.text = "Money: " + currentMonies;
    }

    //Calls Checkcost and subtracts the cost if funds are available
    public bool BuyTower(int cost) {
        if (!CheckCost(cost)) {
            return false;
        }
        else {
            currentMonies -= cost;
            UpdatePanel();
            return true;
        }
    }

	//Calls CheckEarned and adds earned to currentMonies if its valid
	public bool AddProfit(int earned){
		if (CheckEarned(earned)) {
            currentMonies += earned;
            return true;
        }
        return false;
	}
}