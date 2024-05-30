using UnityEngine;

public class MeleeWeapon : Weapon
{
    public float reach;
    public Collider weaponCollider;

    public override void Attack()
    {
        Debug.Log("Attacked for " + damage + " with " + reach + " reach");
    
    }

}
