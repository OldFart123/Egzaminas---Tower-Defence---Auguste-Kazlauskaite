using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int hitPoints = 2;
    [SerializeField] private int currencyWorht = 25;

    private bool isDestroyed = false;
    public void TakeDamage(int dmg)
    {
        hitPoints -= dmg;

        if(hitPoints <= 0 && !isDestroyed)
        {
            EnemySpawner.onEnemyDestroy.Invoke();
            LevelManager.main.IncreacyMoney(currencyWorht);
            isDestroyed = true;
            Destroy(gameObject);
        }
    }
}
