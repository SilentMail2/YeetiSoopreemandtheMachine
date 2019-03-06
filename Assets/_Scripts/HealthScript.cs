using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] bool isPlayer;
    [SerializeField] float maxHealth;
    [SerializeField] Slider healthBar;
    [SerializeField] GameObject[] drop;
    private void Start()
    {
        if (isPlayer)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = health;
        }
    }
    public void TakeHealth(float dam)
    {
        if (health <= 0)
        {
            if (!isPlayer)
            {
                int randomDrop = (Random.Range(0, (drop.Length+20)));
                if (randomDrop > drop.Length)
                {
                    Destroy(this.gameObject);
                }
                else
                {
                    Instantiate(drop[randomDrop], transform.position, transform.rotation);
                    Destroy(this.gameObject);
                }
            }
            if (isPlayer)
            {
                Debug.Log("Yeeti no longer");
            }
        }
        /*if (dam > 0)
        {*/
            health -= dam;
        /*}
        if (dam < 0)
        {
            float newHealth = health;
            newHealth -= dam;
            health = Mathf.Lerp(health, newHealth, Time.deltaTime * 3);
            
        }*/
        if (isPlayer)
        {
            healthBar.value = health;
        }
    }
}
