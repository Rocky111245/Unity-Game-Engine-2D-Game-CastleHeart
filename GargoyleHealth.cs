using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleHealth : MonoBehaviour
{
    public int maxHealth = 100;
 public int currentHealth;
    // Start is called before the first frame update
    public void Start()
    {
        currentHealth = maxHealth;}


          public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		if (currentHealth <= 0)
		{
			Die();
		}
	}
    void Die(){
        Destroy(gameObject);
    }
    }

    // Update is called once per frame
   

