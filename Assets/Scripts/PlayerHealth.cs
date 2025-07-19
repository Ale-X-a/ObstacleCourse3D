using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;

    public void TakeDamage(int amount)
    {
        playerHealth -= amount;
        Debug.Log("Player took damage. Health: " + playerHealth);
        if (playerHealth <= 0)
        {
            Debug.Log("Player died!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}