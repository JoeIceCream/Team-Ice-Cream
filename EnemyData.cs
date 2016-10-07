using UnityEngine;
using System.Collections;

public class EnemyData : MonoBehaviour {
    //Each Defined Range is for the following variable
    //Attacking Stats
    [Range(0.8f, 4.0f)]
    public float range;             //Ranges of 1 or less are melee
    [Range(0.3f, 2.5f)]
    public float attackSpeed;       //Seconds between attacks
    float attackCooldown;           //Time remaining until attack available
    [Range(0, 100.0f)]
    public float damage;            //The damage dealt before modifiers
    [Range(0, 3)]
    public int aoe;                 //Area of Effect an area in which damage is dealt 0 is single target
    //Different Types of Damage dealt
    public enum dmgType {Normal, Piercing, Magic, Heavy};
    //Defending Stats
    [Range(10.0f, 500.0f)]
    public float maxHealth;         //The Maximum Health of the tower
    float health;                   //The current Health of the tower
    [Range(0, 10.0f)]
    public float armour;            //The armour amount of the tower to reduce damage taken
    //Different Types of Armour
    public enum armrType {Unarmed, Steel, Cloth, Stone};
    //Movement Stats
    [Range(0, 5.0f)]
    public float moveSpeedBase;     //The base speed at which the tower moves
    float moveSpeed;                //The current movespeed of the tower

    public GameObject projectile;   //projectiles for ranges towers
}
