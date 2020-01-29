using UnityEngine;


[CreateAssetMenu(fileName = "EnemyDB", menuName = "Enemy")]
public class EnemyTemplate : ScriptableObject{
    public int life, fireDamage, bulletsToRecharg, shieldResistence, meleeDamage;
    public float movimentSpeed, fireRate, fireRechargTime, shieldRechargTime, meleeAttackDelay, meleeAttackTime, stunTime;
}
