using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    private int currentHealth;

    public HeartUI heartUI;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        heartUI.UpdateHearts(currentHealth);
        Debug.Log("ダメージ！ 残りHP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("ゲームオーバー！");
        SceneManager.LoadScene("ResultScene");
    }
}
