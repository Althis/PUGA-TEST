using UnityEngine;

[CreateAssetMenu(fileName = "PlayerShipDB", menuName = "shipTemplates")]
public class PlayerShipTemplate : ScriptableObject {
    public int health;
    public int attack;
    public float speed;
}
