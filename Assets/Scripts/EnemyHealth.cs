using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Image healthBar;
    public GameObject healthBarObj;
    public float enemyHealth = 100;
    public float currentHealth;
    public TMP_Text Status;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = enemyHealth;
    }

    public void TakeDamage(float damage)
    {
        if (currentHealth >= 0)
        {
            currentHealth -= damage;
            healthBar.fillAmount = currentHealth / enemyHealth;
        }
        if (currentHealth <= 0)
        {
            //Enemy Dead
            Dead();
            Status.text = "You Win!";
            StartCoroutine(NextLevel());
            Debug.Log(StartCoroutine(NextLevel()));
        }
    }

    void Dead()
    {
        Destroy(healthBarObj);
        Destroy(gameObject);
    }
    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(2);
    }
}
