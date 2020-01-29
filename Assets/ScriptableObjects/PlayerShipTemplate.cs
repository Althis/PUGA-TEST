using UnityEngine;

[CreateAssetMenu(fileName = "PlayerShipDB", menuName = "shipTemplates")]
public class PlayerShipTemplate : ScriptableObject {
    public int health;
    public int attack;
    public float speed;
    public float shootRate;
    public SecondaryCannonType mySecondaryCannonType;
    public DroneType myDroneType;

    public bool smoothRotateShield;
    public float shieldSpeedToSmoothRotation;
    public float angleToRotateShield;
    [Range(0, 1)] public float sensibilityInput;
    public float delayInputTimeToRotateShield;
    public float shootForSeconds;
    public BulletType bullet;
    public SpecialType currentSpecialAble;
    public float slowMotionMaxTime;
    public float slowMotionTimeToFullRecharg;
    [Range(0, 1)] public float slowMotionEffect;
}
