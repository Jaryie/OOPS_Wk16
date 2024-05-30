using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/Boost")]
public class BoostPowerUp : MonoBehaviour
{
    public float boost = 10;
    public virtual void UsePowerup(Rigidbody rb)
    {
        rb.AddRelativeForce(Vector3.forward * boost, ForceMode.VelocityChange);

    }
}
