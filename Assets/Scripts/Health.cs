using UnityEngine;

namespace TowerDefense
{
    public class Health : MonoBehaviour
    {
        // The current health of this GameObject
        public int currentHealth = 100;

        // Method to apply damage to this GameObject
        public void TakeDamage(int damageAmount)
        {
            currentHealth -= damageAmount;

            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        // Static method to apply damage to a target GameObject
        public static void TryDamage(GameObject target, int damageAmount)
        {
            Health healthComponent = target.GetComponent<Health>();
            if (healthComponent != null)
            {
                healthComponent.TakeDamage(damageAmount);
            }
        }
    }
}
