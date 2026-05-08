using UnityEngine;

public class Player : MonoBehaviour
{
   private int health =10;
public GameObject fireballPrefab;
public Transform attackPoint;
   public  void TakeDamage(int damage)
    {
        health-=damage;
        print("здоровье игрока:"+ health);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, 
        attackPoint.
        position, attackPoint.
        rotation);
        }
    }
}
