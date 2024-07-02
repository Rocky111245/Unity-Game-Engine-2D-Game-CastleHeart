using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

	public int maxHealth = 100;
 public int currentHealth;

	public GameObject deathEffect;
    public HealthBar healthbar;

public void Start(){


currentHealth = maxHealth;
healthbar.SetMaxHealth(maxHealth);
}

    

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

		StartCoroutine(DamageAnimation());

		if (currentHealth <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	IEnumerator DamageAnimation()
	{
		SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

		for (int i = 0; i < 3; i++)
		{
			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 0;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);

			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 1;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);
		}
	}


}




