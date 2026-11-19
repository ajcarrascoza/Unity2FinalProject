using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public float playerHealth = 100;
    public float currentHealth;
    public TMP_Text Status;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = playerHealth;
    }

    public void TakeDamage(float damage)
    {
        if (currentHealth >= 0) {
            currentHealth -= damage;
            healthBar.fillAmount = currentHealth/playerHealth;
        }
        if(currentHealth <= 0)
        {
            Status.text = "You Died!";
            StartCoroutine(Respawn());
            //Player Dead
        }
    }
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }
}
