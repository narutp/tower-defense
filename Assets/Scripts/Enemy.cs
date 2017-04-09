using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	public float startSpeed = 10f;

	[HideInInspector]
	public float speed;
	public float startHealth = 100;
	public float health;
	public int worth = 50;
	public GameObject deathEffect;
	[Header("Unity Stuff")]
	public Image healthBar;

	void Start() {
		speed = startSpeed;
		health = startHealth;
	}

	public void TakeDamage(float amount) {
		health -= amount;
		healthBar.fillAmount = health / startHealth;
		if (health <= 0) {
			Die ();
		}
	}

	public void Slow (float percent) {
		speed = startSpeed * (1f - percent);
	}

	public void setHealth(float health) {
		this.startHealth = health;
		this.health = startHealth;
	}

	public void setWorth(int worth) {
		this.worth = worth;
	}

	void Die() {
		PlayerStats.Money += worth;
		GameObject effect = (GameObject)Instantiate (deathEffect, transform.position, Quaternion.identity);
		Destroy (effect, 5f);
		WaveSpawner.EnemiesAlive--;
		Destroy (gameObject);
	}

}
