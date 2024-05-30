using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Activate(other);
    }

    public abstract void Activate(Collider other);
}
