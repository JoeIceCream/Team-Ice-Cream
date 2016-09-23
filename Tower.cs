using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {
    //Attacking Stats
    float range = 1.0f;                 //Ranges of 1 or less are melee
    float attackSpeed = 1.2f;           //Seconds between attacks
    float cooldown = 0.0f;              //Time remaining until attack available
    public float damage = 5.0f;         //The damage dealt before modifiers
    public int aoe = 0;                 //Area of Effect an area in which damage is dealt 0 is single target
    public string dmgType = "Normal";   //The type of damage the tower deals
    //Defending Stats
    public float maxHealth = 10.0f;     //The Maximum Health of the tower
    public float health = 10.0f;        //The current Health of the tower
    public float armour = 2.0f;         //The armour amount of the tower to reduce damage taken
    public string armrType = "Steel";   //The type of armour the tower has
    //Movement Stats
    Transform turretTransform;
    public float moveSpeedBase = 5.0f;  //The base speed at which the tower moves
    public float moveSpeed = 5.0f;      //The current movespeed of the tower

    public int cost = 100;              //The cost to build the tower

    public GameObject projectile;       //projectiles for ranges towers

	// Use this for initialization
	void Start () {
        turretTransform = transform.GetChild(0);
	}
	
	// Update is called once per frame
	void Update () {
        //Find and attack enemies....



        cooldown -= Time.deltaTime;
        if(cooldown <= 0) {
            cooldown = attackSpeed;
            //Attack()
        }
	}

    void Attack(Enemy e) {
        if(range > 1.0f) {
            GameObject fireProjectile = (GameObject) Instantiate(projectile, this.transform.position, this.transform.rotation);
            //Move Projectile etc...
        }
        //Damage enemy etc...
    }
}
