using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Assertions;


public class HealthBar : MonoBehaviour
{

    public float healthBarValue;

    public float healthBarUpperlimit;
    bool gameLose;

    public Texture2D emptyHealthBar;
    public Texture2D fullHealthBar;

    // Use this for initialization
    void Start()
    {

    }

    void SubtractHealth(float attackPower)
    {
        if (attackPower > 0)
        {
            healthBarValue = healthBarValue - attackPower;
        }

        if (healthBarValue < 0.0f)
        {
            gameLose = true;
        }
    }

    void AddHealth(float amount)
    {
        
        if (HealthbarCheck(amount))
        {
            healthBarValue = healthBarValue + amount;
        }
        else
        {
            healthBarValue = healthBarUpperlimit;
        }
    }

    bool HealthbarCheck(float amount)
    {
        if (healthBarValue+amount > healthBarUpperlimit)
        {

            return false;
        }
        return true;
    }

    //Draws the healthbar on the top-middle of the screen
    void OnGUI()
    {
        if(healthBarUpperlimit > 0 && healthBarValue > 0)
        {
            float sX = Screen.width;
            float sY = Screen.height;
            if(emptyHealthBar != null)
                GUI.DrawTexture(new Rect(sX*0.3f, 0, sX*0.4f, sY*0.05f), emptyHealthBar);
            else
                Debug.Log("Missing empty health bar texture");
            if (fullHealthBar != null)
                GUI.DrawTexture(new Rect(sX*0.313f, sY*0.0125f, sX*0.00375f*(100-(healthBarUpperlimit-healthBarValue)), sY*0.023f), fullHealthBar);
            else
                Debug.Log("Missing full health bar texture");
        }
    }

}